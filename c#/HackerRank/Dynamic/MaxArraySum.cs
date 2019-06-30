using System;

namespace Dynamic
{
    class Program
    {
        // https://www.hackerrank.com/challenges/max-array-sum/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dynamic-programming
        static int MaximumArraySum(int[] arr)
        {
            // The comparison between incl and excl handles the alternating array issue 
            // Either we take the set including the previous array, or we take the set excluding it
            int incl = 0, excl = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int tempExcl = Math.Max(incl, excl);
                incl = excl + arr[i];
                excl = tempExcl;
            }

            return Math.Max(incl, excl);
        }

        static void Main(string[] args)
        {
            int[] arr = {5, 5, 10, 100, 10, 5};
            int result = MaximumArraySum(arr);
            Console.WriteLine(result);
        }
    }
}