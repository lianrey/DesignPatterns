using System;
namespace Command2
{
    public class Broker: IBroker
    {
        public void BuyStock()
        {
            Console.WriteLine("Buy stock");
        }

        public void SellStock()
        {
            Console.WriteLine("Sell stock");
        }
    }
}
