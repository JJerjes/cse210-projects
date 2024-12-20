using System;

namespace OnlineProducts
{
    public class Address
    {
        private string streetAddress;
        private string city;
        private string state;
        private string country;
        public Address(string streetAddress, string city, string state, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public bool InUSA()
        {
            return country.ToLower() == "United States";
        }

        public string GetAddress()
        {
            return $"{streetAddress}\n{city}, {state}\n{country}";
        }

        public string StreetAddress => streetAddress;
        public string City => city;
        public string State => state;
        public string Country => country;
    }
}