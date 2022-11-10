using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Entities.Core;
using System.Text.Json.Serialization;

namespace HomeAssistantGenerated
{
	public interface IEntities
	{
		AutomationEntities Automation { get; }

		BinarySensorEntities BinarySensor { get; }

		ButtonEntities Button { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		ConfigEditorEntities ConfigEditor { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		GroupEntities Group { get; }

		InputBooleanEntities InputBoolean { get; }

		InputDatetimeEntities InputDatetime { get; }

		InputNumberEntities InputNumber { get; }

		InputSelectEntities InputSelect { get; }

		LightEntities Light { get; }

		MediaPlayerEntities MediaPlayer { get; }

		PersonEntities Person { get; }

		RemoteEntities Remote { get; }

		SaverEntities Saver { get; }

		SceneEntities Scene { get; }

		ScriptEntities Script { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		TimerEntities Timer { get; }

		UpdateEntities Update { get; }

		VarEntities Var { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public partial class Entities : IEntities
	{
		private readonly IHaContext _haContext;
		public Entities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AutomationEntities Automation => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public ButtonEntities Button => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public ConfigEditorEntities ConfigEditor => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public GroupEntities Group => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputDatetimeEntities InputDatetime => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public InputSelectEntities InputSelect => new(_haContext);
		public LightEntities Light => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public RemoteEntities Remote => new(_haContext);
		public SaverEntities Saver => new(_haContext);
		public SceneEntities Scene => new(_haContext);
		public ScriptEntities Script => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public TimerEntities Timer => new(_haContext);
		public UpdateEntities Update => new(_haContext);
		public VarEntities Var => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public partial class AutomationEntities
	{
		private readonly IHaContext _haContext;
		public AutomationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>__00_Diner_Zitten Maar en Eten Maar</summary>
		public AutomationEntity E00DinerTimeEtenMaar => new(_haContext, "automation.00_diner_time_eten_maar");
		///<summary>B15_Diner Time_Tafel_Dekken_v2</summary>
		public AutomationEntity E00DinerTimeTafelDekkenV2 => new(_haContext, "automation.00_diner_time_tafel_dekken_v2");
		///<summary>T10_Tuin_Dimmen</summary>
		public AutomationEntity E00TuinDimmen => new(_haContext, "automation.00_tuin_dimmen");
		///<summary>T13_Tuin_Uit_Zonsopgang</summary>
		public AutomationEntity E00TuinUitZonsopgang => new(_haContext, "automation.00_tuin_uit_zonsopgang");
		///<summary>T11_Tuin_Zonsondergang</summary>
		public AutomationEntity E00TuinZonsondergang => new(_haContext, "automation.00_tuin_zonsondergang");
		///<summary>B16 Gaan Slapen VrZaZo v1</summary>
		public AutomationEntity E01GaanSlapenVrzazoV1 => new(_haContext, "automation.01_gaan_slapen_vrzazo_v1");
		///<summary>S10_Slaapkamer_Slaaplampje_Aan</summary>
		public AutomationEntity E01SlaapkamerSlaaplampjeAan => new(_haContext, "automation.01_slaapkamer_slaaplampje_aan");
		///<summary>S13_Slaapkamer_Slaaplampje_UIT</summary>
		public AutomationEntity E01SlaapkamerSlaaplampjeUit => new(_haContext, "automation.01_slaapkamer_slaaplampje_uit");
		///<summary>__09_Tafel Dekken - Diner Time (Copy)</summary>
		public AutomationEntity E09TafelDekkenDinerTimeCopy => new(_haContext, "automation.09_tafel_dekken_diner_time_copy");
		///<summary>B21_Zet_LG_TV_Woonkamer_op_nieuws_RTL4</summary>
		public AutomationEntity E21ZetLgTvWoonkamerOpNieuwsRtl4 => new(_haContext, "automation.21_zet_lg_tv_woonkamer_op_nieuws_rtl4");
		///<summary>Z_B22_Zet_LG_TV_Aan_via_WakeOnLan</summary>
		public AutomationEntity E22ZetLgTvAanViaWakeonlan => new(_haContext, "automation.22_zet_lg_tv_aan_via_wakeonlan");
		///<summary>F28_Zet_LG_TV_Aan_via_WakeOnLan_Automatisering</summary>
		public AutomationEntity E23ZetLgTvAanViaWakeonlanAutomatisering => new(_haContext, "automation.23_zet_lg_tv_aan_via_wakeonlan_automatisering");
		///<summary>B22_Zet_LG_TV_Woonkamer_op_RTL_8</summary>
		public AutomationEntity E24ZetLgTvWoonkamerOpRtl8 => new(_haContext, "automation.24_zet_lg_tv_woonkamer_op_rtl_8");
		///<summary>B23_Zet_LG_TV_op_NPO3</summary>
		public AutomationEntity E27ZetLgTvOpNpo3 => new(_haContext, "automation.27_zet_lg_tv_op_npo3");
		///<summary>K400 Mayson Extra Slaapje Modus Automation v1</summary>
		public AutomationEntity E400MaysonExtraSlaapjeModusAutomationV1 => new(_haContext, "automation.400_mayson_extra_slaapje_modus_automation_v1");
		///<summary>Z_950_Er_Is_Er_Een_Jarig</summary>
		public AutomationEntity E50ErIsErEenJarig => new(_haContext, "automation.50_er_is_er_een_jarig");
		///<summary>S5001 Zet Slaapkamer Lichten aan als bm-pb51-vivaldi actief is</summary>
		public AutomationEntity E5001ZetSlaapkamerLichtenAanAlsBmPb51VivaldiActiefIs => new(_haContext, "automation.5001_zet_slaapkamer_lichten_aan_als_bm_pb51_vivaldi_actief_is");
		///<summary>N800_Cam Motion Detection - Foscam1</summary>
		public AutomationEntity E800CamMotionDetectionFoscam1 => new(_haContext, "automation.800_cam_motion_detection_foscam1");
		///<summary>N801_Motion Detector with App Notifications</summary>
		public AutomationEntity E801MotionDetectorWithAppNotifications => new(_haContext, "automation.801_motion_detector_with_app_notifications");
		///<summary>D882_Deurbel_Knop_Ingedrukt</summary>
		public AutomationEntity E882DeurbelKnopIngedrukt => new(_haContext, "automation.882_deurbel_knop_ingedrukt");
		///<summary>D883_Deurbel2_Knop_Ingedrukt</summary>
		public AutomationEntity E883Deurbel2KnopIngedrukt => new(_haContext, "automation.883_deurbel2_knop_ingedrukt");
		///<summary>M99_Set_Motions_Input_Select_Options</summary>
		public AutomationEntity E99SetMotionsInputSelectOptions => new(_haContext, "automation.99_set_motions_input_select_options");
		///<summary>__00_Tafel Dekken - Diner Time</summary>
		public AutomationEntity AanTafelDinerTime => new(_haContext, "automation.aan_tafel_diner_time");
		///<summary>Dim lights based on sun elevation - test 1</summary>
		public AutomationEntity DimLightsBasedOnSunElevationTest1 => new(_haContext, "automation.dim_lights_based_on_sun_elevation_test_1");
		///<summary>Z19_Dusk_Test_1</summary>
		public AutomationEntity DuskTest1 => new(_haContext, "automation.dusk_test_1");
		///<summary>F620 TV Audio Denon Volume Level v1</summary>
		public AutomationEntity F620TvAudioDenonVolumeLevelV1 => new(_haContext, "automation.f620_tv_audio_denon_volume_level_v1");
		///<summary>N810 Home Assistant update notification</summary>
		public AutomationEntity HomeAssistantUpdateNotification => new(_haContext, "automation.home_assistant_update_notification");
		///<summary>M85 Motion Detection on Slaapkamer Trap</summary>
		public AutomationEntity M85MotionDetectionOnSlaapkamerTrap => new(_haContext, "automation.m85_motion_detection_on_slaapkamer_trap");
		///<summary>M88 Motion Detection v2</summary>
		public AutomationEntity M88MotionDetectionV2 => new(_haContext, "automation.m88_motion_detection_v2");
		///<summary>M999_Publish_MQTT_Message_Motion_Detected</summary>
		public AutomationEntity PublishMqttMessageMotionDetected => new(_haContext, "automation.publish_mqtt_message_motion_detected");
		///<summary>B18_Turn on lights when it rains</summary>
		public AutomationEntity TurnOnLightsWhenItRains => new(_haContext, "automation.turn_on_lights_when_it_rains");
		///<summary>B20_Notificatie sturen:  nieuws 19:30</summary>
		public AutomationEntity TvNotificatieNieuws1930 => new(_haContext, "automation.tv_notificatie_nieuws_1930");
		///<summary>W001 Wake-up Beneden Op OnePlus Wekker Alarm</summary>
		public AutomationEntity W001WakeUpBenedenOpOneplusWekkerAlarm => new(_haContext, "automation.w001_wake_up_beneden_op_oneplus_wekker_alarm");
		///<summary>B12_Woonkamer Beneden TV Scene</summary>
		public AutomationEntity WoonkamerBenedenTvKijken => new(_haContext, "automation.woonkamer_beneden_tv_kijken");
		///<summary>B13_Zet Woonkamer Lichten Uit na 09:00</summary>
		public AutomationEntity ZetWoonkamerLichtenUitNa0900 => new(_haContext, "automation.zet_woonkamer_lichten_uit_na_09_00");
		///<summary>B10_Woonkamer_Beneden_Zonsondergang</summary>
		public AutomationEntity ZonsondergangWoonkamer => new(_haContext, "automation.zonsondergang_woonkamer");
	}

	public partial class BinarySensorEntities
	{
		private readonly IHaContext _haContext;
		public BinarySensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>AirCast Running</summary>
		public BinarySensorEntity AircastRunning => new(_haContext, "binary_sensor.aircast_running");
		///<summary>AirCast Update available</summary>
		public BinarySensorEntity AircastUpdateAvailable => new(_haContext, "binary_sensor.aircast_update_available");
		///<summary>AirSonos Running</summary>
		public BinarySensorEntity AirsonosRunning => new(_haContext, "binary_sensor.airsonos_running");
		///<summary>AirSonos Update available</summary>
		public BinarySensorEntity AirsonosUpdateAvailable => new(_haContext, "binary_sensor.airsonos_update_available");
		///<summary>AppDaemon Running</summary>
		public BinarySensorEntity Appdaemon4Running => new(_haContext, "binary_sensor.appdaemon_4_running");
		///<summary>AppDaemon Update available</summary>
		public BinarySensorEntity Appdaemon4UpdateAvailable => new(_haContext, "binary_sensor.appdaemon_4_update_available");
		///<summary>Check Home Assistant configuration Running</summary>
		public BinarySensorEntity CheckHomeAssistantConfigurationRunning => new(_haContext, "binary_sensor.check_home_assistant_configuration_running");
		///<summary>Check Home Assistant configuration Update available</summary>
		public BinarySensorEntity CheckHomeAssistantConfigurationUpdateAvailable => new(_haContext, "binary_sensor.check_home_assistant_configuration_update_available");
		///<summary>chrony Running</summary>
		public BinarySensorEntity ChronyRunning => new(_haContext, "binary_sensor.chrony_running");
		///<summary>chrony Update available</summary>
		public BinarySensorEntity ChronyUpdateAvailable => new(_haContext, "binary_sensor.chrony_update_available");
		///<summary>ds1 (Schijf 1) Below Min Remaining Life</summary>
		public BinarySensorEntity Ds1BelowMinRemainingLife => new(_haContext, "binary_sensor.ds1_below_min_remaining_life");
		///<summary>ds1 (Schijf 2) Below Min Remaining Life</summary>
		public BinarySensorEntity Ds1BelowMinRemainingLife2 => new(_haContext, "binary_sensor.ds1_below_min_remaining_life_2");
		///<summary>ds1 (Schijf 1) Exceeded Max Bad Sectors</summary>
		public BinarySensorEntity Ds1ExceededMaxBadSectors => new(_haContext, "binary_sensor.ds1_exceeded_max_bad_sectors");
		///<summary>ds1 (Schijf 2) Exceeded Max Bad Sectors</summary>
		public BinarySensorEntity Ds1ExceededMaxBadSectors2 => new(_haContext, "binary_sensor.ds1_exceeded_max_bad_sectors_2");
		///<summary>ds1 Security Status</summary>
		public BinarySensorEntity Ds1SecurityStatus => new(_haContext, "binary_sensor.ds1_security_status");
		///<summary>ds1 Update Available</summary>
		public BinarySensorEntity Ds1UpdateAvailable => new(_haContext, "binary_sensor.ds1_update_available");
		///<summary>File editor Running</summary>
		public BinarySensorEntity FileEditorRunning => new(_haContext, "binary_sensor.file_editor_running");
		///<summary>File editor Update available</summary>
		public BinarySensorEntity FileEditorUpdateAvailable => new(_haContext, "binary_sensor.file_editor_update_available");
		///<summary>Glances Running</summary>
		public BinarySensorEntity GlancesRunning => new(_haContext, "binary_sensor.glances_running");
		///<summary>Glances Update available</summary>
		public BinarySensorEntity GlancesUpdateAvailable => new(_haContext, "binary_sensor.glances_update_available");
		///<summary>Home Assistant Operating System Update available</summary>
		public BinarySensorEntity HomeAssistantOperatingSystemUpdateAvailable => new(_haContext, "binary_sensor.home_assistant_operating_system_update_available");
		///<summary>iPadPro Focus</summary>
		public BinarySensorEntity IpadproFocus => new(_haContext, "binary_sensor.ipadpro_focus");
		///<summary>Log Viewer Running</summary>
		public BinarySensorEntity LogViewerRunning => new(_haContext, "binary_sensor.log_viewer_running");
		///<summary>Log Viewer Update available</summary>
		public BinarySensorEntity LogViewerUpdateAvailable => new(_haContext, "binary_sensor.log_viewer_update_available");
		///<summary>MariaDB Running</summary>
		public BinarySensorEntity MariadbRunning => new(_haContext, "binary_sensor.mariadb_running");
		///<summary>MariaDB Update available</summary>
		public BinarySensorEntity MariadbUpdateAvailable => new(_haContext, "binary_sensor.mariadb_update_available");
		///<summary>Matrix Running</summary>
		public BinarySensorEntity MatrixRunning => new(_haContext, "binary_sensor.matrix_running");
		///<summary>Matrix Update available</summary>
		public BinarySensorEntity MatrixUpdateAvailable => new(_haContext, "binary_sensor.matrix_update_available");
		///<summary>Mosquitto broker Running</summary>
		public BinarySensorEntity MosquittoBrokerRunning => new(_haContext, "binary_sensor.mosquitto_broker_running");
		///<summary>Mosquitto broker Update available</summary>
		public BinarySensorEntity MosquittoBrokerUpdateAvailable => new(_haContext, "binary_sensor.mosquitto_broker_update_available");
		///<summary>OnePlus-9-Pro App Inactive</summary>
		public BinarySensorEntity Oneplus9ProAppInactive => new(_haContext, "binary_sensor.oneplus_9_pro_app_inactive");
		///<summary>OnePlus-9-Pro Device Locked</summary>
		public BinarySensorEntity Oneplus9ProDeviceLocked => new(_haContext, "binary_sensor.oneplus_9_pro_device_locked");
		///<summary>OnePlus-9-Pro Device Secure</summary>
		public BinarySensorEntity Oneplus9ProDeviceSecure => new(_haContext, "binary_sensor.oneplus_9_pro_device_secure");
		///<summary>OnePlus-9-Pro Doze Mode</summary>
		public BinarySensorEntity Oneplus9ProDozeMode => new(_haContext, "binary_sensor.oneplus_9_pro_doze_mode");
		///<summary>OnePlus-9-Pro Headphones</summary>
		public BinarySensorEntity Oneplus9ProHeadphones => new(_haContext, "binary_sensor.oneplus_9_pro_headphones");
		///<summary>OnePlus-9-Pro Interactive</summary>
		public BinarySensorEntity Oneplus9ProInteractive => new(_haContext, "binary_sensor.oneplus_9_pro_interactive");
		///<summary>OnePlus-9-Pro Is Charging</summary>
		public BinarySensorEntity Oneplus9ProIsAanHetOpladen => new(_haContext, "binary_sensor.oneplus_9_pro_is_aan_het_opladen");
		///<summary>OnePlus-9-Pro Keyguard Locked</summary>
		public BinarySensorEntity Oneplus9ProKeyguardLocked => new(_haContext, "binary_sensor.oneplus_9_pro_keyguard_locked");
		///<summary>OnePlus-9-Pro Keyguard Secure</summary>
		public BinarySensorEntity Oneplus9ProKeyguardSecure => new(_haContext, "binary_sensor.oneplus_9_pro_keyguard_secure");
		///<summary>OnePlus-9-Pro Mic Muted</summary>
		public BinarySensorEntity Oneplus9ProMicMuted => new(_haContext, "binary_sensor.oneplus_9_pro_mic_muted");
		///<summary>OnePlus-9-Pro Mobile Data</summary>
		public BinarySensorEntity Oneplus9ProMobileData => new(_haContext, "binary_sensor.oneplus_9_pro_mobile_data");
		///<summary>OnePlus-9-Pro Mobile Data Roaming</summary>
		public BinarySensorEntity Oneplus9ProMobileDataRoaming => new(_haContext, "binary_sensor.oneplus_9_pro_mobile_data_roaming");
		///<summary>OnePlus-9-Pro Music Active</summary>
		public BinarySensorEntity Oneplus9ProMusicActive => new(_haContext, "binary_sensor.oneplus_9_pro_music_active");
		///<summary>OnePlus-9-Pro Power Save</summary>
		public BinarySensorEntity Oneplus9ProPowerSave => new(_haContext, "binary_sensor.oneplus_9_pro_power_save");
		///<summary>OnePlus-9-Pro Speakerphone</summary>
		public BinarySensorEntity Oneplus9ProSpeakerphone => new(_haContext, "binary_sensor.oneplus_9_pro_speakerphone");
		///<summary>OnePlus-9-Pro WiFi State</summary>
		public BinarySensorEntity Oneplus9ProWifiStatus => new(_haContext, "binary_sensor.oneplus_9_pro_wifi_status");
		///<summary>phpMyAdmin Running</summary>
		public BinarySensorEntity PhpmyadminRunning => new(_haContext, "binary_sensor.phpmyadmin_running");
		///<summary>phpMyAdmin Update available</summary>
		public BinarySensorEntity PhpmyadminUpdateAvailable => new(_haContext, "binary_sensor.phpmyadmin_update_available");
		///<summary>Pi-Hole</summary>
		public BinarySensorEntity PiHole => new(_haContext, "binary_sensor.pi_hole");
		///<summary>Pi-Hole Core Update Available</summary>
		public BinarySensorEntity PiHoleCoreUpdateAvailable => new(_haContext, "binary_sensor.pi_hole_core_update_available");
		///<summary>Pi-Hole FTL Update Available</summary>
		public BinarySensorEntity PiHoleFtlUpdateAvailable => new(_haContext, "binary_sensor.pi_hole_ftl_update_available");
		///<summary>Pi-Hole Web Update Available</summary>
		public BinarySensorEntity PiHoleWebUpdateAvailable => new(_haContext, "binary_sensor.pi_hole_web_update_available");
		///<summary>Portainer Running</summary>
		public BinarySensorEntity PortainerRunning => new(_haContext, "binary_sensor.portainer_running");
		///<summary>Portainer Update available</summary>
		public BinarySensorEntity PortainerUpdateAvailable => new(_haContext, "binary_sensor.portainer_update_available");
		///<summary>Samba share Running</summary>
		public BinarySensorEntity SambaShareRunning => new(_haContext, "binary_sensor.samba_share_running");
		///<summary>Samba share Update available</summary>
		public BinarySensorEntity SambaShareUpdateAvailable => new(_haContext, "binary_sensor.samba_share_update_available");
		///<summary>Sensor 101 Motion</summary>
		public BinarySensorEntity Sensor101Motion => new(_haContext, "binary_sensor.sensor_101_motion");
		///<summary>Sensor 102 Motion</summary>
		public BinarySensorEntity Sensor102Motion => new(_haContext, "binary_sensor.sensor_102_motion");
		///<summary>Sensor 201 Motion</summary>
		public BinarySensorEntity Sensor201Motion => new(_haContext, "binary_sensor.sensor_201_motion");
		///<summary>Sensor 202 Motion</summary>
		public BinarySensorEntity Sensor202Motion => new(_haContext, "binary_sensor.sensor_202_motion");
		///<summary>Sensor 301 Motion</summary>
		public BinarySensorEntity Sensor301Motion => new(_haContext, "binary_sensor.sensor_301_motion");
		///<summary>Spotify Connect Running</summary>
		public BinarySensorEntity SpotifyConnectRunning => new(_haContext, "binary_sensor.spotify_connect_running");
		///<summary>Spotify Connect Update available</summary>
		public BinarySensorEntity SpotifyConnectUpdateAvailable => new(_haContext, "binary_sensor.spotify_connect_update_available");
		///<summary>Studio Code Server Running</summary>
		public BinarySensorEntity StudioCodeServerRunning => new(_haContext, "binary_sensor.studio_code_server_running");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
		///<summary>Motion VSensor 101</summary>
		public BinarySensorEntity VirtualMotionVsensor101 => new(_haContext, "binary_sensor.virtual_motion_vsensor_101");
		///<summary>Motion VSensor 102</summary>
		public BinarySensorEntity VirtualMotionVsensor102 => new(_haContext, "binary_sensor.virtual_motion_vsensor_102");
		///<summary>Motion VSensor 201</summary>
		public BinarySensorEntity VirtualMotionVsensor201 => new(_haContext, "binary_sensor.virtual_motion_vsensor_201");
		///<summary>Motion VSensor 202</summary>
		public BinarySensorEntity VirtualMotionVsensor202 => new(_haContext, "binary_sensor.virtual_motion_vsensor_202");
		///<summary>Studio Code Server Update available</summary>
		public BinarySensorEntity VisualStudioCodeUpdateAvailable => new(_haContext, "binary_sensor.visual_studio_code_update_available");
	}

	public partial class ButtonEntities
	{
		private readonly IHaContext _haContext;
		public ButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ds1 Reboot</summary>
		public ButtonEntity Ds1Reboot => new(_haContext, "button.ds1_reboot");
		///<summary>ds1 Shutdown</summary>
		public ButtonEntity Ds1Shutdown => new(_haContext, "button.ds1_shutdown");
		///<summary>Homebridge 62F2 2E06 Identify</summary>
		public ButtonEntity Homebridge62f22e06Identify => new(_haContext, "button.homebridge_62f2_2e06_identify");
	}

	public partial class CameraEntities
	{
		private readonly IHaContext _haContext;
		public CameraEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ds1 Foscam1</summary>
		public CameraEntity Ds1Foscam1 => new(_haContext, "camera.ds1_foscam1");
		///<summary>ds1 indoorCam-Eufy</summary>
		public CameraEntity Ds1IndoorcamEufy => new(_haContext, "camera.ds1_indoorcam_eufy");
		///<summary>Foscam1_Woonkamer</summary>
		public CameraEntity Foscam1Woonkamer => new(_haContext, "camera.foscam1_woonkamer");
	}

	public partial class ClimateEntities
	{
		private readonly IHaContext _haContext;
		public ClimateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Kamer Alyssa</summary>
		public ClimateEntity KamerAlyssa => new(_haContext, "climate.kamer_alyssa");
		///<summary>Kamer Mayson</summary>
		public ClimateEntity KamerMayson => new(_haContext, "climate.kamer_mayson");
		///<summary>Kamer Rosaly</summary>
		public ClimateEntity KamerRosaly => new(_haContext, "climate.kamer_rosaly");
		///<summary>Slaapkamer</summary>
		public ClimateEntity Slaapkamer => new(_haContext, "climate.slaapkamer");
		///<summary>Thuis</summary>
		public ClimateEntity Thuis => new(_haContext, "climate.thuis");
		///<summary>Woonkamer</summary>
		public ClimateEntity Woonkamer => new(_haContext, "climate.woonkamer");
	}

	public partial class ConfigEditorEntities
	{
		private readonly IHaContext _haContext;
		public ConfigEditorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public ConfigEditorEntity Version => new(_haContext, "config_editor.version");
	}

	public partial class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>iPadPro</summary>
		public DeviceTrackerEntity Ipadpro => new(_haContext, "device_tracker.ipadpro");
		///<summary>OnePlus-9-Pro</summary>
		public DeviceTrackerEntity Oneplus9Pro => new(_haContext, "device_tracker.oneplus_9_pro");
	}

	public partial class GroupEntities
	{
		private readonly IHaContext _haContext;
		public GroupEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>hal_sensors_group</summary>
		public GroupEntity HalSensorsGroup => new(_haContext, "group.hal_sensors_group");
		///<summary>overloop_sensors_group</summary>
		public GroupEntity OverloopSensorsGroup => new(_haContext, "group.overloop_sensors_group");
		///<summary>trap_slaapkamer_sensors_group</summary>
		public GroupEntity TrapSlaapkamerSensorsGroup => new(_haContext, "group.trap_slaapkamer_sensors_group");
	}

	public partial class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Donkere Modus</summary>
		public InputBooleanEntity DonkereModus => new(_haContext, "input_boolean.donkere_modus");
		///<summary>Hal MotionLight Enabled</summary>
		public InputBooleanEntity HalMotionlightEnabled => new(_haContext, "input_boolean.hal_motionlight_enabled");
		///<summary>Mayson doet een Extra Slaapje</summary>
		public InputBooleanEntity MaysonDoetEenExtraSlaapje => new(_haContext, "input_boolean.mayson_doet_een_extra_slaapje");
		///<summary>netdaemon_app_model_hello_yaml_app</summary>
		public InputBooleanEntity NetdaemonAppModelHelloYamlApp => new(_haContext, "input_boolean.netdaemon_app_model_hello_yaml_app");
		///<summary>netdaemon_extensions_scheduling_scheduling_app</summary>
		public InputBooleanEntity NetdaemonExtensionsSchedulingSchedulingApp => new(_haContext, "input_boolean.netdaemon_extensions_scheduling_scheduling_app");
		///<summary>netdaemon_hass_model_hello_world_app</summary>
		public InputBooleanEntity NetdaemonHassModelHelloWorldApp => new(_haContext, "input_boolean.netdaemon_hass_model_hello_world_app");
		///<summary>netdaemon_hass_model_light_on_movement</summary>
		public InputBooleanEntity NetdaemonHassModelLightOnMovement => new(_haContext, "input_boolean.netdaemon_hass_model_light_on_movement");
		///<summary>Overloop MotionLight Enabled</summary>
		public InputBooleanEntity OverloopMotionlightEnabled => new(_haContext, "input_boolean.overloop_motionlight_enabled");
		///<summary>Spotcast LG TV source test</summary>
		public InputBooleanEntity SpotcastLgTvSourceTest => new(_haContext, "input_boolean.spotcast_lg_tv_source_test");
		///<summary>Theme alternative</summary>
		public InputBooleanEntity ThemeAlternative => new(_haContext, "input_boolean.theme_alternative");
		///<summary>TrapSlaapkamer MotionLight Enabled</summary>
		public InputBooleanEntity TrapslaapkamerMotionlightEnabled => new(_haContext, "input_boolean.trapslaapkamer_motionlight_enabled");
		///<summary>Vakantie Modus</summary>
		public InputBooleanEntity VakantieModus => new(_haContext, "input_boolean.vakantie_modus");
	}

	public partial class InputDatetimeEntities
	{
		private readonly IHaContext _haContext;
		public InputDatetimeEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tijd om te slapen in Weekend</summary>
		public InputDatetimeEntity TijdOmTeSlapenInWeekend => new(_haContext, "input_datetime.tijd_om_te_slapen_in_weekend");
		///<summary>Tijd om te slapen op Werkdagen</summary>
		public InputDatetimeEntity TijdOmTeSlapenOpWerkdagen => new(_haContext, "input_datetime.tijd_om_te_slapen_op_werkdagen");
	}

	public partial class InputNumberEntities
	{
		private readonly IHaContext _haContext;
		public InputNumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Hal Delay MotionLight Off</summary>
		public InputNumberEntity HalDelayMotionlightOff => new(_haContext, "input_number.hal_delay_motionlight_off");
		///<summary>Overloop Delay MotionLight Off</summary>
		public InputNumberEntity OverloopDelayMotionlightOff => new(_haContext, "input_number.overloop_delay_motionlight_off");
		///<summary>TrapSlaapkamer Delay MotionLight Off</summary>
		public InputNumberEntity TrapslaapkamerDelayMotionlightOff => new(_haContext, "input_number.trapslaapkamer_delay_motionlight_off");
		///<summary>Virtual Volume voor Denon AVR-x2200</summary>
		public InputNumberEntity VirtualVolumeVoorDenonAvrX2200 => new(_haContext, "input_number.virtual_volume_voor_denon_avr_x2200");
		///<summary>Werkelijke Volume van Denon AVR-X2200</summary>
		public InputNumberEntity WerkelijkeVolumeVanDenonAvrX2200 => new(_haContext, "input_number.werkelijke_volume_van_denon_avr_x2200");
	}

	public partial class InputSelectEntities
	{
		private readonly IHaContext _haContext;
		public InputSelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Hal Huidige Scene</summary>
		public InputSelectEntity HalHuidigeScene => new(_haContext, "input_select.hal_huidige_scene");
		///<summary>Huidig Thema </summary>
		public InputSelectEntity HuidigThema => new(_haContext, "input_select.huidig_thema");
		///<summary>Overloop Huidige Scene</summary>
		public InputSelectEntity OverloopHuidigeScene => new(_haContext, "input_select.overloop_huidige_scene");
		public InputSelectEntity Theme => new(_haContext, "input_select.theme");
		///<summary>Trap Slaapkamer Huidige Scene</summary>
		public InputSelectEntity TrapSlaapkamerHuidigeScene => new(_haContext, "input_select.trap_slaapkamer_huidige_scene");
	}

	public partial class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bank Lamp Mama</summary>
		public LightEntity BankLampMama => new(_haContext, "light.bank_lamp_mama");
		///<summary>Bank Lamp Papa</summary>
		public LightEntity BankLampPapa => new(_haContext, "light.bank_lamp_papa");
		///<summary>Beneden</summary>
		public LightEntity Beneden => new(_haContext, "light.beneden");
		///<summary>Boog Color Lamp</summary>
		public LightEntity BoogColorLamp => new(_haContext, "light.boog_color_lamp");
		public LightEntity BrowserBmGraysonPb51 => new(_haContext, "light.browser_bm_grayson_pb51");
		public LightEntity BrowserBmIpadPro => new(_haContext, "light.browser_bm_ipad_pro");
		public LightEntity BrowserBmIpadpro1 => new(_haContext, "light.browser_bm_ipadpro_1");
		public LightEntity BrowserBmOneplus9pro => new(_haContext, "light.browser_bm_oneplus_9pro");
		public LightEntity BrowserBmPb51Vivaldi => new(_haContext, "light.browser_bm_pb51_vivaldi");
		///<summary>Eethoek</summary>
		public LightEntity Eethoek => new(_haContext, "light.eethoek");
		///<summary>Eethoek Plafond Spot 1</summary>
		public LightEntity EethoekPlafondSpot1 => new(_haContext, "light.eethoek_plafond_spot_1");
		///<summary>Eethoek Plafond Spot 2</summary>
		public LightEntity EethoekPlafondSpot2 => new(_haContext, "light.eethoek_plafond_spot_2");
		///<summary>Eethoek Plafond Spot 3</summary>
		public LightEntity EethoekPlafondSpot3 => new(_haContext, "light.eethoek_plafond_spot_3");
		///<summary>Eethoek Plafond Spot 4</summary>
		public LightEntity EethoekPlafondSpot4 => new(_haContext, "light.eethoek_plafond_spot_4");
		///<summary>Eettafel</summary>
		public LightEntity Eettafel => new(_haContext, "light.eettafel");
		///<summary>Hal</summary>
		public LightEntity Hal => new(_haContext, "light.hal");
		///<summary>Hal color spot 1</summary>
		public LightEntity HalColorSpot1 => new(_haContext, "light.hal_color_spot_1");
		///<summary>Hal color spot 2</summary>
		public LightEntity HalColorSpot2 => new(_haContext, "light.hal_color_spot_2");
		///<summary>Hal color spot 3</summary>
		public LightEntity HalColorSpot3 => new(_haContext, "light.hal_color_spot_3");
		///<summary>Hue Go Nachtlamp</summary>
		public LightEntity HueGoNachtlamp => new(_haContext, "light.hue_go_nachtlamp");
		///<summary>Hue lightstrip plus 1</summary>
		public LightEntity HueLightstripPlus1 => new(_haContext, "light.hue_lightstrip_plus_1");
		///<summary>Hue lightstrip plus 2</summary>
		public LightEntity HueLightstripPlus2 => new(_haContext, "light.hue_lightstrip_plus_2");
		///<summary>Hue outdoor wall - Schuur</summary>
		public LightEntity HueOutdoorWallSchuur => new(_haContext, "light.hue_outdoor_wall_schuur");
		///<summary>Hue outdoor wall - Tuindeur</summary>
		public LightEntity HueOutdoorWallTuindeur => new(_haContext, "light.hue_outdoor_wall_tuindeur");
		///<summary>Hue play 1</summary>
		public LightEntity HuePlay1 => new(_haContext, "light.hue_play_1");
		///<summary>Hue play 2</summary>
		public LightEntity HuePlay2 => new(_haContext, "light.hue_play_2");
		///<summary>Hue Smart plug 1</summary>
		public LightEntity HueSmartPlug1 => new(_haContext, "light.hue_smart_plug_1");
		///<summary>Keuken</summary>
		public LightEntity Keuken => new(_haContext, "light.keuken");
		///<summary>Nachtkast Lamp</summary>
		public LightEntity NachtkastLamp => new(_haContext, "light.nachtkast_lamp");
		///<summary>Osram Smart Plug 1 - Spot</summary>
		public LightEntity OsramSmartPlug1Spot => new(_haContext, "light.osram_smart_plug_1_spot");
		///<summary>Overloop</summary>
		public LightEntity Overloop => new(_haContext, "light.overloop");
		///<summary>Overloop ambiance spot 1</summary>
		public LightEntity OverloopAmbianceSpot1 => new(_haContext, "light.overloop_ambiance_spot_1");
		///<summary>Overloop ambiance spot 2</summary>
		public LightEntity OverloopAmbianceSpot2 => new(_haContext, "light.overloop_ambiance_spot_2");
		///<summary>Overloop ambiance spot 3</summary>
		public LightEntity OverloopAmbianceSpot3 => new(_haContext, "light.overloop_ambiance_spot_3");
		///<summary>Plafond lamp 1</summary>
		public LightEntity PlafondLamp1 => new(_haContext, "light.plafond_lamp_1");
		///<summary>Plafond lamp 2</summary>
		public LightEntity PlafondLamp2 => new(_haContext, "light.plafond_lamp_2");
		///<summary>Plafond lamp 3</summary>
		public LightEntity PlafondLamp3 => new(_haContext, "light.plafond_lamp_3");
		///<summary>Slaapkamer</summary>
		public LightEntity Slaapkamer => new(_haContext, "light.slaapkamer");
		///<summary>Trap boven ambiance spot 1</summary>
		public LightEntity TrapBovenAmbianceSpot1 => new(_haContext, "light.trap_boven_ambiance_spot_1");
		///<summary>Trap boven ambiance spot 2</summary>
		public LightEntity TrapBovenAmbianceSpot2 => new(_haContext, "light.trap_boven_ambiance_spot_2");
		///<summary>Trap Slaapkamer</summary>
		public LightEntity TrapSlaapkamer => new(_haContext, "light.trap_slaapkamer");
		///<summary>Tuin</summary>
		public LightEntity Tuin => new(_haContext, "light.tuin");
		///<summary>Virtual Light Hal</summary>
		public LightEntity VirtualVirtualLightHal => new(_haContext, "light.virtual_virtual_light_hal");
		///<summary>Virtual Light State Hal</summary>
		public LightEntity VirtualVirtualLightStateHal => new(_haContext, "light.virtual_virtual_light_state_hal");
		///<summary>Virtual Light State Overloop</summary>
		public LightEntity VirtualVirtualLightStateOverloop => new(_haContext, "light.virtual_virtual_light_state_overloop");
		///<summary>Virtual Light State TrapSlaapkamer</summary>
		public LightEntity VirtualVirtualLightStateTrapslaapkamer => new(_haContext, "light.virtual_virtual_light_state_trapslaapkamer");
		///<summary>Wc</summary>
		public LightEntity Wc => new(_haContext, "light.wc");
		///<summary>WC white lamp</summary>
		public LightEntity WcWhiteLamp => new(_haContext, "light.wc_white_lamp");
		///<summary>Woonkamer</summary>
		public LightEntity Woonkamer => new(_haContext, "light.woonkamer");
	}

	public partial class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public MediaPlayerEntity BrowserBmGraysonPb51 => new(_haContext, "media_player.browser_bm_grayson_pb51");
		public MediaPlayerEntity BrowserBmIpadPro => new(_haContext, "media_player.browser_bm_ipad_pro");
		public MediaPlayerEntity BrowserBmIpadpro1 => new(_haContext, "media_player.browser_bm_ipadpro_1");
		public MediaPlayerEntity BrowserBmOneplus9pro => new(_haContext, "media_player.browser_bm_oneplus_9pro");
		public MediaPlayerEntity BrowserBmPb51Vivaldi => new(_haContext, "media_player.browser_bm_pb51_vivaldi");
		///<summary>Chromecast Slaapkamer</summary>
		public MediaPlayerEntity ChromecastSlaapkamer => new(_haContext, "media_player.chromecast_slaapkamer");
		///<summary>Denon AVR-X2200W</summary>
		public MediaPlayerEntity DenonAvrX2200w => new(_haContext, "media_player.denon_avr_x2200w");
		///<summary>Denon AVR-X2200W DLNA</summary>
		public MediaPlayerEntity DenonAvrX2200wDlna2 => new(_haContext, "media_player.denon_avr_x2200w_dlna_2");
		///<summary>LE2123@ExoAirPlayer</summary>
		public MediaPlayerEntity Le2123Exoairplayer => new(_haContext, "media_player.le2123_exoairplayer");
		///<summary>[LG] webOS TV OLED DLNA</summary>
		public MediaPlayerEntity LgWebosTvOledDlna => new(_haContext, "media_player.lg_webos_tv_oled_dlna");
		///<summary>LG TV Woonkamer</summary>
		public MediaPlayerEntity LgWebostvWoonkamer => new(_haContext, "media_player.lg_webostv_woonkamer");
		///<summary>Spotify Baby-Yoda</summary>
		public MediaPlayerEntity SpotifyBabyYoda => new(_haContext, "media_player.spotify_baby_yoda");
		///<summary>Spotify Jo de Kok</summary>
		public MediaPlayerEntity SpotifyJoDeKok => new(_haContext, "media_player.spotify_jo_de_kok");
		///<summary>Google Home</summary>
		public MediaPlayerEntity WoonkamerGoogleHome => new(_haContext, "media_player.woonkamer_google_home");
	}

	public partial class PersonEntities
	{
		private readonly IHaContext _haContext;
		public PersonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Jork de Kok</summary>
		public PersonEntity JorkDeKok => new(_haContext, "person.jork_de_kok");
		///<summary>Luke Skywatcher</summary>
		public PersonEntity LukeSkywatcher => new(_haContext, "person.luke_skywatcher");
		///<summary>Yamoena de Kok</summary>
		public PersonEntity YamoenaDeKok => new(_haContext, "person.yamoena_de_kok");
	}

	public partial class RemoteEntities
	{
		private readonly IHaContext _haContext;
		public RemoteEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>LE2123@ExoAirPlayer</summary>
		public RemoteEntity Le2123Exoairplayer => new(_haContext, "remote.le2123_exoairplayer");
	}

	public partial class SaverEntities
	{
		private readonly IHaContext _haContext;
		public SaverEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>saver</summary>
		public SaverEntity Saver => new(_haContext, "saver.saver");
	}

	public partial class SceneEntities
	{
		private readonly IHaContext _haContext;
		public SceneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Beneden Avond</summary>
		public SceneEntity BenedenAvond => new(_haContext, "scene.beneden_avond");
		///<summary>beneden_before_ring_state</summary>
		public SceneEntity BenedenBeforeRingState => new(_haContext, "scene.beneden_before_ring_state");
		///<summary>Beneden Concentreren</summary>
		public SceneEntity BenedenConcentreren => new(_haContext, "scene.beneden_concentreren");
		///<summary>Beneden Energie</summary>
		public SceneEntity BenedenEnergie => new(_haContext, "scene.beneden_energie");
		///<summary>Beneden Frozen</summary>
		public SceneEntity BenedenFrozen => new(_haContext, "scene.beneden_frozen");
		///<summary>Beneden Helder</summary>
		public SceneEntity BenedenHelder => new(_haContext, "scene.beneden_helder");
		///<summary>Beneden Lezen</summary>
		public SceneEntity BenedenLezen => new(_haContext, "scene.beneden_lezen");
		///<summary>Beneden-Melkweg</summary>
		public SceneEntity BenedenMelkweg => new(_haContext, "scene.beneden_melkweg");
		///<summary>Beneden Melkweg</summary>
		public SceneEntity BenedenMelkweg2 => new(_haContext, "scene.beneden_melkweg_2");
		///<summary>Beneden Midzomerzon</summary>
		public SceneEntity BenedenMidzomerzon => new(_haContext, "scene.beneden_midzomerzon");
		///<summary>Beneden Mijn Sterrenlicht</summary>
		public SceneEntity BenedenMijnSterrenlicht => new(_haContext, "scene.beneden_mijn_sterrenlicht");
		///<summary>Beneden Nachtbewaker</summary>
		public SceneEntity BenedenNachtbewaker => new(_haContext, "scene.beneden_nachtbewaker");
		///<summary>Beneden Nachtlampje</summary>
		public SceneEntity BenedenNachtlampje => new(_haContext, "scene.beneden_nachtlampje");
		///<summary>Beneden Nightworker-1</summary>
		public SceneEntity BenedenNightworker1 => new(_haContext, "scene.beneden_nightworker_1");
		///<summary>Beneden Ontbijten</summary>
		public SceneEntity BenedenOntbijten => new(_haContext, "scene.beneden_ontbijten");
		///<summary>Beneden Ontspannen</summary>
		public SceneEntity BenedenOntspannen => new(_haContext, "scene.beneden_ontspannen");
		///<summary>Beneden Palm Beach</summary>
		public SceneEntity BenedenPalmBeach => new(_haContext, "scene.beneden_palm_beach");
		///<summary>Beneden Regenachtig</summary>
		public SceneEntity BenedenRegenachtig => new(_haContext, "scene.beneden_regenachtig");
		///<summary>Beneden Robijngloed</summary>
		public SceneEntity BenedenRobijngloed => new(_haContext, "scene.beneden_robijngloed");
		///<summary>Beneden Soho</summary>
		public SceneEntity BenedenSoho => new(_haContext, "scene.beneden_soho");
		///<summary>Beneden Stille nacht</summary>
		public SceneEntity BenedenStilleNacht => new(_haContext, "scene.beneden_stille_nacht");
		///<summary>Beneden Tropische schemering</summary>
		public SceneEntity BenedenTropischeSchemering => new(_haContext, "scene.beneden_tropische_schemering");
		///<summary>Beneden TV_Scene</summary>
		public SceneEntity BenedenTvScene => new(_haContext, "scene.beneden_tv_scene");
		///<summary>Beneden WakeUp_1</summary>
		public SceneEntity BenedenWakeup1 => new(_haContext, "scene.beneden_wakeup_1");
		///<summary>Beneden Wakeup-2</summary>
		public SceneEntity BenedenWakeup2 => new(_haContext, "scene.beneden_wakeup_2");
		///<summary>Beneden Zonsondergang1</summary>
		public SceneEntity BenedenZonsondergang1 => new(_haContext, "scene.beneden_zonsondergang1");
		///<summary>Eethoek Diner_Time</summary>
		public SceneEntity EethoekDinerTime => new(_haContext, "scene.eethoek_diner_time");
		///<summary>Eethoek Gedimd</summary>
		public SceneEntity EethoekGedimd => new(_haContext, "scene.eethoek_gedimd");
		///<summary>Eethoek Helder</summary>
		public SceneEntity EethoekHelder => new(_haContext, "scene.eethoek_helder");
		///<summary>Eethoek Nachtlampje</summary>
		public SceneEntity EethoekNachtlampje => new(_haContext, "scene.eethoek_nachtlampje");
		///<summary>Eethoek Sint</summary>
		public SceneEntity EethoekSint => new(_haContext, "scene.eethoek_sint");
		///<summary>Eettafel Helder</summary>
		public SceneEntity EettafelHelder => new(_haContext, "scene.eettafel_helder");
		///<summary>Eettafel Nachtlampje</summary>
		public SceneEntity EettafelNachtlampje => new(_haContext, "scene.eettafel_nachtlampje");
		///<summary>Eettafel Scene Eettafel 1</summary>
		public SceneEntity EettafelSceneEettafel1 => new(_haContext, "scene.eettafel_scene_eettafel_1");
		///<summary>Hal Avond</summary>
		public SceneEntity HalAvond => new(_haContext, "scene.hal_avond");
		///<summary>Hal Energie</summary>
		public SceneEntity HalEnergie => new(_haContext, "scene.hal_energie");
		///<summary>Hal Gedimd</summary>
		public SceneEntity HalGedimd => new(_haContext, "scene.hal_gedimd");
		///<summary>Hal Helder</summary>
		public SceneEntity HalHelder => new(_haContext, "scene.hal_helder");
		///<summary>Hal Herfstgoud</summary>
		public SceneEntity HalHerfstgoud => new(_haContext, "scene.hal_herfstgoud");
		///<summary>Hal Lentebloesem</summary>
		public SceneEntity HalLentebloesem => new(_haContext, "scene.hal_lentebloesem");
		///<summary>Hal Meermist</summary>
		public SceneEntity HalMeermist => new(_haContext, "scene.hal_meermist");
		///<summary>hal_motion_licht_uit</summary>
		public SceneEntity HalMotionLichtUit => new(_haContext, "scene.hal_motion_licht_uit");
		///<summary>Hal Nachtlampje</summary>
		public SceneEntity HalNachtlampje => new(_haContext, "scene.hal_nachtlampje");
		///<summary>Hal Ochtend</summary>
		public SceneEntity HalOchtend => new(_haContext, "scene.hal_ochtend");
		///<summary>Hal Overdag</summary>
		public SceneEntity HalOverdag => new(_haContext, "scene.hal_overdag");
		///<summary>Hal Scene_Roze</summary>
		public SceneEntity HalSceneRoze => new(_haContext, "scene.hal_scene_roze");
		///<summary>Hal Tokio</summary>
		public SceneEntity HalTokio => new(_haContext, "scene.hal_tokio");
		///<summary>Hal Zondagochtend</summary>
		public SceneEntity HalZondagochtend => new(_haContext, "scene.hal_zondagochtend");
		///<summary>Keuken Concentreren</summary>
		public SceneEntity KeukenConcentreren => new(_haContext, "scene.keuken_concentreren");
		///<summary>Keuken Energie</summary>
		public SceneEntity KeukenEnergie => new(_haContext, "scene.keuken_energie");
		///<summary>Keuken Gedimd</summary>
		public SceneEntity KeukenGedimd => new(_haContext, "scene.keuken_gedimd");
		///<summary>Keuken Helder</summary>
		public SceneEntity KeukenHelder => new(_haContext, "scene.keuken_helder");
		///<summary>Keuken Lentebloesem</summary>
		public SceneEntity KeukenLentebloesem => new(_haContext, "scene.keuken_lentebloesem");
		///<summary>Keuken Nachtlampje</summary>
		public SceneEntity KeukenNachtlampje => new(_haContext, "scene.keuken_nachtlampje");
		///<summary>Keuken Ontspannen</summary>
		public SceneEntity KeukenOntspannen => new(_haContext, "scene.keuken_ontspannen");
		///<summary>Keuken Palmbomen</summary>
		public SceneEntity KeukenPalmbomen => new(_haContext, "scene.keuken_palmbomen");
		///<summary>Keuken Savanne zonsondergang</summary>
		public SceneEntity KeukenSavanneZonsondergang => new(_haContext, "scene.keuken_savanne_zonsondergang");
		///<summary>Keuken Scene 1</summary>
		public SceneEntity KeukenScene1 => new(_haContext, "scene.keuken_scene_1");
		///<summary>Keuken Tropische schemering</summary>
		public SceneEntity KeukenTropischeSchemering => new(_haContext, "scene.keuken_tropische_schemering");
		///<summary>Nightwing 1</summary>
		public SceneEntity Nightwing1 => new(_haContext, "scene.nightwing_1");
		///<summary>Ontbijten-Beneden</summary>
		public SceneEntity OntbijtenBeneden => new(_haContext, "scene.ontbijten_beneden");
		///<summary>Overloop Arctische dageraad</summary>
		public SceneEntity OverloopArctischeDageraad => new(_haContext, "scene.overloop_arctische_dageraad");
		///<summary>Overloop Avond</summary>
		public SceneEntity OverloopAvond => new(_haContext, "scene.overloop_avond");
		///<summary>Overloop Concentreren</summary>
		public SceneEntity OverloopConcentreren => new(_haContext, "scene.overloop_concentreren");
		///<summary>Overloop Energie</summary>
		public SceneEntity OverloopEnergie => new(_haContext, "scene.overloop_energie");
		///<summary>Overloop Gedimd</summary>
		public SceneEntity OverloopGedimd => new(_haContext, "scene.overloop_gedimd");
		///<summary>Overloop Helder</summary>
		public SceneEntity OverloopHelder => new(_haContext, "scene.overloop_helder");
		///<summary>Overloop Kinderbedtijd</summary>
		public SceneEntity OverloopKinderbedtijd => new(_haContext, "scene.overloop_kinderbedtijd");
		///<summary>Overloop Lentebloesem</summary>
		public SceneEntity OverloopLentebloesem => new(_haContext, "scene.overloop_lentebloesem");
		///<summary>Overloop Lezen</summary>
		public SceneEntity OverloopLezen => new(_haContext, "scene.overloop_lezen");
		///<summary>Overloop - motion licht uit</summary>
		public SceneEntity OverloopMotionLichtUit => new(_haContext, "scene.overloop_motion_licht_uit");
		///<summary>Overloop Nachtlampje</summary>
		public SceneEntity OverloopNachtlampje => new(_haContext, "scene.overloop_nachtlampje");
		///<summary>Overloop Ochtend</summary>
		public SceneEntity OverloopOchtend => new(_haContext, "scene.overloop_ochtend");
		///<summary>Overloop Ontspannen</summary>
		public SceneEntity OverloopOntspannen => new(_haContext, "scene.overloop_ontspannen");
		///<summary>Overloop Overdag</summary>
		public SceneEntity OverloopOverdag => new(_haContext, "scene.overloop_overdag");
		///<summary>Overloop Savanne zonsondergang</summary>
		public SceneEntity OverloopSavanneZonsondergang => new(_haContext, "scene.overloop_savanne_zonsondergang");
		///<summary>Overloop Tropische schemering</summary>
		public SceneEntity OverloopTropischeSchemering => new(_haContext, "scene.overloop_tropische_schemering");
		///<summary>Slaapkamer Bloedmaan</summary>
		public SceneEntity SlaapkamerBloedmaan => new(_haContext, "scene.slaapkamer_bloedmaan");
		///<summary>Slaapkamer Chinatown</summary>
		public SceneEntity SlaapkamerChinatown => new(_haContext, "scene.slaapkamer_chinatown");
		///<summary>Slaapkamer Concentreren</summary>
		public SceneEntity SlaapkamerConcentreren => new(_haContext, "scene.slaapkamer_concentreren");
		///<summary>Slaapkamer Energie</summary>
		public SceneEntity SlaapkamerEnergie => new(_haContext, "scene.slaapkamer_energie");
		///<summary>Slaapkamer Gedimd</summary>
		public SceneEntity SlaapkamerGedimd => new(_haContext, "scene.slaapkamer_gedimd");
		///<summary>Slaapkamer Helder</summary>
		public SceneEntity SlaapkamerHelder => new(_haContext, "scene.slaapkamer_helder");
		///<summary>Slaapkamer Lentebloesem</summary>
		public SceneEntity SlaapkamerLentebloesem => new(_haContext, "scene.slaapkamer_lentebloesem");
		///<summary>Slaapkamer Lezen</summary>
		public SceneEntity SlaapkamerLezen => new(_haContext, "scene.slaapkamer_lezen");
		///<summary>Slaapkamer Nachtlampje</summary>
		public SceneEntity SlaapkamerNachtlampje => new(_haContext, "scene.slaapkamer_nachtlampje");
		///<summary>Slaapkamer Slaapkamer Ontspannen</summary>
		public SceneEntity SlaapkamerSlaapkamerOntspannen => new(_haContext, "scene.slaapkamer_slaapkamer_ontspannen");
		///<summary>Slaapkamer Slaaplampje</summary>
		public SceneEntity SlaapkamerSlaaplampje => new(_haContext, "scene.slaapkamer_slaaplampje");
		///<summary>Slaapkamer Sterrenlicht</summary>
		public SceneEntity SlaapkamerSterrenlicht => new(_haContext, "scene.slaapkamer_sterrenlicht");
		///<summary>Slaapkamer Tropische schemering</summary>
		public SceneEntity SlaapkamerTropischeSchemering => new(_haContext, "scene.slaapkamer_tropische_schemering");
		///<summary>Slaapkamer Zon_opkomst</summary>
		public SceneEntity SlaapkamerZonOpkomst => new(_haContext, "scene.slaapkamer_zon_opkomst");
		///<summary>Trap Slaapkamer Arctische dageraad</summary>
		public SceneEntity TrapSlaapkamerArctischeDageraad => new(_haContext, "scene.trap_slaapkamer_arctische_dageraad");
		///<summary>Trap Slaapkamer Avond</summary>
		public SceneEntity TrapSlaapkamerAvond => new(_haContext, "scene.trap_slaapkamer_avond");
		///<summary>Trap Slaapkamer Concentreren</summary>
		public SceneEntity TrapSlaapkamerConcentreren => new(_haContext, "scene.trap_slaapkamer_concentreren");
		///<summary>Trap Slaapkamer Energie</summary>
		public SceneEntity TrapSlaapkamerEnergie => new(_haContext, "scene.trap_slaapkamer_energie");
		///<summary>Trap Slaapkamer Gedimd</summary>
		public SceneEntity TrapSlaapkamerGedimd => new(_haContext, "scene.trap_slaapkamer_gedimd");
		///<summary>Trap Slaapkamer Helder</summary>
		public SceneEntity TrapSlaapkamerHelder => new(_haContext, "scene.trap_slaapkamer_helder");
		///<summary>Trap Slaapkamer Kinderbedtijd</summary>
		public SceneEntity TrapSlaapkamerKinderbedtijd => new(_haContext, "scene.trap_slaapkamer_kinderbedtijd");
		///<summary>Trap Slaapkamer Lentebloesem</summary>
		public SceneEntity TrapSlaapkamerLentebloesem => new(_haContext, "scene.trap_slaapkamer_lentebloesem");
		///<summary>Trap Slaapkamer Lezen</summary>
		public SceneEntity TrapSlaapkamerLezen => new(_haContext, "scene.trap_slaapkamer_lezen");
		///<summary>trap_slaapkamer_motion_licht_uit</summary>
		public SceneEntity TrapSlaapkamerMotionLichtUit => new(_haContext, "scene.trap_slaapkamer_motion_licht_uit");
		///<summary>Trap Slaapkamer Nachtlampje</summary>
		public SceneEntity TrapSlaapkamerNachtlampje => new(_haContext, "scene.trap_slaapkamer_nachtlampje");
		///<summary>Trap Slaapkamer Ochtend</summary>
		public SceneEntity TrapSlaapkamerOchtend => new(_haContext, "scene.trap_slaapkamer_ochtend");
		///<summary>Trap Slaapkamer Ontspannen</summary>
		public SceneEntity TrapSlaapkamerOntspannen => new(_haContext, "scene.trap_slaapkamer_ontspannen");
		///<summary>Trap Slaapkamer Overdag</summary>
		public SceneEntity TrapSlaapkamerOverdag => new(_haContext, "scene.trap_slaapkamer_overdag");
		///<summary>Trap_Slaapkamer_Overdag_Scene_X</summary>
		public SceneEntity TrapSlaapkamerOverdagSceneX => new(_haContext, "scene.trap_slaapkamer_overdag_scene_x");
		///<summary>Trap Slaapkamer Savanne zonsondergang</summary>
		public SceneEntity TrapSlaapkamerSavanneZonsondergang => new(_haContext, "scene.trap_slaapkamer_savanne_zonsondergang");
		///<summary>Trap Slaapkamer Tropische</summary>
		public SceneEntity TrapSlaapkamerTropische => new(_haContext, "scene.trap_slaapkamer_tropische");
		///<summary>Tuin Gedimd</summary>
		public SceneEntity TuinGedimd => new(_haContext, "scene.tuin_gedimd");
		///<summary>Tuin Helder</summary>
		public SceneEntity TuinHelder => new(_haContext, "scene.tuin_helder");
		///<summary>Tuin Nachtlampje</summary>
		public SceneEntity TuinNachtlampje => new(_haContext, "scene.tuin_nachtlampje");
		///<summary>Tuin Tuin 50 gedimd</summary>
		public SceneEntity TuinTuin50Gedimd => new(_haContext, "scene.tuin_tuin_50_gedimd");
		///<summary>TV LG Nachtflyer1</summary>
		public SceneEntity TvLgNachtflyer1 => new(_haContext, "scene.tv_lg_nachtflyer1");
		///<summary>TV_LG_RTL_4</summary>
		public SceneEntity TvLgRtl4 => new(_haContext, "scene.tv_lg_rtl_4");
		///<summary>Wc Gedimd</summary>
		public SceneEntity WcGedimd => new(_haContext, "scene.wc_gedimd");
		///<summary>Wc Helder</summary>
		public SceneEntity WcHelder => new(_haContext, "scene.wc_helder");
		///<summary>Wc Nachtlampje</summary>
		public SceneEntity WcNachtlampje => new(_haContext, "scene.wc_nachtlampje");
		///<summary>Woonkamer Film modus</summary>
		public SceneEntity WoonkamerFilmModus => new(_haContext, "scene.woonkamer_film_modus");
		///<summary>Woonkamer Helder</summary>
		public SceneEntity WoonkamerHelder => new(_haContext, "scene.woonkamer_helder");
		///<summary>Woonkamer Nachtlampje</summary>
		public SceneEntity WoonkamerNachtlampje => new(_haContext, "scene.woonkamer_nachtlampje");
		///<summary>Woonkamer Open Haard</summary>
		public SceneEntity WoonkamerOpenHaard => new(_haContext, "scene.woonkamer_open_haard");
		///<summary>Woonkamer Tv sfeer</summary>
		public SceneEntity WoonkamerTvSfeer => new(_haContext, "scene.woonkamer_tv_sfeer");
		///<summary>Woonkamer Wenkbrauwen</summary>
		public SceneEntity WoonkamerWenkbrauwen => new(_haContext, "scene.woonkamer_wenkbrauwen");
	}

	public partial class ScriptEntities
	{
		private readonly IHaContext _haContext;
		public ScriptEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>00_lg_tv_woonkamer_aanzetten</summary>
		public ScriptEntity E00LgTvWoonkamerAanzetten => new(_haContext, "script.00_lg_tv_woonkamer_aanzetten");
		///<summary>_00_spotify_source_zet_op_lg_tv_woonkamer</summary>
		public ScriptEntity E00SpotifySourceZetOpLgTvWoonkamer => new(_haContext, "script.00_spotify_source_zet_op_lg_tv_woonkamer");
		///<summary>_00_start_spotify_op_lg_tv_woonkamer</summary>
		public ScriptEntity E00StartSpotifyOpLgTvWoonkamer => new(_haContext, "script.00_start_spotify_op_lg_tv_woonkamer");
		///<summary>01_spotify_app_starten_op_lg_tv_woonkamer</summary>
		public ScriptEntity E01SpotifyAppStartenOpLgTvWoonkamer => new(_haContext, "script.01_spotify_app_starten_op_lg_tv_woonkamer");
		///<summary>010_denon_input_op_tv_audio</summary>
		public ScriptEntity E010DenonInputOpTvAudio => new(_haContext, "script.010_denon_input_op_tv_audio");
		///<summary>02 Selecteer input Live TV op LG TV Woonkamer</summary>
		public ScriptEntity E02SelecteerInputLiveTvOpLgTvWoonkamer => new(_haContext, "script.02_selecteer_input_live_tv_op_lg_tv_woonkamer");
		///<summary>03_cast_muziek_van_spotify_baby_yoda_op_lg_tv_woonkamer</summary>
		public ScriptEntity E03CastMuziekVanSpotifyBabyYodaOpLgTvWoonkamer => new(_haContext, "script.03_cast_muziek_van_spotify_baby_yoda_op_lg_tv_woonkamer");
		///<summary>032_cast_muziek_van_spotify_baby_yoda_op_denon_x2200w</summary>
		public ScriptEntity E032CastMuziekVanSpotifyBabyYodaOpDenonX2200w => new(_haContext, "script.032_cast_muziek_van_spotify_baby_yoda_op_denon_x2200w");
		///<summary>04 Start Spotify op LG Woonkamer_v2</summary>
		public ScriptEntity E04StartSpotifyOpLgWoonkamerV2 => new(_haContext, "script.04_start_spotify_op_lg_woonkamer_v2");
		///<summary>04 Transfer Spotify to LG Woonkamer v1</summary>
		public ScriptEntity E04TransferSpotifyToLgWoonkamerV1 => new(_haContext, "script.04_transfer_spotify_to_lg_woonkamer_v1");
		///<summary>050_send_custom_event</summary>
		public ScriptEntity E050SendCustomEvent => new(_haContext, "script.050_send_custom_event");
		///<summary>Redirect Spotify To Livingroom TV</summary>
		public ScriptEntity E1660661182752 => new(_haContext, "script.1660661182752");
		///<summary>Turn on choosen media player</summary>
		public ScriptEntity E1660661226923 => new(_haContext, "script.1660661226923");
		///<summary>401 Mayson extra slaapje modus v1</summary>
		public ScriptEntity E401MaysonExtraSlaapjeModusV1 => new(_haContext, "script.401_mayson_extra_slaapje_modus_v1");
		///<summary>402 Uitzetten Mayson extra slaapje modus v1</summary>
		public ScriptEntity E402UitzettenMaysonExtraSlaapjeModusV1 => new(_haContext, "script.402_uitzetten_mayson_extra_slaapje_modus_v1");
		///<summary>80 Save State before doorbell tring</summary>
		public ScriptEntity E80SaveStateBeforeDoorbellTring => new(_haContext, "script.80_save_state_before_doorbell_tring");
		///<summary>81 Pauzeer alles als de deurbel gaat</summary>
		public ScriptEntity E81PauzeerAllesAlsDeDeurbelGaat => new(_haContext, "script.81_pauzeer_alles_als_de_deurbel_gaat");
		///<summary>82 Restore State before doorbell tring</summary>
		public ScriptEntity E82RestoreStateBeforeDoorbellTring => new(_haContext, "script.82_restore_state_before_doorbell_tring");
		///<summary>85 Say Motion Detected in Slaapkamer trap</summary>
		public ScriptEntity E85SayMotionDetectedInSlaapkamerTrap => new(_haContext, "script.85_say_motion_detected_in_slaapkamer_trap");
		///<summary>88_1_Deurbel_ring_flash_lights_01</summary>
		public ScriptEntity E881DeurbelRingFlashLights01 => new(_haContext, "script.88_1_deurbel_ring_flash_lights_01");
		///<summary>__88_2_Deurbell_Tring_01</summary>
		public ScriptEntity E882DeurbellTring01 => new(_haContext, "script.88_2_deurbell_tring_01");
		///<summary>88 2 Stuur Notificatie Deurbell Tring naar Groep</summary>
		public ScriptEntity E882StuurNotificatieDeurbellTringNaarGroep => new(_haContext, "script.88_2_stuur_notificatie_deurbell_tring_naar_groep");
		///<summary>88_3_deurbel_tring_TTS Google Home 01</summary>
		public ScriptEntity E883DeurbelTringTtsGoogleHome01 => new(_haContext, "script.88_3_deurbel_tring_tts_google_home_01");
		///<summary>__88_Deurbel_ring_01</summary>
		public ScriptEntity E88DeurbelRing01 => new(_haContext, "script.88_deurbel_ring_01");
		///<summary>Foscam1_Plafond_dienst_1_Actief</summary>
		public ScriptEntity Foscam1PlafondDienst1Actief => new(_haContext, "script.foscam1_plafond_dienst_1_actief");
		///<summary>light_turn_off</summary>
		public ScriptEntity LightTurnOff => new(_haContext, "script.light_turn_off");
		///<summary>pyDoorbell_button_2</summary>
		public ScriptEntity PydoorbellButton2 => new(_haContext, "script.pydoorbell_button_2");
		///<summary>set_select_options_for_scenes</summary>
		public ScriptEntity SetSelectOptionsForScenes => new(_haContext, "script.set_select_options_for_scenes");
		///<summary>Stream_foscam1_chromecast_slaapkamer_1</summary>
		public ScriptEntity StreamFoscam1ChromecastSlaapkamer1 => new(_haContext, "script.stream_foscam1_chromecast_slaapkamer_1");
		///<summary>stream_to_lgtv_01</summary>
		public ScriptEntity StreamToLgtv01 => new(_haContext, "script.stream_to_lgtv_01");
		///<summary>stream_to_lgtv_02</summary>
		public ScriptEntity StreamToLgtv012 => new(_haContext, "script.stream_to_lgtv_01_2");
		///<summary>Stuur_Bericht_naar_browser_mod</summary>
		public ScriptEntity StuurBerichtNaarBrowserMod => new(_haContext, "script.stuur_bericht_naar_browser_mod");
		///<summary>thema-set-huidige</summary>
		public ScriptEntity ThemaSetHuidige => new(_haContext, "script.thema_set_huidige");
	}

	public partial class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>afvalwijzer day_after_tomorrow</summary>
		public SensorEntity AfvalwijzerDayAfterTomorrow => new(_haContext, "sensor.afvalwijzer_day_after_tomorrow");
		///<summary>afvalwijzer gft</summary>
		public SensorEntity AfvalwijzerGft => new(_haContext, "sensor.afvalwijzer_gft");
		///<summary>afvalwijzer next_date</summary>
		public SensorEntity AfvalwijzerNextDate => new(_haContext, "sensor.afvalwijzer_next_date");
		///<summary>afvalwijzer next_in_days</summary>
		public SensorEntity AfvalwijzerNextInDays => new(_haContext, "sensor.afvalwijzer_next_in_days");
		///<summary>afvalwijzer next_type</summary>
		public SensorEntity AfvalwijzerNextType => new(_haContext, "sensor.afvalwijzer_next_type");
		///<summary>afvalwijzer restafval</summary>
		public SensorEntity AfvalwijzerRestafval => new(_haContext, "sensor.afvalwijzer_restafval");
		///<summary>afvalwijzer today</summary>
		public SensorEntity AfvalwijzerToday => new(_haContext, "sensor.afvalwijzer_today");
		///<summary>afvalwijzer tomorrow</summary>
		public SensorEntity AfvalwijzerTomorrow => new(_haContext, "sensor.afvalwijzer_tomorrow");
		///<summary>AirCast Newest version</summary>
		public SensorEntity AircastNewestVersion => new(_haContext, "sensor.aircast_newest_version");
		///<summary>AirCast Version</summary>
		public SensorEntity AircastVersion => new(_haContext, "sensor.aircast_version");
		///<summary>AirSonos Newest version</summary>
		public SensorEntity AirsonosNewestVersion => new(_haContext, "sensor.airsonos_newest_version");
		///<summary>AirSonos Version</summary>
		public SensorEntity AirsonosVersion => new(_haContext, "sensor.airsonos_version");
		///<summary>AppDaemon Newest version</summary>
		public SensorEntity Appdaemon4NewestVersion => new(_haContext, "sensor.appdaemon_4_newest_version");
		///<summary>AppDaemon Version</summary>
		public SensorEntity Appdaemon4Version => new(_haContext, "sensor.appdaemon_4_version");
		public SensorEntity BrowserBmGraysonPb51 => new(_haContext, "sensor.browser_bm_grayson_pb51");
		public SensorEntity BrowserBmIpadPro => new(_haContext, "sensor.browser_bm_ipad_pro");
		public SensorEntity BrowserBmIpadpro1 => new(_haContext, "sensor.browser_bm_ipadpro_1");
		public SensorEntity BrowserBmOneplus9pro => new(_haContext, "sensor.browser_bm_oneplus_9pro");
		public SensorEntity BrowserBmPb51Vivaldi => new(_haContext, "sensor.browser_bm_pb51_vivaldi");
		///<summary>Check Home Assistant configuration Newest version</summary>
		public SensorEntity CheckHomeAssistantConfigurationNewestVersion => new(_haContext, "sensor.check_home_assistant_configuration_newest_version");
		///<summary>Check Home Assistant configuration Version</summary>
		public SensorEntity CheckHomeAssistantConfigurationVersion => new(_haContext, "sensor.check_home_assistant_configuration_version");
		///<summary>Chromecast Devices</summary>
		public SensorEntity ChromecastDevices => new(_haContext, "sensor.chromecast_devices");
		///<summary>chrony Newest version</summary>
		public SensorEntity ChronyNewestVersion => new(_haContext, "sensor.chrony_newest_version");
		///<summary>chrony Version</summary>
		public SensorEntity ChronyVersion => new(_haContext, "sensor.chrony_version");
		///<summary>Current Version</summary>
		public SensorEntity CurrentVersion => new(_haContext, "sensor.current_version");
		///<summary>Date</summary>
		public SensorEntity Date => new(_haContext, "sensor.date");
		///<summary>Date & Time</summary>
		public SensorEntity DateTime => new(_haContext, "sensor.date_time");
		///<summary>Date & Time (ISO)</summary>
		public SensorEntity DateTimeIso => new(_haContext, "sensor.date_time_iso");
		///<summary>Date & Time (UTC)</summary>
		public SensorEntity DateTimeUtc => new(_haContext, "sensor.date_time_utc");
		///<summary>Daytime</summary>
		public SensorEntity Daytime => new(_haContext, "sensor.daytime");
		///<summary>ds1 (Volume 1) Status</summary>
		public SensorEntity Ds1Status => new(_haContext, "sensor.ds1_status");
		///<summary>ds1 (Volume 2) Status</summary>
		public SensorEntity Ds1Status2 => new(_haContext, "sensor.ds1_status_2");
		///<summary>ds1 (Schijf 1) Status</summary>
		public SensorEntity Ds1Status3 => new(_haContext, "sensor.ds1_status_3");
		///<summary>ds1 (Schijf 2) Status</summary>
		public SensorEntity Ds1Status4 => new(_haContext, "sensor.ds1_status_4");
		///<summary>File editor Newest version</summary>
		public SensorEntity FileEditorNewestVersion => new(_haContext, "sensor.file_editor_newest_version");
		///<summary>File editor Version</summary>
		public SensorEntity FileEditorVersion => new(_haContext, "sensor.file_editor_version");
		///<summary>Glances Newest version</summary>
		public SensorEntity GlancesNewestVersion => new(_haContext, "sensor.glances_newest_version");
		///<summary>Glances Version</summary>
		public SensorEntity GlancesVersion => new(_haContext, "sensor.glances_version");
		///<summary>Home Assistant Operating System Newest version</summary>
		public SensorEntity HomeAssistantOperatingSystemNewestVersion => new(_haContext, "sensor.home_assistant_operating_system_newest_version");
		///<summary>Home Assistant Operating System Version</summary>
		public SensorEntity HomeAssistantOperatingSystemVersion => new(_haContext, "sensor.home_assistant_operating_system_version");
		///<summary>Hue play 1 Zigbee Connectivity</summary>
		public SensorEntity HuePlay1ZigbeeConnectivity => new(_haContext, "sensor.hue_play_1_zigbee_connectivity");
		///<summary>Internet Time</summary>
		public SensorEntity InternetTime => new(_haContext, "sensor.internet_time");
		///<summary>iPadPro Activity</summary>
		public SensorEntity IpadproActivity => new(_haContext, "sensor.ipadpro_activity");
		///<summary>iPadPro Battery State</summary>
		public SensorEntity IpadproBatteryState => new(_haContext, "sensor.ipadpro_battery_state");
		///<summary>iPadPro BSSID</summary>
		public SensorEntity IpadproBssid => new(_haContext, "sensor.ipadpro_bssid");
		///<summary>iPadPro Connection Type</summary>
		public SensorEntity IpadproConnectionType => new(_haContext, "sensor.ipadpro_connection_type");
		///<summary>iPadPro Geocoded Location</summary>
		public SensorEntity IpadproGeocodedLocation => new(_haContext, "sensor.ipadpro_geocoded_location");
		///<summary>iPadPro Last Update Trigger</summary>
		public SensorEntity IpadproLastUpdateTrigger => new(_haContext, "sensor.ipadpro_last_update_trigger");
		///<summary>iPadPro SSID</summary>
		public SensorEntity IpadproSsid => new(_haContext, "sensor.ipadpro_ssid");
		///<summary>Log Viewer Newest version</summary>
		public SensorEntity LogViewerNewestVersion => new(_haContext, "sensor.log_viewer_newest_version");
		///<summary>Log Viewer Version</summary>
		public SensorEntity LogViewerVersion => new(_haContext, "sensor.log_viewer_version");
		///<summary>MariaDB Newest version</summary>
		public SensorEntity MariadbNewestVersion => new(_haContext, "sensor.mariadb_newest_version");
		///<summary>MariaDB Version</summary>
		public SensorEntity MariadbVersion => new(_haContext, "sensor.mariadb_version");
		///<summary>Matrix Newest version</summary>
		public SensorEntity MatrixNewestVersion => new(_haContext, "sensor.matrix_newest_version");
		///<summary>Matrix Version</summary>
		public SensorEntity MatrixVersion => new(_haContext, "sensor.matrix_version");
		///<summary>Mosquitto broker Newest version</summary>
		public SensorEntity MosquittoBrokerNewestVersion => new(_haContext, "sensor.mosquitto_broker_newest_version");
		///<summary>Mosquitto broker Version</summary>
		public SensorEntity MosquittoBrokerVersion => new(_haContext, "sensor.mosquitto_broker_version");
		///<summary>OnePlus-9-Pro App Importance</summary>
		public SensorEntity Oneplus9ProAppImportance => new(_haContext, "sensor.oneplus_9_pro_app_importance");
		///<summary>OnePlus-9-Pro App Standby Bucket</summary>
		public SensorEntity Oneplus9ProAppStandbyBucket => new(_haContext, "sensor.oneplus_9_pro_app_standby_bucket");
		///<summary>OnePlus-9-Pro Audio Mode</summary>
		public SensorEntity Oneplus9ProAudioMode => new(_haContext, "sensor.oneplus_9_pro_audio_mode");
		///<summary>OnePlus-9-Pro Battery State</summary>
		public SensorEntity Oneplus9ProBatterijLaadstatus => new(_haContext, "sensor.oneplus_9_pro_batterij_laadstatus");
		///<summary>OnePlus-9-Pro Battery Health</summary>
		public SensorEntity Oneplus9ProBatterijstatus => new(_haContext, "sensor.oneplus_9_pro_batterijstatus");
		///<summary>OnePlus-9-Pro Current Time Zone</summary>
		public SensorEntity Oneplus9ProCurrentTimeZone => new(_haContext, "sensor.oneplus_9_pro_current_time_zone");
		///<summary>OnePlus-9-Pro Current Version</summary>
		public SensorEntity Oneplus9ProCurrentVersion => new(_haContext, "sensor.oneplus_9_pro_current_version");
		///<summary>OnePlus-9-Pro Detected Activity</summary>
		public SensorEntity Oneplus9ProDetectedActivity => new(_haContext, "sensor.oneplus_9_pro_detected_activity");
		///<summary>OnePlus-9-Pro Do Not Disturb Sensor</summary>
		public SensorEntity Oneplus9ProDoNotDisturbSensor => new(_haContext, "sensor.oneplus_9_pro_do_not_disturb_sensor");
		///<summary>OnePlus-9-Pro Geocoded Location</summary>
		public SensorEntity Oneplus9ProGegeocodeerdeLocatie => new(_haContext, "sensor.oneplus_9_pro_gegeocodeerde_locatie");
		///<summary>OnePlus-9-Pro Last Reboot</summary>
		public SensorEntity Oneplus9ProLastReboot => new(_haContext, "sensor.oneplus_9_pro_last_reboot");
		///<summary>OnePlus-9-Pro Media Session</summary>
		public SensorEntity Oneplus9ProMediaSession => new(_haContext, "sensor.oneplus_9_pro_media_session");
		///<summary>OnePlus-9-Pro Phone State</summary>
		public SensorEntity Oneplus9ProPhoneState => new(_haContext, "sensor.oneplus_9_pro_phone_state");
		///<summary>OnePlus-9-Pro Proximity Sensor</summary>
		public SensorEntity Oneplus9ProProximitySensor => new(_haContext, "sensor.oneplus_9_pro_proximity_sensor");
		///<summary>OnePlus-9-Pro Public IP Address</summary>
		public SensorEntity Oneplus9ProPublicIpAddress => new(_haContext, "sensor.oneplus_9_pro_public_ip_address");
		///<summary>OnePlus-9-Pro Ringer Mode</summary>
		public SensorEntity Oneplus9ProRingerMode => new(_haContext, "sensor.oneplus_9_pro_ringer_mode");
		///<summary>OnePlus-9-Pro SIM 1</summary>
		public SensorEntity Oneplus9ProSim1 => new(_haContext, "sensor.oneplus_9_pro_sim_1");
		///<summary>OnePlus-9-Pro SIM 2</summary>
		public SensorEntity Oneplus9ProSim2 => new(_haContext, "sensor.oneplus_9_pro_sim_2");
		///<summary>OnePlus-9-Pro Last Update Trigger</summary>
		public SensorEntity Oneplus9ProTriggerLaatsteUpdate => new(_haContext, "sensor.oneplus_9_pro_trigger_laatste_update");
		///<summary>OnePlus-9-Pro Charger Type</summary>
		public SensorEntity Oneplus9ProTypeOplader => new(_haContext, "sensor.oneplus_9_pro_type_oplader");
		///<summary>OnePlus-9-Pro Next Alarm</summary>
		public SensorEntity Oneplus9ProVolgendeAlarm => new(_haContext, "sensor.oneplus_9_pro_volgende_alarm");
		///<summary>OnePlus-9-Pro Volume Level Alarm</summary>
		public SensorEntity Oneplus9ProVolumeLevelAlarm => new(_haContext, "sensor.oneplus_9_pro_volume_level_alarm");
		///<summary>OnePlus-9-Pro Volume Level Call</summary>
		public SensorEntity Oneplus9ProVolumeLevelCall => new(_haContext, "sensor.oneplus_9_pro_volume_level_call");
		///<summary>OnePlus-9-Pro Volume Level Music</summary>
		public SensorEntity Oneplus9ProVolumeLevelMusic => new(_haContext, "sensor.oneplus_9_pro_volume_level_music");
		///<summary>OnePlus-9-Pro Volume Level Ringer</summary>
		public SensorEntity Oneplus9ProVolumeLevelRinger => new(_haContext, "sensor.oneplus_9_pro_volume_level_ringer");
		///<summary>OnePlus-9-Pro WiFi BSSID</summary>
		public SensorEntity Oneplus9ProWifiBssid => new(_haContext, "sensor.oneplus_9_pro_wifi_bssid");
		///<summary>OnePlus-9-Pro WiFi IP Address</summary>
		public SensorEntity Oneplus9ProWifiIpAdres => new(_haContext, "sensor.oneplus_9_pro_wifi_ip_adres");
		///<summary>OnePlus-9-Pro WiFi Connection</summary>
		public SensorEntity Oneplus9ProWifiVerbinding => new(_haContext, "sensor.oneplus_9_pro_wifi_verbinding");
		///<summary>phpMyAdmin Newest version</summary>
		public SensorEntity PhpmyadminNewestVersion => new(_haContext, "sensor.phpmyadmin_newest_version");
		///<summary>phpMyAdmin Version</summary>
		public SensorEntity PhpmyadminVersion => new(_haContext, "sensor.phpmyadmin_version");
		///<summary>Playlists sensor</summary>
		public SensorEntity PlaylistsSensor => new(_haContext, "sensor.playlists_sensor");
		///<summary>Portainer Newest version</summary>
		public SensorEntity PortainerNewestVersion => new(_haContext, "sensor.portainer_newest_version");
		///<summary>Portainer Version</summary>
		public SensorEntity PortainerVersion => new(_haContext, "sensor.portainer_version");
		///<summary>Samba share Newest version</summary>
		public SensorEntity SambaShareNewestVersion => new(_haContext, "sensor.samba_share_newest_version");
		///<summary>Samba share Version</summary>
		public SensorEntity SambaShareVersion => new(_haContext, "sensor.samba_share_version");
		///<summary>Spotify Connect Newest version</summary>
		public SensorEntity SpotifyConnectNewestVersion => new(_haContext, "sensor.spotify_connect_newest_version");
		///<summary>Spotify Connect Version</summary>
		public SensorEntity SpotifyConnectVersion => new(_haContext, "sensor.spotify_connect_version");
		///<summary>Time</summary>
		public SensorEntity Time => new(_haContext, "sensor.time");
		///<summary>Time & Date</summary>
		public SensorEntity TimeDate => new(_haContext, "sensor.time_date");
		///<summary>Time (UTC)</summary>
		public SensorEntity TimeUtc => new(_haContext, "sensor.time_utc");
		///<summary>Studio Code Server Newest version</summary>
		public SensorEntity VisualStudioCodeNewestVersion => new(_haContext, "sensor.visual_studio_code_newest_version");
		///<summary>Studio Code Server Version</summary>
		public SensorEntity VisualStudioCodeVersion => new(_haContext, "sensor.visual_studio_code_version");
		///<summary>AirCast CPU percent</summary>
		public NumericSensorEntity AircastCpuPercent => new(_haContext, "sensor.aircast_cpu_percent");
		///<summary>AirCast Memory percent</summary>
		public NumericSensorEntity AircastMemoryPercent => new(_haContext, "sensor.aircast_memory_percent");
		///<summary>AirSonos CPU percent</summary>
		public NumericSensorEntity AirsonosCpuPercent => new(_haContext, "sensor.airsonos_cpu_percent");
		///<summary>AirSonos Memory percent</summary>
		public NumericSensorEntity AirsonosMemoryPercent => new(_haContext, "sensor.airsonos_memory_percent");
		///<summary>AppDaemon CPU percent</summary>
		public NumericSensorEntity Appdaemon4CpuPercent => new(_haContext, "sensor.appdaemon_4_cpu_percent");
		///<summary>AppDaemon Memory percent</summary>
		public NumericSensorEntity Appdaemon4MemoryPercent => new(_haContext, "sensor.appdaemon_4_memory_percent");
		///<summary>Check Home Assistant configuration CPU percent</summary>
		public NumericSensorEntity CheckHomeAssistantConfigurationCpuPercent => new(_haContext, "sensor.check_home_assistant_configuration_cpu_percent");
		///<summary>Check Home Assistant configuration Memory percent</summary>
		public NumericSensorEntity CheckHomeAssistantConfigurationMemoryPercent => new(_haContext, "sensor.check_home_assistant_configuration_memory_percent");
		///<summary>chrony CPU percent</summary>
		public NumericSensorEntity ChronyCpuPercent => new(_haContext, "sensor.chrony_cpu_percent");
		///<summary>chrony Memory percent</summary>
		public NumericSensorEntity ChronyMemoryPercent => new(_haContext, "sensor.chrony_memory_percent");
		///<summary>ds1 (Volume 1) Average Disk Temp</summary>
		public NumericSensorEntity Ds1AverageDiskTemp => new(_haContext, "sensor.ds1_average_disk_temp");
		///<summary>ds1 (Volume 2) Average Disk Temp</summary>
		public NumericSensorEntity Ds1AverageDiskTemp2 => new(_haContext, "sensor.ds1_average_disk_temp_2");
		///<summary>ds1 CPU Load Average (15 min)</summary>
		public NumericSensorEntity Ds1CpuLoadAverage15Min => new(_haContext, "sensor.ds1_cpu_load_average_15_min");
		///<summary>ds1 CPU Load Average (5 min)</summary>
		public NumericSensorEntity Ds1CpuLoadAverage5Min => new(_haContext, "sensor.ds1_cpu_load_average_5_min");
		///<summary>ds1 CPU Utilization (Total)</summary>
		public NumericSensorEntity Ds1CpuUtilizationTotal => new(_haContext, "sensor.ds1_cpu_utilization_total");
		///<summary>ds1 CPU Utilization (User)</summary>
		public NumericSensorEntity Ds1CpuUtilizationUser => new(_haContext, "sensor.ds1_cpu_utilization_user");
		///<summary>ds1 Download Throughput</summary>
		public NumericSensorEntity Ds1DownloadThroughput => new(_haContext, "sensor.ds1_download_throughput");
		///<summary>ds1 Memory Available (Real)</summary>
		public NumericSensorEntity Ds1MemoryAvailableReal => new(_haContext, "sensor.ds1_memory_available_real");
		///<summary>ds1 Memory Available (Swap)</summary>
		public NumericSensorEntity Ds1MemoryAvailableSwap => new(_haContext, "sensor.ds1_memory_available_swap");
		///<summary>ds1 Memory Total (Real)</summary>
		public NumericSensorEntity Ds1MemoryTotalReal => new(_haContext, "sensor.ds1_memory_total_real");
		///<summary>ds1 Memory Total (Swap)</summary>
		public NumericSensorEntity Ds1MemoryTotalSwap => new(_haContext, "sensor.ds1_memory_total_swap");
		///<summary>ds1 Memory Usage (Real)</summary>
		public NumericSensorEntity Ds1MemoryUsageReal => new(_haContext, "sensor.ds1_memory_usage_real");
		///<summary>ds1 (Schijf 1) Temperature</summary>
		public NumericSensorEntity Ds1Temperature => new(_haContext, "sensor.ds1_temperature");
		///<summary>ds1 (Schijf 2) Temperature</summary>
		public NumericSensorEntity Ds1Temperature2 => new(_haContext, "sensor.ds1_temperature_2");
		///<summary>ds1 Temperature</summary>
		public NumericSensorEntity Ds1Temperature3 => new(_haContext, "sensor.ds1_temperature_3");
		///<summary>ds1 Upload Throughput</summary>
		public NumericSensorEntity Ds1UploadThroughput => new(_haContext, "sensor.ds1_upload_throughput");
		///<summary>ds1 (Volume 1) Used Space</summary>
		public NumericSensorEntity Ds1UsedSpace => new(_haContext, "sensor.ds1_used_space");
		///<summary>ds1 (Volume 2) Used Space</summary>
		public NumericSensorEntity Ds1UsedSpace2 => new(_haContext, "sensor.ds1_used_space_2");
		///<summary>ds1 (Volume 1) Volume Used</summary>
		public NumericSensorEntity Ds1VolumeUsed => new(_haContext, "sensor.ds1_volume_used");
		///<summary>ds1 (Volume 2) Volume Used</summary>
		public NumericSensorEntity Ds1VolumeUsed2 => new(_haContext, "sensor.ds1_volume_used_2");
		///<summary>File editor CPU percent</summary>
		public NumericSensorEntity FileEditorCpuPercent => new(_haContext, "sensor.file_editor_cpu_percent");
		///<summary>File editor Memory percent</summary>
		public NumericSensorEntity FileEditorMemoryPercent => new(_haContext, "sensor.file_editor_memory_percent");
		///<summary>Glances CPU percent</summary>
		public NumericSensorEntity GlancesCpuPercent => new(_haContext, "sensor.glances_cpu_percent");
		///<summary>Glances Memory percent</summary>
		public NumericSensorEntity GlancesMemoryPercent => new(_haContext, "sensor.glances_memory_percent");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>Hue dimmer switch 1 Battery</summary>
		public NumericSensorEntity HueDimmerSwitch1BatteryLevel => new(_haContext, "sensor.hue_dimmer_switch_1_battery_level");
		///<summary>Hue dimmer switch 2 Battery</summary>
		public NumericSensorEntity HueDimmerSwitch2BatteryLevel => new(_haContext, "sensor.hue_dimmer_switch_2_battery_level");
		///<summary>iPadPro Battery Level</summary>
		public NumericSensorEntity IpadproBatteryLevel => new(_haContext, "sensor.ipadpro_battery_level");
		///<summary>iPadPro Storage</summary>
		public NumericSensorEntity IpadproStorage => new(_haContext, "sensor.ipadpro_storage");
		///<summary>Log Viewer CPU percent</summary>
		public NumericSensorEntity LogViewerCpuPercent => new(_haContext, "sensor.log_viewer_cpu_percent");
		///<summary>Log Viewer Memory percent</summary>
		public NumericSensorEntity LogViewerMemoryPercent => new(_haContext, "sensor.log_viewer_memory_percent");
		///<summary>MariaDB CPU percent</summary>
		public NumericSensorEntity MariadbCpuPercent => new(_haContext, "sensor.mariadb_cpu_percent");
		///<summary>MariaDB Memory percent</summary>
		public NumericSensorEntity MariadbMemoryPercent => new(_haContext, "sensor.mariadb_memory_percent");
		///<summary>Matrix CPU percent</summary>
		public NumericSensorEntity MatrixCpuPercent => new(_haContext, "sensor.matrix_cpu_percent");
		///<summary>Matrix Memory percent</summary>
		public NumericSensorEntity MatrixMemoryPercent => new(_haContext, "sensor.matrix_memory_percent");
		///<summary>Mosquitto broker CPU percent</summary>
		public NumericSensorEntity MosquittoBrokerCpuPercent => new(_haContext, "sensor.mosquitto_broker_cpu_percent");
		///<summary>Mosquitto broker Memory percent</summary>
		public NumericSensorEntity MosquittoBrokerMemoryPercent => new(_haContext, "sensor.mosquitto_broker_memory_percent");
		///<summary>OnePlus-9-Pro App Memory</summary>
		public NumericSensorEntity Oneplus9ProAppMemory => new(_haContext, "sensor.oneplus_9_pro_app_memory");
		///<summary>OnePlus-9-Pro App Rx GB</summary>
		public NumericSensorEntity Oneplus9ProAppRxGb => new(_haContext, "sensor.oneplus_9_pro_app_rx_gb");
		///<summary>OnePlus-9-Pro App Tx GB</summary>
		public NumericSensorEntity Oneplus9ProAppTxGb => new(_haContext, "sensor.oneplus_9_pro_app_tx_gb");
		///<summary>OnePlus-9-Pro Battery Level</summary>
		public NumericSensorEntity Oneplus9ProBatterijniveau => new(_haContext, "sensor.oneplus_9_pro_batterijniveau");
		///<summary>OnePlus-9-Pro Battery Temperature</summary>
		public NumericSensorEntity Oneplus9ProBatteryTemperature => new(_haContext, "sensor.oneplus_9_pro_battery_temperature");
		///<summary>OnePlus-9-Pro Internal Storage</summary>
		public NumericSensorEntity Oneplus9ProInternalStorage => new(_haContext, "sensor.oneplus_9_pro_internal_storage");
		///<summary>OnePlus-9-Pro Light Sensor</summary>
		public NumericSensorEntity Oneplus9ProLightSensor => new(_haContext, "sensor.oneplus_9_pro_light_sensor");
		///<summary>OnePlus-9-Pro Mobile Rx GB</summary>
		public NumericSensorEntity Oneplus9ProMobileRxGb => new(_haContext, "sensor.oneplus_9_pro_mobile_rx_gb");
		///<summary>OnePlus-9-Pro Mobile Tx GB</summary>
		public NumericSensorEntity Oneplus9ProMobileTxGb => new(_haContext, "sensor.oneplus_9_pro_mobile_tx_gb");
		///<summary>OnePlus-9-Pro Sleep Segment</summary>
		public NumericSensorEntity Oneplus9ProSleepSegment => new(_haContext, "sensor.oneplus_9_pro_sleep_segment");
		///<summary>OnePlus-9-Pro Steps Sensor</summary>
		public NumericSensorEntity Oneplus9ProStepsSensor => new(_haContext, "sensor.oneplus_9_pro_steps_sensor");
		///<summary>OnePlus-9-Pro Total Rx GB</summary>
		public NumericSensorEntity Oneplus9ProTotalRxGb => new(_haContext, "sensor.oneplus_9_pro_total_rx_gb");
		///<summary>OnePlus-9-Pro Total Tx GB</summary>
		public NumericSensorEntity Oneplus9ProTotalTxGb => new(_haContext, "sensor.oneplus_9_pro_total_tx_gb");
		///<summary>OnePlus-9-Pro WiFi Frequency</summary>
		public NumericSensorEntity Oneplus9ProWifiFrequency => new(_haContext, "sensor.oneplus_9_pro_wifi_frequency");
		///<summary>OnePlus-9-Pro WiFi Link Speed</summary>
		public NumericSensorEntity Oneplus9ProWifiLinkSpeed => new(_haContext, "sensor.oneplus_9_pro_wifi_link_speed");
		///<summary>OnePlus-9-Pro WiFi Signal Strength</summary>
		public NumericSensorEntity Oneplus9ProWifiSignalStrength => new(_haContext, "sensor.oneplus_9_pro_wifi_signal_strength");
		///<summary>phpMyAdmin CPU percent</summary>
		public NumericSensorEntity PhpmyadminCpuPercent => new(_haContext, "sensor.phpmyadmin_cpu_percent");
		///<summary>phpMyAdmin Memory percent</summary>
		public NumericSensorEntity PhpmyadminMemoryPercent => new(_haContext, "sensor.phpmyadmin_memory_percent");
		///<summary>Pi-Hole Ads Blocked Today</summary>
		public NumericSensorEntity PiHoleAdsBlockedToday => new(_haContext, "sensor.pi_hole_ads_blocked_today");
		///<summary>Pi-Hole Ads Percentage Blocked Today</summary>
		public NumericSensorEntity PiHoleAdsPercentageBlockedToday => new(_haContext, "sensor.pi_hole_ads_percentage_blocked_today");
		///<summary>Pi-Hole DNS Queries Cached</summary>
		public NumericSensorEntity PiHoleDnsQueriesCached => new(_haContext, "sensor.pi_hole_dns_queries_cached");
		///<summary>Pi-Hole DNS Queries Forwarded</summary>
		public NumericSensorEntity PiHoleDnsQueriesForwarded => new(_haContext, "sensor.pi_hole_dns_queries_forwarded");
		///<summary>Pi-Hole DNS Queries Today</summary>
		public NumericSensorEntity PiHoleDnsQueriesToday => new(_haContext, "sensor.pi_hole_dns_queries_today");
		///<summary>Pi-Hole DNS Unique Clients</summary>
		public NumericSensorEntity PiHoleDnsUniqueClients => new(_haContext, "sensor.pi_hole_dns_unique_clients");
		///<summary>Pi-Hole DNS Unique Domains</summary>
		public NumericSensorEntity PiHoleDnsUniqueDomains => new(_haContext, "sensor.pi_hole_dns_unique_domains");
		///<summary>Pi-Hole Domains Blocked</summary>
		public NumericSensorEntity PiHoleDomainsBlocked => new(_haContext, "sensor.pi_hole_domains_blocked");
		///<summary>Pi-Hole Seen Clients</summary>
		public NumericSensorEntity PiHoleSeenClients => new(_haContext, "sensor.pi_hole_seen_clients");
		///<summary>Portainer CPU percent</summary>
		public NumericSensorEntity PortainerCpuPercent => new(_haContext, "sensor.portainer_cpu_percent");
		///<summary>Portainer Memory percent</summary>
		public NumericSensorEntity PortainerMemoryPercent => new(_haContext, "sensor.portainer_memory_percent");
		///<summary>Samba share CPU percent</summary>
		public NumericSensorEntity SambaShareCpuPercent => new(_haContext, "sensor.samba_share_cpu_percent");
		///<summary>Samba share Memory percent</summary>
		public NumericSensorEntity SambaShareMemoryPercent => new(_haContext, "sensor.samba_share_memory_percent");
		///<summary>Sensor 101 Battery</summary>
		public NumericSensorEntity Sensor101Battery => new(_haContext, "sensor.sensor_101_battery");
		///<summary>Sensor 101 Illuminance</summary>
		public NumericSensorEntity Sensor101LightLevel => new(_haContext, "sensor.sensor_101_light_level");
		///<summary>Sensor 101 Temperature</summary>
		public NumericSensorEntity Sensor101Temperature => new(_haContext, "sensor.sensor_101_temperature");
		///<summary>Sensor 102 Battery</summary>
		public NumericSensorEntity Sensor102Battery => new(_haContext, "sensor.sensor_102_battery");
		///<summary>Sensor 102 Illuminance</summary>
		public NumericSensorEntity Sensor102LightLevel => new(_haContext, "sensor.sensor_102_light_level");
		///<summary>Sensor 102 Temperature</summary>
		public NumericSensorEntity Sensor102Temperature => new(_haContext, "sensor.sensor_102_temperature");
		///<summary>Sensor 201 Battery</summary>
		public NumericSensorEntity Sensor201Battery => new(_haContext, "sensor.sensor_201_battery");
		///<summary>Sensor 201 Illuminance</summary>
		public NumericSensorEntity Sensor201LightLevel => new(_haContext, "sensor.sensor_201_light_level");
		///<summary>Sensor 201 Temperature</summary>
		public NumericSensorEntity Sensor201Temperature => new(_haContext, "sensor.sensor_201_temperature");
		///<summary>Sensor 202 Battery</summary>
		public NumericSensorEntity Sensor202Battery => new(_haContext, "sensor.sensor_202_battery");
		///<summary>Sensor 202 Illuminance</summary>
		public NumericSensorEntity Sensor202LightLevel => new(_haContext, "sensor.sensor_202_light_level");
		///<summary>Sensor 202 Temperature</summary>
		public NumericSensorEntity Sensor202Temperature => new(_haContext, "sensor.sensor_202_temperature");
		///<summary>Sensor 301 Battery</summary>
		public NumericSensorEntity Sensor301Battery => new(_haContext, "sensor.sensor_301_battery");
		///<summary>Sensor 301 Illuminance</summary>
		public NumericSensorEntity Sensor301LightLevel => new(_haContext, "sensor.sensor_301_light_level");
		///<summary>Sensor 301 Temperature</summary>
		public NumericSensorEntity Sensor301Temperature => new(_haContext, "sensor.sensor_301_temperature");
		///<summary>Spotify Connect CPU percent</summary>
		public NumericSensorEntity SpotifyConnectCpuPercent => new(_haContext, "sensor.spotify_connect_cpu_percent");
		///<summary>Spotify Connect Memory percent</summary>
		public NumericSensorEntity SpotifyConnectMemoryPercent => new(_haContext, "sensor.spotify_connect_memory_percent");
		///<summary>Studio Code Server CPU percent</summary>
		public NumericSensorEntity StudioCodeServerCpuPercent => new(_haContext, "sensor.studio_code_server_cpu_percent");
		///<summary>Studio Code Server Memory percent</summary>
		public NumericSensorEntity StudioCodeServerMemoryPercent => new(_haContext, "sensor.studio_code_server_memory_percent");
		///<summary>Sun Angle</summary>
		public NumericSensorEntity SunAngle => new(_haContext, "sensor.sun_angle");
	}

