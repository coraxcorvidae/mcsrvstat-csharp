namespace McSrvStat
{
    public class ServerStatus
    {
        public bool Online { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        public ServerDebugInfo Debug { get; set; }
        public CleanRawHtml Motd { get; set; }
        public ServerPlayers Players { get; set; }
        public string Version { get; set; }
        public int Protocol { get; set; }
        public string HostName { get; set; }
        public string Icon { get; set; }
        public string Software { get; set; }
        public string Map { get; set; }
        public NamesRaw Plugins { get; set; }
        public NamesRaw Mods { get; set; }
        public CleanRawHtml Info { get; set; }
    }
}