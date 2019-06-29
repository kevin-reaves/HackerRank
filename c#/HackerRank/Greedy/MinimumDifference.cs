using System;
using System.Collections.Immutable;

namespace Greedy
{
    class Program
    {
        // Could make this in, didn't set up with c# 7.2
        // Don't feel like changing setup for this
        
        // https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms
        static int MinimumAbsoluteDifference(int[] arr)
        {
            int result = int.MaxValue;
            // Deep copy into local array, don't want to modify original
            int[] local = (int[]) arr.Clone();
            
            // Sorting the array to reduce the total number of checks needed
            Array.Sort(local);

            // For each item in the array, compare it to the item on the right
            // Check if absolute value of right - left is lower than current best
            for (int i = 0; i < local.Length - 1; i++)
            {
                int left = local[i];
                int right = local[i + 1];
                if (Math.Abs(right - left) < result)
                {
                    result = Math.Abs(right - left);
                }
            }
            
            return result;
        }
        
        static void Main(string[] args)
        {
            int[] arr = {-59, -36, -13, 1, -53, -2, -96, -54, 75};
            int result = MinimumAbsoluteDifference(arr);
            Console.WriteLine(result);
        }
    }
}