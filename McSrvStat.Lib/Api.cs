using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace McSrvStat
{
    public static class Api
    {
        public static async Task<ServerStatus> GetServerStatusAsync(string domain)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "mcsrvstat-csharp (https://https://github.com/coraxcorvidae/mcsrvstat-csharp)");

            var stringTask = await client.GetStringAsync("https://api.mcsrvstat.us/2/" + domain);

            return JsonConvert.DeserializeObject<ServerStatus>(stringTask);
        }

        public static ServerStatus GetServerStatus(string domain)
        {
            return GetServerStatusAsync(domain).Result;
        }
    }
}