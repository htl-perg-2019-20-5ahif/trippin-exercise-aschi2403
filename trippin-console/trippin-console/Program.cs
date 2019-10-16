using Microsoft.Extensions.Configuration;
using System;
using System.Text.Json;

namespace trippin_console
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            var path = config["filepath"];

            var jsonUserReader = new JsonUserReader();
            var converter = new JsonUserToTrippinUserConverter();
            var checker = new TrippinUserChecker();

            var jsonUsers = jsonUserReader.Read(path);
            var trippinUsers = converter.ConvertAll(jsonUsers);
            checker.AddMissingUsersAsync(trippinUsers).Wait();
        }
    }
}
