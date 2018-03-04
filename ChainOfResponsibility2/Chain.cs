using System;
namespace ChainOfResponsibility2
{
    public interface Chain
    {
        void SetNextChain(Chain next);
        void AproveVacation(int numberOfDays);
    }
}
