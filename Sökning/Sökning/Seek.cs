namespace Sökning;

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
    public static int RecursiveCounter { get; set; }
    internal static int FindWhileSortedRecursive(int[] arr, int target)
    {
        RecursiveCounter = 0;
        if (arr.Length <= 1) return -1;
        var max = arr.Length - 1;
        const int  min = 0;

        return RecursiveFind(arr, target, min, max);
    }
    private static int RecursiveFind(int[] arr, int target,int min,int max)
    {
        RecursiveCounter++;
        if (max <= min)
        {
            Console.WriteLine("Didnt find " + target + ", used " + RecursiveCounter + " loops");
            return -1;
        }

        var lookingAt = (max + min) / 2;
        if (arr[lookingAt] == target)
        {
            Console.WriteLine("Found " + target + ", used " + RecursiveCounter + " loops");
            return arr[lookingAt];
        }
        else if (arr[lookingAt] > target) max = lookingAt - 1;
        else min = lookingAt + 1;
        return RecursiveFind(arr, target, min, max);
    }
}
