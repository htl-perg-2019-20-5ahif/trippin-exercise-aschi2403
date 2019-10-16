using System;
using System.Collections.Generic;
using System.Text;

namespace trippin_console
{
    internal interface IJsonReader<T>
    {
        IEnumerable<T> Read(string path);
    }
}
