using System;
namespace Proxy1
{
    public class StreamProxy: MyStream
    {
        public void DoSomething()
        {
            ExternalStream ex = new ExternalStream();
            ex.DoSomething();
        }
    }
}
