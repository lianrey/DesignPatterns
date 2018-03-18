using System;

namespace Features
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point point1 = new Point(10);
            Point point2 = new Point(15);
            Point point3 = new Point(10);

            var result_sum = point1 + point2;
            Console.WriteLine(result_sum.Height);

            var result_substraction = point3 - point2;
            Console.WriteLine(result_substraction.Height);

            if (point1 == point3) Console.WriteLine("Are equals");
        }
    }
}
