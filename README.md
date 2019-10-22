# McSrvStat-CSharp

McSvrStat.Lib.dll is a simple client library for fetching minecraft server status from the [Minecraft Server Status API](https://api.mcsrvstat.us/). Refer to the site for information about usage terms and conditions.

## Example

A simple demonstration program is provided to show basic use of the library.

````cs
var status = Api.GetServerStatus("minecraft.example.com");
if (status.Online)
{
    Console.Write($"{status.HostName} is online. ");
    Console.Write($"{status.Players.Online}/{status.Players.Max} players");
    if (status.Players.Online > 0)
    {
        Console.WriteLine(":");
        foreach (var player in status.Players.List)
        {
            Console.WriteLine($"\t{player}");
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
````

All information returned by the API is available in the requested ServerStatus object.

## Libraries used

- [Newtonsoft.Json](http://www.newtonsoft.com/json)

## License

Released under the [MIT license](https://opensource.org/licenses/MIT). See License.md for more information.

## Acknowledgements

Thanks to [Anders G. Jørgensen](https://spirit55555.dk/) for creating [Minecraft Server Status API](https://api.mcsrvstat.us/) which made this library possible.