	public partial class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public partial class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ds1 Surveillance Station Home Mode</summary>
		public SwitchEntity Ds1HomeMode => new(_haContext, "switch.ds1_home_mode");
		///<summary>Delay GMotion - Trap Slaapkamer</summary>
		public SwitchEntity ScheduleDelayGmotionTrapSlaapkamer => new(_haContext, "switch.schedule_delay_gmotion_trap_slaapkamer");
		///<summary>Hal Weekend Schema</summary>
		public SwitchEntity ScheduleHalWeekendSchema => new(_haContext, "switch.schedule_hal_weekend_schema");
		///<summary>Hal Werkdagen Schema</summary>
		public SwitchEntity ScheduleHalWerkdagenSchema => new(_haContext, "switch.schedule_hal_werkdagen_schema");
		///<summary>Overloop Weekend Schema</summary>
		public SwitchEntity ScheduleOverloopWeekendSchema => new(_haContext, "switch.schedule_overloop_weekend_schema");
		///<summary>Overloop Werkdagen Schema</summary>
		public SwitchEntity ScheduleOverloopWerkdagenSchema => new(_haContext, "switch.schedule_overloop_werkdagen_schema");
		///<summary>Trap Slaapkamer Weekend Schema</summary>
		public SwitchEntity ScheduleTrapSlaapkamerWeekendSchema => new(_haContext, "switch.schedule_trap_slaapkamer_weekend_schema");
		///<summary>Trap Slaapkamer Werkdagen Schema</summary>
		public SwitchEntity ScheduleTrapSlaapkamerWerkdagenSchema => new(_haContext, "switch.schedule_trap_slaapkamer_werkdagen_schema");
		///<summary>Vakantiemodus Tijdplanner</summary>
		public SwitchEntity ScheduleVakantiemodusTijdplanner => new(_haContext, "switch.schedule_vakantiemodus_tijdplanner");
		///<summary>Sensor 101 Illuminance</summary>
		public SwitchEntity Sensor101Illuminance => new(_haContext, "switch.sensor_101_illuminance");
		///<summary>Sensor 101 Motion</summary>
		public SwitchEntity Sensor101Motion => new(_haContext, "switch.sensor_101_motion");
		///<summary>Sensor 102 Illuminance</summary>
		public SwitchEntity Sensor102Illuminance => new(_haContext, "switch.sensor_102_illuminance");
		///<summary>Sensor 102 Motion</summary>
		public SwitchEntity Sensor102Motion => new(_haContext, "switch.sensor_102_motion");
		///<summary>Sensor 201 Illuminance</summary>
		public SwitchEntity Sensor201Illuminance => new(_haContext, "switch.sensor_201_illuminance");
		///<summary>Sensor 201 Motion</summary>
		public SwitchEntity Sensor201Motion => new(_haContext, "switch.sensor_201_motion");
		///<summary>Sensor 202 Illuminance</summary>
		public SwitchEntity Sensor202Illuminance => new(_haContext, "switch.sensor_202_illuminance");
		///<summary>Sensor 202 Motion</summary>
		public SwitchEntity Sensor202Motion => new(_haContext, "switch.sensor_202_motion");
		///<summary>Sensor 301 Illuminance</summary>
		public SwitchEntity Sensor301Illuminance => new(_haContext, "switch.sensor_301_illuminance");
		///<summary>Sensor 301 Motion</summary>
		public SwitchEntity Sensor301Motion => new(_haContext, "switch.sensor_301_motion");
	}

