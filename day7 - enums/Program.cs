using System;

[Flags]
public enum BorderSides
{
    Left = 1,
    Right = 2,
    Top = 4,
    Bottom = 8,
    LeftRight = Left | Right
}

class Program
{
    static void Main(string[] args)
    {
        // Konversi Enum ke Nilai Integral
        int i = (int)BorderSides.Top;
        Console.WriteLine("Enum ke Integral: " + i);  // Output: 4

        // Konversi Enum ke String
        BorderSides side = BorderSides.Top;
        Console.WriteLine("Enum ke String: " + side.ToString());  // Output: Top
        Console.WriteLine("Nilai Dasar (D): " + side.ToString("D"));  // Output: 4
        Console.WriteLine("Heksadesimal (X): " + side.ToString("X"));  // Output: 4

        // Konversi Integral ke Enum
        object bs = Enum.ToObject(typeof(BorderSides), 3);
        Console.WriteLine("Integral ke Enum: " + bs);  // Output: Left, Right

        // Parsing String ke Enum
        BorderSides parsedSide = (BorderSides)Enum.Parse(typeof(BorderSides), "Top");
        Console.WriteLine("Parsing String ke Enum: " + parsedSide);  // Output: Top

        // Parsing dengan Enum.TryParse untuk menangani kesalahan
        bool success = Enum.TryParse("Left, Right", out BorderSides parsedSides);
        Console.WriteLine(success ? "Parsed: " + parsedSides : "Parsing failed");  // Output: Parsed: Left, Right

        // Mengiterasi Semua Nilai Enum
        Console.WriteLine("Daftar Semua Nilai Enum:");
        foreach (Enum value in Enum.GetValues(typeof(BorderSides)))
        {
            Console.WriteLine(value);  // Output: Left, Right, Top, Bottom, LeftRight
        }

        // Menggunakan Flags untuk menggabungkan nilai
        BorderSides combinedSides = BorderSides.Left | BorderSides.Top;
        Console.WriteLine("Flag Gabungan: " + combinedSides);  // Output: Left, Top

        // Menampilkan Nama-nama Anggota Enum
        Console.WriteLine("Nama-nama Anggota Enum:");
        foreach (string name in Enum.GetNames(typeof(BorderSides)))
        {
            Console.WriteLine(name);  // Output: Left, Right, Top, Bottom, LeftRight
        }
    }
}
