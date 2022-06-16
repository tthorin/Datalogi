// See https://aka.ms/new-console-template for more information

using DatalogiOvn1;
using System.Diagnostics;
using static DatalogiOvn1.RandomArray;

//for (int i = 0; i < 5; i++)
//{
//    GenerateNumbersList();
//    GenerateNumbers();
//    Console.WriteLine();

//    SumNumbers();
//    SumListNumbers();
//    Console.WriteLine();
//}
//for (int i = 0; i < 5; i++)
//{
//    FillLinkedList(10000000);
//}
//TestMyStack();
TestMyList();

void TestMyList()
{
    MyLinkedList<string> myList = new();
    var keepGoing = true;
    while (keepGoing)
    {
        Console.Write("add <text>, get <index>: ");
        string input = Console.ReadLine();
        var command = input.Split(" ", 2);
        switch (command[0])
        {
            case "add": myList.Push(command[1]); break;

            case "get":
                var pop = myList.Get(int.Parse(command[1]));
                Console.WriteLine(pop);
                break;
            case "remove":
                myList.RemoveAt(int.Parse(command[1]));
                break;
            case "exit": keepGoing = false; break;
            default:
                Console.WriteLine("Unknown command.");
                break;
        }
    }

}

void TestMyStack()
{
    MyStack<string> myStack = new();
    while (true)
    {
        Console.Write("add <text>, print, or pop: ");
        string input = Console.ReadLine();
        var command = input.Split(" ", 2);
        switch (command[0])
        {
            case "add": myStack.Push(command[1]); break;
            case "addLast": myStack.AddLast(command[1]); break;
            case "pop":
                var pop = myStack.Pop();
                Console.WriteLine(pop);
                break;
            case "print":
                while (myStack.Count > 0)
                {
                    Console.WriteLine(myStack.Pop());
                }
                break;

            default:
                Console.WriteLine("Unknown command.");
                break;
        }
    }
}

void FillLinkedList(int count)
{
    var linkedList = new MyLinkedList<double>();

    var stopWatch = Stopwatch.StartNew();
    var rng = new Random();
    for (int i = 0; i < count; i++)
    {
        linkedList.Push(rng.NextDouble() * 100 + 100);
    }
    stopWatch.Stop();
    var elapsed = stopWatch.Elapsed;
    Console.WriteLine($"Generate Numbers (linkedList). Elapsed Time: {elapsed.TotalMilliseconds} ms.");

    var sum = 0d;
    stopWatch = Stopwatch.StartNew();
    for (int i = 0; i < count; i++)
    {
        sum += linkedList.Iterate();
    }
    stopWatch.Stop();
    elapsed = stopWatch.Elapsed;
    Console.WriteLine($"Sum Numbers (linkedList). Elapsed Time: {elapsed.TotalMilliseconds} ms.");
}
