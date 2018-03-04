using System;

namespace Command
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IElectronicDevice device = new Pad();

            SendOrder sendOrderCommand = new SendOrder(device);
            //sendOrderCommand.execute();

            DeviceButton onPress = new DeviceButton(sendOrderCommand);

            onPress.Press();
        }
    }
}
