using System;
namespace ChainOfResponsibility
{
    public interface Chain
    {
        void SetNextChain(Chain nextChain);
        void Withdraw(int quantity);
    }
}
