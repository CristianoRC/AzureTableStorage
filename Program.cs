using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AzureTableStorage
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var configs = Configuration.Get();

            var connectionStirng = configs["AZURE_STORAGE_CONNECTION_STRING"];

            Console.WriteLine(connectionStirng);
        }
    }
}
