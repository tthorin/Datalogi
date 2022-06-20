namespace Sökning
{
    using System;
    using System.Collections.Generic;

    internal static class Seek
    {
        internal static int FindWhenSorted(int[] arr, int value)
        {
            var max = arr.Length - 1;
            var min = 0;
            var lookingAt = (max + min) / 2;
            var loops = 0;
            while (max > min)
            {
                loops++;
                if (arr[lookingAt] == value)
                {
                    Console.WriteLine($"Found, used {loops} loops");
                    return value;

                }
                else if (value > arr[lookingAt])
                {
                    min = lookingAt + 1;
                }
                else
                {
                    max = lookingAt - 1;
                }
                lookingAt = (max + min) / 2;
            }
            Console.WriteLine($"not found, used {loops} loops");
            return -1;
        }
        internal static int FindWhileSortedRecursive(int[] arr, int target)
        {
            
            return 0;
        }
    }
}
