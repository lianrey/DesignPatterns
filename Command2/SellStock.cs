using System;
namespace Command2
{
    public class SellStock: ICommand
    {
        IBroker _broker;
        public SellStock(IBroker newBroker)
        {
            _broker = newBroker;
        }

        public void Execute()
        {
            _broker.SellStock();
        }
    }
}
