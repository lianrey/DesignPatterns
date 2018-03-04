using System;
namespace Command2
{
    public class BuyStock: ICommand
    {
        IBroker _broker;
        public BuyStock(IBroker newBroker)
        {
            _broker = newBroker;
        }

        public void Execute()
        {
            _broker.BuyStock();
        }
    }
}
