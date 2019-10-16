using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace trippin_console
{
    internal class JsonUser
    {
        [JsonPropertyName("UserName")]
        public String UserName { get; set; }
        [JsonPropertyName("FirstName")]
        public String FirstName { get; set; }
        [JsonPropertyName("LastName")]
        public String LastName { get; set; }
        [JsonPropertyName("Email")]
        public String Email { get; set; }
        [JsonPropertyName("Address")]
        public String Address { get; set; }
        [JsonPropertyName("CityName")]
        public String CityName { get; set; }
        [JsonPropertyName("Contry")]
        public String County { get; set; }
    }
}
