using System;

namespace InterviewCake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // QUESTION 1
            var stockPrices = new int[] { 12, 10, 7, 5, 11, 9, 2 };
            Console.WriteLine(Question1.GetMaxProfit(stockPrices));

            // QUESTION 2
            var intArray = new int[] { 3, 4 };
            var result = Question2.GetProductsOfAllIntsExceptAtIndex(intArray);
            foreach (var value in result)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}