using System;
namespace Composite
{
    public class Engineer: IEmployee
    {
        public void Leave()
        {
            Console.WriteLine("Engineer on leave");
        }
    }
}
