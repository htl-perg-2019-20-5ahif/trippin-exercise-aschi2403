using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace trippin_console
{
    internal class JsonUserReader : IJsonReader<JsonUser>
    {
        public IEnumerable<JsonUser> Read(string path)
        {
            var fileReader = new FileReader();
            var json = fileReader.ReadFile(path);
            var users = JsonSerializer.Deserialize<JsonUser[]>(json);
            return users;
        }
    }
}
