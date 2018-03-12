using System;
namespace Proxy2
{
    public class TwitterProxy: GetTwitterData
    {
        public void GetAccountFeed()
        {
            Twitter t = new Twitter();
            t.GetAccountFeed();
        }

        public void UnfollowAccount()
        {
            Twitter t = new Twitter();
            t.UnfollowAccount();
        }
    }
}
