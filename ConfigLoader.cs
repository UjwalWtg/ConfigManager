using Newtonsoft.Json;

namespace SuperConfigManager
{
    public class ConfigLoader
    {
        public AppSettings LoadFromJson(string jsonFilePath)
        {
            if (!File.Exists(jsonFilePath))
            {
                throw new FileNotFoundException($"Configuration file not found: {jsonFilePath}");

            }
            var json = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<AppSettings>(json);
        }

        public AppSettings LoadFromEnvironmentVariables()
        {
            var appSettings = new AppSettings
            {
                ApiUrl = Environment.GetEnvironmentVariable("API_URL"),
                MaxRetries = int.TryParse(Environment.GetEnvironmentVariable("MAX_RETRIES"), out var maxRetries) ? maxRetries : 3,
                LogLevel = Environment.GetEnvironmentVariable("LOG_LEVEL") ?? "Information"
            };
            return appSettings;
        }

    }
}