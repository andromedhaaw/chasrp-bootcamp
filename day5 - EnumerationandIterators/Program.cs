using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Iterasi menggunakan foreach 
        foreach (char c in "beer")
        {
            Console.WriteLine(c);
        }

        // 2. Collection Initializer 
        var numbers = new List<int> { 1, 2, 3 };
        foreach (var num in numbers)
        {
            Console.Write(num + " "); // Output: 1 2 3
        }
        Console.WriteLine();

        // 3. Iterator dengan yield return 
        foreach (int fib in Fibs(6))
        {
            Console.Write(fib + " "); // Output: 0 1 1 2 3 5
        }
        Console.WriteLine();
    }

    // Iterator: Fibonacci Sequence 
    static IEnumerable<int> Fibs(int count)
    {
        int prev = 0, cur = 1;
        for (int i = 0; i < count; i++)
        {
            yield return prev;
            int newFib = prev + cur;
            prev = cur;
            cur = newFib;
        }
    }
}
