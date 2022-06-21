namespace Sökning;

using System;
using static Sökning.Seek;
using static Sökning.MergeSortClass;
using static Sökning.QuickSortClass;
using System.Diagnostics;

internal static class Ovningar

{
    internal static void Ovning1()
    {
        var list = new MyLinkedList<int>();
        list.Push(1);
        list.Push(2);
        list.Push(3);

        var (found, data) = list.Find(x => x == 2);
        Console.WriteLine("Ovning 1\nList contains: 3, 2, 1");
        Console.WriteLine("Looking for 2, result is: " + found);
        Console.WriteLine("Looking for 3, result is: " + list.Find(x => x == 3));
        Console.WriteLine("Looking for 4, result is: " + list.Find(x => x == 4));
        Console.WriteLine("Looking for greater than 1, result is: " + list.Find(x => x > 1));
        Console.WriteLine("Looking for smaller than 3, result is: " + list.Find(x => x < 3));
    }
    internal static void Ovning1b()
    {
        var list = new MyLinkedList<int>();
        list.Push(1);
        list.Push(2);
        list.Push(3);

        var serchResult = list.FindLast(x => x == 2);
        Console.WriteLine("\nOvning 1b\nList contains: 3, 2, 1");
        Console.WriteLine("Looking for 2, result is: " + serchResult);
        Console.WriteLine("Looking for 3, result is: " + list.FindLast(x => x == 3));
        Console.WriteLine("Looking for 4, result is: " + list.FindLast(x => x == 4));
        Console.WriteLine("Looking for greater than 1, result is: " + list.FindLast(x => x > 1));
        Console.WriteLine("Looking for smaller than 3, result is: " + list.FindLast(x => x < 3));
    }
    internal static void Ovning2()
    {
        for (int i = 0; i <= 10; i++)
        {
            var list = new MyLinkedList<int>();
            var rng = new Random();
            for (int j = 0; j < 100; j++)
            {
                list.Push(rng.Next(1, 101));
            }
            var numberToFind = rng.Next(1, 101);
            var (found, data) = list.Find(x => x == numberToFind);
        }
    }
    internal static void Ovning3()
    {
        for (int j = 0; j < 10; j++)
        {
            var intArr = new int[100];
            var rng = new Random();
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rng.Next(1, 101);
            }
            Array.Sort(intArr);
            var lookingFor = rng.Next(1, 101);
            FindWhenSorted(intArr, lookingFor);
        }
    }
    internal static void Ovning3Recursive()
    {
        for (int j = 0; j < 10; j++)
        {
            var intArr = new int[100];
            var rng = new Random();
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rng.Next(1, 101);
            }
            Array.Sort(intArr);
            var lookingFor = rng.Next(1, 101);
            FindWhileSortedRecursive(intArr, lookingFor);
        }
    }
    const int SIZE = 7000000;
    internal static void Ovning4Sort()
    {
        var sample = new List<int>();
        var rng = new Random();
        for (int i = 0; i < SIZE; i++)
        {
            sample.Add(rng.Next(1, 1001));
        }
        var mergeSorted = MergeSort(sample);
        Console.WriteLine("\nMerge sort took " + MergeSortClass.Count + " steps in " + MergeSortClass.Time + " ms");
        var quickSorted = QuickSortNotExtension(sample);
        Console.WriteLine("Quick sort took " + QuickSortClass.Count + " steps in " + QuickSortClass.Time + " ms");
        //sample.QuickSort();
        //sample[0] = 999;
        //Console.WriteLine("Sample[0] set to 999, mergeSorted[0] is " + mergeSorted[0] + " and quickSorted[0] is " + quickSorted[0]);
        //mergeSorted[0] = 999;
        //Console.WriteLine("Sample[0] and mergeSorted[0] set to 999, mergeSorted[0] is " + mergeSorted[0] + " and quickSorted[0] is " + quickSorted[0]);
        //foreach (var number in quickSorted)
        //{
        //    Console.WriteLine(number);
        //}
    }
    internal static void SortAndFindTest()
    {
        var sampleOne = new List<int>();
        var rng = new Random();
        for (int i = 0; i < SIZE; i++)
        {
            sampleOne.Add(rng.Next(1, 1001));
        }
        var numberToFind = rng.Next(1, 1001);
        var timer = Stopwatch.StartNew();
        var quickSorted = QuickSortNotExtension(sampleOne);
        FindWhenSorted(quickSorted, numberToFind);
        timer.Stop();
        Console.WriteLine(timer.ElapsedMilliseconds);
        timer.Restart();
        sampleOne.Sort();
        FindWhenSorted(sampleOne.ToArray(), numberToFind);
        timer.Stop();
        Console.WriteLine(timer.ElapsedMilliseconds);
    }
}
