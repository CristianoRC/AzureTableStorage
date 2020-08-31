using System.Collections.Generic;
using System.Threading.Tasks;
using AzureTableStorage.models;
using Microsoft.Azure.Cosmos.Table;
using System.Linq;

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

        public async Task<User> GetUser(long userId, long groupId)
        {
            var table = await TableService.GetTableAsync(_tableName);
            var operation = TableOperation.Retrieve<User>(groupId.ToString(), userId.ToString());
            var response = await table.ExecuteAsync(operation);
            return response.Result as User;
        }

        public async Task<IList<User>> GetUsersByGroup(long groupId)
        {
            var table = await TableService.GetTableAsync(_tableName);

            return table.CreateQuery<User>()
                .Where(x => x.PartitionKey == groupId.ToString())
                .ToList();
        }
    }
}