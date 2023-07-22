using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.IO;
using KartRider;

namespace RiderData
{
    public static class FavoriteItem
    {
        public static void Favorite_Item()
        {
            int itemCount = 17;
            using (OutPacket outPacket = new OutPacket("PrFavoriteItemGet"))
            {
                if (Program.FavoriteItem)
                {
                    outPacket.WriteInt(itemCount);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(839);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(854);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1045);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1098);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1239);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1247);
                    outPacket.WriteShort(301);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1276);
                    outPacket.WriteShort(59);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1348);
                    outPacket.WriteShort(85);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1359);
                    outPacket.WriteShort(95);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1379);
                    outPacket.WriteShort(106);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1385);
                    outPacket.WriteShort(112);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1387);
                    outPacket.WriteShort(114);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1401);
                    outPacket.WriteShort(124);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1430);
                    outPacket.WriteShort(140);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1433);
                    outPacket.WriteShort(142);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1435);
                    outPacket.WriteShort(143);
                    outPacket.WriteByte(0);

                    outPacket.WriteShort(3);
                    outPacket.WriteShort(1440);
                    outPacket.WriteShort(146);
                    outPacket.WriteByte(0);
                }
                else
                {
                    outPacket.WriteInt(0);
                }
                RouterListener.MySession.Client.Send(outPacket);
            }
        }
    }
}