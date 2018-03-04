using System;
namespace ChainOfResponsibility2
{
    public abstract class AbstractRole: Chain
    {
        private Chain nextChain;
        protected int numberOfDays;
        protected string message;

        public void AproveVacation(int numberOfDays)
        {
            if (numberOfDays < this.numberOfDays)
            {
                Console.WriteLine(this.message);
            }
            else if(this.nextChain != null)
            {
                this.nextChain.AproveVacation(numberOfDays);
            }
            else{
                Console.WriteLine("No no no, no te vas!");
            }
        }

        public void SetNextChain(Chain next)
        {
            this.nextChain = next;
        }
    }
}
