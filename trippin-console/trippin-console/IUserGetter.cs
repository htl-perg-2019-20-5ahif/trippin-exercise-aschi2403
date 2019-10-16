using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace trippin_console
{
    internal interface IUserGetter
    {
        Task<TrippinUser> GetUser(string username);
    }
}
