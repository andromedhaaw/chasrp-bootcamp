using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 1. Char: Mendefinisikan dan memanipulasi karakter
        char c = 'A';  // Karakter A
        char newLine = '\n';  // Karakter newline (pindah baris)
        Console.WriteLine("Char Example:");
        Console.WriteLine($"Char: {c}");
        Console.WriteLine($"Newline Character: {newLine}");
        Console.WriteLine(char.ToUpper('c'));  // C (mengubah huruf kecil menjadi besar)
        Console.WriteLine(char.IsWhiteSpace('\t'));  // True (cek apakah karakter adalah spasi)
        Console.WriteLine();

        // 2. String: Membuat dan memanipulasi string
        string s1 = "Hello";
        string s2 = "First Line\r\nSecond Line";  // String multiline
        char[] ca = "Hello".ToCharArray();
        string s = new string(ca);  // Membuat string dari array char
        string empty = "";
        string? nullString = null;

        Console.WriteLine("String Example:");
        Console.WriteLine($"String s1: {s1}");
        Console.WriteLine($"Multiline String s2: {s2}");
        Console.WriteLine($"String from Char Array: {s}");
        Console.WriteLine($"Is Empty String: {empty == ""}");  // True (string kosong)
        Console.WriteLine($"Is Null String: {nullString == null}");  // True (string null)
        Console.WriteLine();

        // 3. Mengakses dan memodifikasi string
        string str = "abcde";
        char letter = str[1];  // letter == 'b'
        string newString = "Hello".Substring(0, 3);  // "Hel"
        string replaced = "Hello".Replace("o", "a");  // "Hella"

        Console.WriteLine("String Manipulation Example:");
        Console.WriteLine($"Letter at index 1: {letter}");
        Console.WriteLine($"Substring from index 0, length 3: {newString}");
        Console.WriteLine($"Replaced string: {replaced}");
        Console.WriteLine();

        // 4. Mencari dan membandingkan string
        Console.WriteLine("String Search and Comparison Example:");
        Console.WriteLine($"Ends with 'fox': {"quick brown fox".EndsWith("fox")}");
        Console.WriteLine($"Contains 'brown': {"quick brown fox".Contains("brown")}");
        Console.WriteLine($"Compare 'apple' to 'banana': {"apple".CompareTo("banana")}");
        Console.WriteLine($"Compare 'apple' to 'Apple' (case insensitive): {"apple".Equals("Apple", StringComparison.OrdinalIgnoreCase)}");
        Console.WriteLine();

        // 5. StringBuilder untuk manipulasi string yang lebih efisien
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 50; i++) 
            sb.Append(i).Append(",");

        Console.WriteLine("StringBuilder Example:");
        Console.WriteLine(sb.ToString());
        Console.WriteLine();

        // 6. Encoding dan Unicode
        string text = "Hello, World!";
        byte[] utf8Bytes = Encoding.UTF8.GetBytes(text);
        string decodedText = Encoding.UTF8.GetString(utf8Bytes);

        Console.WriteLine("Encoding and Unicode Example:");
        Console.WriteLine($"Encoded Text (UTF-8): {BitConverter.ToString(utf8Bytes)}");
        Console.WriteLine($"Decoded Text: {decodedText}");
        Console.WriteLine();

        // 7. String Interpolation dan Format
        int temperature = 30;
        string city = "Jakarta";

        Console.WriteLine("String Interpolation and Format Example:");
        Console.WriteLine($"Temperature is {temperature}°C in {city}.");
        string composite = "The temperature is {0}°C in {1}.";
        string formatted = string.Format(composite, temperature, city);
        Console.WriteLine(formatted);
    }
}
