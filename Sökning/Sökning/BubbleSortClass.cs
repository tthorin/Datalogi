namespace Sökning;

internal static class BubbleSortClass
{
    internal static T[] BubbleSort<T>(IList<T> arr) where T : IComparable<T>
    {
        var sorted = arr.ToArray();
        if (arr.Count <= 1) return sorted;
        //int last = sorted.Length - 1;
        for (int i = 0; i < sorted.Length - 1; i++)
        {
            for (int j = 0; j < sorted.Length - 1 - i; j++)
            {
                if (sorted[j].CompareTo(sorted[j + 1]) > 0)
                {
                    (sorted[j], sorted[j + 1]) = (sorted[j + 1], sorted[j]);
                }
            }
            //last--;
        }
        return sorted;
    }
}
