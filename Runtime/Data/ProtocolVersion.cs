namespace OpenBLive.Runtime.Data
{
    /// <summary>
    /// 弹幕协议版本
    /// </summary>
    public enum ProtocolVersion
    {
        /// <summary>
        /// 未压缩数据
        /// </summary>
        UnCompressed = 0,

        /// <summary>
        /// 心跳数据
        /// </summary>
        HeartBeat = 1,

        /// <summary>
        /// zlib数据
        /// </summary>
        Zlib = 2,

        /// <summary>
        /// Br数据
        /// </summary>
        Brotli = 3
    }
}