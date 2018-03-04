using System;
using System.Linq;
namespace FactoryMethod1
{
    public class AvocadoImport
    {
        public string Origin{ get; set; }

        public int[] AvailableMonths;

        public bool CanImport(int month){

            if (AvailableMonths.FirstOrDefault(f => f == month) != 0) return true;
            return false;
        }
    }
}
