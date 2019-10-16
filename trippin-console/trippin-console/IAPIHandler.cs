using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace trippin_console
{
    internal interface IAPIHandler
    {
        Task<HttpResponseMessage> Get(string argument);
        Task<HttpResponseMessage> Post(string argument, HttpContent httpContent);
    }
}
