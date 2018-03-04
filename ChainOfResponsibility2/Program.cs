using System;

namespace ChainOfResponsibility2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Chain teamLeader = new TeamLeader();
            Chain projectLeader = new ProjectLeader();
            Chain hr = new HR();

            teamLeader.SetNextChain(projectLeader);
            projectLeader.SetNextChain(hr);

            teamLeader.AproveVacation(100);
            teamLeader.AproveVacation(1);
            teamLeader.AproveVacation(29);
        }
    }
}
