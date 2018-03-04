using System;
namespace ChainOfResponsibility2
{
    public class HR: AbstractRole
    {
        public HR(){
            this.numberOfDays = 30;
            this.message = "HR approved it";
        }
    }
}
