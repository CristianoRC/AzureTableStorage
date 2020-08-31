using System.Threading.Tasks;
using AzureTableStorage.models;
using AzureTableStorage.Services;
using System;
using System.Linq;

namespace AzureTableStorage
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var userService = new UserService();

            await InsertUser(userService);
            await GetUserById(userService);
            await ListUsersByGroup(userService);
        }

        private static async Task InsertUser(UserService userService)
        {
            var user = new User(2, 21, "Cristiano Cunha", "contato@cristianoprogramador.com");
            await userService.AddOrUpdate(user);
            Console.WriteLine("Usuário criado com sucesso");
        }

        private static async Task GetUserById(UserService userService)
        {
            var userById = await userService.GetUser(1, 21);
            Console.WriteLine(userById.ToString());
        }

        private static async Task ListUsersByGroup(UserService userService)
        {
            var usersByGroup = await userService.GetUsersByGroup(21);

            foreach (var item in usersByGroup.ToList())
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}