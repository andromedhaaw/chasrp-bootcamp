using System;

class Program
{
    static void Main()
    {
        // 1. Konstanta dan Variabel
        int x = 12; // Variabel
        const int y = 30; // Konstanta

        // 2. Operator Biner (Binary Operators)
        int hasil = x * y; // Operator * mengalikan dua operand
        Console.WriteLine("Hasil perkalian: " + hasil); // Output ke konsol

        // 3. Ekspresi Bersarang (Nested Expressions)
        int nilai = 1 + (x * y);
        Console.WriteLine("Hasil nested expression: " + nilai);

        // 4. Operator Unary (Unary Operators)
        int a = 5;
        a++; // Increment, a menjadi 6
        int b = -a; // Negasi, b menjadi -6
        bool isTrue = false;
        bool isFalse = !isTrue; // Logika NOT

        Console.WriteLine("Nilai a setelah increment: " + a);
        Console.WriteLine("Nilai b setelah negasi: " + b);
        Console.WriteLine("isFalse: " + isFalse);

        // 5. Ekspresi Void (Void Expressions)
        Console.WriteLine("Hello, C#!");

        // 6. Ekspresi Penugasan (Assignment Expressions)
        int c;
        c = 10; 
        Console.WriteLine("Nilai c: " + c); // Menggunakan variabel c

        int d = (c = 5) * 2;
        Console.WriteLine("Nilai d setelah assignment expression: " + d);

        // Penugasan berantai
        int e, f, g;
        e = f = g = 0; 
        Console.WriteLine("Nilai g: " + g); // Menggunakan variabel g

        // Penugasan majemuk (Compound Assignment)
        int h = 10;
        h *= 2;
        Console.WriteLine("Nilai h setelah compound assignment: " + h);

        // 7. Operator Relasional (Relational Operators)
        bool isEqual = (x == y);
        Console.WriteLine("Apakah x sama dengan y? " + isEqual);

        // 8. Operator Logika (Logical Operators)
        bool isValid = (x > 0 && y > 0); 
        bool isAnyTrue = (x > 0 || y < 0); 
        Console.WriteLine("Logical AND: " + isValid);
        Console.WriteLine("Logical OR: " + isAnyTrue);

        // 9. Operator Lambda (Lambda Operators)
        Func<int, int> square = n => n * n;
        Console.WriteLine("Hasil lambda square(5): " + square(5));
    }
}
