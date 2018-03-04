using System;
namespace Command
{
    public class SendOrder: ICommand
    {
        IElectronicDevice device;

        public SendOrder(IElectronicDevice newDevice){
            device = newDevice;
        }

        public void execute()
        {
            device.SendOrder();
        }
    }
}
