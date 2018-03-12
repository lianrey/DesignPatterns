using System;

namespace Proxy2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TwitterProxy tproxy = new TwitterProxy();
            tproxy.GetAccountFeed();
            tproxy.UnfollowAccount();
        }
    }
}
