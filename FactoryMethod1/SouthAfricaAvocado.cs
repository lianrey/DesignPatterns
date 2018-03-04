using System;
namespace FactoryMethod1
{
    public class SouthAfricaAvocado: AvocadoImport
    {
        public SouthAfricaAvocado()
        {
            Origin = "South Africa";
            AvailableMonths = new int[] { 4, 5, 6, 7, 8, 9, 10, 11 };
        }
    }
}
