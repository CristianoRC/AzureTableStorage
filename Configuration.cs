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
    }
}