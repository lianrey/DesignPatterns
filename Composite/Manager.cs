using System;
namespace Composite
{
    public class Manager: IEmployee
    {
        public void Leave()
        {
            Console.WriteLine("Manager on leave");
        }
    }
}
