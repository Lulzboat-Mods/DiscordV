using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DiscordV.Core
{
    public static class Webhooks
    {
        public static async Task SendWebhook<T>(T webhookMessage)
        {
            using (HttpClient client = new HttpClient())
            {
                var stringContent = new StringContent(JsonConvert.SerializeObject(webhookMessage), Encoding.UTF8, "application/json");
                await client.PostAsync("https://discordapp.com/api/webhooks/327375251585499136/Fiu6Suv0LrKPr5sBR8-lJJj-4KBBo9AoDJCrYktxp12vjGjc0RZ1MtVFVF6pbbQXBZt4", stringContent);
            }
        }
    }
}
