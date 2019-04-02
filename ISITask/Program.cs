using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(FindFactorial(num));
        }

        static BigInteger FindFactorial(BigInteger num)
        {
            BigInteger factorial = 1;

            for (BigInteger i = num; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
