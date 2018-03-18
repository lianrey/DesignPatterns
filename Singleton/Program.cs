using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Singleton
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //https://msdn.microsoft.com/en-us/library/ff650316.aspx
            //firstExample();

            secondExample();
        }

        public static void firstExample(){
            ReservationSingleton instance = ReservationSingleton.GetInstance();
            Console.WriteLine("1st instace ID " + RuntimeHelpers.GetHashCode(instance));

            ReservationSingleton instance2 = ReservationSingleton.GetInstance();
            Console.WriteLine("2nd instace ID " + RuntimeHelpers.GetHashCode(instance2));
        }

        public static void secondExample(){
            Console.WriteLine("--------THREADS---------");

            new Thread(() =>
            {
                ReservationSingleton instance = ReservationSingleton.GetInstance();
                Console.WriteLine("1st thread instace ID " + RuntimeHelpers.GetHashCode(instance));
            }).Start();

            new Thread(() =>
            {
                ReservationSingleton instance = ReservationSingleton.GetInstance();
                Console.WriteLine("2nd thread instace ID " + RuntimeHelpers.GetHashCode(instance));
            }).Start();
        }
    }
}
