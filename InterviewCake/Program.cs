using System;
using System.Collections.Generic;

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
            var result2 = Question2.GetProductsOfAllIntsExceptAtIndex(intArray);
            foreach (var value in result2)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            // QUESTION 4
            var meetings = new List<Meeting>()
            {
                new Meeting(0,12),
                new Meeting(1,2),
                new Meeting(22,23)
            };

            var result4 = Question4.mergeRanges(meetings);
            foreach (var meeting in result4)
            {
                Console.Write($"{meeting} ");
            }
            Console.WriteLine();


            // QUESTION 5
            Console.WriteLine(Question5.ChangePossibilitiesBottomUp(4, new int[]{ 1, 2, 3 }));
        }
    }
}