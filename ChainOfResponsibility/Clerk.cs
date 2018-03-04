using System;
namespace ChainOfResponsibility
{
    public class Clerk: Chain
    {
        private Chain nextChain;

        public void SetNextChain(Chain nextChain)
        {
            this.nextChain = nextChain;
        }

        public void Withdraw(int quantity)
        {
            if(quantity < 1000){
                Console.WriteLine("Clerk did it, withdraw of " + quantity);
            }
            else{
                nextChain.Withdraw(quantity);
            }
        }
    }
}
