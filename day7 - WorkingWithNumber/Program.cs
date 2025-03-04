using System;  
using System.Numerics;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Konversi Angka
        int hexValue = Convert.ToInt32("1E", 16); // Parsing hexadecimal
        Console.WriteLine("Hexadecimal '1E' ke Integer: " + hexValue);

        int i;
        bool ok = int.TryParse("3", out i); // safe parsing
        Console.WriteLine("Parsing '3' menjadi integer:" + ok);

        // Pembulatan
        double d = 23.5;
        int roundedValue = Convert.ToInt32(d); // Pembulatan ke integer terdekat
        Console.WriteLine("Pembularan 23.5 menjadi integer: " + roundedValue);

        //fungsi Math
        double value = 2.5;
        Console.WriteLine("Math.Round: " + Math.Round(value)); // pembulatan
        Console.WriteLine("Math.Floor: " + Math.Floor(value)); // pembulatan ke bawah
        Console.WriteLine("Math.Ceiling: " + Math.Ceiling(value)); //pembulatan ke atas

        // BigInteger
        BigInteger googol = BigInteger.Pow(10, 100); // 10^100
        Console.WriteLine("Googol: " + googol); //

        // Angka Acak
        Random random = new Random();
        Console.WriteLine("Angka acak antara 0 dan 99: " + random.Next(100));
        Console.WriteLine("Angka acak double antara 0 dan 1: " + random.NextDouble());

        // Operasi Bitwise
        uint number = 16; // Change to uint
        Console.WriteLine("IsPow2: " + BitOperations.IsPow2(number));  // Memeriksa apakah 16 adalah pangkat dua
        Console.WriteLine("LeadingZeroCount: " + BitOperations.LeadingZeroCount(number));  // Jumlah nol di depan
    }
}
