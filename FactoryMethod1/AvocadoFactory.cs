using System;
namespace FactoryMethod1
{
    public enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
    public class AvocadoFactory
    {
        private readonly AvocadoImport[] _avocados;

        public AvocadoFactory(AvocadoImport[] avocados){
            _avocados = avocados;
        }

        public AvocadoImport Create(int month){
            foreach (var a in _avocados)
            {
                if (a.CanImport(month))
                    return a;
            }
            return new AvocadoImport{ Origin = "Mexico" };
        }
    }
}
