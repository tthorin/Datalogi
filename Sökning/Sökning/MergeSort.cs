namespace Sökning;

using System.Diagnostics;

internal static class MergeSortClass
{
    public static int Count { get; set; }
    public static decimal Time { get; set; }
    internal static T[] MergeSort<T>(IList<T> arr) where T : IComparable
    {
        Count = 0;
        var timer = Stopwatch.StartNew();
        if (arr.Count <= 1) return arr.ToArray();

        const int start = 0;
        var end = arr.Count - 1;

        var result = MergeSortRecursive(arr, start, end);
        timer.Stop();
        Time = timer.ElapsedTicks/10000M;
        return result;
    } //O(1)

    private static T[] MergeSortRecursive<T>(IList<T> arr, int start, int end) where T : IComparable
    {
        //Count++;
        if (start == end) return new T[] {arr[start]};

        var mid = (start + end) / 2;
        var left = MergeSortRecursive(arr, start, mid);
        var right = MergeSortRecursive(arr, mid + 1, end);

        return Merge(left,right);
    }

    private static T[] Merge<T>(T[] left, T[] right) where T : IComparable
    {
        var result = new T[left.Length + right.Length];
        int leftIndex = 0, rightIndex = 0, sortIndex = 0;
        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
            {
                result[sortIndex] = left[leftIndex];
                leftIndex++;
            }
            else
            {
                result[sortIndex] = right[rightIndex];
                rightIndex++;
            }
            sortIndex++;
            Count++;
        }
        while (leftIndex < left.Length)
        {
            result[sortIndex] = left[leftIndex];
            leftIndex++;
            sortIndex++;
            Count++;
        }
        while (rightIndex < right.Length)
        {
            result[sortIndex] = right[rightIndex];
            rightIndex++;
            sortIndex++;
            Count++;
        }
        return result;
    }
    private static void MergeInPlace<T>(IList<T> arr, int start, int mid,int end) where T : IComparable
    {
        int left = start, sortIndex = left, right = mid+1;
        while (left<right)
        {
            if (arr[left].CompareTo(arr[right]) < 0)
            {
                left++;
                sortIndex++;
            }
        }

    }
}
