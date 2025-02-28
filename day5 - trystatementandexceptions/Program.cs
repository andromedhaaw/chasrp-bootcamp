using System;
using System.IO;

class ExceptionHandlingDemo
{
    static void Main()
    {
        Console.WriteLine("=== Try-Catch-Finally Example ===");
        TryCatchFinallyExample();

        Console.WriteLine("\n=== Multiple Catch Blocks Example ===");
        MultipleCatchExample();

        Console.WriteLine("\n=== Using Statement Example ===");
        UsingStatementExample();

        Console.WriteLine("\n=== TryXXX Pattern Example ===");
        TryPatternExample();
    }

    // 1. Try-Catch-Finally: Menangani error dan memastikan cleanup
    static void TryCatchFinallyExample()
    {
        try
        {
            int result = Divide(10, 0); // Akan menyebabkan DivideByZeroException
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero!"); // Menangani pembagian oleh nol
        }
        finally
        {
            Console.WriteLine("Cleanup completed. This will always run."); // Akan selalu dijalankan
        }
    }

    // Fungsi pembagian yang dapat menyebabkan pembagian oleh nol
    static int Divide(int a, int b)
    {
        return a / b; // Akan melempar DivideByZeroException jika b == 0
    }

    // 2. Multiple Catch Blocks: Menangani berbagai jenis pengecualian
    static void MultipleCatchExample()
    {
        try
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input); // Bisa menyebabkan FormatException atau OverflowException
            Console.WriteLine($"You entered: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Input is not a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number is too large or too small.");
        }
        catch (Exception ex) // Menangkap error umum yang tidak terduga
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    // 3. Using Statement: Menyederhanakan manajemen sumber daya (file, database, dll.)
    static void UsingStatementExample()
    {
        try
        {
            using (StreamReader reader = File.OpenText("file.txt")) // File akan otomatis ditutup setelah keluar dari blok using
            {
                Console.WriteLine(reader.ReadLine()); // Membaca baris pertama dari file
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
    }

    // 4. TryXXX Pattern: Menghindari pengecualian yang tidak perlu
    static void TryPatternExample()
    {
        if (TryDivide(10, 2, out int result)) // Coba membagi 10 dengan 2
        {
            Console.WriteLine($"Division successful: {result}"); // Jika sukses
        }
        else
        {
            Console.WriteLine("Division failed. Denominator cannot be zero."); // Jika gagal (misalnya pembagian dengan nol)
        }
    }

    // Fungsi pembagian dengan TryXXX pattern (mengembalikan bool, bukan melempar pengecualian)
    static bool TryDivide(int numerator, int denominator, out int result)
    {
        if (denominator == 0)
        {
            result = 0;
            return false; // Jika pembagi nol, kembalikan false
        }
        result = numerator / denominator;
        return true; // Jika berhasil, kembalikan true
    }
}
