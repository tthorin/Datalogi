namespace Rekursion
{
    internal static class Recursion
    {
        public static int Factorial(int n)
        {
            if (n <= 0) return 1;
            return n * Factorial(n - 1);
        }

        public static void PrintNumbers(int num)
        {
            if (num < 1) return;
            PrintNumbers(num - 1);
            Console.WriteLine(num);
        }
        public static double CalculateBalance(double balance, int years)
        {
            const double interest = 0.05;
            if (years == 1) return balance + balance * interest;

            var accumulated = CalculateBalance(balance, years - 1);
            return accumulated + accumulated * interest;
        }
        public static int ArraySum(int[] array, int startIndex = 0)
        {
            if (startIndex == array.Length - 1) return array[startIndex];
            return array[startIndex] + ArraySum(array, startIndex + 1);
        }
        public static int Fibonacci(int n)
        {
            if (n == 1) return 0;
            else if (n == 2) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static long FibIterative(int n)
        {
            if (n <= 1) return 0;
            if (n == 2) return 1;
            //var fibList = new List<long> { 0, 1 };
            long twoBack = 0;
            long oneBack = 1;
            long answer = 0;
            for (int i = 2; i <= n; i++)
            {
                answer = oneBack + twoBack;
                twoBack = oneBack;
                oneBack = answer;
            }
            return answer;
        }
        public static void PrintEven(int min, int max)
        {
            if (max < min) return;
            PrintEven(min, max - 1);
            if (max % 2 == 0) Console.WriteLine(max);
        }
        public static string Reverse(string s, int startAt = 0)
        {
            if (startAt == s.Length - 1) return s[startAt].ToString();
            return Reverse(s, startAt + 1) + s[startAt].ToString();
        }
        
        public static bool IsPalindrome(string s)
        {
            return s.Replace(" ","").Equals(Reverse(s).Replace(" ",""));
        }
    }
}
