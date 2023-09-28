
using System;

class Program
{
    static uint FibonacciNum(uint n)
    {
        return (n == 0 || n == 1)
            ? 1
            : FibonacciNum(n - 1) + FibonacciNum(n - 2);
    }

    static void Main(string[] args)
    {
        Console.Write("N = ");
        var n = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine($"{n} перших чисел Фiбоначчi");
        for (uint i = 0; i < n; i++)
        {
            var separator = i + 1 == n ? string.Empty : ", ";
            Console.Write($"{FibonacciNum(i)}{separator}");
        }
        Console.ReadLine();
    }
}