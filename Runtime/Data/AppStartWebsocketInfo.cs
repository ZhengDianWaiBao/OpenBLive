using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenBLive.Runtime.Data
{
    public class AppStartWebsocketInfo
    {
        /// <summary>
        /// 长连使用的请求json体 第三方无需关注内容,建立长连时使用即可
        /// </summary>
        [JsonProperty("auth_body")]
        public string AuthBody;
        /// <summary>
        ///  wss 长连地址
        /// </summary>
        [JsonProperty("wss_link")]
        public List<string> WssLink;
    }
}