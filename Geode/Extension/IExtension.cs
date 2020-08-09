using System.Collections.Generic;

using Geode.Habbo;
using Geode.Network;
using Geode.Habbo.Messages;
using Geode.Network.Protocol;

namespace Geode.Extension
{
    public interface IExtension
    {
        Incoming In { get; }
        Outgoing Out { get; }
        string Revision { get; }
        HotelEndPoint HotelServer { get; }

        IReadOnlyDictionary<int, HEntity> Entities { get; }
        IReadOnlyDictionary<int, HWallItem> WallItems { get; }
        IReadOnlyDictionary<int, HFloorItem> FloorItems { get; }

        void OnEntitiesLoaded(int count);
        void OnWallItemsLoaded(int count);
        void OnFloorItemsLoaded(int count);

        void OnFlagsCheck(HPacket packet);
        void OnDoubleClick(HPacket packet);
        void OnInfoRequest(HPacket packet);
        void OnPacketIntercept(HPacket packet);
        void OnDataIntercept(DataInterceptedEventArgs data); /*Fixed: Added OnDataIntercept event*/

        void OnInitialized(HPacket packet);
        void OnConnected(HPacket packet);
        void OnDisconnected(HPacket packet);
        void OnCriticalError(string error_desc); /*Fixed: Added OnCriticalError event*/
    }
}