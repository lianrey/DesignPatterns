using System;
namespace InterviewCake
{
    public class Question2
    {
        public static int[] GetProductsOfAllIntsExceptAtIndex(int[] intArray)
        {
            if (intArray.Length < 2)
            {
                throw new ArgumentException("Getting the product of numbers at other indices requires at least 2 numbers", nameof(intArray));
            }
            int[] resultBefore = new int[intArray.Length];
            int productSoFar = 1;

            for (int i = 0; i < intArray.Length; i++)
            {
                resultBefore[i] = productSoFar;
                productSoFar *= intArray[i];
            }

            int[] resultFinal = new int[intArray.Length];
            productSoFar = 1;
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                resultFinal[i] = productSoFar * resultBefore[i];
                productSoFar *= intArray[i];
            }

            return resultFinal;
        }
    }
}
