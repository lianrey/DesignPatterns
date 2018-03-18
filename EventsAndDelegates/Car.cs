using System;
using System.Collections;

namespace EventsAndDelegates
{
    public class Car
    {
        public int _maxSpeed = 100;
        public int _speed = 0;
        public bool isDead = false;
        public bool isOpened = false;
        public delegate void LoggerHandle(string message);
        LoggerHandle _logHandler;

        public Car(LoggerHandle logHander){
            _logHandler = logHander;
        }
       
        public void HandleDoor(){
            if(isOpened){
                Console.WriteLine("Close door");
                _logHandler("close door");
            }
            else{
                isOpened = true;
                Console.WriteLine("Open door");
                _logHandler("Open door");
            }
             
        }

        public void Accelerate()
        {
            if (!isDead && _speed < _maxSpeed)
            { 
                _speed += 20;
                Console.WriteLine("Accelerating: " + _speed);
                _logHandler("Accelerating spead::" + _speed);
            }
            else{
                Console.WriteLine("Sorry car is dead");
                _logHandler("Sorry car is dead " + _speed);
            }
        }

        public void Decelerate()
        {
            _speed =  (_speed == 0)? 0: _speed -20;
            Console.WriteLine("Decelerating: " + _speed);
            _logHandler("Decelerating spead::" + _speed);
        }
    }
}
