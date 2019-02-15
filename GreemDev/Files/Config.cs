using System.IO;
using Newtonsoft.Json;

namespace GreemDev.Files
{
    public class Config
    {
        private static SiteConfig _site;
        private const string ConfigFile = "data/config.json";

        static Config()
        {
            CreateIfNotExists();
            if (File.Exists(ConfigFile) && !string.IsNullOrEmpty(File.ReadAllText(ConfigFile)))
                _site = JsonConvert.DeserializeObject<SiteConfig>(File.ReadAllText(ConfigFile));
        }

        public static void CreateIfNotExists()
        {
            if (!Directory.Exists("data")) Directory.CreateDirectory("data");
            if (File.Exists(ConfigFile) && !string.IsNullOrEmpty(File.ReadAllText(ConfigFile))) return;
            _site = new SiteConfig
            {
                WebhookToken = string.Empty,
                WebhookId = ulong.MinValue
            };
            File.WriteAllText(ConfigFile,
                JsonConvert.SerializeObject(_site, Formatting.Indented));
        }

        public static string GetWebhookToken() => _site.WebhookToken;
        public static ulong GetWebhookId() => _site.WebhookId;

        private struct SiteConfig
        {
            public string WebhookToken;
            public ulong WebhookId;
        }
    }
}