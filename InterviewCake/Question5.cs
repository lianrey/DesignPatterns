using System;
using System.Linq;
namespace InterviewCake
{
    public class Question5
    {
        public static int ChangePossibilitiesBottomUp(int amount, int[] denominations, int currentIndex = 0)
        {
            int[] waysOfDoingNCents = new int[amount + 1];
            waysOfDoingNCents[0] = 1;

            foreach (int coin in denominations)
            {
                Console.WriteLine("Coin:" + coin);
                for (int higherAmount = coin; higherAmount <= amount; higherAmount++)
                {
                    int higherAmountRemainder = higherAmount - coin;
                    Console.WriteLine("higherAmountRemainder:" + higherAmountRemainder);
                    waysOfDoingNCents[higherAmount] += waysOfDoingNCents[higherAmountRemainder];

                    Console.WriteLine("waysOfDoingNCents[higherAmountRemainder]:" + waysOfDoingNCents[higherAmountRemainder]);
                }
            }

            return waysOfDoingNCents[amount]; ;
        }
    }
}
