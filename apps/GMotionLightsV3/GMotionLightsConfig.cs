using System.Collections.Generic;
using GMotionLightsV3.Configs;

namespace GMotionLightsV3;

public class GMotionLightsConfig
{
    public string? AppName { get; set; }
    public IEnumerable<MotionLightRoomConfig>? RoomConfigs { get; set; }
}
