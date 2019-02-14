using System.Threading.Tasks;
using Discord;
using Discord.Webhook;
using GreemDev.Files;

namespace GreemDev.Handlers {
    public static class Webhook {
        private static DiscordWebhookClient Client =>
            new DiscordWebhookClient(Config.GetWebhookId(), Config.GetWebhookToken());

        public static Task SendAsync(string name, string email, string message) {
            if (Config.GetWebhookId() == 0 || Config.GetWebhookToken() == "") return Task.CompletedTask;
            var embed = new EmbedBuilder()
                .WithColor(0x7000FB)
                .WithTitle("New Website Submission")
                .AddField($"{name} | {email}", message);
            return Client.SendMessageAsync("<@168548441939509248>", false, new[] {embed.Build()},
                "Website Contact Form");
        }
    }
}