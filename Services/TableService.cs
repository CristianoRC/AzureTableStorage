using System;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos.Table;

namespace AzureTableStorage.Services
{
    public static class TableService
    {
        public static async Task<CloudTable> GetTableAsync(string tableName)
        {
            //TODO: Estudar sobre as permissões na hora de criar as tabelas.
            var storageAccount = ConnectionService.GetStorageAccount();
            var tableClient = storageAccount.CreateCloudTableClient(new TableClientConfiguration());
            var table = tableClient.GetTableReference(tableName);
            await table.CreateIfNotExistsAsync();
            return table;
        }
    }
}