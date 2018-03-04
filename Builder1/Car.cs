using System;
namespace Builder1
{
    public class Car
    {
        public string _model { get; set; }
        public int _wheels { get; set; }
        public string _upholstery { get; set; }
        public string _color { get; set; }
        public bool _airConditioning { get; set; }

        public Car(string model, int wheels, string upholstery, string color, bool airConditioning)
        {
            _model = model;
            _wheels = wheels;
            _upholstery = upholstery;
            _color = color;
            _airConditioning = airConditioning;
        }
    }
}
