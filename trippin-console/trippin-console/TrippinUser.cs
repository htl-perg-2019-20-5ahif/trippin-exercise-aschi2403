using System;
using System.Collections.Generic;
using System.Text;

namespace trippin_console
{
    internal class TrippinUser
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string[] Emails { get; set; }
        public AddressInfo[] AddressInfo {get; set;}
    }
}
