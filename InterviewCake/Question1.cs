using System;

namespace InterviewCake
{
    class Question1
    {
        public static int GetMaxProfit(int[] stockPricesYesterday)
        {
            if (stockPricesYesterday.Length < 2)
            {
                throw new ArgumentException("Getting a profit requires at least 2 prices", nameof(stockPricesYesterday));
            }

            // Calculate the max profit
            int minPrice = stockPricesYesterday[0];
            int max = stockPricesYesterday[1] - stockPricesYesterday[0];

            for (int i = 1; i < stockPricesYesterday.Length; i++)
            {

                int currentPrice = stockPricesYesterday[i];

                int potentialProfit = currentPrice - minPrice;

                max = Math.Max(max, potentialProfit);

                minPrice = Math.Min(minPrice, currentPrice);
            }

            return max;
        }
    }
}