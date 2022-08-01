using System;

namespace McSrvStat.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: McSrvStat.Demo.exe <hostname>");
                return;
            }

            var status = Api.GetServerStatus(args[0]);
            if (status.Online)
            {
                Console.Write($"{status.HostName} is online. ");
                Console.Write($"{status.Players.Online}/{status.Players.Max} players");
                if (status.Players.Online > 0)
                {
                    Console.WriteLine(":");
                    if (status.Players.List != null)
                    {
                        foreach (var player in status.Players.List)
                        {
                            Console.WriteLine($"\t{player}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
            else
            {
                Console.WriteLine($"{args[0]} is offline.");
            }
        }
    }
}