	public partial class TimerEntities
	{
		private readonly IHaContext _haContext;
		public TimerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Mayson Extra Slaapje Timer</summary>
		public TimerEntity MaysonExtraSlaapjeTimer => new(_haContext, "timer.mayson_extra_slaapje_timer");
		///<summary>Timer Gaan Slapen Licht Uit</summary>
		public TimerEntity TimerGaanSlapenLichtUit => new(_haContext, "timer.timer_gaan_slapen_licht_uit");
	}

	public partial class UpdateEntities
	{
		private readonly IHaContext _haContext;
		public UpdateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Ad Watchdog update</summary>
		public UpdateEntity AdWatchdogUpdate => new(_haContext, "update.ad_watchdog_update");
		///<summary>Afvalwijzer update</summary>
		public UpdateEntity AfvalwijzerUpdate => new(_haContext, "update.afvalwijzer_update");
		///<summary>AirCast Update</summary>
		public UpdateEntity AircastUpdate => new(_haContext, "update.aircast_update");
		///<summary>AirSonos Update</summary>
		public UpdateEntity AirsonosUpdate => new(_haContext, "update.airsonos_update");
		///<summary>AppDaemon Update</summary>
		public UpdateEntity AppdaemonUpdate => new(_haContext, "update.appdaemon_update");
		///<summary>AsusRouter update</summary>
		public UpdateEntity AsusrouterUpdate => new(_haContext, "update.asusrouter_update");
		///<summary>Atomic Calendar Revive update</summary>
		public UpdateEntity AtomicCalendarReviveUpdate => new(_haContext, "update.atomic_calendar_revive_update");
		///<summary>auto-entities update</summary>
		public UpdateEntity AutoEntitiesUpdate => new(_haContext, "update.auto_entities_update");
		///<summary>Bar Card update</summary>
		public UpdateEntity BarCardUpdate => new(_haContext, "update.bar_card_update");
		///<summary>bootstrap-grid-card update</summary>
		public UpdateEntity BootstrapGridCardUpdate => new(_haContext, "update.bootstrap_grid_card_update");
		///<summary>browser_mod update</summary>
		public UpdateEntity BrowserModUpdate => new(_haContext, "update.browser_mod_update");
		///<summary>button-card update</summary>
		public UpdateEntity ButtonCardUpdate => new(_haContext, "update.button_card_update");
		///<summary>card-mod update</summary>
		public UpdateEntity CardModUpdate => new(_haContext, "update.card_mod_update");
		///<summary>card-tools update</summary>
		public UpdateEntity CardToolsUpdate => new(_haContext, "update.card_tools_update");
		///<summary>Caule Themes Pack 1 - by caule.studio update</summary>
		public UpdateEntity CauleThemesPack1ByCaulecriativoComUpdate => new(_haContext, "update.caule_themes_pack_1_by_caulecriativo_com_update");
		///<summary>Check Home Assistant configuration Update</summary>
		public UpdateEntity CheckHomeAssistantConfigurationUpdate => new(_haContext, "update.check_home_assistant_configuration_update");
		///<summary>chrony Update</summary>
		public UpdateEntity ChronyUpdate => new(_haContext, "update.chrony_update");
		///<summary>Config Editor Card update</summary>
		public UpdateEntity ConfigEditorCardUpdate => new(_haContext, "update.config_editor_card_update");
		///<summary>Config Editor update</summary>
		public UpdateEntity ConfigEditorUpdate => new(_haContext, "update.config_editor_update");
		///<summary>Dark Teal update</summary>
		public UpdateEntity DarkTealUpdate => new(_haContext, "update.dark_teal_update");
		///<summary>Dark Thermostat update</summary>
		public UpdateEntity DarkThermostatUpdate => new(_haContext, "update.dark_thermostat_update");
		///<summary>Darkish Theme update</summary>
		public UpdateEntity DarkishThemeUpdate => new(_haContext, "update.darkish_theme_update");
		///<summary>Datetime Card update</summary>
		public UpdateEntity DatetimeCardUpdate => new(_haContext, "update.datetime_card_update");
		///<summary>Decluttering Card update</summary>
		public UpdateEntity DeclutteringCardUpdate => new(_haContext, "update.decluttering_card_update");
		///<summary>Digital Clock update</summary>
		public UpdateEntity DigitalClockUpdate => new(_haContext, "update.digital_clock_update");
		///<summary>Dnsmasq Update</summary>
		public UpdateEntity DnsmasqUpdate => new(_haContext, "update.dnsmasq_update");
		///<summary>ds1 DSM Update</summary>
		public UpdateEntity Ds1DsmUpdate => new(_haContext, "update.ds1_dsm_update");
		///<summary>Entities Button Group update</summary>
		public UpdateEntity EntitiesButtonGroupUpdate => new(_haContext, "update.entities_button_group_update");
		///<summary>Eufy Security Add-on Update</summary>
		public UpdateEntity EufySecurityAddOnUpdate => new(_haContext, "update.eufy_security_add_on_update");
		///<summary>Eufy Security update</summary>
		public UpdateEntity EufySecurityUpdate => new(_haContext, "update.eufy_security_update");
		///<summary>Event Monitor update</summary>
		public UpdateEntity EventMonitorUpdate => new(_haContext, "update.event_monitor_update");
		///<summary>Event sensor update</summary>
		public UpdateEntity EventSensorUpdate => new(_haContext, "update.event_sensor_update");
		///<summary>File editor Update</summary>
		public UpdateEntity FileEditorUpdate => new(_haContext, "update.file_editor_update");
		///<summary>Flipdown Timer Card update</summary>
		public UpdateEntity FlipdownTimerCardUpdate => new(_haContext, "update.flipdown_timer_card_update");
		///<summary>fold-entity-row update</summary>
		public UpdateEntity FoldEntityRowUpdate => new(_haContext, "update.fold_entity_row_update");
		///<summary>Git pull Update</summary>
		public UpdateEntity GitPullUpdate => new(_haContext, "update.git_pull_update");
		///<summary>Glances Update</summary>
		public UpdateEntity GlancesUpdate => new(_haContext, "update.glances_update");
		///<summary>gogs update</summary>
		public UpdateEntity GogsUpdate => new(_haContext, "update.gogs_update");
		///<summary>Google Dark Theme update</summary>
		public UpdateEntity GoogleDarkThemeUpdate => new(_haContext, "update.google_dark_theme_update");
		///<summary>Google Theme - Based on the Android light and dark interface update</summary>
		public UpdateEntity GoogleThemeBasedOnTheAndroidLightAndDarkInterfaceUpdate => new(_haContext, "update.google_theme_based_on_the_android_light_and_dark_interface_update");
		///<summary>HACS update</summary>
		public UpdateEntity HacsUpdate => new(_haContext, "update.hacs_update");
		///<summary>HASS.Agent MediaPlayer update</summary>
		public UpdateEntity HassAgentMediaplayerUpdate => new(_haContext, "update.hass_agent_mediaplayer_update");
		///<summary>Hass Hue Icons update</summary>
		public UpdateEntity HassHueIconsUpdate => new(_haContext, "update.hass_hue_icons_update");
		///<summary>Home Assistant Core Update</summary>
		public UpdateEntity HomeAssistantCoreUpdate => new(_haContext, "update.home_assistant_core_update");
		///<summary>Home Assistant Operating System Update</summary>
		public UpdateEntity HomeAssistantOperatingSystemUpdate => new(_haContext, "update.home_assistant_operating_system_update");
		///<summary>Home Assistant Supervisor Update</summary>
		public UpdateEntity HomeAssistantSupervisorUpdate => new(_haContext, "update.home_assistant_supervisor_update");
		///<summary>Home Assistant Swipe Navigation update</summary>
		public UpdateEntity HomeAssistantSwipeNavigationUpdate => new(_haContext, "update.home_assistant_swipe_navigation_update");
		///<summary>Hue-Like Light Card update</summary>
		public UpdateEntity HueLikeLightCardUpdate => new(_haContext, "update.hue_like_light_card_update");
		///<summary>InfluxDB Update</summary>
		public UpdateEntity InfluxdbUpdate => new(_haContext, "update.influxdb_update");
		///<summary>iOS Dark Mode Theme update</summary>
		public UpdateEntity IosDarkModeThemeUpdate => new(_haContext, "update.ios_dark_mode_theme_update");
		///<summary>iOS Theme - Based on the system-wide light and dark mode UI update</summary>
		public UpdateEntity IosThemeBasedOnTheSystemWideLightAndDarkModeUiUpdate => new(_haContext, "update.ios_theme_based_on_the_system_wide_light_and_dark_mode_ui_update");
		///<summary>iOS Themes - Dark Mode and Light Mode update</summary>
		public UpdateEntity IosThemesDarkModeAndLightModeUpdate => new(_haContext, "update.ios_themes_dark_mode_and_light_mode_update");
		///<summary>kibibit Theme update</summary>
		public UpdateEntity KibibitThemeUpdate => new(_haContext, "update.kibibit_theme_update");
		///<summary>knmi update</summary>
		public UpdateEntity KnmiUpdate => new(_haContext, "update.knmi_update");
		///<summary>Last Changed Element update</summary>
		public UpdateEntity LastChangedElementUpdate => new(_haContext, "update.last_changed_element_update");
		///<summary>layout-card update</summary>
		public UpdateEntity LayoutCardUpdate => new(_haContext, "update.layout_card_update");
		///<summary>LG WebOS channel pad update</summary>
		public UpdateEntity LgWebosChannelPadUpdate => new(_haContext, "update.lg_webos_channel_pad_update");
		///<summary>LG WebOS Remote Control update</summary>
		public UpdateEntity LgWebosRemoteControlUpdate => new(_haContext, "update.lg_webos_remote_control_update");
		///<summary>Log Viewer Update</summary>
		public UpdateEntity LogViewerUpdate => new(_haContext, "update.log_viewer_update");
		///<summary>Lovelace Home Feed Card update</summary>
		public UpdateEntity LovelaceHomeFeedCardUpdate => new(_haContext, "update.lovelace_home_feed_card_update");
		///<summary>MariaDB Update</summary>
		public UpdateEntity MariadbUpdate => new(_haContext, "update.mariadb_update");
		///<summary>Matrix Update</summary>
		public UpdateEntity MatrixUpdate => new(_haContext, "update.matrix_update");
		///<summary>Microsoft Edge TTS update</summary>
		public UpdateEntity MicrosoftEdgeTtsUpdate => new(_haContext, "update.microsoft_edge_tts_update");
		///<summary>Midnight Theme update</summary>
		public UpdateEntity MidnightThemeUpdate => new(_haContext, "update.midnight_theme_update");
		///<summary>mini-graph-card update</summary>
		public UpdateEntity MiniGraphCardUpdate => new(_haContext, "update.mini_graph_card_update");
		///<summary>Mini Media Player update</summary>
		public UpdateEntity MiniMediaPlayerUpdate => new(_haContext, "update.mini_media_player_update");
		///<summary>Mjpeg Timelapse update</summary>
		public UpdateEntity MjpegTimelapseUpdate => new(_haContext, "update.mjpeg_timelapse_update");
		///<summary>Mosquitto broker Update</summary>
		public UpdateEntity MosquittoBrokerUpdate => new(_haContext, "update.mosquitto_broker_update");
		///<summary>Multiline Entity Card update</summary>
		public UpdateEntity MultilineEntityCardUpdate => new(_haContext, "update.multiline_entity_card_update");
		///<summary>Multiple Entity Row update</summary>
		public UpdateEntity MultipleEntityRowUpdate => new(_haContext, "update.multiple_entity_row_update");
		///<summary>Music Assistant update</summary>
		public UpdateEntity MusicAssistantUpdate => new(_haContext, "update.music_assistant_update");
		///<summary>Neerslag App update</summary>
		public UpdateEntity NeerslagAppUpdate => new(_haContext, "update.neerslag_app_update");
		///<summary>NetDaemon update</summary>
		public UpdateEntity NetdaemonUpdate => new(_haContext, "update.netdaemon_update");
		///<summary>NetDaemon V3 - beta Update</summary>
		public UpdateEntity NetdaemonV3BetaUpdate => new(_haContext, "update.netdaemon_v3_beta_update");
		///<summary>Noctis-Solarized update</summary>
		public UpdateEntity NoctisSolarizedUpdate => new(_haContext, "update.noctis_solarized_update");
		///<summary>Noctis update</summary>
		public UpdateEntity NoctisUpdate => new(_haContext, "update.noctis_update");
		///<summary>Nordic Theme update</summary>
		public UpdateEntity NordicThemeUpdate => new(_haContext, "update.nordic_theme_update");
		///<summary>Notify Card update</summary>
		public UpdateEntity NotifyCardUpdate => new(_haContext, "update.notify_card_update");
		///<summary>Notify on Update update</summary>
		public UpdateEntity NotifyOnUpdateUpdate => new(_haContext, "update.notify_on_update_update");
		///<summary>Person update</summary>
		public UpdateEntity PersonUpdate => new(_haContext, "update.person_update");
		///<summary>pfSense integration for Home Assistant update</summary>
		public UpdateEntity PfsenseIntegrationForHomeAssistantUpdate => new(_haContext, "update.pfsense_integration_for_home_assistant_update");
		///<summary>phpMyAdmin Update</summary>
		public UpdateEntity PhpmyadminUpdate => new(_haContext, "update.phpmyadmin_update");
		///<summary>Pi-Hole Core Update Available</summary>
		public UpdateEntity PiHoleCoreUpdateAvailable => new(_haContext, "update.pi_hole_core_update_available");
		///<summary>Pi-Hole FTL Update Available</summary>
		public UpdateEntity PiHoleFtlUpdateAvailable => new(_haContext, "update.pi_hole_ftl_update_available");
		///<summary>Pi-Hole Web Update Available</summary>
		public UpdateEntity PiHoleWebUpdateAvailable => new(_haContext, "update.pi_hole_web_update_available");
		///<summary>Portainer Update</summary>
		public UpdateEntity PortainerUpdate => new(_haContext, "update.portainer_update");
		///<summary>RGB Light Card update</summary>
		public UpdateEntity RgbLightCardUpdate => new(_haContext, "update.rgb_light_card_update");
		///<summary>Samba share Update</summary>
		public UpdateEntity SambaShareUpdate => new(_haContext, "update.samba_share_update");
		///<summary>Saver update</summary>
		public UpdateEntity SaverUpdate => new(_haContext, "update.saver_update");
		///<summary>Scheduler Card update</summary>
		public UpdateEntity SchedulerCardUpdate => new(_haContext, "update.scheduler_card_update");
		///<summary>Scheduler component update</summary>
		public UpdateEntity SchedulerComponentUpdate => new(_haContext, "update.scheduler_component_update");
		///<summary>Simple Thermostat update</summary>
		public UpdateEntity SimpleThermostatUpdate => new(_haContext, "update.simple_thermostat_update");
		///<summary>slider-entity-row update</summary>
		public UpdateEntity SliderEntityRowUpdate => new(_haContext, "update.slider_entity_row_update");
		///<summary>Spotcast update</summary>
		public UpdateEntity SpotcastUpdate => new(_haContext, "update.spotcast_update");
		///<summary>Spotify Connect Update</summary>
		public UpdateEntity SpotifyConnectUpdate => new(_haContext, "update.spotify_connect_update");
		///<summary>Spotify Lovelace Card update</summary>
		public UpdateEntity SpotifyLovelaceCardUpdate => new(_haContext, "update.spotify_lovelace_card_update");
		///<summary>Spotify Mood Lights Sync update</summary>
		public UpdateEntity SpotifyMoodLightsSyncUpdate => new(_haContext, "update.spotify_mood_lights_sync_update");
		///<summary>state-switch update</summary>
		public UpdateEntity StateSwitchUpdate => new(_haContext, "update.state_switch_update");
		///<summary>Studio Code Server Update</summary>
		public UpdateEntity StudioCodeServerUpdate => new(_haContext, "update.studio_code_server_update");
		///<summary>Synthwave Hass update</summary>
		public UpdateEntity SynthwaveHassUpdate => new(_haContext, "update.synthwave_hass_update");
		///<summary>Terminal & SSH Update</summary>
		public UpdateEntity TerminalSshUpdate => new(_haContext, "update.terminal_ssh_update");
		///<summary>Time Picker Card update</summary>
		public UpdateEntity TimePickerCardUpdate => new(_haContext, "update.time_picker_card_update");
		///<summary>Timer Bar Card update</summary>
		public UpdateEntity TimerBarCardUpdate => new(_haContext, "update.timer_bar_card_update");
		///<summary>TV Remote Card (with touchpad and haptic feedback) update</summary>
		public UpdateEntity TvRemoteCardWithTouchpadAndHapticFeedbackUpdate => new(_haContext, "update.tv_remote_card_with_touchpad_and_haptic_feedback_update");
		///<summary>Upcoming Media Card update</summary>
		public UpdateEntity UpcomingMediaCardUpdate => new(_haContext, "update.upcoming_media_card_update");
		///<summary>Variable update</summary>
		public UpdateEntity VariableUpdate => new(_haContext, "update.variable_update");
		///<summary>Vertical Stack In Card update</summary>
		public UpdateEntity VerticalStackInCardUpdate => new(_haContext, "update.vertical_stack_in_card_update");
		///<summary>Virtual Components update</summary>
		public UpdateEntity VirtualComponentsUpdate => new(_haContext, "update.virtual_components_update");
		///<summary>Webhook Service Integration update</summary>
		public UpdateEntity WebhookServiceHomeAssistantUpdate => new(_haContext, "update.webhook_service_home_assistant_update");
		///<summary>WebRTC Camera update</summary>
		public UpdateEntity WebrtcCameraUpdate => new(_haContext, "update.webrtc_camera_update");
		///<summary>Your Name. update</summary>
		public UpdateEntity YourNameUpdate => new(_haContext, "update.your_name_update");
	}

