using Microsoft.Extensions.Configuration;

namespace AzureTableStorage
{
    public static class Configuration
    {
        public static IConfiguration Get()
        {
            return new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .Build();
        }

        public static string GetConnectionString()
        {
            var configs = Configuration.Get();
            return configs["AZURE_STORAGE_CONNECTION_STRING"];
        }
    }
}