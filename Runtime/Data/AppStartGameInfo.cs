using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
    public class AppStartGameInfo
    {
        /// <summary>
        /// 场次id,心跳key(心跳保持20s-60s)调用一次,超过60s无心跳自动关闭,长连停止推送消息
        /// </summary>
        [JsonProperty("game_id")]
        public string GameId;
    }
}