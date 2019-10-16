using System;
using System.Collections.Generic;
using System.Text;

namespace trippin_console
{
    internal class FileReader : IFileReader
    {
        public string ReadFile(string path)
        {
            return System.IO.File.ReadAllText(path);
        }
    }
}
