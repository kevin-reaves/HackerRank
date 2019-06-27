using System;

namespace Sorting
{
    class Sort
    {
        static void BubbleSort(int[] unsorted)
        {
            int n = unsorted.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (unsorted[j] > unsorted[j + 1])
                    {
                        int temp = unsorted[j];
                        unsorted[j] = unsorted[j + 1];
                        unsorted[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] unsorted = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            BubbleSort(unsorted);
            foreach (var item in unsorted)
            {
                Console.Write(item + " ");
            }
        }
    }
}