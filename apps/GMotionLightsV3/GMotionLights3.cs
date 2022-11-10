using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using GMotionLightsV3.Configs;
using GMotionLightsV3.RxExtensions;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace GMotionLightsV3;

/// <summary>
/// GMotionLights3
/// </summary>
[NetDaemonApp]
public class GMotionLights3
{
    private readonly ILogger<GMotionLights3> _logger;
    private readonly IHaContext _ha;
    private readonly IAppConfig<GMotionLightsConfig> _config;
    private readonly IScheduler _scheduler;
    private readonly Entities _myEntities;
    private readonly RoomStatesList _roomStates;

    public GMotionLights3(ILogger<GMotionLights3> logger, IHaContext ha, IScheduler scheduler, IAppConfig<GMotionLightsConfig> config)
    {
        _logger = logger;
        _config = config;
        _ha = ha;
        _scheduler = scheduler;
        _myEntities = new Entities(ha);

        _logger.LogInformation($"{nameof(GMotionLights3)} initializing");

        _roomStates = ToRoomStates(_config.Value.RoomConfigs);

        foreach (var rstate in _roomStates)
        {
            RoomState roomState = rstate;
            InitSensors(rstate.CurrentRoomConfig);

        }

        _logger.LogInformation($"{nameof(GMotionLights3)} app started");
    }

    private RoomStatesList ToRoomStates(IEnumerable<MotionLightRoomConfig>? roomConfigs)
    {
        return RoomStatesListExtensions.MyToRoomStates(roomConfigs);
    }

    private void InitSensors(MotionLightRoomConfig currentRoomConfig)
    {
        var sensorsList = new List<IObservable<TriggerEvent>>();
        // Setup MotionSensor1
        var subject1 = new Subject<TriggerEvent>().AsObservable();

        foreach (var sensor in currentRoomConfig.MotionSensors)
        {
            IObservable<StateChange> sensorOn1, sensorOff1;
            (sensorOn1, sensorOff1) = SetupMotionSensor(currentRoomConfig);
            var tsubject = subject1.Merge(sensorOn1
                    .Select(u => new TriggerEvent(TriggerStates.Aan)
                )).Merge(
                    sensorOff1
                     .Select(u => new TriggerEvent(TriggerStates.Uit)
                ));
            sensorsList.Add(tsubject);
        }


        // Setup MotionTrigger
        IObservable<TriggerEvent> trigger1 = Observable.Return<TriggerEvent>(new TriggerEvent(TriggerStates.Idle) );
        foreach (var item in sensorsList)
        {
            trigger1 = trigger1.Merge(item);
        }
        // IObservable<TriggerEvent> trigger1 = obs1
        //     .MyTimeout1(new TimeSpan(0, 0, 10))
        //     .Select(u => new TriggerEvent(TriggerStates.Aan))
        //     .Merge(sensorOff1
        //         .Select(u => new TriggerEvent(TriggerStates.Uit))
        //         );

        // Setup Aan Timout settings
        TimeSpan aanTimespan = TimeSpan.FromSeconds(10);

        // Subscribtion MotionTrigger1
        var triggerHal = trigger1.MyTimeout1(aanTimespan)
            .Subscribe(
                //onNext: u => _ha.Entity(roomConfig.TargetLightId).CallService("turn_on")
                u => TriggerOnAction(u, currentRoomConfig.TargetLightId)
            );
    }

    private (IObservable<StateChange>, IObservable<StateChange>) SetupMotionSensor(MotionLightRoomConfig currentRoomConfig)
    {
        IObservable<StateChange> sensorOn1 = Observable.Empty<StateChange>();
        IObservable<StateChange> sensorOff1 = Observable.Empty<StateChange>();
        foreach (var motionSensorId in currentRoomConfig.MotionSensors)
        {
            //  setup motion "On"
            sensorOn1 = _ha.Entity(motionSensorId)
                .StateChanges()
                .Where(e => e.New?.State == "on");
            //  setup motion "Off"
            sensorOff1 = _ha.Entity(motionSensorId)
                .StateChanges()
                .Where(e => e.New?.State == "off");
        }
        return (sensorOn1, sensorOff1);
    }

    private void TriggerOnAction(TriggerEvent triggerEvent, string targetId)
    {
        switch (triggerEvent.State)
        {
            case TriggerStates.Aan:
                _ha.Entity(targetId).CallService("turn_on");
                break;
            case TriggerStates.Uit:
                _ha.Entity(targetId).CallService("turn_off");
                break;
            case TriggerStates.AanTimeout:
                _ha.Entity(targetId).CallService("turn_off");
                break;
            case TriggerStates.Idle:
                // do nothing
                break;
        }
    }

}
