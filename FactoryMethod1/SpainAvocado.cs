using System;
namespace FactoryMethod1
{
    public class SpainAvocado: AvocadoImport
    {
        public SpainAvocado()
        {
            Origin = "Spain";
            AvailableMonths = new int[] { 12, 1, 2 };
        }
    }
}
