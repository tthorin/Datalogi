namespace Sökning
{
    using System;
    using static Sökning.Seek;
    internal static class Ovningar

    {
        internal static void Ovning1()
        {
            var list = new MyLinkedList<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);

            var result = list.Find(x => x == 2);
            Console.WriteLine("Ovning 1\nList contains: 3, 2, 1");
            Console.WriteLine("Looking for 2, result is: " + result.found);
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
                var result = list.Find(x => x == numberToFind);
            }
        }
        internal static void Ovning3()
        {
            for (int j = 0; j < 10; j++)
            {
                var intArr = new int[1000];
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
    }
}
