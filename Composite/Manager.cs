using System;
using System.Collections.Generic;
namespace Composite
{
    public class Manager : IEmployee
    {
        private List<IEmployee> _employees;

        public Manager()
        {
            _employees = new List<IEmployee>();
        }

        public void Add(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public void DoWork()
        {
            Console.WriteLine($"{GetType().Name} - Working");

            foreach (var employee in _employees)
            {
                employee.DoWork();
            }
        }
    }

}
