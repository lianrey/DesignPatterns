using System;
namespace ChainOfResponsibility
{
    public class BankManager: Chain
    {
        private Chain nextChain;

        public void SetNextChain(Chain nextChain)
        {
            this.nextChain = nextChain;
        }

        public void Withdraw(int quantity)
        {
            if (quantity < 9000)
            {
                Console.WriteLine("Bank Manager did it, withdraw of " + quantity);
            }
            else
            {
                Console.WriteLine("Need to divide withdraw into several");
            }
        }
    }
}
