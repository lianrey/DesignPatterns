using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();

            for (int i = 0; i < 3; i++)
            {
                manager.Add(new Engineer());
                manager.Add(new Manager());
            }

            manager.DoWork();
            Console.ReadLine();
        }
    }
}
