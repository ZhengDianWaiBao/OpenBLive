namespace OpenBLive.Runtime.Data
{
    /// <summary>
    /// 操作数据
    /// </summary>
    public enum Operation
    {
        /// <summary>
        /// 心跳包
        /// </summary>
        HeartBeat = 2,

        /// <summary>
        /// 服务器心跳回应(包含人气信息)
        /// </summary>
        HeartBeatResponse = 3,

        /// <summary>
        /// 服务器消息(正常消息)
        /// </summary>
        ServerNotify = 5,

        /// <summary>
        /// 客户端认证请求
        /// </summary>
        Authority = 7,

        /// <summary>
        /// 认证回应
        /// </summary>
        AuthorityResponse = 8
    }
}