using System;
using System.Collections.Generic;
using System.Text;

namespace trippin_console
{
    class JsonUserToTrippinUserConverter : IUserConverter<TrippinUser, JsonUser>
    {
        public TrippinUser Convert(JsonUser userToConvert)
        {
            var emails = new List<string>();
            emails.Add(userToConvert.Email);

            var city = new City
            {
                Name = userToConvert.CityName,
                CountryRegion = userToConvert.County,
                Region = "" //TODO better implementation, Region missing in JsonUser?
            };

            var addressInfo = new AddressInfo
            {
                Address = userToConvert.Address,
                City = city
            };

            var trippinUser = new TrippinUser
            { 
                UserName = userToConvert.UserName,
                FirstName = userToConvert.FirstName,
                LastName = userToConvert.LastName,
                Emails = emails,
                AddressInfos = addressInfo
            };
            return trippinUser;
        }

        public IEnumerable<TrippinUser> ConvertAll(IEnumerable<JsonUser> usersToConvert)
        {
            var trippinUsers = new List<TrippinUser>();
            foreach(var user in usersToConvert)
            {
                trippinUsers.Add(this.Convert(user));
            }
            return trippinUsers;
        }
    }
}
