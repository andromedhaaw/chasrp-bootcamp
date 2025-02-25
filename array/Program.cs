using System;

class Program
{
    static void Main()
    {
        // 1. Declaring and Initializing Arrays
        char[] Vokal = new char[5] { 'a', 'e', 'i', 'o', 'u' };
        char[] VokalCSharp12 = ['a', 'e', 'i', 'o', 'u']; // C# 12 syntax
        Console.WriteLine("Vokal: " + string.Join(", ", Vokal));

        // 2. Accessing Array Elements
        Console.WriteLine($"First Vokal: {Vokal[0]}");
        Console.WriteLine($"Last Vokal: {Vokal[^1]}"); // Using C# 8 index operator

        // 3. Array Length Property
        Console.Write("All Vokal: ");
        for (int i = 0; i < Vokal.Length; i++)
        {
            Console.Write(Vokal[i] + " ");
        }
        Console.WriteLine("\n");

        // 4. Default Values in Arrays
        int[] numbers = new int[5]; // Initialized to 0
        Console.WriteLine($"Default int value at index 2: {numbers[2]}");

        // 5. Indices and Ranges (C# 8+)
        char[] firstTwo = Vokal[..2]; // First two elements
        char[] lastThree = Vokal[2..]; // Last three elements
        Console.WriteLine("First two Vokal: " + string.Join(", ", firstTwo));
        Console.WriteLine("Last three Vokal: " + string.Join(", ", lastThree));
    }
}

