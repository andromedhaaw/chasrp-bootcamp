using System;
using System.Text;

class Program
{
    static int Factorial(int x) => x == 0 ? 1 : x * Factorial(x - 1); // Stack (rekursi)
    static void Increment(ref int p) => p++; // By Reference (ref)
    static void SplitName(string name, out string first, out string last) // By Output (out)
    {
        var parts = name.Split(' ');
        first = parts[0];
        last = parts.Length > 1 ? parts[1] : ""; 
    }
    static int Sum(params int[] nums) => nums.Length > 0 ? nums.Sum() : 0; // Params (jumlah fleksibel)
    static void Greet(string name = "Anonim") => Console.WriteLine($"Halo, {name}!"); // Optional Parameter

    static void Main()
    {
        Console.WriteLine($"Factorial(5): {Factorial(5)}"); // Stack
        Console.WriteLine(new StringBuilder("Hello, Heap!")); // Heap

        int num = 8; Increment(ref num);
        Console.WriteLine($"Setelah Increment: {num}"); // By Reference

        SplitName("John Doe", out string first, out string last);
        Console.WriteLine($"Nama Depan: {first}, Nama Belakang: {last}"); // By Output

        Console.WriteLine($"Total: {Sum(1, 2, 3, 4, 5)}"); // Params
        Greet(); Greet("Alice"); // Optional Parameter
    }
}
