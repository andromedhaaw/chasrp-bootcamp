// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // **Integral Types**
        int x = 12 * 30;          // int, multiplication
        long y = 0x7F;            // long, hexadecimal
        ushort z = 65000;         // ushort, within range 0 to 65535

        Console.WriteLine("Integral Types:");
        Console.WriteLine($"int x: {x}, long y: {y}, ushort z: {z}\n");

        // **Real Types**
        float f = 1.5F;           // float with F suffix
        double d = 1.0;           // double, no need for suffix
        decimal m = 10.0M;        // decimal with M suffix

        Console.WriteLine("Real Types:");
        Console.WriteLine($"float f: {f}, double d: {d}, decimal m: {m}\n");

        // **Numeric Literals and Type Inference**
        int num1 = 127;           // Decimal
        long num2 = 0x7F;         // Hexadecimal
        var binary = 0b1010_1011_1100_1101; // Binary
        double exp = 1E06;        // Exponential notation

        Console.WriteLine("Numeric Literals:");
        Console.WriteLine($"Decimal: {num1}, Hexadecimal: {num2}, Binary: {binary}, Exponential: {exp}\n");

        // **Implicit and Explicit Conversions**
        int a = 12345;
        long b = a;               // Implicit conversion from int to long
        Console.WriteLine("Implicit Conversion:");
        Console.WriteLine($"int a: {a} (converted to long b: {b})\n");

        long largeValue = 123456789L;
        int smallValue = (int)largeValue; // Explicit conversion from long to int
        Console.WriteLine("Explicit Conversion:");
        Console.WriteLine($"long largeValue: {largeValue} (converted to int smallValue: {smallValue})\n");

        // **Floating-Point and Integral Conversions**
        int i = 1;
        float f2 = i;             // Implicit conversion from int to float

        double d2 = 5.5;
        int i2 = (int)d2;         // Explicit conversion from double to int (fraction truncated)

        Console.WriteLine("Floating-Point and Integral Conversions:");
        Console.WriteLine($"int i: {i} (converted to float f2: {f2})");
        Console.WriteLine($"double d2: {d2} (converted to int i2: {i2})\n");

        // **Arithmetic Operators**
        int sum = 5 + 3;          // Addition
        int difference = 10 - 2;  // Subtraction
        int product = 4 * 2;      // Multiplication
        int quotient = 9 / 3;     // Division
        int remainder = 10 % 3;   // Remainder (modulo)

        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"sum: {sum}, difference: {difference}, product: {product}, quotient: {quotient}, remainder: {remainder}\n");

        // **Increment and Decrement Operators**
        int xIncrement = 0, yIncrement = 0;
        Console.WriteLine("Increment and Decrement Operators:");
        Console.WriteLine($"xIncrement: {xIncrement++} (post-increment), yIncrement: {++yIncrement} (pre-increment)\n");

        // **Overflow and Underflow Handling**
        try
        {
            int max = int.MaxValue;
            int overflow = unchecked(max + 1);  // Will not throw an exception
            Console.WriteLine($"Overflow (unchecked): {overflow}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Overflow Exception: {ex.Message}");
        }

        // **Overflow Example using checked**
        try
        {
            int max = int.MaxValue;
            int overflowChecked = checked(max + 1); // Will throw an exception
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Checked Overflow Exception: " + ex.Message);
        }
    }
}

