using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee manager = new Manager();
            manager.Leave();

            IEmployee engineer = new Engineer();
            engineer.Leave();
        }
    }
}
