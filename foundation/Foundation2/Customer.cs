using System;

namespace OnlineProducts
{
    public class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public bool InUSA()
        {
            return address.InUSA();
        }

        public string GetCustomer()
        {
            return $"{name}\n{address.GetAddress()}";
        }

        public string Name => name;
        public Address CustomerAddress => address;
    }
}