using System;
namespace EventsAndDelegates
{
    public class Car
    {
        public int _maxSpeed = 100;
        public int _speed = 0;
        public bool isDead = false;
        public bool isOpened = false;
        public delegate void LoggerHandle(string message);
        LoggerHandle _logHander;

        public Car(LoggerHandle logHander){
            _logHander = logHander;
        }
       
        public void HandleDoor(){
            if(isOpened){
                Console.WriteLine("Close door");
                _logHander("Logger: close door");
            }
            else{
                isOpened = true;
                Console.WriteLine("Open door");
                _logHander("Logger: Open door");
            }

        }

        public void Accelerate()
        {
            if (!isDead)
            { 
                _speed += _speed + 20;
                Console.WriteLine("Accelerating: " + _speed);
            }
            else{
                Console.WriteLine("Sorry car is dead");
            }
        }

        public void Decelerate()
        {
            _speed =  (_speed == 0)? 0: _speed--;
            Console.WriteLine("Decelerating: " + _speed);
        }
    }
}
