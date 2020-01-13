using System;

namespace Lab0
{
    class Program
    {
        static void Main(string[] args)
        {
            int mpp = 0;
            int[] numbers = { 1, 2, 10, 90, 10, 2, 1};
            mpp = MaxPairwiseProduct.NaiveMaxPairwiseProduct(numbers);
            Console.WriteLine(mpp);

            mpp = MaxPairwiseProduct.BetterMaxPairwiseProduct(numbers);
            Console.WriteLine(mpp);
        }
    }
}
