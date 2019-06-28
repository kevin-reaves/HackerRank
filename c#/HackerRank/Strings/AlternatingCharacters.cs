using System;

namespace Strings
{
    class Program
    {
        // https://www.hackerrank.com/challenges/alternating-characters/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        static int CountRemovedCharacters(string dupString)
        {
            int result = 0;
            int look = dupString.Length;
            // Can't check element n + 1, so we only need to go to -1 length
            for (int i = 0; i < dupString.Length -1; i++)
            {
                if (dupString[i] == dupString[i + 1])
                {
                    result += 1;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            string duplicateString = "AAABBB";
            int result = CountRemovedCharacters(duplicateString);
            Console.WriteLine(result);
        }
    }
}