using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace LazyCustomerList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string namesFile = File.ReadAllText(@"../../Files/names.txt");
            String[] names = namesFile.Split('\n');

            string citiesFile = File.ReadAllText(@"../../Files/cities.txt");
            String[] cities = citiesFile.Split('\n');

            List<Customer> customers = new List<Customer>();
            foreach (var item in names)
            {
                Random r = new Random();
                customers.Add(new Customer(item, cities[r.Next(0, cities.Length - 1)]));

            }

            Lazy<List<Customer>> customersLazy = new Lazy<List<Customer>>(() => customers);

            var watch = Stopwatch.StartNew();
            foreach (var c in customersLazy.Value)
            {
                Console.WriteLine($"Customer: {c.Name}, city: {c.City}, random: {c.Balance}");
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.Write("Time: " + elapsedMs);
        }
    }
}
