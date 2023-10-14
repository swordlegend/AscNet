﻿using AscNet.Common.MsgPack;
using MessagePack;

namespace AscNet.GameServer.Handlers
{
    [MessagePackObject(true)]
    public class GuideGroupFinishRequest
    {
        public int GroupId;
    }

    [MessagePackObject(true)]
    public class GuideGroupFinishResponse
    {
        public int Code;
        public List<dynamic>? RewardGoodsList;
    }
    
    internal class GuideModule
    {
        [RequestPacketHandler("GuideOpenRequest")]
        public static void GuideOpenRequestHandler(Session session, Packet.Request packet)
        {
            session.SendResponse(new GuideOpenResponse(), packet.Id);
        }

        // TODO: Invalid, need proper types
        [RequestPacketHandler("GuideGroupFinishRequest")]
        public static void GuideGroupFinishRequestHandler(Session session, Packet.Request packet)
        {
            session.SendResponse(new GuideGroupFinishResponse(), packet.Id);
        }
    }
}
