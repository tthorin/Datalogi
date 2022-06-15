// See https://aka.ms/new-console-template for more information
namespace DatalogiOvn1;

using System.Diagnostics;

internal static class RandomArray
{
    public static double[] TimedArray { get; set; } = new double[140000000];
    public static List<double> TimedList { get; set; } = new List<double>();

    internal static void SumNumbers()
    {
        if(TimedArray[0]==0) GenerateNumbers();
        var stopWatch = Stopwatch.StartNew();
        var output = 0d;
        for (int i = 0; i < TimedArray.Length; i++)
        {
            output += TimedArray[i];
        }
        stopWatch.Stop();
        var elapsed = stopWatch.Elapsed;
        //Console.WriteLine($"Sum is {output}");
        Console.WriteLine($"Add all numbers (array). Elapsed Time: {elapsed.TotalMilliseconds} ms.");
        stopWatch.Reset();
        //Console.WriteLine(stopWatch.Elapsed);
        output = 0;
        stopWatch.Start();
        foreach (var number in TimedArray)
        {
            output+=number;
        }
        stopWatch.Stop();
        elapsed = stopWatch.Elapsed;
        //Console.WriteLine($"Sum is {output} (foreach)");
        Console.WriteLine($"Add all numbers (array/foreach). Elapsed Time: {elapsed.TotalMilliseconds} ms.");
    }
    internal static void SumListNumbers()
    {
        if (TimedList[0] == 0) GenerateNumbersList();
        var stopWatch = Stopwatch.StartNew();
        var output = 0d;
        for (int i = 0; i < TimedList.Count; i++)
        {
            output += TimedArray[i];
        }
        stopWatch.Stop();
        var elapsed = stopWatch.Elapsed;
        //Console.WriteLine($"Sum is {output}");
        Console.WriteLine($"Add all numbers (list). Elapsed Time: {elapsed.TotalMilliseconds} ms.");
        stopWatch.Reset();
        //Console.WriteLine(stopWatch.Elapsed);
        output = 0;
        stopWatch.Start();
        foreach (var number in TimedList)
        {
            output += number;
        }
        stopWatch.Stop();
        elapsed = stopWatch.Elapsed;
        //Console.WriteLine($"Sum is {output} (foreach)");
        Console.WriteLine($"Add all numbers (list/foreach). Elapsed Time: {elapsed.TotalMilliseconds} ms.");
    }

    internal static void GenerateNumbers()
    {
        var stopWatch = Stopwatch.StartNew();
        var rng = new Random();
        for (int i = 0; i < TimedArray.Length; i++)
        {
            TimedArray[i] = rng.NextDouble() * 100 + 100;
        }
        stopWatch.Stop();
        var elapsed = stopWatch.Elapsed;
        Console.WriteLine($"Generate Numbers (array). Elapsed Time: {elapsed.TotalMilliseconds} ms.");
    }

    internal static void GenerateNumbersList()
    {
        TimedList.Clear();
        var stopWatch = Stopwatch.StartNew();
        var rng = new Random();
        for (int i = 0; i < TimedArray.Length; i++)
        {
            TimedList.Add(rng.NextDouble() * 100 + 100);
        }
        stopWatch.Stop();
        var elapsed = stopWatch.Elapsed;
        Console.WriteLine($"Generate Numbers (List). Elapsed Time: {elapsed.TotalMilliseconds} ms.");
    }
}
