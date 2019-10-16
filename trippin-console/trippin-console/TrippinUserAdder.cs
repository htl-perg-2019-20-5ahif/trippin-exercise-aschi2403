using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace trippin_console
{
    internal class TrippinUserAdder : IUserAdder
    {
        private IAPIHandler handler = new TrippinAPIHandler();
        public async Task AddUserAsync(TrippinUser user)
        {
            var content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            var result = await handler.Post("People", content);
        }
    }
}
