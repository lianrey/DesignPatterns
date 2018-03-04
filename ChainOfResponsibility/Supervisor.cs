using System;
namespace ChainOfResponsibility
{
    public class Supervisor: Chain
    {
        private Chain nextChain;

        public void SetNextChain(Chain nextChain)
        {
            this.nextChain = nextChain;
        }

        public void Withdraw(int quantity)
        {
            if (quantity < 4000)
            {
                Console.WriteLine("Supervisor did it, withdraw of " + quantity);
            }
            else
            {
                nextChain.Withdraw(quantity);
            }
        }
    }
}
