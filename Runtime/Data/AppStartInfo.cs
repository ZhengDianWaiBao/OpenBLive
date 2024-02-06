using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenBLive.Runtime.Data
{
    public class AppStartInfo
    {
        [JsonProperty("code")]
        public int Code;
        [JsonProperty("message")]
        public string Message;
        [JsonProperty("data")]
        public AppStartInfoData Data;


        /// <summary>
        /// 获取GameId
        /// </summary>
        /// <returns></returns>
        public string GetGameId() => Data?.GameInfo?.GameId;
        /// <summary>
        /// 获取长链地址
        /// </summary>
        /// <returns></returns>
        public IList<string> GetWssLink() => Data?.WebsocketInfo?.WssLink;


        /// <summary>
        /// 获取长链地址
        /// </summary>
        /// <returns></returns>
        public string GetAuthBody() => Data?.WebsocketInfo?.AuthBody;

    }
}
