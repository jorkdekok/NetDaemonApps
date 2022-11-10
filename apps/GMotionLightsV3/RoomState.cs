using GMotionLightsV3.Configs;

namespace GMotionLightsV3;

public class RoomState
{
    public MotionLightRoomConfig CurrentRoomConfig { get; set; }

    public RoomState(MotionLightRoomConfig currentRoomConfig)
    {
        CurrentRoomConfig = currentRoomConfig;
    }
}