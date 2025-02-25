using System;
using System.Text;

class Program
{
    static int Factorial(int x) => x == 0 ? 1 : x * Factorial(x - 1); // Stack (recursion)
    static void Increment(ref int p) => p++; // By Reference (ref)
    static void SplitName(string name, out string first, out string last) // By Output (out)
    {
        string[] parts = name.Split(' ');
        first = parts.Length > 0 ? parts[0] : "";
        last = parts.Length > 1 ? parts[1] : "";
    }
    static int Sum(params int[] nums) => nums.Length > 0 ? nums.Sum() : 0; // Using params
    static void Greet(string name = "Anonim") => Console.WriteLine($"Halo, {name}!"); // Optional Parameter

    static void Main()
    {
        Console.WriteLine($"Factorial(5): {Factorial(5)}"); // Stack recursion
        Console.WriteLine(new StringBuilder("Hello, Heap!")); // Heap object

        int num = 8;
        Increment(ref num); // Using ref
        Console.WriteLine($"After Increment: {num}");

        SplitName("John Doe", out string first, out string last); // Using out
        Console.WriteLine($"First Name: {first}, Last Name: {last}");

        Console.WriteLine($"Sum: {Sum(1, 2, 3, 4, 5)}"); // Using params
        Greet(); Greet("Alice"); // Optional Parameter
    }
}
