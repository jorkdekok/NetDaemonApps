using System.Collections.Generic;
using GMotionLightsV3.Configs;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GMotionLightsV3.Configs
{

    public class RoomStatesList : List<RoomState>, IList<RoomState>
    {
        public RoomStatesList() : base()
        {
        }


        public RoomStatesList(int capacity) : base(capacity)
        {
        }

        public RoomStatesList(IEnumerable<RoomState> collection) : base(collection)
        {
        }

    }

    public static class RoomStatesListExtensions
    {
        public static RoomStatesList MyToRoomStates(IEnumerable<MotionLightRoomConfig> roomConfigs)
        {
            var newList = new RoomStatesList();
            foreach (var config in roomConfigs)
            {
                newList.Add(new RoomState(config));
            }

            return newList;
        }

    }
}