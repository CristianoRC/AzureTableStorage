using System.Threading.Tasks;
using AzureTableStorage.models;
using AzureTableStorage.Services;
using System;

namespace AzureTableStorage
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var userService = new UserService();
            var user = new User(1, 21, "Cristiano", "contato@cristianoprogramador.com");
            await userService.AddOrUpdate(user);
            var userResponse = await userService.GetUser(1, 21);
            Console.WriteLine(userResponse.ToString());
        }
    }
}
