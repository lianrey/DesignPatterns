using System;
using System.Collections.Generic;
using DataLib2.Entities;
using DataLib2.Interfaces;
using DataLib2.Initializers;
using System.Linq;

namespace DataLib2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IInitializer<Racer> racerInitializer = new RacerInitializer();
            racerInitializer.Initialize();
            List<Racer> racers = racerInitializer.Result.ToList();



            List<Racer> racersFromBrazil = racers.Where(r => r.Country == "Brazil").OrderBy(o => o.Wins).ToList();

            List<string> names = racers.Where(r => r.Cars.Any(c => c == "Ferrari")).Select(s => s.FirstName).ToList();

            Console.WriteLine("Names");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            List<Racer> sortedRacers = racers.OrderBy(o => o.Country).ThenBy(b => b.FirstName).Take(9).ToList();

            var groupedRacers = racers.GroupBy(g => g.Country).OrderByDescending(o => o.Count()).Select(s => new { Country = s.First().Cars, Total = s.Count()});

            Console.WriteLine("Names");
        }
    }
}
