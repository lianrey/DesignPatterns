using System;
using System.Collections.Generic;
namespace Composite
{
    public class Engineer : IEmployee
    {
        List<IEmployee> _employees;

        public Engineer()
        {
            _employees = new List<IEmployee>();
        }

        public void Add(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public void DoWork()
        {
            Console.WriteLine($"{GetType()} - Working");
        }
    }
}
