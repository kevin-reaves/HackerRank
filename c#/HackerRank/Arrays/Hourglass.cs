// https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays


using System.Linq;
using System;

namespace Arrays
{
    class Hourglass
    {
        static int HourGlassSum(int[,] arr)
        {
            // Gets the length of a certain dimension. 1 returns the len of the inner set of arrays -- arr[0]
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            int maxSum = int.MinValue;

            if (rows != cols)
            {
                throw new ArgumentException("Your array should have the same number of rows and cols");
            }

            // Starting from the top left most element in the hourglass, needs to go down 2 and right 2
            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    int sum = (
                        // top
                        arr[i, j] + arr[i, j + 1] + arr[i, j + 2]
                        // mid
                        + arr[i + 1, j + 1]
                        // bottom
                        + arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2]
                    );

                    maxSum = Math.Max(maxSum, sum);
                }
            }

            return maxSum;
        }

        // Complete the hourglassSum function below.
        static int HourGlassSum(int[][] arr) {
            // Gets the length of a certain dimension. 1 returns the len of the inner set of arrays -- arr[0]
            int rows = arr.Count();
            int cols = arr[0].Count();

            int maxSum = int.MinValue;

            // Starting from the top left most element in the hourglass, needs to go down 2 and right 2
            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    int sum = (
                        // top
                        arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                        // mid
                        + arr[i + 1][j + 1]
                        // bottom
                        + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]
                    );

                    maxSum = Math.Max(maxSum, sum);
                }
            }

            return maxSum;
        }

        static void Main(string[] args)
        {
            // Hacker Rank uses the [][] syntax, wanted to work through that way as well
            int[,] hourGlassArray = new int[,]
            {
                {1, 1, 1, 0, 0, 0},
                {0, 1, 0, 0, 0, 0},
                {1, 1, 1, 0, 0, 0},
                {0, 0, 2, 4, 4, 0},
                {0, 0, 0, 2, 0, 0},
                {0, 0, 1, 2, 4, 0},
            };

            int result = HourGlassSum(hourGlassArray);
            Console.WriteLine(result);
            
            int[][] hourGlassArray2 = new int[6][];
            hourGlassArray2[0] = new int[6] {1, 1, 1, 0, 0, 0};
            hourGlassArray2[1] = new int[6] {0, 1, 0, 0, 0, 0};
            hourGlassArray2[2] = new int[6] {1, 1, 1, 0, 0, 0};
            hourGlassArray2[3] = new int[6] {0, 0, 2, 4, 4, 0};
            hourGlassArray2[4] = new int[6] {0, 0, 0, 2, 0, 0};
            hourGlassArray2[5] = new int[6] {0, 0, 1, 2, 4, 0};

            int result2 = HourGlassSum(hourGlassArray2);
            Console.WriteLine(result2);

        }
    }
}