	public partial class VarEntities
	{
		private readonly IHaContext _haContext;
		public VarEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Hal Virtual Switch State</summary>
		public VarEntity HalVirtualSwitchState => new(_haContext, "var.hal_virtual_switch_state");
		///<summary>Spotify Device: GRAYSON-PB51RF</summary>
		public VarEntity VarSpotifyDeviceIdGraysonPb51 => new(_haContext, "var.var_spotify_device_id_grayson_pb51");
	}

	public partial class WeatherEntities
	{
		private readonly IHaContext _haContext;
		public WeatherEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Forecast OnsHuis</summary>
		public WeatherEntity Huis => new(_haContext, "weather.huis");
		///<summary>Forecast OnsHuis hourly</summary>
		public WeatherEntity HuisHourly => new(_haContext, "weather.huis_hourly");
	}

	public partial class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Casper's Rovershol</summary>
		public ZoneEntity CasperSRovershol => new(_haContext, "zone.casper_s_rovershol");
		///<summary>OnsHuis</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
	}

	public partial record AutomationEntity : Entity<AutomationEntity, EntityState<AutomationAttributes>, AutomationAttributes>
	{
		public AutomationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AutomationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AutomationAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public partial record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("current_version")]
		public string? CurrentVersion { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("ignoring_battery_optimizations")]
		public bool? IgnoringBatteryOptimizations { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("latest_available_version")]
		public object? LatestAvailableVersion { get; init; }

		[JsonPropertyName("latest_version")]
		public string? LatestVersion { get; init; }

		[JsonPropertyName("malware")]
		public string? Malware { get; init; }

		[JsonPropertyName("motion_valid")]
		public bool? MotionValid { get; init; }

		[JsonPropertyName("network")]
		public string? Network { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("securitySetting")]
		public string? SecuritySetting { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("systemCheck")]
		public string? SystemCheck { get; init; }

		[JsonPropertyName("unique_id")]
		public string? UniqueId { get; init; }

		[JsonPropertyName("update")]
		public string? Update { get; init; }

		[JsonPropertyName("userInfo")]
		public string? UserInfo { get; init; }
	}

	public partial record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
	{
		public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ButtonAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public partial record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CameraAttributes
	{
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("frontend_stream_type")]
		public string? FrontendStreamType { get; init; }

		[JsonPropertyName("motion_detection")]
		public bool? MotionDetection { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ClimateAttributes
	{
		[JsonPropertyName("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hvac_modes")]
		public IReadOnlyList<string>? HvacModes { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("max_temp")]
		public double? MaxTemp { get; init; }

		[JsonPropertyName("min_temp")]
		public double? MinTemp { get; init; }

		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public object? PresetModes { get; init; }

		[JsonPropertyName("status")]
		public object? Status { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public partial record ConfigEditorEntity : Entity<ConfigEditorEntity, EntityState<ConfigEditorAttributes>, ConfigEditorAttributes>
	{
		public ConfigEditorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ConfigEditorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ConfigEditorAttributes
	{
	}

	public partial record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerAttributes
	{
		[JsonPropertyName("altitude")]
		public double? Altitude { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("course")]
		public double? Course { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source_type")]
		public string? SourceType { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }

		[JsonPropertyName("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }
	}

	public partial record GroupEntity : Entity<GroupEntity, EntityState<GroupAttributes>, GroupAttributes>
	{
		public GroupEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public GroupEntity(Entity entity) : base(entity)
		{
		}
	}

	public record GroupAttributes
	{
		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("order")]
		public double? Order { get; init; }
	}

	public partial record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record InputDatetimeEntity : Entity<InputDatetimeEntity, EntityState<InputDatetimeAttributes>, InputDatetimeAttributes>
	{
		public InputDatetimeEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputDatetimeEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputDatetimeAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("has_date")]
		public bool? HasDate { get; init; }

		[JsonPropertyName("has_time")]
		public bool? HasTime { get; init; }

		[JsonPropertyName("hour")]
		public double? Hour { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("minute")]
		public double? Minute { get; init; }

		[JsonPropertyName("second")]
		public double? Second { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }
	}

	public partial record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputNumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputNumberAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("initial")]
		public object? Initial { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }
	}

	public partial record InputSelectEntity : Entity<InputSelectEntity, EntityState<InputSelectAttributes>, InputSelectAttributes>
	{
		public InputSelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputSelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputSelectAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("options")]
		public IReadOnlyList<string>? Options { get; init; }
	}

	public partial record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightAttributes
	{
		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("color_temp")]
		public double? ColorTemp { get; init; }

		[JsonPropertyName("deviceID")]
		public string? DeviceID { get; init; }

		[JsonPropertyName("dynamics")]
		public object? Dynamics { get; init; }

		[JsonPropertyName("effect")]
		public string? Effect { get; init; }

		[JsonPropertyName("effect_list")]
		public IReadOnlyList<string>? EffectList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hs_color")]
		public IReadOnlyList<double>? HsColor { get; init; }

		[JsonPropertyName("hue_scenes")]
		public IReadOnlyList<string>? HueScenes { get; init; }

		[JsonPropertyName("hue_type")]
		public string? HueType { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("is_hue_group")]
		public bool? IsHueGroup { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("lights")]
		public IReadOnlyList<string>? Lights { get; init; }

		[JsonPropertyName("max_mireds")]
		public double? MaxMireds { get; init; }

		[JsonPropertyName("min_mireds")]
		public double? MinMireds { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("rgb_color")]
		public IReadOnlyList<double>? RgbColor { get; init; }

		[JsonPropertyName("supported_color_modes")]
		public IReadOnlyList<string>? SupportedColorModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("type")]
		public string? Type { get; init; }

		[JsonPropertyName("xy_color")]
		public IReadOnlyList<double>? XyColor { get; init; }
	}

	public partial record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("assumed_state")]
		public bool? AssumedState { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("deviceID")]
		public string? DeviceID { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }

		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		[JsonPropertyName("media_duration")]
		public double? MediaDuration { get; init; }

		[JsonPropertyName("media_playlist")]
		public string? MediaPlaylist { get; init; }

		[JsonPropertyName("media_title")]
		public string? MediaTitle { get; init; }

		[JsonPropertyName("media_track")]
		public double? MediaTrack { get; init; }

		[JsonPropertyName("repeat")]
		public string? Repeat { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }

		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }

		[JsonPropertyName("sound_mode_list")]
		public IReadOnlyList<string>? SoundModeList { get; init; }

		[JsonPropertyName("sound_mode_raw")]
		public string? SoundModeRaw { get; init; }

		[JsonPropertyName("sound_output")]
		public string? SoundOutput { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("source_list")]
		public IReadOnlyList<string>? SourceList { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("type")]
		public string? Type { get; init; }

		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public partial record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("user_id")]
		public string? UserId { get; init; }
	}

	public partial record RemoteEntity : Entity<RemoteEntity, EntityState<RemoteAttributes>, RemoteAttributes>
	{
		public RemoteEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public RemoteEntity(Entity entity) : base(entity)
		{
		}
	}

	public record RemoteAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record SaverEntity : Entity<SaverEntity, EntityState<SaverAttributes>, SaverAttributes>
	{
		public SaverEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SaverEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SaverAttributes
	{
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("variables")]
		public object? Variables { get; init; }
	}

	public partial record SceneEntity : Entity<SceneEntity, EntityState<SceneAttributes>, SceneAttributes>
	{
		public SceneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SceneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SceneAttributes
	{
		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("group_name")]
		public string? GroupName { get; init; }

		[JsonPropertyName("group_type")]
		public string? GroupType { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("is_dynamic")]
		public bool? IsDynamic { get; init; }

		[JsonPropertyName("name")]
		public string? Name { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }
	}

	public partial record ScriptEntity : Entity<ScriptEntity, EntityState<ScriptAttributes>, ScriptAttributes>
	{
		public ScriptEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ScriptEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ScriptAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public partial record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorAttributes
	{
		[JsonPropertyName("Administrative Area")]
		public string? AdministrativeArea_0 { get; init; }

		[JsonPropertyName("administrative_area")]
		public string? AdministrativeArea_1 { get; init; }

		[JsonPropertyName("Areas Of Interest")]
		public string? AreasOfInterest { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("carrier id")]
		public double? Carrierid { get; init; }

		[JsonPropertyName("carrier name")]
		public string? Carriername { get; init; }

		[JsonPropertyName("config")]
		public object? Config { get; init; }

		[JsonPropertyName("country")]
		public string? Country_0 { get; init; }

		[JsonPropertyName("Country")]
		public string? Country_1 { get; init; }

		[JsonPropertyName("currentUser")]
		public string? CurrentUser { get; init; }

		[JsonPropertyName("darkMode")]
		public bool? DarkMode { get; init; }

		[JsonPropertyName("data roaming")]
		public string? Dataroaming { get; init; }

		[JsonPropertyName("days_until_collection_date")]
		public double? DaysUntilCollectionDate { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("deviceID")]
		public string? DeviceID { get; init; }

		[JsonPropertyName("devices")]
		public IReadOnlyList<object>? Devices { get; init; }

		[JsonPropertyName("devices_json")]
		public string? DevicesJson { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("fullyKiosk")]
		public bool? FullyKiosk { get; init; }

		[JsonPropertyName("height")]
		public double? Height { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("in_daylight_time")]
		public bool? InDaylightTime { get; init; }

		[JsonPropertyName("Inland Water")]
		public string? InlandWater { get; init; }

		[JsonPropertyName("is_collection_date_day_after_tomorrow")]
		public bool? IsCollectionDateDayAfterTomorrow { get; init; }

		[JsonPropertyName("is_collection_date_today")]
		public bool? IsCollectionDateToday { get; init; }

		[JsonPropertyName("is_collection_date_tomorrow")]
		public bool? IsCollectionDateTomorrow { get; init; }

		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; init; }

		[JsonPropertyName("iso country code")]
		public string? Isocountrycode { get; init; }

		[JsonPropertyName("iso_country_code")]
		public string? IsoCountryCode { get; init; }

		[JsonPropertyName("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[JsonPropertyName("is opportunistic")]
		public bool? Isopportunistic { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("last_update")]
		public string? LastUpdate { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("locality")]
		public string? Locality_0 { get; init; }

		[JsonPropertyName("Locality")]
		public string? Locality_1 { get; init; }

		[JsonPropertyName("Local Time")]
		public string? LocalTime { get; init; }

		[JsonPropertyName("Location")]
		public IReadOnlyList<double>? Location { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("Low Power Mode")]
		public bool? LowPowerMode { get; init; }

		[JsonPropertyName("mac_address")]
		public string? MacAddress { get; init; }

		[JsonPropertyName("mcc")]
		public string? Mcc { get; init; }

		[JsonPropertyName("mnc")]
		public string? Mnc { get; init; }

		[JsonPropertyName("Name")]
		public string? Name { get; init; }

		[JsonPropertyName("Ocean")]
		public string? Ocean { get; init; }

		[JsonPropertyName("Package")]
		public string? Package { get; init; }

		[JsonPropertyName("path")]
		public string? Path { get; init; }

		[JsonPropertyName("playlists")]
		public IReadOnlyList<object>? Playlists { get; init; }

		[JsonPropertyName("Postal Code")]
		public string? PostalCode_0 { get; init; }

		[JsonPropertyName("postal_code")]
		public string? PostalCode_1 { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("still")]
		public double? Still { get; init; }

		[JsonPropertyName("Sub Administrative Area")]
		public string? SubAdministrativeArea_0 { get; init; }

		[JsonPropertyName("sub_administrative_area")]
		public string? SubAdministrativeArea_1 { get; init; }

		[JsonPropertyName("Sub Locality")]
		public string? SubLocality_0 { get; init; }

		[JsonPropertyName("sub_locality")]
		public string? SubLocality_1 { get; init; }

		[JsonPropertyName("Sub Thoroughfare")]
		public string? SubThoroughfare_0 { get; init; }

		[JsonPropertyName("sub_thoroughfare")]
		public string? SubThoroughfare_1 { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("thoroughfare")]
		public string? Thoroughfare_0 { get; init; }

		[JsonPropertyName("Thoroughfare")]
		public string? Thoroughfare_1 { get; init; }

		[JsonPropertyName("Time in Milliseconds")]
		public double? TimeinMilliseconds { get; init; }

		[JsonPropertyName("Time Zone")]
		public string? TimeZone { get; init; }

		[JsonPropertyName("time_zone_id")]
		public string? TimeZoneId { get; init; }

		[JsonPropertyName("time_zone_short")]
		public string? TimeZoneShort { get; init; }

		[JsonPropertyName("total_media_session_count")]
		public double? TotalMediaSessionCount { get; init; }

		[JsonPropertyName("type")]
		public string? Type { get; init; }

		[JsonPropertyName("unknown")]
		public double? Unknown { get; init; }

		[JsonPropertyName("userAgent")]
		public string? UserAgent { get; init; }

		[JsonPropertyName("userData")]
		public object? UserData { get; init; }

		[JsonPropertyName("uses_daylight_time")]
		public bool? UsesDaylightTime { get; init; }

		[JsonPropertyName("utc_offset")]
		public double? UtcOffset { get; init; }

		[JsonPropertyName("visibility")]
		public string? Visibility { get; init; }

		[JsonPropertyName("width")]
		public double? Width { get; init; }

		[JsonPropertyName("year_month_day_date")]
		public string? YearMonthDayDate { get; init; }

		[JsonPropertyName("Zones")]
		public IReadOnlyList<string>? Zones { get; init; }
	}

	public partial record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("Available")]
		public string? Available { get; init; }

		[JsonPropertyName("Available (Important)")]
		public string? AvailableImportant { get; init; }

		[JsonPropertyName("Available (Opportunistic)")]
		public string? AvailableOpportunistic { get; init; }

		[JsonPropertyName("battery_state")]
		public string? BatteryState { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("domains_blocked")]
		public double? DomainsBlocked { get; init; }

		[JsonPropertyName("end")]
		public double? End { get; init; }

		[JsonPropertyName("Free internal storage")]
		public string? Freeinternalstorage { get; init; }

		[JsonPropertyName("free_memory")]
		public double? FreeMemory { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("light_level")]
		public double? LightLevel { get; init; }

		[JsonPropertyName("light_level_valid")]
		public bool? LightLevelValid { get; init; }

		[JsonPropertyName("start")]
		public double? Start { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("temperature_valid")]
		public bool? TemperatureValid { get; init; }

		[JsonPropertyName("Total")]
		public string? Total { get; init; }

		[JsonPropertyName("Total internal storage")]
		public string? Totalinternalstorage { get; init; }

		[JsonPropertyName("total_memory")]
		public double? TotalMemory { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public partial record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunAttributes
	{
		[JsonPropertyName("azimuth")]
		public double? Azimuth { get; init; }

		[JsonPropertyName("elevation")]
		public double? Elevation { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("next_dawn")]
		public string? NextDawn { get; init; }

		[JsonPropertyName("next_dusk")]
		public string? NextDusk { get; init; }

		[JsonPropertyName("next_midnight")]
		public string? NextMidnight { get; init; }

		[JsonPropertyName("next_noon")]
		public string? NextNoon { get; init; }

		[JsonPropertyName("next_rising")]
		public string? NextRising { get; init; }

		[JsonPropertyName("next_setting")]
		public string? NextSetting { get; init; }

		[JsonPropertyName("rising")]
		public bool? Rising { get; init; }
	}

	public partial record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchAttributes
	{
		[JsonPropertyName("actions")]
		public IReadOnlyList<object>? Actions { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("current_slot")]
		public double? CurrentSlot { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("entities")]
		public IReadOnlyList<string>? Entities { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("next_slot")]
		public double? NextSlot { get; init; }

		[JsonPropertyName("next_trigger")]
		public string? NextTrigger { get; init; }

		[JsonPropertyName("tags")]
		public IReadOnlyList<string>? Tags { get; init; }

		[JsonPropertyName("timeslots")]
		public IReadOnlyList<string>? Timeslots { get; init; }

		[JsonPropertyName("weekdays")]
		public IReadOnlyList<string>? Weekdays { get; init; }
	}

	public partial record TimerEntity : Entity<TimerEntity, EntityState<TimerAttributes>, TimerAttributes>
	{
		public TimerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public TimerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record TimerAttributes
	{
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }

		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("restore")]
		public bool? Restore { get; init; }
	}

	public partial record UpdateEntity : Entity<UpdateEntity, EntityState<UpdateAttributes>, UpdateAttributes>
	{
		public UpdateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public UpdateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record UpdateAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("auto_update")]
		public bool? AutoUpdate { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("in_progress")]
		public bool? InProgress { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("latest_version")]
		public string? LatestVersion { get; init; }

		[JsonPropertyName("release_summary")]
		public string? ReleaseSummary { get; init; }

		[JsonPropertyName("release_url")]
		public string? ReleaseUrl { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("skipped_version")]
		public object? SkippedVersion { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public partial record VarEntity : Entity<VarEntity, EntityState<VarAttributes>, VarAttributes>
	{
		public VarEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VarEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VarAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public partial record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(Entity entity) : base(entity)
		{
		}
	}

	public record WeatherAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("forecast")]
		public IReadOnlyList<object>? Forecast { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("precipitation_unit")]
		public string? PrecipitationUnit { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("pressure_unit")]
		public string? PressureUnit { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("temperature_unit")]
		public string? TemperatureUnit { get; init; }

		[JsonPropertyName("visibility_unit")]
		public string? VisibilityUnit { get; init; }

		[JsonPropertyName("wind_bearing")]
		public double? WindBearing { get; init; }

		[JsonPropertyName("wind_speed")]
		public double? WindSpeed { get; init; }

		[JsonPropertyName("wind_speed_unit")]
		public string? WindSpeedUnit { get; init; }
	}

	public partial record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("passive")]
		public bool? Passive { get; init; }

		[JsonPropertyName("persons")]
		public IReadOnlyList<string>? Persons { get; init; }

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AutomationServices Automation { get; }

		BrowserModServices BrowserMod { get; }

		ButtonServices Button { get; }

		CameraServices Camera { get; }

		CastServices Cast { get; }

		ClimateServices Climate { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DenonavrServices Denonavr { get; }

		DeviceTrackerServices DeviceTracker { get; }

		EvohomeServices Evohome { get; }

		FanServices Fan { get; }

		FfmpegServices Ffmpeg { get; }

		FoscamServices Foscam { get; }

		FrontendServices Frontend { get; }

		GroupServices Group { get; }

		HassioServices Hassio { get; }

		HomeassistantServices Homeassistant { get; }

		HomekitServices Homekit { get; }

		HueServices Hue { get; }

		HumidifierServices Humidifier { get; }

		InputBooleanServices InputBoolean { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		LightServices Light { get; }

		LockServices Lock { get; }

		LogbookServices Logbook { get; }

		LoggerServices Logger { get; }

		MediaExtractorServices MediaExtractor { get; }

		MediaPlayerServices MediaPlayer { get; }

		MqttServices Mqtt { get; }

		NetdaemonServices Netdaemon { get; }

		NotifyServices Notify { get; }

		NumberServices Number { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		RecorderServices Recorder { get; }

		RemoteServices Remote { get; }

		RestServices Rest { get; }

		RestCommandServices RestCommand { get; }

		SaverServices Saver { get; }

		SceneServices Scene { get; }

		SchedulerServices Scheduler { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		SirenServices Siren { get; }

		SpotcastServices Spotcast { get; }

		SwitchServices Switch { get; }

		SynologyDsmServices SynologyDsm { get; }

		SystemLogServices SystemLog { get; }

		TemplateServices Template { get; }

		TimerServices Timer { get; }

		TtsServices Tts { get; }

		UpdateServices Update { get; }

		VacuumServices Vacuum { get; }

		VarServices Var { get; }

		VirtualServices Virtual { get; }

		WakeOnLanServices WakeOnLan { get; }

		WebostvServices Webostv { get; }

		WebrtcServices Webrtc { get; }

		ZoneServices Zone { get; }
	}

	public class Services : IServices
	{
		private readonly IHaContext _haContext;
		public Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AutomationServices Automation => new(_haContext);
		public BrowserModServices BrowserMod => new(_haContext);
		public ButtonServices Button => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public CastServices Cast => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DenonavrServices Denonavr => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public EvohomeServices Evohome => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FfmpegServices Ffmpeg => new(_haContext);
		public FoscamServices Foscam => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HassioServices Hassio => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public HomekitServices Homekit => new(_haContext);
		public HueServices Hue => new(_haContext);
		public HumidifierServices Humidifier => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public LightServices Light => new(_haContext);
		public LockServices Lock => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public LoggerServices Logger => new(_haContext);
		public MediaExtractorServices MediaExtractor => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NetdaemonServices Netdaemon => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NumberServices Number => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public RemoteServices Remote => new(_haContext);
		public RestServices Rest => new(_haContext);
		public RestCommandServices RestCommand => new(_haContext);
		public SaverServices Saver => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public SchedulerServices Scheduler => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SpotcastServices Spotcast => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SynologyDsmServices SynologyDsm => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TtsServices Tts => new(_haContext);
		public UpdateServices Update => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public VarServices Var => new(_haContext);
		public VirtualServices Virtual => new(_haContext);
		public WakeOnLanServices WakeOnLan => new(_haContext);
		public WebostvServices Webostv => new(_haContext);
		public WebrtcServices Webrtc => new(_haContext);
		public ZoneServices Zone => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public void AlarmArmVacation(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmVacationParameters
	{
		///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AutomationServices
	{
		private readonly IHaContext _haContext;
		public AutomationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class BrowserModServices
	{
		private readonly IHaContext _haContext;
		public BrowserModServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cover screen in black until the mouse is moved or a key is pressed.</summary>
		public void Blackout(BrowserModBlackoutParameters data)
		{
			_haContext.CallService("browser_mod", "blackout", null, data);
		}

		///<summary>Cover screen in black until the mouse is moved or a key is pressed.</summary>
		///<param name="time">(optional) The blackout will turn on automatically after the specified number of seconds. It works kind of like a screensaver and will keep turning on until blackout is called again with time: -1. eg: 20</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Blackout(object? @time = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "blackout", null, new BrowserModBlackoutParameters{Time = @time, DeviceID = @deviceID});
		}

		public void CallService()
		{
			_haContext.CallService("browser_mod", "call_service", null);
		}

		public void CleanDevices()
		{
			_haContext.CallService("browser_mod", "clean_devices", null);
		}

		///<summary>Close all popups on all browsers.</summary>
		public void ClosePopup(BrowserModClosePopupParameters data)
		{
			_haContext.CallService("browser_mod", "close_popup", null, data);
		}

		///<summary>Close all popups on all browsers.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void ClosePopup(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "close_popup", null, new BrowserModClosePopupParameters{DeviceID = @deviceID});
		}

		///<summary>Send a command to a browser.</summary>
		public void Command(BrowserModCommandParameters data)
		{
			_haContext.CallService("browser_mod", "command", null, data);
		}

		///<summary>Send a command to a browser.</summary>
		///<param name="command">Command to send eg: navigate</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Command(object? @command = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "command", null, new BrowserModCommandParameters{Command = @command, DeviceID = @deviceID});
		}

		///<summary>Send several commands to a browser</summary>
		public void Commands(BrowserModCommandsParameters data)
		{
			_haContext.CallService("browser_mod", "commands", null, data);
		}

		///<summary>Send several commands to a browser</summary>
		///<param name="commands">List of commands to send</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Commands(object? @commands = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "commands", null, new BrowserModCommandsParameters{Commands = @commands, DeviceID = @deviceID});
		}

		///<summary>On all browsers, show a popup, and a javascript alert with the current device ID.</summary>
		public void Debug(BrowserModDebugParameters data)
		{
			_haContext.CallService("browser_mod", "debug", null, data);
		}

		///<summary>On all browsers, show a popup, and a javascript alert with the current device ID.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Debug(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "debug", null, new BrowserModDebugParameters{DeviceID = @deviceID});
		}

		///<summary>Do nothing for a while</summary>
		public void Delay(BrowserModDelayParameters data)
		{
			_haContext.CallService("browser_mod", "delay", null, data);
		}

		///<summary>Do nothing for a while</summary>
		///<param name="seconds">Number of seconds to delay eg: 5</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Delay(object? @seconds = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "delay", null, new BrowserModDelayParameters{Seconds = @seconds, DeviceID = @deviceID});
		}

		///<summary>Refresh the lovelace configuration.</summary>
		public void LovelaceReload(BrowserModLovelaceReloadParameters data)
		{
			_haContext.CallService("browser_mod", "lovelace_reload", null, data);
		}

		///<summary>Refresh the lovelace configuration.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void LovelaceReload(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "lovelace_reload", null, new BrowserModLovelaceReloadParameters{DeviceID = @deviceID});
		}

		///<summary>Open the more info dialog of an entity on a browser.</summary>
		public void MoreInfo(BrowserModMoreInfoParameters data)
		{
			_haContext.CallService("browser_mod", "more_info", null, data);
		}

		///<summary>Open the more info dialog of an entity on a browser.</summary>
		///<param name="entityId">Entity to show more info for eg: camera.front_door</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="large">(optional) Set to true to make wider eg: true</param>
		public void MoreInfo(object? @entityId = null, object? @deviceID = null, object? @large = null)
		{
			_haContext.CallService("browser_mod", "more_info", null, new BrowserModMoreInfoParameters{EntityId = @entityId, DeviceID = @deviceID, Large = @large});
		}

		///<summary>Navigate to a path on a browser.</summary>
		public void Navigate(BrowserModNavigateParameters data)
		{
			_haContext.CallService("browser_mod", "navigate", null, data);
		}

		///<summary>Navigate to a path on a browser.</summary>
		///<param name="navigationPath">Path to navigate to eg: /lovelace/1</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Navigate(object? @navigationPath = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "navigate", null, new BrowserModNavigateParameters{NavigationPath = @navigationPath, DeviceID = @deviceID});
		}

		///<summary>Remove a blackout from a browser.</summary>
		public void NoBlackout(BrowserModNoBlackoutParameters data)
		{
			_haContext.CallService("browser_mod", "no_blackout", null, data);
		}

		///<summary>Remove a blackout from a browser.</summary>
		///<param name="brightness">(optional) On a Fully Kiosk Browser Plus set the screen brightness from 0 - 255.</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void NoBlackout(object? @brightness = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "no_blackout", null, new BrowserModNoBlackoutParameters{Brightness = @brightness, DeviceID = @deviceID});
		}

		///<summary>Pop up a card on a browser.</summary>
		public void Popup(BrowserModPopupParameters data)
		{
			_haContext.CallService("browser_mod", "popup", null, data);
		}

		///<summary>Pop up a card on a browser.</summary>
		///<param name="title">Name to show in popup bar eg: Popup example</param>
		///<param name="card">YAML config for card to show</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="large">(optional) Set to true to make wider eg: true</param>
		///<param name="hideHeader">(optional) Hide header title and close button eg: true</param>
		///<param name="autoClose">(optional) Close popup when mouse is moved or key is pressed. Also hides header eg: true</param>
		///<param name="time">(optional) When mouse isn't moved or keys aren't pressed for this amount of seconds, reopen. Only usable with auto_close. See blackout eg: 20</param>
		public void Popup(object? @title = null, object? @card = null, object? @deviceID = null, object? @large = null, object? @hideHeader = null, object? @autoClose = null, object? @time = null)
		{
			_haContext.CallService("browser_mod", "popup", null, new BrowserModPopupParameters{Title = @title, Card = @card, DeviceID = @deviceID, Large = @large, HideHeader = @hideHeader, AutoClose = @autoClose, Time = @time});
		}

		///<summary>On all browsers, change the theme.</summary>
		public void SetTheme(BrowserModSetThemeParameters data)
		{
			_haContext.CallService("browser_mod", "set_theme", null, data);
		}

		///<summary>On all browsers, change the theme.</summary>
		///<param name="theme">Theme to change to eg: {theme: "clear_light"}</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void SetTheme(object? @theme = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "set_theme", null, new BrowserModSetThemeParameters{Theme = @theme, DeviceID = @deviceID});
		}

		///<summary>Show a toast message in the bottom left on all browsers.</summary>
		public void Toast(BrowserModToastParameters data)
		{
			_haContext.CallService("browser_mod", "toast", null, data);
		}

		///<summary>Show a toast message in the bottom left on all browsers.</summary>
		///<param name="message">Message to show eg: Short message</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="duration">(optional) Time in milliseconds to show message for. Set to 0 for persistent display. eg: 10000</param>
		public void Toast(object? @message = null, object? @deviceID = null, object? @duration = null)
		{
			_haContext.CallService("browser_mod", "toast", null, new BrowserModToastParameters{Message = @message, DeviceID = @deviceID, Duration = @duration});
		}

		///<summary>Forces the browser to reload the page. Same as clicking your browser's refresh button. Note: This is not guaranteed to clear the frontend cache.</summary>
		public void WindowReload(BrowserModWindowReloadParameters data)
		{
			_haContext.CallService("browser_mod", "window_reload", null, data);
		}

		///<summary>Forces the browser to reload the page. Same as clicking your browser's refresh button. Note: This is not guaranteed to clear the frontend cache.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void WindowReload(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "window_reload", null, new BrowserModWindowReloadParameters{DeviceID = @deviceID});
		}
	}

	public record BrowserModBlackoutParameters
	{
		///<summary>(optional) The blackout will turn on automatically after the specified number of seconds. It works kind of like a screensaver and will keep turning on until blackout is called again with time: -1. eg: 20</summary>
		[JsonPropertyName("time")]
		public object? Time { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModClosePopupParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModCommandParameters
	{
		///<summary>Command to send eg: navigate</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModCommandsParameters
	{
		///<summary>List of commands to send</summary>
		[JsonPropertyName("commands")]
		public object? Commands { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModDebugParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModDelayParameters
	{
		///<summary>Number of seconds to delay eg: 5</summary>
		[JsonPropertyName("seconds")]
		public object? Seconds { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModLovelaceReloadParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModMoreInfoParameters
	{
		///<summary>Entity to show more info for eg: camera.front_door</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Set to true to make wider eg: true</summary>
		[JsonPropertyName("large")]
		public object? Large { get; init; }
	}

	public record BrowserModNavigateParameters
	{
		///<summary>Path to navigate to eg: /lovelace/1</summary>
		[JsonPropertyName("navigation_path")]
		public object? NavigationPath { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModNoBlackoutParameters
	{
		///<summary>(optional) On a Fully Kiosk Browser Plus set the screen brightness from 0 - 255.</summary>
		[JsonPropertyName("brightness")]
		public object? Brightness { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModPopupParameters
	{
		///<summary>Name to show in popup bar eg: Popup example</summary>
		[JsonPropertyName("title")]
		public object? Title { get; init; }

		///<summary>YAML config for card to show</summary>
		[JsonPropertyName("card")]
		public object? Card { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Set to true to make wider eg: true</summary>
		[JsonPropertyName("large")]
		public object? Large { get; init; }

		///<summary>(optional) Hide header title and close button eg: true</summary>
		[JsonPropertyName("hide_header")]
		public object? HideHeader { get; init; }

		///<summary>(optional) Close popup when mouse is moved or key is pressed. Also hides header eg: true</summary>
		[JsonPropertyName("auto_close")]
		public object? AutoClose { get; init; }

		///<summary>(optional) When mouse isn't moved or keys aren't pressed for this amount of seconds, reopen. Only usable with auto_close. See blackout eg: 20</summary>
		[JsonPropertyName("time")]
		public object? Time { get; init; }
	}

	public record BrowserModSetThemeParameters
	{
		///<summary>Theme to change to eg: {theme: "clear_light"}</summary>
		[JsonPropertyName("theme")]
		public object? Theme { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModToastParameters
	{
		///<summary>Message to show eg: Short message</summary>
		[JsonPropertyName("message")]
		public object? Message { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Time in milliseconds to show message for. Set to 0 for persistent display. eg: 10000</summary>
		[JsonPropertyName("duration")]
		public object? Duration { get; init; }
	}

	public record BrowserModWindowReloadParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public class ButtonServices
	{
		private readonly IHaContext _haContext;
		public ButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("button", "press", target);
		}
	}

	public class CameraServices
	{
		private readonly IHaContext _haContext;
		public CameraServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(ServiceTarget target, string @mediaPlayer, object? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[JsonPropertyName("format")]
		public object? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class CastServices
	{
		private readonly IHaContext _haContext;
		public CastServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		public void ShowLovelaceView(CastShowLovelaceViewParameters data)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, data);
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		///<param name="entityId">Media Player entity to show the Lovelace view on.</param>
		///<param name="dashboardPath">The URL path of the Lovelace dashboard to show. eg: lovelace-cast</param>
		///<param name="viewPath">The path of the Lovelace view to show. eg: downstairs</param>
		public void ShowLovelaceView(string @entityId, string @dashboardPath, string? @viewPath = null)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, new CastShowLovelaceViewParameters{EntityId = @entityId, DashboardPath = @dashboardPath, ViewPath = @viewPath});
		}
	}

	public record CastShowLovelaceViewParameters
	{
		///<summary>Media Player entity to show the Lovelace view on.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The URL path of the Lovelace dashboard to show. eg: lovelace-cast</summary>
		[JsonPropertyName("dashboard_path")]
		public string? DashboardPath { get; init; }

		///<summary>The path of the Lovelace view to show. eg: downstairs</summary>
		[JsonPropertyName("view_path")]
		public string? ViewPath { get; init; }
	}

	public class ClimateServices
	{
		private readonly IHaContext _haContext;
		public ClimateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(ServiceTarget target, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public class CounterServices
	{
		private readonly IHaContext _haContext;
		public CounterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly IHaContext _haContext;
		public CoverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DenonavrServices
	{
		private readonly IHaContext _haContext;
		public DenonavrServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a generic HTTP get command.</summary>
		///<param name="target">The target for this service call</param>
		public void GetCommand(ServiceTarget target, DenonavrGetCommandParameters data)
		{
			_haContext.CallService("denonavr", "get_command", target, data);
		}

		///<summary>Send a generic HTTP get command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Endpoint of the command, including associated parameters. eg: /goform/formiPhoneAppDirect.xml?RCKSK0410370</param>
		public void GetCommand(ServiceTarget target, string @command)
		{
			_haContext.CallService("denonavr", "get_command", target, new DenonavrGetCommandParameters{Command = @command});
		}

		///<summary>Enable or disable DynamicEQ.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDynamicEq(ServiceTarget target, DenonavrSetDynamicEqParameters data)
		{
			_haContext.CallService("denonavr", "set_dynamic_eq", target, data);
		}

		///<summary>Enable or disable DynamicEQ.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="dynamicEq">True/false for enable/disable.</param>
		public void SetDynamicEq(ServiceTarget target, bool? @dynamicEq = null)
		{
			_haContext.CallService("denonavr", "set_dynamic_eq", target, new DenonavrSetDynamicEqParameters{DynamicEq = @dynamicEq});
		}

		///<summary>Update Audyssey settings.</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateAudyssey(ServiceTarget target)
		{
			_haContext.CallService("denonavr", "update_audyssey", target);
		}
	}

	public record DenonavrGetCommandParameters
	{
		///<summary>Endpoint of the command, including associated parameters. eg: /goform/formiPhoneAppDirect.xml?RCKSK0410370</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }
	}

	public record DenonavrSetDynamicEqParameters
	{
		///<summary>True/false for enable/disable.</summary>
		[JsonPropertyName("dynamic_eq")]
		public bool? DynamicEq { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Control tracked device.</summary>
		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		///<summary>Control tracked device.</summary>
		///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
		///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
		///<param name="hostName">Hostname of device eg: Dave</param>
		///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
		///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
		///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
		///<param name="battery">Battery level of device.</param>
		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters{Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery});
		}
	}

	public record DeviceTrackerSeeParameters
	{
		///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class EvohomeServices
	{
		private readonly IHaContext _haContext;
		public EvohomeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set a zone to follow its schedule.</summary>
		public void ClearZoneOverride(EvohomeClearZoneOverrideParameters data)
		{
			_haContext.CallService("evohome", "clear_zone_override", null, data);
		}

		///<summary>Set a zone to follow its schedule.</summary>
		///<param name="entityId">The entity_id of the zone.</param>
		public void ClearZoneOverride(string @entityId)
		{
			_haContext.CallService("evohome", "clear_zone_override", null, new EvohomeClearZoneOverrideParameters{EntityId = @entityId});
		}

		///<summary>Pull the latest data from the vendor's servers now, rather than waiting for the next scheduled update.</summary>
		public void RefreshSystem()
		{
			_haContext.CallService("evohome", "refresh_system", null);
		}

		///<summary>Set the system mode, either indefinitely, or for a specified period of time, after which it will revert to Auto. Not all systems support all modes.</summary>
		public void SetSystemMode(EvohomeSetSystemModeParameters data)
		{
			_haContext.CallService("evohome", "set_system_mode", null, data);
		}

		///<summary>Set the system mode, either indefinitely, or for a specified period of time, after which it will revert to Auto. Not all systems support all modes.</summary>
		///<param name="mode">Mode to set thermostat. eg: Away</param>
		///<param name="period">A period of time in days; used only with Away, DayOff, or Custom. The system will revert to Auto at midnight (up to 99 days, today is day 1). eg: {"days": 28}</param>
		///<param name="duration">The duration in hours; used only with AutoWithEco (up to 24 hours). eg: {"hours": 18}</param>
		public void SetSystemMode(object? @mode = null, object? @period = null, object? @duration = null)
		{
			_haContext.CallService("evohome", "set_system_mode", null, new EvohomeSetSystemModeParameters{Mode = @mode, Period = @period, Duration = @duration});
		}

		///<summary>Override a zone's setpoint, either indefinitely, or for a specified period of time, after which it will revert to following its schedule.</summary>
		public void SetZoneOverride(EvohomeSetZoneOverrideParameters data)
		{
			_haContext.CallService("evohome", "set_zone_override", null, data);
		}

		///<summary>Override a zone's setpoint, either indefinitely, or for a specified period of time, after which it will revert to following its schedule.</summary>
		///<param name="entityId">The entity_id of the Evohome zone. eg: climate.bathroom</param>
		///<param name="setpoint">The temperature to be used instead of the scheduled setpoint.</param>
		///<param name="duration">The zone will revert to its schedule after this time. If 0 the change is until the next scheduled setpoint. eg: {"minutes": 135}</param>
		public void SetZoneOverride(string @entityId, double @setpoint, object? @duration = null)
		{
			_haContext.CallService("evohome", "set_zone_override", null, new EvohomeSetZoneOverrideParameters{EntityId = @entityId, Setpoint = @setpoint, Duration = @duration});
		}
	}

	public record EvohomeClearZoneOverrideParameters
	{
		///<summary>The entity_id of the zone.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record EvohomeSetSystemModeParameters
	{
		///<summary>Mode to set thermostat. eg: Away</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }

		///<summary>A period of time in days; used only with Away, DayOff, or Custom. The system will revert to Auto at midnight (up to 99 days, today is day 1). eg: {"days": 28}</summary>
		[JsonPropertyName("period")]
		public object? Period { get; init; }

		///<summary>The duration in hours; used only with AutoWithEco (up to 24 hours). eg: {"hours": 18}</summary>
		[JsonPropertyName("duration")]
		public object? Duration { get; init; }
	}

	public record EvohomeSetZoneOverrideParameters
	{
		///<summary>The entity_id of the Evohome zone. eg: climate.bathroom</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The temperature to be used instead of the scheduled setpoint.</summary>
		[JsonPropertyName("setpoint")]
		public double? Setpoint { get; init; }

		///<summary>The zone will revert to its schedule after this time. If 0 the change is until the next scheduled setpoint. eg: {"minutes": 135}</summary>
		[JsonPropertyName("duration")]
		public object? Duration { get; init; }
	}

	public class FanServices
	{
		private readonly IHaContext _haContext;
		public FanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(ServiceTarget target, object @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[JsonPropertyName("direction")]
		public object? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FfmpegServices
	{
		private readonly IHaContext _haContext;
		public FfmpegServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		public void Restart(FfmpegRestartParameters data)
		{
			_haContext.CallService("ffmpeg", "restart", null, data);
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
		public void Restart(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "restart", null, new FfmpegRestartParameters{EntityId = @entityId});
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		public void Start(FfmpegStartParameters data)
		{
			_haContext.CallService("ffmpeg", "start", null, data);
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will start. Platform dependent.</param>
		public void Start(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "start", null, new FfmpegStartParameters{EntityId = @entityId});
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		public void Stop(FfmpegStopParameters data)
		{
			_haContext.CallService("ffmpeg", "stop", null, data);
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
		public void Stop(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "stop", null, new FfmpegStopParameters{EntityId = @entityId});
		}
	}

	public record FfmpegRestartParameters
	{
		///<summary>Name of entity that will restart. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStartParameters
	{
		///<summary>Name of entity that will start. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStopParameters
	{
		///<summary>Name of entity that will stop. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class FoscamServices
	{
		private readonly IHaContext _haContext;
		public FoscamServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Pan/Tilt service for Foscam camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Ptz(ServiceTarget target, FoscamPtzParameters data)
		{
			_haContext.CallService("foscam", "ptz", target, data);
		}

		///<summary>Pan/Tilt service for Foscam camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="movement">Direction of the movement.</param>
		///<param name="travelTime">Travel time in seconds.</param>
		public void Ptz(ServiceTarget target, object @movement, double? @travelTime = null)
		{
			_haContext.CallService("foscam", "ptz", target, new FoscamPtzParameters{Movement = @movement, TravelTime = @travelTime});
		}

		///<summary>PTZ Preset service for Foscam camera.</summary>
		///<param name="target">The target for this service call</param>
		public void PtzPreset(ServiceTarget target, FoscamPtzPresetParameters data)
		{
			_haContext.CallService("foscam", "ptz_preset", target, data);
		}

		///<summary>PTZ Preset service for Foscam camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetName">The name of the preset to move to. Presets can be created from within the official Foscam apps. eg: TopMost</param>
		public void PtzPreset(ServiceTarget target, string @presetName)
		{
			_haContext.CallService("foscam", "ptz_preset", target, new FoscamPtzPresetParameters{PresetName = @presetName});
		}
	}

	public record FoscamPtzParameters
	{
		///<summary>Direction of the movement.</summary>
		[JsonPropertyName("movement")]
		public object? Movement { get; init; }

		///<summary>Travel time in seconds.</summary>
		[JsonPropertyName("travel_time")]
		public double? TravelTime { get; init; }
	}

	public record FoscamPtzPresetParameters
	{
		///<summary>The name of the preset to move to. Presets can be created from within the official Foscam apps. eg: TopMost</summary>
		[JsonPropertyName("preset_name")]
		public string? PresetName { get; init; }
	}

	public class FrontendServices
	{
		private readonly IHaContext _haContext;
		public FrontendServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload themes from YAML configuration.</summary>
		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		///<param name="name">Name of a predefined theme eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(object @name, object? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme eg: default</summary>
		[JsonPropertyName("name")]
		public object? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public class GroupServices
	{
		private readonly IHaContext _haContext;
		public GroupServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload group configuration, entities, and notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		///<summary>Remove a user group.</summary>
		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		///<summary>Remove a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new GroupRemoveParameters{ObjectId = @objectId});
		}

		///<summary>Create/Update a user group.</summary>
		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		///<summary>Create/Update a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		///<param name="name">Name of group eg: My test group</param>
		///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
		///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, object? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HassioServices
	{
		private readonly IHaContext _haContext;
		public HassioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Restart add-on.</summary>
		public void AddonRestart(HassioAddonRestartParameters data)
		{
			_haContext.CallService("hassio", "addon_restart", null, data);
		}

		///<summary>Restart add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonRestart(string @addon)
		{
			_haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters{Addon = @addon});
		}

		///<summary>Start add-on.</summary>
		public void AddonStart(HassioAddonStartParameters data)
		{
			_haContext.CallService("hassio", "addon_start", null, data);
		}

		///<summary>Start add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStart(string @addon)
		{
			_haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters{Addon = @addon});
		}

		///<summary>Write data to add-on stdin.</summary>
		public void AddonStdin(HassioAddonStdinParameters data)
		{
			_haContext.CallService("hassio", "addon_stdin", null, data);
		}

		///<summary>Write data to add-on stdin.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStdin(string @addon)
		{
			_haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters{Addon = @addon});
		}

		///<summary>Stop add-on.</summary>
		public void AddonStop(HassioAddonStopParameters data)
		{
			_haContext.CallService("hassio", "addon_stop", null, data);
		}

		///<summary>Stop add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStop(string @addon)
		{
			_haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters{Addon = @addon});
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		public void AddonUpdate(HassioAddonUpdateParameters data)
		{
			_haContext.CallService("hassio", "addon_update", null, data);
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonUpdate(string @addon)
		{
			_haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters{Addon = @addon});
		}

		///<summary>Create a full backup.</summary>
		public void BackupFull(HassioBackupFullParameters data)
		{
			_haContext.CallService("hassio", "backup_full", null, data);
		}

		///<summary>Create a full backup.</summary>
		///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupFull(string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters{Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Create a partial backup.</summary>
		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		///<summary>Create a partial backup.</summary>
		///<param name="homeassistant">Backup Home Assistant settings</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupPartial(bool? @homeassistant = null, object? @addons = null, object? @folders = null, string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters{Homeassistant = @homeassistant, Addons = @addons, Folders = @folders, Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Reboot the host system.</summary>
		public void HostReboot()
		{
			_haContext.CallService("hassio", "host_reboot", null);
		}

		///<summary>Poweroff the host system.</summary>
		public void HostShutdown()
		{
			_haContext.CallService("hassio", "host_shutdown", null);
		}

		///<summary>Restore from full backup.</summary>
		public void RestoreFull(HassioRestoreFullParameters data)
		{
			_haContext.CallService("hassio", "restore_full", null, data);
		}

		///<summary>Restore from full backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestoreFull(string @slug, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters{Slug = @slug, Password = @password});
		}

		///<summary>Restore from partial backup.</summary>
		public void RestorePartial(HassioRestorePartialParameters data)
		{
			_haContext.CallService("hassio", "restore_partial", null, data);
		}

		///<summary>Restore from partial backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="homeassistant">Restore Home Assistant</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters{Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password});
		}
	}

	public record HassioAddonRestartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		///<summary>Optional (default = current date and time). eg: Backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		///<summary>Backup Home Assistant settings</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Restore Home Assistant</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly IHaContext _haContext;
		public HomeassistantServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters{EntryId = @entryId});
		}

		///<summary>Reload the core configuration.</summary>
		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		///<summary>Restart the Home Assistant service.</summary>
		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		///<summary>Update the Home Assistant location.</summary>
		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		///<summary>Update the Home Assistant location.</summary>
		///<param name="latitude">Latitude of your location. eg: 32,87336</param>
		///<param name="longitude">Longitude of your location. eg: 117,22743</param>
		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters{Latitude = @latitude, Longitude = @longitude});
		}

		///<summary>Stop the Home Assistant service.</summary>
		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		///<summary>Generic service to toggle devices on/off under any domain</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32,87336</summary>
		[JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117,22743</summary>
		[JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class HomekitServices
	{
		private readonly IHaContext _haContext;
		public HomekitServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload homekit and re-process YAML configuration</summary>
		public void Reload()
		{
			_haContext.CallService("homekit", "reload", null);
		}

		///<summary>Reset a HomeKit accessory</summary>
		///<param name="target">The target for this service call</param>
		public void ResetAccessory(ServiceTarget target)
		{
			_haContext.CallService("homekit", "reset_accessory", target);
		}

		///<summary>Forcefully remove all pairings from an accessory to allow re-pairing. Use this service if the accessory is no longer responsive, and you want to avoid deleting and re-adding the entry. Room locations, and accessory preferences will be lost.</summary>
		///<param name="target">The target for this service call</param>
		public void Unpair(ServiceTarget target)
		{
			_haContext.CallService("homekit", "unpair", target);
		}
	}

	public class HueServices
	{
		private readonly IHaContext _haContext;
		public HueServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The target for this service call</param>
		public void ActivateScene(ServiceTarget target, HueActivateSceneParameters data)
		{
			_haContext.CallService("hue", "activate_scene", target, data);
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		///<param name="dynamic">Enable dynamic mode of the scene.</param>
		///<param name="speed">Speed of dynamic palette for this scene</param>
		///<param name="brightness">Set brightness for the scene.</param>
		public void ActivateScene(ServiceTarget target, long? @transition = null, bool? @dynamic = null, long? @speed = null, long? @brightness = null)
		{
			_haContext.CallService("hue", "activate_scene", target, new HueActivateSceneParameters{Transition = @transition, Dynamic = @dynamic, Speed = @speed, Brightness = @brightness});
		}

		///<summary>Activate a hue scene stored in the hue hub.</summary>
		public void HueActivateScene(HueHueActivateSceneParameters data)
		{
			_haContext.CallService("hue", "hue_activate_scene", null, data);
		}

		///<summary>Activate a hue scene stored in the hue hub.</summary>
		///<param name="groupName">Name of hue group/room from the hue app. eg: Living Room</param>
		///<param name="sceneName">Name of hue scene from the hue app. eg: Energize</param>
		///<param name="dynamic">Enable dynamic mode of the scene (V2 bridges and supported scenes only).</param>
		public void HueActivateScene(string? @groupName = null, string? @sceneName = null, bool? @dynamic = null)
		{
			_haContext.CallService("hue", "hue_activate_scene", null, new HueHueActivateSceneParameters{GroupName = @groupName, SceneName = @sceneName, Dynamic = @dynamic});
		}
	}

	public record HueActivateSceneParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Enable dynamic mode of the scene.</summary>
		[JsonPropertyName("dynamic")]
		public bool? Dynamic { get; init; }

		///<summary>Speed of dynamic palette for this scene</summary>
		[JsonPropertyName("speed")]
		public long? Speed { get; init; }

		///<summary>Set brightness for the scene.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record HueHueActivateSceneParameters
	{
		///<summary>Name of hue group/room from the hue app. eg: Living Room</summary>
		[JsonPropertyName("group_name")]
		public string? GroupName { get; init; }

		///<summary>Name of hue scene from the hue app. eg: Energize</summary>
		[JsonPropertyName("scene_name")]
		public string? SceneName { get; init; }

		///<summary>Enable dynamic mode of the scene (V2 bridges and supported scenes only).</summary>
		[JsonPropertyName("dynamic")]
		public bool? Dynamic { get; init; }
	}

	public class HumidifierServices
	{
		private readonly IHaContext _haContext;
		public HumidifierServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, HumidifierSetHumidityParameters data)
		{
			_haContext.CallService("humidifier", "set_humidity", target, data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(ServiceTarget target, HumidifierSetModeParameters data)
		{
			_haContext.CallService("humidifier", "set_mode", target, data);
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">New mode eg: away</param>
		public void SetMode(ServiceTarget target, string @mode)
		{
			_haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Toggles a humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "toggle", target);
		}

		///<summary>Turn humidifier device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_off", target);
		}

		///<summary>Turn humidifier device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_on", target);
		}
	}

	public record HumidifierSetHumidityParameters
	{
		///<summary>New target humidity for humidifier device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record HumidifierSetModeParameters
	{
		///<summary>New mode eg: away</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly IHaContext _haContext;
		public InputBooleanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputDatetimeServices
	{
		private readonly IHaContext _haContext;
		public InputDatetimeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly IHaContext _haContext;
		public InputNumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		///<summary>Reload the input_number configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly IHaContext _haContext;
		public InputSelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly IHaContext _haContext;
		public InputTextServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class LightServices
	{
		private readonly IHaContext _haContext;
		public LightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(ServiceTarget target, long? @transition = null, object? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating level of white.</summary>
		[JsonPropertyName("white_value")]
		public long? WhiteValue { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>The color for the light (based on RGB - red, green, blue).</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LockServices
	{
		private readonly IHaContext _haContext;
		public LockServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(ServiceTarget target, LockLockParameters data)
		{
			_haContext.CallService("lock", "lock", target, data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public void Lock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "lock", target, new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Open(ServiceTarget target, LockOpenParameters data)
		{
			_haContext.CallService("lock", "open", target, data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public void Open(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "open", target, new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Unlock(ServiceTarget target, LockUnlockParameters data)
		{
			_haContext.CallService("lock", "unlock", target, data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public void Unlock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "unlock", target, new LockUnlockParameters{Code = @code});
		}
	}

	public record LockLockParameters
	{
		///<summary>An optional code to lock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockOpenParameters
	{
		///<summary>An optional code to open the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockUnlockParameters
	{
		///<summary>An optional code to unlock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class LogbookServices
	{
		private readonly IHaContext _haContext;
		public LogbookServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a custom entry in your logbook.</summary>
		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		///<summary>Create a custom entry in your logbook.</summary>
		///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
		///<param name="message">Message of the custom logbook entry. eg: is being used</param>
		///<param name="entityId">Entity to reference in custom logbook entry.</param>
		///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new LogbookLogParameters{Name = @name, Message = @message, EntityId = @entityId, Domain = @domain});
		}
	}

	public record LogbookLogParameters
	{
		///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class LoggerServices
	{
		private readonly IHaContext _haContext;
		public LoggerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the default log level for integrations.</summary>
		public void SetDefaultLevel(LoggerSetDefaultLevelParameters data)
		{
			_haContext.CallService("logger", "set_default_level", null, data);
		}

		///<summary>Set the default log level for integrations.</summary>
		///<param name="level">Default severity level for all integrations.</param>
		public void SetDefaultLevel(object? @level = null)
		{
			_haContext.CallService("logger", "set_default_level", null, new LoggerSetDefaultLevelParameters{Level = @level});
		}

		///<summary>Set log level for integrations.</summary>
		public void SetLevel()
		{
			_haContext.CallService("logger", "set_level", null);
		}
	}

	public record LoggerSetDefaultLevelParameters
	{
		///<summary>Default severity level for all integrations.</summary>
		[JsonPropertyName("level")]
		public object? Level { get; init; }
	}

	public class MediaExtractorServices
	{
		private readonly IHaContext _haContext;
		public MediaExtractorServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Downloads file from given URL.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaExtractorPlayMediaParameters data)
		{
			_haContext.CallService("media_extractor", "play_media", target, data);
		}

		///<summary>Downloads file from given URL.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://soundcloud.com/bruttoband/brutto-11</param>
		///<param name="mediaContentType">The type of the content to play. Must be one of MUSIC, TVSHOW, VIDEO, EPISODE, CHANNEL or PLAYLIST MUSIC.</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, object @mediaContentType)
		{
			_haContext.CallService("media_extractor", "play_media", target, new MediaExtractorPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}
	}

	public record MediaExtractorPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://soundcloud.com/bruttoband/brutto-11</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Must be one of MUSIC, TVSHOW, VIDEO, EPISODE, CHANNEL or PLAYLIST MUSIC.</summary>
		[JsonPropertyName("media_content_type")]
		public object? MediaContentType { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly IHaContext _haContext;
		public MediaPlayerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </param>
		public void Join(ServiceTarget target, string @groupMembers)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(ServiceTarget target, object @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </summary>
		[JsonPropertyName("group_members")]
		public string? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		///<summary>If the content should be played now or be added to the queue.</summary>
		[JsonPropertyName("enqueue")]
		public object? Enqueue { get; init; }

		///<summary>If the media should be played as an announcement. eg: true</summary>
		[JsonPropertyName("announce")]
		public bool? Announce { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[JsonPropertyName("repeat")]
		public object? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class MqttServices
	{
		private readonly IHaContext _haContext;
		public MqttServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		///<param name="topic">topic to listen to eg: OpenZWave/#</param>
		///<param name="duration">how long we should listen for messages in seconds</param>
		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new MqttDumpParameters{Topic = @topic, Duration = @duration});
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
		///<param name="payload">Payload to publish. eg: This is great</param>
		///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
		///<param name="qos">Quality of Service to use.</param>
		///<param name="retain">If message should have the retain flag set.</param>
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, object? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new MqttPublishParameters{Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain});
		}

		///<summary>Reload all MQTT entities from YAML.</summary>
		public void Reload()
		{
			_haContext.CallService("mqtt", "reload", null);
		}
	}

	public record MqttDumpParameters
	{
		///<summary>topic to listen to eg: OpenZWave/#</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[JsonPropertyName("payload_template")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[JsonPropertyName("qos")]
		public object? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
		[JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class NetdaemonServices
	{
		private readonly IHaContext _haContext;
		public NetdaemonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create an entity</summary>
		public void EntityCreate(NetdaemonEntityCreateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_create", null, data);
		}

		///<summary>Create an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		///<param name="state">The state of the entity eg: Lorem ipsum</param>
		///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
		///<param name="unit">The unit of measurement for the entity</param>
		///<param name="options">List of options for a select entity</param>
		///<param name="attributes">The attributes of the entity</param>
		public void EntityCreate(object? @entityId = null, object? @state = null, object? @icon = null, object? @unit = null, object? @options = null, object? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_create", null, new NetdaemonEntityCreateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Options = @options, Attributes = @attributes});
		}

		///<summary>Remove an entity</summary>
		public void EntityRemove(NetdaemonEntityRemoveParameters data)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, data);
		}

		///<summary>Remove an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		public void EntityRemove(object? @entityId = null)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, new NetdaemonEntityRemoveParameters{EntityId = @entityId});
		}

		///<summary>Update an entity</summary>
		public void EntityUpdate(NetdaemonEntityUpdateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_update", null, data);
		}

		///<summary>Update an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		///<param name="state">The state of the entity eg: Lorem ipsum</param>
		///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
		///<param name="unit">The unit of measurement for the entity</param>
		///<param name="options">List of options for a select entity</param>
		///<param name="attributes">The attributes of the entity</param>
		public void EntityUpdate(object? @entityId = null, object? @state = null, object? @icon = null, object? @unit = null, object? @options = null, object? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_update", null, new NetdaemonEntityUpdateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Options = @options, Attributes = @attributes});
		}

		///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
		public void RegisterService(NetdaemonRegisterServiceParameters data)
		{
			_haContext.CallService("netdaemon", "register_service", null, data);
		}

		///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
		///<param name="service">The name of the service to register</param>
		///<param name="class">The class that implements the service call</param>
		///<param name="method">The method to call</param>
		public void RegisterService(object? @service = null, object? @class = null, object? @method = null)
		{
			_haContext.CallService("netdaemon", "register_service", null, new NetdaemonRegisterServiceParameters{Service = @service, Class = @class, Method = @method});
		}

		public void ReloadApps()
		{
			_haContext.CallService("netdaemon", "reload_apps", null);
		}
	}

	public record NetdaemonEntityCreateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[JsonPropertyName("state")]
		public object? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[JsonPropertyName("unit")]
		public object? Unit { get; init; }

		///<summary>List of options for a select entity</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The attributes of the entity</summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }
	}

	public record NetdaemonEntityRemoveParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record NetdaemonEntityUpdateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[JsonPropertyName("state")]
		public object? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[JsonPropertyName("unit")]
		public object? Unit { get; init; }

		///<summary>List of options for a select entity</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The attributes of the entity</summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }
	}

	public record NetdaemonRegisterServiceParameters
	{
		///<summary>The name of the service to register</summary>
		[JsonPropertyName("service")]
		public object? Service { get; init; }

		///<summary>The class that implements the service call</summary>
		[JsonPropertyName("class")]
		public object? Class { get; init; }

		///<summary>The method to call</summary>
		[JsonPropertyName("method")]
		public object? Method { get; init; }
	}

	public class NotifyServices
	{
		private readonly IHaContext _haContext;
		public NotifyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the all_devices service.</summary>
		public void AllDevices(NotifyAllDevicesParameters data)
		{
			_haContext.CallService("notify", "all_devices", null, data);
		}

		///<summary>Sends a notification message using the all_devices service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AllDevices(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "all_devices", null, new NotifyAllDevicesParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the gotify service.</summary>
		public void Gotify(NotifyGotifyParameters data)
		{
			_haContext.CallService("notify", "gotify", null, data);
		}

		///<summary>Sends a notification message using the gotify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Gotify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "gotify", null, new NotifyGotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the lg_webostv_woonkamer service.</summary>
		public void LgWebostvWoonkamer(NotifyLgWebostvWoonkamerParameters data)
		{
			_haContext.CallService("notify", "lg_webostv_woonkamer", null, data);
		}

		///<summary>Sends a notification message using the lg_webostv_woonkamer service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void LgWebostvWoonkamer(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "lg_webostv_woonkamer", null, new NotifyLgWebostvWoonkamerParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_ipadpro integration.</summary>
		public void MobileAppIpadpro(NotifyMobileAppIpadproParameters data)
		{
			_haContext.CallService("notify", "mobile_app_ipadpro", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_ipadpro integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppIpadpro(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_ipadpro", null, new NotifyMobileAppIpadproParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_oneplus_9_pro integration.</summary>
		public void MobileAppOneplus9Pro(NotifyMobileAppOneplus9ProParameters data)
		{
			_haContext.CallService("notify", "mobile_app_oneplus_9_pro", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_oneplus_9_pro integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppOneplus9Pro(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_oneplus_9_pro", null, new NotifyMobileAppOneplus9ProParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the notify service.</summary>
		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		///<summary>Sends a notification message using the notify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new NotifyNotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}
	}

	public record NotifyAllDevicesParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyGotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyLgWebostvWoonkamerParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppIpadproParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppOneplus9ProParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public class NumberServices
	{
		private readonly IHaContext _haContext;
		public NumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a notification in the frontend.</summary>
		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		///<summary>Show a notification in the frontend.</summary>
		///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
		///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
		///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters{Message = @message, Title = @title, NotificationId = @notificationId});
		}

		///<summary>Remove a notification from the frontend.</summary>
		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		///<summary>Remove a notification from the frontend.</summary>
		///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters{NotificationId = @notificationId});
		}

		///<summary>Mark a notification read.</summary>
		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		///<summary>Mark a notification read.</summary>
		///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters{NotificationId = @notificationId});
		}
	}

	public record PersistentNotificationCreateParameters
	{
		///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly IHaContext _haContext;
		public PersonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the person configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class RecorderServices
	{
		private readonly IHaContext _haContext;
		public RecorderServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stop the recording of events and state changes</summary>
		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		///<summary>Start the recording of events and state changes</summary>
		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		///<param name="keepDays">Number of history days to keep in database after purge.</param>
		///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
		///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters{KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter});
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class RemoteServices
	{
		private readonly IHaContext _haContext;
		public RemoteServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		public void DeleteCommand(ServiceTarget target, RemoteDeleteCommandParameters data)
		{
			_haContext.CallService("remote", "delete_command", target, data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public void DeleteCommand(ServiceTarget target, object @command, string? @device = null)
		{
			_haContext.CallService("remote", "delete_command", target, new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		public void LearnCommand(ServiceTarget target, RemoteLearnCommandParameters data)
		{
			_haContext.CallService("remote", "learn_command", target, data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public void LearnCommand(ServiceTarget target, string? @device = null, object? @command = null, object? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			_haContext.CallService("remote", "learn_command", target, new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, RemoteSendCommandParameters data)
		{
			_haContext.CallService("remote", "send_command", target, data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public void SendCommand(ServiceTarget target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			_haContext.CallService("remote", "send_command", target, new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("remote", "toggle", target);
		}

		///<summary>Sends the Power Off Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("remote", "turn_off", target);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, RemoteTurnOnParameters data)
		{
			_haContext.CallService("remote", "turn_on", target, data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public void TurnOn(ServiceTarget target, string? @activity = null)
		{
			_haContext.CallService("remote", "turn_on", target, new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public record RemoteDeleteCommandParameters
	{
		///<summary>Name of the device from which commands will be deleted. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to delete. eg: Mute</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }
	}

	public record RemoteLearnCommandParameters
	{
		///<summary>Device ID to learn command from. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to learn. eg: Turn on</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The type of command to be learned.</summary>
		[JsonPropertyName("command_type")]
		public object? CommandType { get; init; }

		///<summary>If code must be stored as alternative (useful for discrete remotes).</summary>
		[JsonPropertyName("alternative")]
		public bool? Alternative { get; init; }

		///<summary>Timeout for the command to be learned.</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record RemoteSendCommandParameters
	{
		///<summary>Device ID to send command to. eg: 32756745</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to send. eg: Play</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The number of times you want to repeat the command(s).</summary>
		[JsonPropertyName("num_repeats")]
		public long? NumRepeats { get; init; }

		///<summary>The time you want to wait in between repeated commands.</summary>
		[JsonPropertyName("delay_secs")]
		public double? DelaySecs { get; init; }

		///<summary>The time you want to have it held before the release is send.</summary>
		[JsonPropertyName("hold_secs")]
		public double? HoldSecs { get; init; }
	}

	public record RemoteTurnOnParameters
	{
		///<summary>Activity ID or Activity Name to start. eg: BedroomTV</summary>
		[JsonPropertyName("activity")]
		public string? Activity { get; init; }
	}

	public class RestServices
	{
		private readonly IHaContext _haContext;
		public RestServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all rest entities and notify services</summary>
		public void Reload()
		{
			_haContext.CallService("rest", "reload", null);
		}
	}

	public class RestCommandServices
	{
		private readonly IHaContext _haContext;
		public RestCommandServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void GotifySendMessage()
		{
			_haContext.CallService("rest_command", "gotify_send_message", null);
		}

		public void PfsenseGetGatewayStatus()
		{
			_haContext.CallService("rest_command", "pfsense_get_gateway_status", null);
		}

		public void WhDs1PlafondDienstCmd()
		{
			_haContext.CallService("rest_command", "wh_ds1_plafond_dienst_cmd", null);
		}
	}

	public class SaverServices
	{
		private readonly IHaContext _haContext;
		public SaverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Deletes all saved data. </summary>
		public void Clear()
		{
			_haContext.CallService("saver", "clear", null);
		}

		///<summary>Deletes a saved state for an entity. </summary>
		public void Delete(SaverDeleteParameters data)
		{
			_haContext.CallService("saver", "delete", null, data);
		}

		///<summary>Deletes a saved state for an entity. </summary>
		///<param name="entityId">ID of entity to delete from saver. eg: light.patio</param>
		public void Delete(object? @entityId = null)
		{
			_haContext.CallService("saver", "delete", null, new SaverDeleteParameters{EntityId = @entityId});
		}

		///<summary>Deletes a saved variable. </summary>
		public void DeleteVariable(SaverDeleteVariableParameters data)
		{
			_haContext.CallService("saver", "delete_variable", null, data);
		}

		///<summary>Deletes a saved variable. </summary>
		///<param name="name">Name of the variable to delete from saver. eg: counter</param>
		public void DeleteVariable(object? @name = null)
		{
			_haContext.CallService("saver", "delete_variable", null, new SaverDeleteVariableParameters{Name = @name});
		}

		///<summary>Executes a script using all saved entities and variables. </summary>
		public void Execute(SaverExecuteParameters data)
		{
			_haContext.CallService("saver", "execute", null, data);
		}

		///<summary>Executes a script using all saved entities and variables. </summary>
		///<param name="script">The script to excute using saved data.</param>
		public void Execute(object? @script = null)
		{
			_haContext.CallService("saver", "execute", null, new SaverExecuteParameters{Script = @script});
		}

		///<summary>Executes the script using saved state of the entity. </summary>
		public void RestoreState(SaverRestoreStateParameters data)
		{
			_haContext.CallService("saver", "restore_state", null, data);
		}

		///<summary>Executes the script using saved state of the entity. </summary>
		///<param name="entityId">ID of the entity to restore. eg: light.patio</param>
		///<param name="restoreScript">Script used to restore values.</param>
		///<param name="deleteAfterRun">Deletes the saved state after an execution of the script. Default: true [Optional] eg: False</param>
		public void RestoreState(object? @entityId = null, object? @restoreScript = null, object? @deleteAfterRun = null)
		{
			_haContext.CallService("saver", "restore_state", null, new SaverRestoreStateParameters{EntityId = @entityId, RestoreScript = @restoreScript, DeleteAfterRun = @deleteAfterRun});
		}

		///<summary>Saves the state and parameters of the entity. </summary>
		public void SaveState(SaverSaveStateParameters data)
		{
			_haContext.CallService("saver", "save_state", null, data);
		}

		///<summary>Saves the state and parameters of the entity. </summary>
		///<param name="entityId">ID of the entity that should be saved. eg: light.patio</param>
		public void SaveState(object? @entityId = null)
		{
			_haContext.CallService("saver", "save_state", null, new SaverSaveStateParameters{EntityId = @entityId});
		}

		///<summary>Sets the value to the variable. </summary>
		public void SetVariable(SaverSetVariableParameters data)
		{
			_haContext.CallService("saver", "set_variable", null, data);
		}

		///<summary>Sets the value to the variable. </summary>
		///<param name="name">Name of the variable to save. eg: counter</param>
		///<param name="value">The new value eg: 3</param>
		public void SetVariable(object? @name = null, object? @value = null)
		{
			_haContext.CallService("saver", "set_variable", null, new SaverSetVariableParameters{Name = @name, Value = @value});
		}
	}

	public record SaverDeleteParameters
	{
		///<summary>ID of entity to delete from saver. eg: light.patio</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record SaverDeleteVariableParameters
	{
		///<summary>Name of the variable to delete from saver. eg: counter</summary>
		[JsonPropertyName("name")]
		public object? Name { get; init; }
	}

	public record SaverExecuteParameters
	{
		///<summary>The script to excute using saved data.</summary>
		[JsonPropertyName("script")]
		public object? Script { get; init; }
	}

	public record SaverRestoreStateParameters
	{
		///<summary>ID of the entity to restore. eg: light.patio</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Script used to restore values.</summary>
		[JsonPropertyName("restore_script")]
		public object? RestoreScript { get; init; }

		///<summary>Deletes the saved state after an execution of the script. Default: true [Optional] eg: False</summary>
		[JsonPropertyName("delete_after_run")]
		public object? DeleteAfterRun { get; init; }
	}

	public record SaverSaveStateParameters
	{
		///<summary>ID of the entity that should be saved. eg: light.patio</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record SaverSetVariableParameters
	{
		///<summary>Name of the variable to save. eg: counter</summary>
		[JsonPropertyName("name")]
		public object? Name { get; init; }

		///<summary>The new value eg: 3</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }
	}

	public class SceneServices
	{
		private readonly IHaContext _haContext;
		public SceneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new SceneApplyParameters{Entities = @entities, Transition = @transition});
		}

		///<summary>Creates a new scene.</summary>
		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		///<summary>Creates a new scene.</summary>
		///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</param>
		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new SceneCreateParameters{SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities});
		}

		///<summary>Reload the scene configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</summary>
		[JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class SchedulerServices
	{
		private readonly IHaContext _haContext;
		public SchedulerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a new schedule entity</summary>
		public void Add(SchedulerAddParameters data)
		{
			_haContext.CallService("scheduler", "add", null, data);
		}

		///<summary>Create a new schedule entity</summary>
		///<param name="weekdays">Days of the week for which the schedule should be repeated eg: ["daily"]</param>
		///<param name="startDate">Date from which schedule should be executed eg: ["2021-01-01"]</param>
		///<param name="endDate">Date until which schedule should be executed eg: ["2021-12-31"]</param>
		///<param name="timeslots">list of timeslots with their actions and optionally conditions (should be kept the same for all timeslots) eg: [{start: "12:00", stop: "13:00", actions: [{service: "light.turn_on", entity_id: "light.my_lamp", service_data: {brightness: 200}}]}]</param>
		///<param name="repeatType">Control what happens after the schedule is triggered eg: "repeat"</param>
		///<param name="name">Friendly name for the schedule eg: My schedule</param>
		public void Add(object @timeslots, object @repeatType, object? @weekdays = null, object? @startDate = null, object? @endDate = null, string? @name = null)
		{
			_haContext.CallService("scheduler", "add", null, new SchedulerAddParameters{Weekdays = @weekdays, StartDate = @startDate, EndDate = @endDate, Timeslots = @timeslots, RepeatType = @repeatType, Name = @name});
		}

		///<summary>Duplicate a schedule entity</summary>
		public void Copy(SchedulerCopyParameters data)
		{
			_haContext.CallService("scheduler", "copy", null, data);
		}

		///<summary>Duplicate a schedule entity</summary>
		///<param name="entityId">Identifier of the scheduler entity. eg: switch.schedule_abcdef</param>
		///<param name="name">Friendly name for the copied schedule eg: My schedule</param>
		public void Copy(string @entityId, string? @name = null)
		{
			_haContext.CallService("scheduler", "copy", null, new SchedulerCopyParameters{EntityId = @entityId, Name = @name});
		}

		///<summary>Edit a schedule entity</summary>
		public void Edit(SchedulerEditParameters data)
		{
			_haContext.CallService("scheduler", "edit", null, data);
		}

		///<summary>Edit a schedule entity</summary>
		///<param name="entityId">Identifier of the scheduler entity. eg: switch.schedule_abcdef</param>
		///<param name="weekdays">Days of the week for which the schedule should be repeated eg: ["daily"]</param>
		///<param name="startDate">Date from which schedule should be executed eg: ["2021-01-01"]</param>
		///<param name="endDate">Date until which schedule should be executed eg: ["2021-12-31"]</param>
		///<param name="timeslots">list of timeslots with their actions and optionally conditions (should be kept the same for all timeslots) eg: [{start: "12:00", stop: "13:00", actions: [{service: "light.turn_on", entity_id: "light.my_lamp", service_data: {brightness: 200}}]}]</param>
		///<param name="repeatType">Control what happens after the schedule is triggered eg: "repeat"</param>
		///<param name="name">Friendly name for the schedule eg: My schedule</param>
		public void Edit(string @entityId, object? @weekdays = null, object? @startDate = null, object? @endDate = null, object? @timeslots = null, object? @repeatType = null, string? @name = null)
		{
			_haContext.CallService("scheduler", "edit", null, new SchedulerEditParameters{EntityId = @entityId, Weekdays = @weekdays, StartDate = @startDate, EndDate = @endDate, Timeslots = @timeslots, RepeatType = @repeatType, Name = @name});
		}

		///<summary>Remove a schedule entity</summary>
		public void Remove(SchedulerRemoveParameters data)
		{
			_haContext.CallService("scheduler", "remove", null, data);
		}

		///<summary>Remove a schedule entity</summary>
		///<param name="entityId">Identifier of the scheduler entity. eg: switch.schedule_abcdef</param>
		public void Remove(string @entityId)
		{
			_haContext.CallService("scheduler", "remove", null, new SchedulerRemoveParameters{EntityId = @entityId});
		}

		///<summary>Execute the action of a schedule, optionally at a given time.</summary>
		public void RunAction(SchedulerRunActionParameters data)
		{
			_haContext.CallService("scheduler", "run_action", null, data);
		}

		///<summary>Execute the action of a schedule, optionally at a given time.</summary>
		///<param name="entityId">Identifier of the scheduler entity. eg: switch.schedule_abcdef</param>
		///<param name="time">Time for which to evaluate the action (only useful for schedules with multiple timeslot) eg: "12:00"</param>
		public void RunAction(string @entityId, DateTime? @time = null)
		{
			_haContext.CallService("scheduler", "run_action", null, new SchedulerRunActionParameters{EntityId = @entityId, Time = @time});
		}
	}

	public record SchedulerAddParameters
	{
		///<summary>Days of the week for which the schedule should be repeated eg: ["daily"]</summary>
		[JsonPropertyName("weekdays")]
		public object? Weekdays { get; init; }

		///<summary>Date from which schedule should be executed eg: ["2021-01-01"]</summary>
		[JsonPropertyName("start_date")]
		public object? StartDate { get; init; }

		///<summary>Date until which schedule should be executed eg: ["2021-12-31"]</summary>
		[JsonPropertyName("end_date")]
		public object? EndDate { get; init; }

		///<summary>list of timeslots with their actions and optionally conditions (should be kept the same for all timeslots) eg: [{start: "12:00", stop: "13:00", actions: [{service: "light.turn_on", entity_id: "light.my_lamp", service_data: {brightness: 200}}]}]</summary>
		[JsonPropertyName("timeslots")]
		public object? Timeslots { get; init; }

		///<summary>Control what happens after the schedule is triggered eg: "repeat"</summary>
		[JsonPropertyName("repeat_type")]
		public object? RepeatType { get; init; }

		///<summary>Friendly name for the schedule eg: My schedule</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record SchedulerCopyParameters
	{
		///<summary>Identifier of the scheduler entity. eg: switch.schedule_abcdef</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Friendly name for the copied schedule eg: My schedule</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record SchedulerEditParameters
	{
		///<summary>Identifier of the scheduler entity. eg: switch.schedule_abcdef</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Days of the week for which the schedule should be repeated eg: ["daily"]</summary>
		[JsonPropertyName("weekdays")]
		public object? Weekdays { get; init; }

		///<summary>Date from which schedule should be executed eg: ["2021-01-01"]</summary>
		[JsonPropertyName("start_date")]
		public object? StartDate { get; init; }

		///<summary>Date until which schedule should be executed eg: ["2021-12-31"]</summary>
		[JsonPropertyName("end_date")]
		public object? EndDate { get; init; }

		///<summary>list of timeslots with their actions and optionally conditions (should be kept the same for all timeslots) eg: [{start: "12:00", stop: "13:00", actions: [{service: "light.turn_on", entity_id: "light.my_lamp", service_data: {brightness: 200}}]}]</summary>
		[JsonPropertyName("timeslots")]
		public object? Timeslots { get; init; }

		///<summary>Control what happens after the schedule is triggered eg: "repeat"</summary>
		[JsonPropertyName("repeat_type")]
		public object? RepeatType { get; init; }

		///<summary>Friendly name for the schedule eg: My schedule</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record SchedulerRemoveParameters
	{
		///<summary>Identifier of the scheduler entity. eg: switch.schedule_abcdef</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record SchedulerRunActionParameters
	{
		///<summary>Identifier of the scheduler entity. eg: switch.schedule_abcdef</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Time for which to evaluate the action (only useful for schedules with multiple timeslot) eg: "12:00"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }
	}

	public class ScriptServices
	{
		private readonly IHaContext _haContext;
		public ScriptServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void HA00LgTvWoonkamerAanzetten()
		{
			_haContext.CallService("script", "00_lg_tv_woonkamer_aanzetten", null);
		}

		public void HA00SpotifySourceZetOpLgTvWoonkamer()
		{
			_haContext.CallService("script", "00_spotify_source_zet_op_lg_tv_woonkamer", null);
		}

		public void HA00StartSpotifyOpLgTvWoonkamer()
		{
			_haContext.CallService("script", "00_start_spotify_op_lg_tv_woonkamer", null);
		}

		public void HA01SpotifyAppStartenOpLgTvWoonkamer()
		{
			_haContext.CallService("script", "01_spotify_app_starten_op_lg_tv_woonkamer", null);
		}

		public void HA010DenonInputOpTvAudio()
		{
			_haContext.CallService("script", "010_denon_input_op_tv_audio", null);
		}

		public void HA02SelecteerInputLiveTvOpLgTvWoonkamer()
		{
			_haContext.CallService("script", "02_selecteer_input_live_tv_op_lg_tv_woonkamer", null);
		}

		public void HA03CastMuziekVanSpotifyBabyYodaOpLgTvWoonkamer()
		{
			_haContext.CallService("script", "03_cast_muziek_van_spotify_baby_yoda_op_lg_tv_woonkamer", null);
		}

		public void HA032CastMuziekVanSpotifyBabyYodaOpDenonX2200w()
		{
			_haContext.CallService("script", "032_cast_muziek_van_spotify_baby_yoda_op_denon_x2200w", null);
		}

		public void HA04StartSpotifyOpLgWoonkamerV2()
		{
			_haContext.CallService("script", "04_start_spotify_op_lg_woonkamer_v2", null);
		}

		public void HA04TransferSpotifyToLgWoonkamerV1()
		{
			_haContext.CallService("script", "04_transfer_spotify_to_lg_woonkamer_v1", null);
		}

		public void HA050SendCustomEvent()
		{
			_haContext.CallService("script", "050_send_custom_event", null);
		}

		public void HA1660661182752()
		{
			_haContext.CallService("script", "1660661182752", null);
		}

		public void HA1660661226923(ScriptHA1660661226923Parameters data)
		{
			_haContext.CallService("script", "1660661226923", null, data);
		}

		///<param name="entityId">entity to be turned-off</param>
		public void HA1660661226923(object? @entityId = null)
		{
			_haContext.CallService("script", "1660661226923", null, new ScriptHA1660661226923Parameters{EntityId = @entityId});
		}

		public void HA401MaysonExtraSlaapjeModusV1()
		{
			_haContext.CallService("script", "401_mayson_extra_slaapje_modus_v1", null);
		}

		public void HA402UitzettenMaysonExtraSlaapjeModusV1()
		{
			_haContext.CallService("script", "402_uitzetten_mayson_extra_slaapje_modus_v1", null);
		}

		public void HA80SaveStateBeforeDoorbellTring()
		{
			_haContext.CallService("script", "80_save_state_before_doorbell_tring", null);
		}

		public void HA81PauzeerAllesAlsDeDeurbelGaat()
		{
			_haContext.CallService("script", "81_pauzeer_alles_als_de_deurbel_gaat", null);
		}

		public void HA82RestoreStateBeforeDoorbellTring()
		{
			_haContext.CallService("script", "82_restore_state_before_doorbell_tring", null);
		}

		public void HA85SayMotionDetectedInSlaapkamerTrap()
		{
			_haContext.CallService("script", "85_say_motion_detected_in_slaapkamer_trap", null);
		}

		public void HA881DeurbelRingFlashLights01()
		{
			_haContext.CallService("script", "88_1_deurbel_ring_flash_lights_01", null);
		}

		public void HA882DeurbellTring01()
		{
			_haContext.CallService("script", "88_2_deurbell_tring_01", null);
		}

		public void HA882StuurNotificatieDeurbellTringNaarGroep()
		{
			_haContext.CallService("script", "88_2_stuur_notificatie_deurbell_tring_naar_groep", null);
		}

		public void HA883DeurbelTringTtsGoogleHome01()
		{
			_haContext.CallService("script", "88_3_deurbel_tring_tts_google_home_01", null);
		}

		public void HA88DeurbelRing01()
		{
			_haContext.CallService("script", "88_deurbel_ring_01", null);
		}

		public void Foscam1PlafondDienst1Actief()
		{
			_haContext.CallService("script", "foscam1_plafond_dienst_1_actief", null);
		}

		public void LightTurnOff(ScriptLightTurnOffParameters data)
		{
			_haContext.CallService("script", "light_turn_off", null, data);
		}

		///<param name="targetLight">Turn off light with transition eg: light.trap_slaapkamer</param>
		public void LightTurnOff(string? @targetLight = null)
		{
			_haContext.CallService("script", "light_turn_off", null, new ScriptLightTurnOffParameters{TargetLight = @targetLight});
		}

		public void PydoorbellButton2()
		{
			_haContext.CallService("script", "pydoorbell_button_2", null);
		}

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		///<summary>Set select options for GMotions</summary>
		public void SetSelectOptionsForScenes(ScriptSetSelectOptionsForScenesParameters data)
		{
			_haContext.CallService("script", "set_select_options_for_scenes", null, data);
		}

		///<summary>Set select options for GMotions</summary>
		///<param name="roomname">Name of room. eg. Hal</param>
		///<param name="targetInputSelect">Id of input_select helper</param>
		public void SetSelectOptionsForScenes(string? @roomname = null, string? @targetInputSelect = null)
		{
			_haContext.CallService("script", "set_select_options_for_scenes", null, new ScriptSetSelectOptionsForScenesParameters{Roomname = @roomname, TargetInputSelect = @targetInputSelect});
		}

		public void StreamFoscam1ChromecastSlaapkamer1()
		{
			_haContext.CallService("script", "stream_foscam1_chromecast_slaapkamer_1", null);
		}

		public void StreamToLgtv01()
		{
			_haContext.CallService("script", "stream_to_lgtv_01", null);
		}

		public void StreamToLgtv012()
		{
			_haContext.CallService("script", "stream_to_lgtv_01_2", null);
		}

		public void StuurBerichtNaarBrowserMod()
		{
			_haContext.CallService("script", "stuur_bericht_naar_browser_mod", null);
		}

		public void ThemaSetHuidige()
		{
			_haContext.CallService("script", "thema_set_huidige", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public record ScriptHA1660661226923Parameters
	{
		///<summary>entity to be turned-off</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record ScriptLightTurnOffParameters
	{
		///<summary>Turn off light with transition eg: light.trap_slaapkamer</summary>
		[JsonPropertyName("target_light")]
		public string? TargetLight { get; init; }
	}

	public record ScriptSetSelectOptionsForScenesParameters
	{
		///<summary>Name of room. eg. Hal</summary>
		[JsonPropertyName("roomname")]
		public string? Roomname { get; init; }

		///<summary>Id of input_select helper</summary>
		[JsonPropertyName("target_input_select")]
		public string? TargetInputSelect { get; init; }
	}

	public class SelectServices
	{
		private readonly IHaContext _haContext;
		public SelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class SirenServices
	{
		private readonly IHaContext _haContext;
		public SirenServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0,5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0,5</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SpotcastServices
	{
		private readonly IHaContext _haContext;
		public SpotcastServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Starts spotify playback on chromecast devices</summary>
		public void Start(SpotcastStartParameters data)
		{
			_haContext.CallService("spotcast", "start", null, data);
		}

		///<summary>Starts spotify playback on chromecast devices</summary>
		///<param name="deviceName">The friendly name of the chromecast or spotify connect device. First checks spotify device list for name (not used together with entity_id and spotify_device_id). eg: Livingroom</param>
		///<param name="spotifyDeviceId">Advanced users only. The spotify device id (not used together with entity_id or device_name). eg: 4363634563457346xcyvydgf3qwa</param>
		///<param name="entityId">The entity_id of the chromecast mediaplayer. Friendly name MUST match the spotify connect device name (not used together with device_name and spotify_device_id). eg: media_player.vardagsrum</param>
		///<param name="uri">Supported Spotify URI as string. None or empty uri will transfer the current/last playback (see parameter force_playback). eg: spotify:playlist:37i9dQZF1DX3yvAYDslnv8</param>
		///<param name="category">A category to fetch playlist from. See https://developer.spotify.com/console/get-browse-categories/ for a list of categories</param>
		///<param name="country">Country code to use with category. See https://spotipy.readthedocs.io/en/2.19.0/#spotipy.client.Spotify.country_codes for list of available codes</param>
		///<param name="limit">Limit of playlist to fetch in a given category. Default 20</param>
		///<param name="search">A Search request to the spotify API. Will play the most relevant search result.</param>
		///<param name="account">Optionally starts Spotify using an alternative account specified in config. eg: my_wifes</param>
		///<param name="forcePlayback">In case of transfering playback: If true starts playing the user's last playback even if nothing is currently playing. eg: True</param>
		///<param name="randomSong">Starts the playback at a random position in the playlist or album. eg: True</param>
		///<param name="repeat">Set repeat mode for playback. eg: track</param>
		///<param name="shuffle">Set shuffle mode for playback. eg: True</param>
		///<param name="offset">Set offset mode for playback. 0 is the first song. eg: 1</param>
		///<param name="startVolume">Set the volume for playback in percentage. eg: 50</param>
		///<param name="ignoreFullyPlayed">Set to ignore or not already played episodes in a podcast playlist eg: True</param>
		public void Start(string? @deviceName = null, string? @spotifyDeviceId = null, string? @entityId = null, string? @uri = null, string? @category = null, string? @country = null, long? @limit = null, string? @search = null, string? @account = null, bool? @forcePlayback = null, bool? @randomSong = null, object? @repeat = null, bool? @shuffle = null, long? @offset = null, long? @startVolume = null, bool? @ignoreFullyPlayed = null)
		{
			_haContext.CallService("spotcast", "start", null, new SpotcastStartParameters{DeviceName = @deviceName, SpotifyDeviceId = @spotifyDeviceId, EntityId = @entityId, Uri = @uri, Category = @category, Country = @country, Limit = @limit, Search = @search, Account = @account, ForcePlayback = @forcePlayback, RandomSong = @randomSong, Repeat = @repeat, Shuffle = @shuffle, Offset = @offset, StartVolume = @startVolume, IgnoreFullyPlayed = @ignoreFullyPlayed});
		}
	}

	public record SpotcastStartParameters
	{
		///<summary>The friendly name of the chromecast or spotify connect device. First checks spotify device list for name (not used together with entity_id and spotify_device_id). eg: Livingroom</summary>
		[JsonPropertyName("device_name")]
		public string? DeviceName { get; init; }

		///<summary>Advanced users only. The spotify device id (not used together with entity_id or device_name). eg: 4363634563457346xcyvydgf3qwa</summary>
		[JsonPropertyName("spotify_device_id")]
		public string? SpotifyDeviceId { get; init; }

		///<summary>The entity_id of the chromecast mediaplayer. Friendly name MUST match the spotify connect device name (not used together with device_name and spotify_device_id). eg: media_player.vardagsrum</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Supported Spotify URI as string. None or empty uri will transfer the current/last playback (see parameter force_playback). eg: spotify:playlist:37i9dQZF1DX3yvAYDslnv8</summary>
		[JsonPropertyName("uri")]
		public string? Uri { get; init; }

		///<summary>A category to fetch playlist from. See https://developer.spotify.com/console/get-browse-categories/ for a list of categories</summary>
		[JsonPropertyName("category")]
		public string? Category { get; init; }

		///<summary>Country code to use with category. See https://spotipy.readthedocs.io/en/2.19.0/#spotipy.client.Spotify.country_codes for list of available codes</summary>
		[JsonPropertyName("country")]
		public string? Country { get; init; }

		///<summary>Limit of playlist to fetch in a given category. Default 20</summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }

		///<summary>A Search request to the spotify API. Will play the most relevant search result.</summary>
		[JsonPropertyName("search")]
		public string? Search { get; init; }

		///<summary>Optionally starts Spotify using an alternative account specified in config. eg: my_wifes</summary>
		[JsonPropertyName("account")]
		public string? Account { get; init; }

		///<summary>In case of transfering playback: If true starts playing the user's last playback even if nothing is currently playing. eg: True</summary>
		[JsonPropertyName("force_playback")]
		public bool? ForcePlayback { get; init; }

		///<summary>Starts the playback at a random position in the playlist or album. eg: True</summary>
		[JsonPropertyName("random_song")]
		public bool? RandomSong { get; init; }

		///<summary>Set repeat mode for playback. eg: track</summary>
		[JsonPropertyName("repeat")]
		public object? Repeat { get; init; }

		///<summary>Set shuffle mode for playback. eg: True</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }

		///<summary>Set offset mode for playback. 0 is the first song. eg: 1</summary>
		[JsonPropertyName("offset")]
		public long? Offset { get; init; }

		///<summary>Set the volume for playback in percentage. eg: 50</summary>
		[JsonPropertyName("start_volume")]
		public long? StartVolume { get; init; }

		///<summary>Set to ignore or not already played episodes in a podcast playlist eg: True</summary>
		[JsonPropertyName("ignore_fully_played")]
		public bool? IgnoreFullyPlayed { get; init; }
	}

	public class SwitchServices
	{
		private readonly IHaContext _haContext;
		public SwitchServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SynologyDsmServices
	{
		private readonly IHaContext _haContext;
		public SynologyDsmServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reboot the NAS. This service is deprecated and will be removed in future release. Please use the corresponding button entity.</summary>
		public void Reboot(SynologyDsmRebootParameters data)
		{
			_haContext.CallService("synology_dsm", "reboot", null, data);
		}

		///<summary>Reboot the NAS. This service is deprecated and will be removed in future release. Please use the corresponding button entity.</summary>
		///<param name="serial">serial of the NAS to reboot; required when multiple NAS are configured. eg: 1NDVC86409</param>
		public void Reboot(string? @serial = null)
		{
			_haContext.CallService("synology_dsm", "reboot", null, new SynologyDsmRebootParameters{Serial = @serial});
		}

		///<summary>Shutdown the NAS. This service is deprecated and will be removed in future release. Please use the corresponding button entity.</summary>
		public void Shutdown(SynologyDsmShutdownParameters data)
		{
			_haContext.CallService("synology_dsm", "shutdown", null, data);
		}

		///<summary>Shutdown the NAS. This service is deprecated and will be removed in future release. Please use the corresponding button entity.</summary>
		///<param name="serial">serial of the NAS to shutdown; required when multiple NAS are configured. eg: 1NDVC86409</param>
		public void Shutdown(string? @serial = null)
		{
			_haContext.CallService("synology_dsm", "shutdown", null, new SynologyDsmShutdownParameters{Serial = @serial});
		}
	}

	public record SynologyDsmRebootParameters
	{
		///<summary>serial of the NAS to reboot; required when multiple NAS are configured. eg: 1NDVC86409</summary>
		[JsonPropertyName("serial")]
		public string? Serial { get; init; }
	}

	public record SynologyDsmShutdownParameters
	{
		///<summary>serial of the NAS to shutdown; required when multiple NAS are configured. eg: 1NDVC86409</summary>
		[JsonPropertyName("serial")]
		public string? Serial { get; init; }
	}

	public class SystemLogServices
	{
		private readonly IHaContext _haContext;
		public SystemLogServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear all log entries.</summary>
		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		///<summary>Write log entry.</summary>
		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		///<summary>Write log entry.</summary>
		///<param name="message">Message to log. eg: Something went wrong</param>
		///<param name="level">Log level.</param>
		///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
		public void Write(string @message, object? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[JsonPropertyName("level")]
		public object? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TemplateServices
	{
		private readonly IHaContext _haContext;
		public TemplateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all template entities.</summary>
		public void Reload()
		{
			_haContext.CallService("template", "reload", null);
		}
	}

	public class TimerServices
	{
		private readonly IHaContext _haContext;
		public TimerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TtsServices
	{
		private readonly IHaContext _haContext;
		public TtsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
		public void ClearCache()
		{
			_haContext.CallService("tts", "clear_cache", null);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		public void GoogleSay(TtsGoogleSayParameters data)
		{
			_haContext.CallService("tts", "google_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void GoogleSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "google_say", null, new TtsGoogleSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}

		///<summary>Say something using text-to-speech on a media player with picotts.</summary>
		public void PicottsSay(TtsPicottsSayParameters data)
		{
			_haContext.CallService("tts", "picotts_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with picotts.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void PicottsSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "picotts_say", null, new TtsPicottsSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}
	}

	public record TtsGoogleSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record TtsPicottsSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class UpdateServices
	{
		private readonly IHaContext _haContext;
		public UpdateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearSkipped(ServiceTarget target)
		{
			_haContext.CallService("update", "clear_skipped", target);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		public void Install(ServiceTarget target, UpdateInstallParameters data)
		{
			_haContext.CallService("update", "install", target, data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public void Install(ServiceTarget target, string? @version = null, bool? @backup = null)
		{
			_haContext.CallService("update", "install", target, new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		///<param name="target">The target for this service call</param>
		public void Skip(ServiceTarget target)
		{
			_haContext.CallService("update", "skip", target);
		}
	}

	public record UpdateInstallParameters
	{
		///<summary>Version to install, if omitted, the latest version will be installed. eg: 1.0.0</summary>
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		///<summary>Backup before installing the update, if supported by the integration.</summary>
		[JsonPropertyName("backup")]
		public bool? Backup { get; init; }
	}

	public class VacuumServices
	{
		private readonly IHaContext _haContext;
		public VacuumServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class VarServices
	{
		private readonly IHaContext _haContext;
		public VarServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("var", "reload", null);
		}

		///<summary>Set attributes of a variable entity.</summary>
		public void Set(VarSetParameters data)
		{
			_haContext.CallService("var", "set", null, data);
		}

		///<summary>Set attributes of a variable entity.</summary>
		///<param name="entityId">Entity id of the variable whose value will be set. eg: var.x</param>
		///<param name="value">The new value for the variable entity. eg: 13</param>
		///<param name="valueTemplate">The new value template for the variable entity. eg: {{ input_boolean.foo }}</param>
		///<param name="attributes">Additional attributes to set for the variable entity. eg: attr1: 42 attr2: "{{ now() }}" </param>
		///<param name="trackedEntityId">The new list of entities for the variable entity to track. eg: input_boolean.bar</param>
		///<param name="trackedEventType">The new list of event types for the variable entity to track. eg: sunset</param>
		///<param name="query">An SQL QUERY string, should return 1 result at most. eg: SELECT COUNT(*) AS todays_diaper_count FROM events WHERE event_type = 'diaper_event' AND time_fired BETWEEN DATETIME('now', 'start of day') and DATETIME('now');</param>
		///<param name="column">The SQL COLUMN to select from the result of the SQL QUERY. eg: todays_diaper_count</param>
		///<param name="restore">The new restore value for the variable entity. eg: False</param>
		///<param name="forceUpdate">The new force_update value for the variable entity. eg: True</param>
		///<param name="unitOfMeasurement">The new unit of measurement for the variable entity. eg: ounces</param>
		///<param name="icon">The new icon for the variable entity. eg: mdi:baby-bottle-outline</param>
		///<param name="iconTemplate">The new icon template for the variable entity.</param>
		///<param name="entityPicture">The new picture for the variable entity. eg: local/pic.png</param>
		///<param name="entityPictureTemplate">The new picture template for the variable entity.</param>
		public void Set(object? @entityId = null, object? @value = null, object? @valueTemplate = null, object? @attributes = null, object? @trackedEntityId = null, object? @trackedEventType = null, object? @query = null, object? @column = null, object? @restore = null, object? @forceUpdate = null, object? @unitOfMeasurement = null, object? @icon = null, object? @iconTemplate = null, object? @entityPicture = null, object? @entityPictureTemplate = null)
		{
			_haContext.CallService("var", "set", null, new VarSetParameters{EntityId = @entityId, Value = @value, ValueTemplate = @valueTemplate, Attributes = @attributes, TrackedEntityId = @trackedEntityId, TrackedEventType = @trackedEventType, Query = @query, Column = @column, Restore = @restore, ForceUpdate = @forceUpdate, UnitOfMeasurement = @unitOfMeasurement, Icon = @icon, IconTemplate = @iconTemplate, EntityPicture = @entityPicture, EntityPictureTemplate = @entityPictureTemplate});
		}

		///<summary>Force a variable to update its state and atttributes.</summary>
		public void Update(VarUpdateParameters data)
		{
			_haContext.CallService("var", "update", null, data);
		}

		///<summary>Force a variable to update its state and atttributes.</summary>
		///<param name="entityId">Entity id of the variable that will be updated. eg: var.x</param>
		public void Update(object? @entityId = null)
		{
			_haContext.CallService("var", "update", null, new VarUpdateParameters{EntityId = @entityId});
		}
	}

	public record VarSetParameters
	{
		///<summary>Entity id of the variable whose value will be set. eg: var.x</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The new value for the variable entity. eg: 13</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }

		///<summary>The new value template for the variable entity. eg: {{ input_boolean.foo }}</summary>
		[JsonPropertyName("value_template")]
		public object? ValueTemplate { get; init; }

		///<summary>Additional attributes to set for the variable entity. eg: attr1: 42 attr2: "{{ now() }}" </summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }

		///<summary>The new list of entities for the variable entity to track. eg: input_boolean.bar</summary>
		[JsonPropertyName("tracked_entity_id")]
		public object? TrackedEntityId { get; init; }

		///<summary>The new list of event types for the variable entity to track. eg: sunset</summary>
		[JsonPropertyName("tracked_event_type")]
		public object? TrackedEventType { get; init; }

		///<summary>An SQL QUERY string, should return 1 result at most. eg: SELECT COUNT(*) AS todays_diaper_count FROM events WHERE event_type = 'diaper_event' AND time_fired BETWEEN DATETIME('now', 'start of day') and DATETIME('now');</summary>
		[JsonPropertyName("query")]
		public object? Query { get; init; }

		///<summary>The SQL COLUMN to select from the result of the SQL QUERY. eg: todays_diaper_count</summary>
		[JsonPropertyName("column")]
		public object? Column { get; init; }

		///<summary>The new restore value for the variable entity. eg: False</summary>
		[JsonPropertyName("restore")]
		public object? Restore { get; init; }

		///<summary>The new force_update value for the variable entity. eg: True</summary>
		[JsonPropertyName("force_update")]
		public object? ForceUpdate { get; init; }

		///<summary>The new unit of measurement for the variable entity. eg: ounces</summary>
		[JsonPropertyName("unit_of_measurement")]
		public object? UnitOfMeasurement { get; init; }

		///<summary>The new icon for the variable entity. eg: mdi:baby-bottle-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The new icon template for the variable entity.</summary>
		[JsonPropertyName("icon_template")]
		public object? IconTemplate { get; init; }

		///<summary>The new picture for the variable entity. eg: local/pic.png</summary>
		[JsonPropertyName("entity_picture")]
		public object? EntityPicture { get; init; }

		///<summary>The new picture template for the variable entity.</summary>
		[JsonPropertyName("entity_picture_template")]
		public object? EntityPictureTemplate { get; init; }
	}

	public record VarUpdateParameters
	{
		///<summary>Entity id of the variable that will be updated. eg: var.x</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public class VirtualServices
	{
		private readonly IHaContext _haContext;
		public VirtualServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set availability of a entity.</summary>
		public void SetAvailable(VirtualSetAvailableParameters data)
		{
			_haContext.CallService("virtual", "set_available", null, data);
		}

		///<summary>Set availability of a entity.</summary>
		///<param name="entityId">Name(s) of entities to set eg: switch.virtual_switch_1</param>
		///<param name="value">Value to set eg: False</param>
		public void SetAvailable(object? @entityId = null, object? @value = null)
		{
			_haContext.CallService("virtual", "set_available", null, new VirtualSetAvailableParameters{EntityId = @entityId, Value = @value});
		}

		///<summary>Toggle a binary sensor.</summary>
		public void Toggle(VirtualToggleParameters data)
		{
			_haContext.CallService("virtual", "toggle", null, data);
		}

		///<summary>Toggle a binary sensor.</summary>
		///<param name="entityId">Name(s) of entities to toggle eg: binary_sensor.virtual_motion_1</param>
		public void Toggle(object? @entityId = null)
		{
			_haContext.CallService("virtual", "toggle", null, new VirtualToggleParameters{EntityId = @entityId});
		}

		///<summary>Turn off a binary sensor.</summary>
		public void TurnOff(VirtualTurnOffParameters data)
		{
			_haContext.CallService("virtual", "turn_off", null, data);
		}

		///<summary>Turn off a binary sensor.</summary>
		///<param name="entityId">Name(s) of entities to turn off eg: binary_sensor.virtual_motion_1</param>
		public void TurnOff(object? @entityId = null)
		{
			_haContext.CallService("virtual", "turn_off", null, new VirtualTurnOffParameters{EntityId = @entityId});
		}

		///<summary>Turn on a binary sensor.</summary>
		public void TurnOn(VirtualTurnOnParameters data)
		{
			_haContext.CallService("virtual", "turn_on", null, data);
		}

		///<summary>Turn on a binary sensor.</summary>
		///<param name="entityId">Name(s) of entities to turn on eg: binary_sensor.virtual_motion_1</param>
		public void TurnOn(object? @entityId = null)
		{
			_haContext.CallService("virtual", "turn_on", null, new VirtualTurnOnParameters{EntityId = @entityId});
		}
	}

	public record VirtualSetAvailableParameters
	{
		///<summary>Name(s) of entities to set eg: switch.virtual_switch_1</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Value to set eg: False</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }
	}

	public record VirtualToggleParameters
	{
		///<summary>Name(s) of entities to toggle eg: binary_sensor.virtual_motion_1</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record VirtualTurnOffParameters
	{
		///<summary>Name(s) of entities to turn off eg: binary_sensor.virtual_motion_1</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record VirtualTurnOnParameters
	{
		///<summary>Name(s) of entities to turn on eg: binary_sensor.virtual_motion_1</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public class WakeOnLanServices
	{
		private readonly IHaContext _haContext;
		public WakeOnLanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a 'magic packet' to wake up a device with 'Wake-On-LAN' capabilities.</summary>
		public void SendMagicPacket(WakeOnLanSendMagicPacketParameters data)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, data);
		}

		///<summary>Send a 'magic packet' to wake up a device with 'Wake-On-LAN' capabilities.</summary>
		///<param name="mac">MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</param>
		///<param name="broadcastAddress">Broadcast IP where to send the magic packet. eg: 192.168.255.255</param>
		///<param name="broadcastPort">Port where to send the magic packet.</param>
		public void SendMagicPacket(string @mac, string? @broadcastAddress = null, long? @broadcastPort = null)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, new WakeOnLanSendMagicPacketParameters{Mac = @mac, BroadcastAddress = @broadcastAddress, BroadcastPort = @broadcastPort});
		}
	}

	public record WakeOnLanSendMagicPacketParameters
	{
		///<summary>MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Broadcast IP where to send the magic packet. eg: 192.168.255.255</summary>
		[JsonPropertyName("broadcast_address")]
		public string? BroadcastAddress { get; init; }

		///<summary>Port where to send the magic packet.</summary>
		[JsonPropertyName("broadcast_port")]
		public long? BroadcastPort { get; init; }
	}

	public class WebostvServices
	{
		private readonly IHaContext _haContext;
		public WebostvServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a button press command.</summary>
		public void Button(WebostvButtonParameters data)
		{
			_haContext.CallService("webostv", "button", null, data);
		}

		///<summary>Send a button press command.</summary>
		///<param name="entityId">Name(s) of the webostv entities where to run the API method.</param>
		///<param name="button">Name of the button to press.  Known possible values are LEFT, RIGHT, DOWN, UP, HOME, MENU, BACK, ENTER, DASH, INFO, ASTERISK, CC, EXIT, MUTE, RED, GREEN, BLUE, VOLUMEUP, VOLUMEDOWN, CHANNELUP, CHANNELDOWN, PLAY, PAUSE, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 eg: LEFT</param>
		public void Button(string @entityId, string @button)
		{
			_haContext.CallService("webostv", "button", null, new WebostvButtonParameters{EntityId = @entityId, Button = @button});
		}

		///<summary>Send a command.</summary>
		public void Command(WebostvCommandParameters data)
		{
			_haContext.CallService("webostv", "command", null, data);
		}

		///<summary>Send a command.</summary>
		///<param name="entityId">Name(s) of the webostv entities where to run the API method.</param>
		///<param name="command">Endpoint of the command. eg: system.launcher/open</param>
		///<param name="payload">An optional payload to provide to the endpoint in the format of key value pair(s). eg: target: https://www.google.com</param>
		public void Command(string @entityId, string @command, object? @payload = null)
		{
			_haContext.CallService("webostv", "command", null, new WebostvCommandParameters{EntityId = @entityId, Command = @command, Payload = @payload});
		}

		///<summary>Send the TV the command to change sound output.</summary>
		public void SelectSoundOutput(WebostvSelectSoundOutputParameters data)
		{
			_haContext.CallService("webostv", "select_sound_output", null, data);
		}

		///<summary>Send the TV the command to change sound output.</summary>
		///<param name="entityId">Name(s) of the webostv entities to change sound output on.</param>
		///<param name="soundOutput">Name of the sound output to switch to. eg: external_speaker</param>
		public void SelectSoundOutput(string @entityId, string @soundOutput)
		{
			_haContext.CallService("webostv", "select_sound_output", null, new WebostvSelectSoundOutputParameters{EntityId = @entityId, SoundOutput = @soundOutput});
		}
	}

	public record WebostvButtonParameters
	{
		///<summary>Name(s) of the webostv entities where to run the API method.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Name of the button to press.  Known possible values are LEFT, RIGHT, DOWN, UP, HOME, MENU, BACK, ENTER, DASH, INFO, ASTERISK, CC, EXIT, MUTE, RED, GREEN, BLUE, VOLUMEUP, VOLUMEDOWN, CHANNELUP, CHANNELDOWN, PLAY, PAUSE, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 eg: LEFT</summary>
		[JsonPropertyName("button")]
		public string? Button { get; init; }
	}

	public record WebostvCommandParameters
	{
		///<summary>Name(s) of the webostv entities where to run the API method.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Endpoint of the command. eg: system.launcher/open</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>An optional payload to provide to the endpoint in the format of key value pair(s). eg: target: https://www.google.com</summary>
		[JsonPropertyName("payload")]
		public object? Payload { get; init; }
	}

	public record WebostvSelectSoundOutputParameters
	{
		///<summary>Name(s) of the webostv entities to change sound output on.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Name of the sound output to switch to. eg: external_speaker</summary>
		[JsonPropertyName("sound_output")]
		public string? SoundOutput { get; init; }
	}

	public class WebrtcServices
	{
		private readonly IHaContext _haContext;
		public WebrtcServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a temporary or permanent link to a stream (enter "url" or "entity")</summary>
		public void CreateLink(WebrtcCreateLinkParameters data)
		{
			_haContext.CallService("webrtc", "create_link", null, data);
		}

		///<summary>Create a temporary or permanent link to a stream (enter "url" or "entity")</summary>
		///<param name="linkId">Create a random or permanent ID for your link eg: fd0a53ca-e9ab-4e7a-86a2-441642b16ae1</param>
		///<param name="url">Link to RTSP-stream eg: rtsp://rtsp:12345678@192.168.1.123:554/av_stream/ch0</param>
		///<param name="entity">Camera entity eg: camera.generic_stream</param>
		///<param name="openLimit">How many times a link can be opened (0 - unlimit) eg: 1</param>
		///<param name="timeToLive">How many seconds will the link live (0 - unlimit) eg: 60</param>
		public void CreateLink(string @linkId, string? @url = null, string? @entity = null, long? @openLimit = null, long? @timeToLive = null)
		{
			_haContext.CallService("webrtc", "create_link", null, new WebrtcCreateLinkParameters{LinkId = @linkId, Url = @url, Entity = @entity, OpenLimit = @openLimit, TimeToLive = @timeToLive});
		}

		///<summary>Cast stream to Chromecast device via DashCast application</summary>
		public void DashCast(WebrtcDashCastParameters data)
		{
			_haContext.CallService("webrtc", "dash_cast", null, data);
		}

		///<summary>Cast stream to Chromecast device via DashCast application</summary>
		///<param name="entityId">Media player entity eg: media_player.mibox4</param>
		///<param name="url">Link to RTSP-stream eg: rtsp://rtsp:12345678@192.168.1.123:554/av_stream/ch0</param>
		///<param name="entity">Camera entity eg: camera.generic_stream</param>
		public void DashCast(string @entityId, string? @url = null, string? @entity = null)
		{
			_haContext.CallService("webrtc", "dash_cast", null, new WebrtcDashCastParameters{EntityId = @entityId, Url = @url, Entity = @entity});
		}
	}

	public record WebrtcCreateLinkParameters
	{
		///<summary>Create a random or permanent ID for your link eg: fd0a53ca-e9ab-4e7a-86a2-441642b16ae1</summary>
		[JsonPropertyName("link_id")]
		public string? LinkId { get; init; }

		///<summary>Link to RTSP-stream eg: rtsp://rtsp:12345678@192.168.1.123:554/av_stream/ch0</summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		///<summary>Camera entity eg: camera.generic_stream</summary>
		[JsonPropertyName("entity")]
		public string? Entity { get; init; }

		///<summary>How many times a link can be opened (0 - unlimit) eg: 1</summary>
		[JsonPropertyName("open_limit")]
		public long? OpenLimit { get; init; }

		///<summary>How many seconds will the link live (0 - unlimit) eg: 60</summary>
		[JsonPropertyName("time_to_live")]
		public long? TimeToLive { get; init; }
	}

	public record WebrtcDashCastParameters
	{
		///<summary>Media player entity eg: media_player.mibox4</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Link to RTSP-stream eg: rtsp://rtsp:12345678@192.168.1.123:554/av_stream/ch0</summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		///<summary>Camera entity eg: camera.generic_stream</summary>
		[JsonPropertyName("entity")]
		public string? Entity { get; init; }
	}

	public class ZoneServices
	{
		private readonly IHaContext _haContext;
		public ZoneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public static class AutomationEntityExtensionMethods
	{
		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this AutomationEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this AutomationEntity target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this IEnumerable<AutomationEntity> target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this AutomationEntity target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this IEnumerable<AutomationEntity> target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this AutomationEntity target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this AutomationEntity target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this AutomationEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ButtonEntityExtensionMethods
	{
		///<summary>Press the button entity.</summary>
		public static void Press(this ButtonEntity target)
		{
			target.CallService("press");
		}

		///<summary>Press the button entity.</summary>
		public static void Press(this IEnumerable<ButtonEntity> target)
		{
			target.CallService("press");
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this IEnumerable<CameraEntity> target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this IEnumerable<CameraEntity> target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this IEnumerable<CameraEntity> target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this IEnumerable<CameraEntity> target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this IEnumerable<CameraEntity> target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this IEnumerable<CameraEntity> target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class DenonavrEntityExtensionMethods
	{
		///<summary>Send a generic HTTP get command.</summary>
		public static void GetCommand(this MediaPlayerEntity target, DenonavrGetCommandParameters data)
		{
			target.CallService("get_command", data);
		}

		///<summary>Send a generic HTTP get command.</summary>
		public static void GetCommand(this IEnumerable<MediaPlayerEntity> target, DenonavrGetCommandParameters data)
		{
			target.CallService("get_command", data);
		}

		///<summary>Send a generic HTTP get command.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="command">Endpoint of the command, including associated parameters. eg: /goform/formiPhoneAppDirect.xml?RCKSK0410370</param>
		public static void GetCommand(this MediaPlayerEntity target, string @command)
		{
			target.CallService("get_command", new DenonavrGetCommandParameters{Command = @command});
		}

		///<summary>Send a generic HTTP get command.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="command">Endpoint of the command, including associated parameters. eg: /goform/formiPhoneAppDirect.xml?RCKSK0410370</param>
		public static void GetCommand(this IEnumerable<MediaPlayerEntity> target, string @command)
		{
			target.CallService("get_command", new DenonavrGetCommandParameters{Command = @command});
		}

		///<summary>Enable or disable DynamicEQ.</summary>
		public static void SetDynamicEq(this MediaPlayerEntity target, DenonavrSetDynamicEqParameters data)
		{
			target.CallService("set_dynamic_eq", data);
		}

		///<summary>Enable or disable DynamicEQ.</summary>
		public static void SetDynamicEq(this IEnumerable<MediaPlayerEntity> target, DenonavrSetDynamicEqParameters data)
		{
			target.CallService("set_dynamic_eq", data);
		}

		///<summary>Enable or disable DynamicEQ.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="dynamicEq">True/false for enable/disable.</param>
		public static void SetDynamicEq(this MediaPlayerEntity target, bool? @dynamicEq = null)
		{
			target.CallService("set_dynamic_eq", new DenonavrSetDynamicEqParameters{DynamicEq = @dynamicEq});
		}

		///<summary>Enable or disable DynamicEQ.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="dynamicEq">True/false for enable/disable.</param>
		public static void SetDynamicEq(this IEnumerable<MediaPlayerEntity> target, bool? @dynamicEq = null)
		{
			target.CallService("set_dynamic_eq", new DenonavrSetDynamicEqParameters{DynamicEq = @dynamicEq});
		}

		///<summary>Update Audyssey settings.</summary>
		public static void UpdateAudyssey(this MediaPlayerEntity target)
		{
			target.CallService("update_audyssey");
		}

		///<summary>Update Audyssey settings.</summary>
		public static void UpdateAudyssey(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("update_audyssey");
		}
	}

	public static class FoscamEntityExtensionMethods
	{
		///<summary>Pan/Tilt service for Foscam camera.</summary>
		public static void Ptz(this CameraEntity target, FoscamPtzParameters data)
		{
			target.CallService("ptz", data);
		}

		///<summary>Pan/Tilt service for Foscam camera.</summary>
		public static void Ptz(this IEnumerable<CameraEntity> target, FoscamPtzParameters data)
		{
			target.CallService("ptz", data);
		}

		///<summary>Pan/Tilt service for Foscam camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="movement">Direction of the movement.</param>
		///<param name="travelTime">Travel time in seconds.</param>
		public static void Ptz(this CameraEntity target, object @movement, double? @travelTime = null)
		{
			target.CallService("ptz", new FoscamPtzParameters{Movement = @movement, TravelTime = @travelTime});
		}

		///<summary>Pan/Tilt service for Foscam camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="movement">Direction of the movement.</param>
		///<param name="travelTime">Travel time in seconds.</param>
		public static void Ptz(this IEnumerable<CameraEntity> target, object @movement, double? @travelTime = null)
		{
			target.CallService("ptz", new FoscamPtzParameters{Movement = @movement, TravelTime = @travelTime});
		}

		///<summary>PTZ Preset service for Foscam camera.</summary>
		public static void PtzPreset(this CameraEntity target, FoscamPtzPresetParameters data)
		{
			target.CallService("ptz_preset", data);
		}

		///<summary>PTZ Preset service for Foscam camera.</summary>
		public static void PtzPreset(this IEnumerable<CameraEntity> target, FoscamPtzPresetParameters data)
		{
			target.CallService("ptz_preset", data);
		}

		///<summary>PTZ Preset service for Foscam camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="presetName">The name of the preset to move to. Presets can be created from within the official Foscam apps. eg: TopMost</param>
		public static void PtzPreset(this CameraEntity target, string @presetName)
		{
			target.CallService("ptz_preset", new FoscamPtzPresetParameters{PresetName = @presetName});
		}

		///<summary>PTZ Preset service for Foscam camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="presetName">The name of the preset to move to. Presets can be created from within the official Foscam apps. eg: TopMost</param>
		public static void PtzPreset(this IEnumerable<CameraEntity> target, string @presetName)
		{
			target.CallService("ptz_preset", new FoscamPtzPresetParameters{PresetName = @presetName});
		}
	}

	public static class HueEntityExtensionMethods
	{
		///<summary>Activate a Hue scene with more control over the options.</summary>
		public static void ActivateScene(this SceneEntity target, HueActivateSceneParameters data)
		{
			target.CallService("activate_scene", data);
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		public static void ActivateScene(this IEnumerable<SceneEntity> target, HueActivateSceneParameters data)
		{
			target.CallService("activate_scene", data);
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The SceneEntity to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		///<param name="dynamic">Enable dynamic mode of the scene.</param>
		///<param name="speed">Speed of dynamic palette for this scene</param>
		///<param name="brightness">Set brightness for the scene.</param>
		public static void ActivateScene(this SceneEntity target, long? @transition = null, bool? @dynamic = null, long? @speed = null, long? @brightness = null)
		{
			target.CallService("activate_scene", new HueActivateSceneParameters{Transition = @transition, Dynamic = @dynamic, Speed = @speed, Brightness = @brightness});
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The IEnumerable<SceneEntity> to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		///<param name="dynamic">Enable dynamic mode of the scene.</param>
		///<param name="speed">Speed of dynamic palette for this scene</param>
		///<param name="brightness">Set brightness for the scene.</param>
		public static void ActivateScene(this IEnumerable<SceneEntity> target, long? @transition = null, bool? @dynamic = null, long? @speed = null, long? @brightness = null)
		{
			target.CallService("activate_scene", new HueActivateSceneParameters{Transition = @transition, Dynamic = @dynamic, Speed = @speed, Brightness = @brightness});
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputDatetimeEntityExtensionMethods
	{
		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this InputDatetimeEntity target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The InputDatetimeEntity to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this InputDatetimeEntity target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The IEnumerable<InputDatetimeEntity> to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this InputNumberEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this InputNumberEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this InputNumberEntity target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The InputNumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this InputNumberEntity target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The IEnumerable<InputNumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}
	}

	public static class InputSelectEntityExtensionMethods
	{
		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this InputSelectEntity target)
		{
			target.CallService("select_first");
		}

		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this IEnumerable<InputSelectEntity> target)
		{
			target.CallService("select_first");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this InputSelectEntity target)
		{
			target.CallService("select_last");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this IEnumerable<InputSelectEntity> target)
		{
			target.CallService("select_last");
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this InputSelectEntity target, InputSelectSelectNextParameters data)
		{
			target.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this IEnumerable<InputSelectEntity> target, InputSelectSelectNextParameters data)
		{
			target.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this InputSelectEntity target, bool? @cycle = null)
		{
			target.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
		{
			target.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this InputSelectEntity target, InputSelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this IEnumerable<InputSelectEntity> target, InputSelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this InputSelectEntity target, string @option)
		{
			target.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<InputSelectEntity> target, string @option)
		{
			target.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this InputSelectEntity target, InputSelectSelectPreviousParameters data)
		{
			target.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, InputSelectSelectPreviousParameters data)
		{
			target.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this InputSelectEntity target, bool? @cycle = null)
		{
			target.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
		{
			target.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this InputSelectEntity target, InputSelectSetOptionsParameters data)
		{
			target.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this IEnumerable<InputSelectEntity> target, InputSelectSetOptionsParameters data)
		{
			target.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this InputSelectEntity target, object @options)
		{
			target.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this IEnumerable<InputSelectEntity> target, object @options)
		{
			target.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class MediaExtractorEntityExtensionMethods
	{
		///<summary>Downloads file from given URL.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaExtractorPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Downloads file from given URL.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaExtractorPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Downloads file from given URL.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://soundcloud.com/bruttoband/brutto-11</param>
		///<param name="mediaContentType">The type of the content to play. Must be one of MUSIC, TVSHOW, VIDEO, EPISODE, CHANNEL or PLAYLIST MUSIC.</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, object @mediaContentType)
		{
			target.CallService("play_media", new MediaExtractorPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Downloads file from given URL.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://soundcloud.com/bruttoband/brutto-11</param>
		///<param name="mediaContentType">The type of the content to play. Must be one of MUSIC, TVSHOW, VIDEO, EPISODE, CHANNEL or PLAYLIST MUSIC.</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, object @mediaContentType)
		{
			target.CallService("play_media", new MediaExtractorPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </param>
		public static void Join(this MediaPlayerEntity target, string @groupMembers)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, string @groupMembers)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity target)
		{
			target.CallService("media_play");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity target)
		{
			target.CallService("volume_down");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity target)
		{
			target.CallService("volume_up");
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_up");
		}
	}

	public static class RemoteEntityExtensionMethods
	{
		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this RemoteEntity target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this RemoteEntity target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this RemoteEntity target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this RemoteEntity target, string? @device = null, object? @command = null, object? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, string? @device = null, object? @command = null, object? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this RemoteEntity target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this RemoteEntity target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this RemoteEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this RemoteEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this RemoteEntity target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this RemoteEntity target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public static class SceneEntityExtensionMethods
	{
		///<summary>Activate a scene.</summary>
		public static void TurnOn(this SceneEntity target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		public static void TurnOn(this IEnumerable<SceneEntity> target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The SceneEntity to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this SceneEntity target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The IEnumerable<SceneEntity> to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this IEnumerable<SceneEntity> target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public static class ScriptEntityExtensionMethods
	{
		///<summary>Toggle script</summary>
		public static void Toggle(this ScriptEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle script</summary>
		public static void Toggle(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this ScriptEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this ScriptEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a switch state</summary>
		public static void Toggle(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class TimerEntityExtensionMethods
	{
		///<summary>Cancel a timer.</summary>
		public static void Cancel(this TimerEntity target)
		{
			target.CallService("cancel");
		}

		///<summary>Cancel a timer.</summary>
		public static void Cancel(this IEnumerable<TimerEntity> target)
		{
			target.CallService("cancel");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this TimerEntity target)
		{
			target.CallService("finish");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this IEnumerable<TimerEntity> target)
		{
			target.CallService("finish");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this TimerEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this IEnumerable<TimerEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Start a timer</summary>
		public static void Start(this TimerEntity target, TimerStartParameters data)
		{
			target.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		public static void Start(this IEnumerable<TimerEntity> target, TimerStartParameters data)
		{
			target.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The TimerEntity to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this TimerEntity target, string? @duration = null)
		{
			target.CallService("start", new TimerStartParameters{Duration = @duration});
		}

		///<summary>Start a timer</summary>
		///<param name="target">The IEnumerable<TimerEntity> to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this IEnumerable<TimerEntity> target, string? @duration = null)
		{
			target.CallService("start", new TimerStartParameters{Duration = @duration});
		}
	}

	public static class UpdateEntityExtensionMethods
	{
		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this UpdateEntity target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this UpdateEntity target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this IEnumerable<UpdateEntity> target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The UpdateEntity to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this UpdateEntity target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The IEnumerable<UpdateEntity> to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this IEnumerable<UpdateEntity> target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this UpdateEntity target)
		{
			target.CallService("skip");
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("skip");
		}
	}
}