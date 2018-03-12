using System;
namespace Strategy2
{
    public class Car:ITransports
    {
        public void Move()
        {
            Console.WriteLine("Car");
        }
    }
}
