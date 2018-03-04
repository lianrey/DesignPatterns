using System;
namespace ChainOfResponsibility2
{
    public class TeamLeader: AbstractRole
    {
        public TeamLeader(){
            this.numberOfDays = 10;
            this.message = "Team Leader approved it";
        }
    }
}
