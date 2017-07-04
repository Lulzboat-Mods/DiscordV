using DiscordV.Models;
using DiscordV.Core;
using System.Threading.Tasks;

namespace DiscordVTest
{
    class Program
    {
        static void Main(string[] args) => new Program().Run().GetAwaiter().GetResult();

        async Task Run()
        {
            Message message = new Message()
            {
                username = "test",
                content = "mdr",
                avatar_url = "https://cdn.iconverticons.com/files/png/9feca6582f22e9a7_256x256.png"
            };
            
            await Webhooks.SendWebhook<Message>(message);
        }
    }
}
