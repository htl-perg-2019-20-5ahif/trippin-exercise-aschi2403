using System;
using System.Collections.Generic;
using System.Text;

namespace trippin_console
{
    internal class TrippinUserChecker : IUserChecker<TrippinUser>
    {
        private const bool SUCCESS = true;
        private const bool FAILURE = false;
        private readonly IUserGetter UserGetter = new TrippinUserGetter();
        private readonly IUserAdder UserAdder = new TrippinUserAdder();

        public async System.Threading.Tasks.Task<bool> AddMissingUsersAsync(IEnumerable<TrippinUser> trippinUsers)
        {
            try
            {
                foreach (var trippinUser in trippinUsers)
                {
                    var userResult = await UserGetter.GetUser(trippinUser.UserName);
                    if(userResult == null)
                    {
                        UserAdder.AddUserAsync(trippinUser);
                        Console.WriteLine("User Added");
                    }
                    else
                    {
                        Console.WriteLine("User already exists");
                    }
                }
                return SUCCESS;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return FAILURE;
            }
            
        }
    }
}
