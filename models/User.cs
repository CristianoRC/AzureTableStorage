using System;
using Microsoft.Azure.Cosmos.Table;

namespace AzureTableStorage.models
{
    public class User : TableEntity
    {
        public User()
        {
            System.Console.WriteLine("Olá Mundo!");
        }

        public User(long id, long groupId, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.GroupId = groupId;
            RowKey = id.ToString();
            PartitionKey = groupId.ToString();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long GroupId { get; set; }

        public override string ToString()
        {
            return $"{Id} - {GroupId}, {Name}, {Email}{Environment.NewLine}";
        }
    }
}