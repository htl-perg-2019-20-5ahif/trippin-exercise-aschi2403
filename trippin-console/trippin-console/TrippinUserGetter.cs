using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace trippin_console
{
    internal class TrippinUserGetter : IUserGetter
    {
        private readonly TrippinAPIHandler TrippinAPIHandler = new TrippinAPIHandler();
        
        public async Task<TrippinUser> GetUser(string username)
        {
            var result = await TrippinAPIHandler.Get("People('" + username + "')");
            if (result == null)
                return null;
            if(result.StatusCode.Equals(404))
                return null;

            var responseBody = await result.Content.ReadAsStringAsync();
            var user = JsonSerializer.Deserialize<TrippinUser>(responseBody);
            return user;
        }
    }
}
