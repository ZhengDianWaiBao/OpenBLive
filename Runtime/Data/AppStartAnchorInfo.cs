using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
    public class AppStartAnchorInfo
    {
        /// <summary>
        /// 主播房间号
        /// </summary>
        [JsonProperty("room_id")]
        public long RoomId;
        /// <summary>
        /// 主播昵称
        /// </summary>
        [JsonProperty("uname")]
        public string UName;
        /// <summary>
        /// 主播头像
        /// </summary>
        [JsonProperty("uface")]
        public string UFace;
        /// <summary>
        /// 主播Uid
        /// </summary>
        [JsonProperty("uid")]
        public string Uid;
    }
}