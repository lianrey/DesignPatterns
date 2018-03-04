using System;
namespace Command
{
    public class Pad: IElectronicDevice
    {
        public void SendOrder()
        {
            Console.WriteLine("Sending order to cook");
        }
    }
}
