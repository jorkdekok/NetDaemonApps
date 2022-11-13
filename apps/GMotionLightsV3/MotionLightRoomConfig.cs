using System.Collections.Generic;

namespace GMotionLightsV3.Configs;

public class MotionLightRoomConfig
{
    public string? Name { get; set; }
    public IEnumerable<string?>? MotionSensors { get; set; }


    public string? TargetLightId { get; set; }
    public string? AanTimeoutId { get; set; }
    public int? AanTimeoutValue { get; set; }
}
