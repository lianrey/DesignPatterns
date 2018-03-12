using System;
namespace Proxy2
{
    public class Twitter
    {
        public void GetAccountFeed(){
            Console.WriteLine("GetAccountFeed");
        }

        public void PostTweet()
        {
            Console.WriteLine("PostTweet");
        }

        public void FollowAccount()
        {
            Console.WriteLine("FollowAccount");
        }

        public void UnfollowAccount()
        {
            Console.WriteLine("UnfollowAccount");
        }
    }
}
