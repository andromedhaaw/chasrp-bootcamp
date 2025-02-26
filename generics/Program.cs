using System;

class Program
{
    // ✅ Move Swap<T> inside the Program class
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int x = 5, y = 10;
        Swap(ref x, ref y);
        Console.WriteLine($"{x}, {y}"); // Output: 10, 5

        string a = "Kopi", b = "Teh";
        Swap(ref a, ref b);
        Console.WriteLine($"{a}, {b}"); // Output: Teh, Kopi.
    }
}
