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
        
            // QUESTION 6
            Console.WriteLine(Question6.FindRectangularOverlap(new Rectangle(1, 10, 3, 20), new Rectangle(2, 10, 3, 15)).LeftX);

            // QUESTION 7
            TempTracker temp = new TempTracker();
            temp.addTemperature(1);
            temp.addTemperature(3);
            temp.addTemperature(6);
            temp.addTemperature(3);
            temp.addTemperature(1);
            temp.addTemperature(3);
            Console.WriteLine($"Max: {temp.GetMax()}");
            Console.WriteLine($"Min: {temp.GetMin()}");
            Console.WriteLine($"Average: {temp.GetMean()}");
            Console.WriteLine($"Total: {temp.GetMode()}");

            // QUESTION 8
            BinaryTreeNode tree = new BinaryTreeNode(1);
            BinaryTreeNode left1 = tree.InsertLeft(2);
            BinaryTreeNode left2 = left1.InsertLeft(3);
            BinaryTreeNode left3 = left2.InsertLeft(4);

            BinaryTreeNode right1 = tree.InsertRight(5);
            BinaryTreeNode right1left1 = tree.InsertRight(8);
            BinaryTreeNode right2 = right1.InsertRight(6);
            BinaryTreeNode right3 = right2.InsertRight(7);

            Console.WriteLine("Is balanced:D " + Question8.IsBalanced(tree));
        }
    }
}