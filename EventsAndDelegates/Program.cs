using System;

namespace EventsAndDelegates
{
    class MainClass
    {
        static void Logger(string m){
            Console.WriteLine("Logger::" + m);
        }

        public static void Main(string[] args)
        {
            Car.LoggerHandle myLogger = new Car.LoggerHandle(Logger);
            Car _car = new Car(myLogger);
            _car.HandleDoor();
            _car.HandleDoor();
            _car.HandleDoor();
            _car.Accelerate();
            _car.Accelerate();
            _car.Accelerate();
            _car.Accelerate();
            _car.Accelerate();
            _car.Accelerate();
            _car.Accelerate();
            _car.Decelerate();
        }
    }
}
