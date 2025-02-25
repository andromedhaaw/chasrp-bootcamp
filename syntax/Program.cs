using System;

class Example
{
    static void Main()
    {
        // Variable declaration
        int number = 10;
        Console.WriteLine("Number: " + number);

        // Array using `{}` and indexing with `[]`
        int[] numbers = {1, 2, 3}; 
        Console.WriteLine("Second Element: " + numbers[1]);

        // Loop (for)
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }

        // Conditional statement (if-else)
        if (number > 5)
        {
            Console.WriteLine("Number is greater than 5");
        }
        else
        {
            Console.WriteLine("Number is 5 or less");
        }

        // Simple function call
        PrintMessage();
    }

    // Method (function)
    static void PrintMessage()
    {
        Console.WriteLine("Hello from PrintMessage!");
    }
}
