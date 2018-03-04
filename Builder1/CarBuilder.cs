using System;
namespace Builder1
{
    public class CarBuilder
    {
        private string _model;
        private int _wheels;
        private string _upholstery;
        private string _color;
        private bool _airConditioning;

        public CarBuilder Model(string model){
            _model = model;
            return this;
        }

        public CarBuilder Wheels(int wheels)
        {
            _wheels = wheels;
            return this;
        }

        public CarBuilder Upholstery(string upholstery)
        {
            _upholstery = upholstery;
            return this;
        }

        public CarBuilder Color(string color)
        {
            _color = color;
            return this;
        }

        public CarBuilder AirConditioning(bool airConditioning)
        {
            _airConditioning = airConditioning;
            return this;
        }

        public Car Build(){
            return new Car(_model, _wheels, _upholstery, _color, _airConditioning);
        }

    }
}
