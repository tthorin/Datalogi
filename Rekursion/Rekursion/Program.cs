// See https://aka.ms/new-console-template for more information
using static Rekursion.Recursion;

var wantToKnow = 5;
Console.WriteLine($"Factorial of {wantToKnow} is {Factorial(wantToKnow)}.");

PrintNumbers(5);

var startAmount = 100;
Console.WriteLine(CalculateBalance(startAmount,50));

int[] myArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var result = ArraySum(myArr, 8);
Console.WriteLine($"ArraySum result = {result}");

var whatIsFibFor = 400;
//Console.WriteLine($"Number {whatIsFibFor} in the Fibonacci sequence is {Fibonacci(whatIsFibFor)}.");
//Console.WriteLine($"(Iterative)Number {whatIsFibFor} in the Fibonacci sequence is {FibIterative(whatIsFibFor)}.");
//for (int i = 0; i <= whatIsFibFor; i++)
//{
//    var loopResult = FibIterative(i);
//    if (loopResult < 0)
//    {
//        Console.WriteLine($"i is {i}, value caused overflow, value is {loopResult}");
//        break;
//    }
//    Console.WriteLine(loopResult);
//}

//PrintEven(0, 10);
Console.WriteLine(Reverse("hejhej"));
Console.WriteLine("is pap papp a palindrome? "+IsPalindrome("pap papp"));
Console.WriteLine("is ni talar bra latin a palindrome? " + IsPalindrome("ni talar bra latin"));
