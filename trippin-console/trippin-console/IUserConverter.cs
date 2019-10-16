using System;
using System.Collections.Generic;
using System.Text;

namespace trippin_console
{
    internal interface IUserConverter<T, I>
    {
        T Convert(I userToConvert);
        IEnumerable<T> ConvertAll(IEnumerable<I> usersToConvert);
    }
}
