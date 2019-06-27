using System;

namespace Sorting
{
    class Sort
    {
        //www.hackerrank.com/challenges/ctci-bubble-sort/problem
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
        
        // www.hackerrank.com/challenges/mark-and-toys/problem
        static int MaximumToys(int[] prices, int availableMoney)
        {
            int numToys = 0, moneySpent = 0;
            Array.Sort(prices);

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < availableMoney && moneySpent <= availableMoney)
                {
                    moneySpent += prices[i];
                    if (moneySpent <= availableMoney)
                    {
                        numToys++;
                    }
                }
            }

            return numToys;
        }
        
        static void Main(string[] args)
        {
            int[] unsorted = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            
            Console.WriteLine("BubbleSort Before");
            foreach (var item in unsorted)
            {
                Console.Write(item + " ");
            }
            
            BubbleSort(unsorted);
            
            Console.WriteLine("\nBubbleSort After");
            
            foreach (var item in unsorted)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\n\nMax Toys Before");

            int totalMoney = 50;
            int[] cost = {1, 12, 5, 111, 200, 1000, 10};

            int numToys = MaximumToys(cost, totalMoney);

            Console.WriteLine($"{totalMoney} total dollars for the items in the below list. We can buy {numToys} total");

            foreach (var item in cost)
            {
                Console.Write(item + " ");
            }

        }
    }
}