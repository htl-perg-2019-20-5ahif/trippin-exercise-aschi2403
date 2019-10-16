using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace trippin_console
{
    internal interface IUserChecker<T>
    {
        Task<bool> AddMissingUsersAsync(IEnumerable<T> trippinUsers);
    }
}
