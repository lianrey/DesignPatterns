using System;

namespace Generics2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string value = "5";
            int result = Convert<Int32>.ParseType(value);
            Double result2 = Convert<Double>.ParseType(value);
            Console.WriteLine(result.GetType());
            Console.WriteLine(result2.GetType());
        }
    }
}
