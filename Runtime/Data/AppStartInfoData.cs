using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
    public class AppStartInfoData
    {
        /// <summary>
        /// 场次信息
        /// </summary>
        [JsonProperty("game_info")]
        public AppStartGameInfo GameInfo;
        /// <summary>
        /// 长连信息
        /// </summary>
        [JsonProperty("websocket_info")]
        public AppStartWebsocketInfo WebsocketInfo;
        /// <summary>
        /// 主播信息
        /// </summary>
        [JsonProperty("anchor_info")]
        public AppStartAnchorInfo AnchorInfo;
    }
}