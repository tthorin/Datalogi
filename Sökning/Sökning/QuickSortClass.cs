namespace Sökning;

using System;
using System.Collections.Generic;
using System.Diagnostics;

internal static class QuickSortClass
{
    public static int Count { get; set; }
    public static decimal Time { get; set; }
    internal static T[] QuickSortNotExtension<T>(IList<T> arr) where T : IComparable
    {
        Count = 0;
        if (arr.Count <= 1) return arr.ToArray();
        var sorted = arr.ToArray();
        var timer = Stopwatch.StartNew();

        const int start = 0;
        var end = arr.Count - 1;
        QuickSortRecursive(sorted, start, end);
        timer.Stop();
        Time = timer.ElapsedTicks / 10000M;
        return sorted;
    }
    internal static void QuickSort<T>(this IList<T> arr) where T : IComparable
    {
        Count = 0;
        if (arr.Count <= 1) return;
        var timer = Stopwatch.StartNew();

        const int start = 0;
        var end = arr.Count - 1;
        QuickSortRecursive(arr, start, end);
        timer.Stop();
        Time = timer.ElapsedTicks / 10000M;
    }

    private static void QuickSortRecursive<T>(IList<T> arr, int start, int end) where T : IComparable
    {
        //Count++;
        if (start < end)
        {
            //for HoarePartition should be pivot & pivot +1, for other should be pivot -1 & pivot +1
            if (end - start <= 10) InsertionSort(arr, start, end);
            else
            {
                var pivot = HoarePartition(arr, start, end);
                QuickSortRecursive(arr, start, pivot);
                QuickSortRecursive(arr, pivot + 1, end);
            }
            //var pivot = HoarePartition(arr, start, end);
            //QuickSortRecursive(arr, start, pivot);
            //QuickSortRecursive(arr, pivot + 1, end);
        }
    }

    private static int HoarePartition<T>(IList<T> arr, int start, int end) where T : IComparable
    {
        var mid = (start + end) / 2;
        var pivot = arr[mid];
        var left = start - 1;
        var right = end + 1;
        while (true)
        {
            do
            {
                left++;
            } while (arr[left].CompareTo(pivot) < 0);
            do
            {
                right--;
            } while (arr[right].CompareTo(pivot) > 0);
            if (left >= right) return right;
            Count++;
            (arr[left], arr[right]) = (arr[right], arr[left]);
        }
    }
    private static void InsertionSort<T>(IList<T> arr, int start, int end) where T : IComparable
    {
        for (var i = start; i <= end; i++)
        {
            var j = i;
            while (j > start && arr[j - 1].CompareTo(arr[j]) > 0)
            {
                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                j--;
                Count++;
            }
        }
    }
    private static int Partition<T>(IList<T> arr, int start, int end) where T : IComparable
    {
        // 1 2 3 4 5
        // 1 2 3 4 5
        // 1 2 5 4 3
        var mid = (start + end) / 2;
        if (arr[mid].CompareTo(arr[start]) < 0) (arr[mid], arr[start]) = (arr[start], arr[mid]);
        if (arr[end].CompareTo(arr[start]) < 0) (arr[end], arr[start]) = (arr[start], arr[end]);
        if (arr[mid].CompareTo(arr[end]) < 0) (arr[mid], arr[end]) = (arr[end], arr[mid]);

        var pivot = arr[end];
        var i = start - 1;
        for (var j = start; j < end; j++)
        {
            if (arr[j].CompareTo(pivot) < 0)
            {
                i++;
                (arr[j], arr[i]) = (arr[i], arr[j]);
            }
        }
        (arr[i + 1], arr[end]) = (arr[end], arr[i + 1]);
        return i + 1;
    }
}
