using System;

namespace ChainOfResponsibility
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Chain clerk = new Clerk();
            Chain supervisor = new Supervisor();
            Chain bankManager = new BankManager();

            clerk.SetNextChain(supervisor);
            supervisor.SetNextChain(bankManager);

            clerk.Withdraw(900);
            clerk.Withdraw(3000);
            clerk.Withdraw(5000);
            clerk.Withdraw(10000);
        }
    }
}
