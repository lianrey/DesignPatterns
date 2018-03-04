using System;

namespace Command2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IBroker broker = new Broker();
            ICommand buyStockCommand = new BuyStock(broker);
            buyStockCommand.Execute();
            ICommand sellStockCommand = new SellStock(broker);
            sellStockCommand.Execute();
        }
    }
}
