using Microsoft.Azure.Cosmos.Table;

namespace AzureTableStorage.Services
{
    public static class ConnectionService
    {
        public static CloudStorageAccount GetStorageAccount()
        {
            var connectionStirng = Configuration.GetConnectionString();
            return CloudStorageAccount.Parse(connectionStirng);
        }
    }
}