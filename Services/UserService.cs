using System.Threading.Tasks;
using AzureTableStorage.models;
using Microsoft.Azure.Cosmos.Table;

namespace AzureTableStorage.Services
{
    public class UserService
    {
        private readonly string _tableName;
        public UserService()
        {
            _tableName = "Users";
        }

        public async Task AddOrUpdate(User user)
        {
            var table = await TableService.GetTableAsync(_tableName);
            var operation = TableOperation.InsertOrMerge(user);
            await table.ExecuteAsync(operation);
        }
    }
}