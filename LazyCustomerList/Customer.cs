
using System;
namespace LazyCustomerList
{
    public class Customer
    {
        public string Name;

        public string City;

        public int Balance;

        public Guid code;

        public Customer(string name, string city){
            Name = name;
            City = city;
            Random r = new Random();
            Balance = r.Next(0, 100000);
            code = new Guid();
        }
    }
}
