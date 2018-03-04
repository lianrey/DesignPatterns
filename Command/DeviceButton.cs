using System;
namespace Command
{
    public class DeviceButton
    {
        ICommand command;

        public DeviceButton(ICommand newCommand)
        {
            command = newCommand;
        }

        public void Press(){
            command.execute();
        }
    }
}
