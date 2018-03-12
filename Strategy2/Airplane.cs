using System;
namespace Strategy2
{
    public class Airplane:ITransports
    {
        public void Move()
        {
            Console.WriteLine("Airplane");
        }
    }
}
