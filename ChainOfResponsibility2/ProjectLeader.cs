using System;
namespace ChainOfResponsibility2
{
    public class ProjectLeader: AbstractRole
    {
        public ProjectLeader()
        {
            this.numberOfDays = 20;
            this.message = "Project Leader approved it";
        }
    }
}
