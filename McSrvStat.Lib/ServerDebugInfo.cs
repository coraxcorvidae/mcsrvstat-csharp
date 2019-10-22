namespace McSrvStat
{
    public class ServerDebugInfo
    {
        public bool Ping { get; set; }
        public bool Query { get; set; }
        public bool Srv { get; set; }
        public bool IpInSrv { get; set; }
        public bool AnimatedMotd { get; set; }
        public bool ProxyPipe { get; set; }
        public long CacheTime { get; set; }
    }
}