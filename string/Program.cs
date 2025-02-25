using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Ensure Unicode output in console
        Console.OutputEncoding = Encoding.UTF8;

        // Character Type (char)
        char c = 'A';  // A simple character
        Console.WriteLine("Character: " + c);

        // Escape Sequences
        char newLine = '\n';  // Represents a new line
        char backSlash = '\\'; // Represents a backslash
        Console.WriteLine("Escape sequences: " + newLine + " Backslash: " + backSlash);

        // Unicode Escape Sequences
        char copyrightSymbol = '\u00A9';  // Copyright symbol (©)
        char omegaSymbol = '\u03A9';      // Greek letter Omega (Ω)
        Console.WriteLine("Unicode: " + copyrightSymbol + " " + omegaSymbol);

        // Character Conversions
        int asciiValue = c; // Implicit conversion to int (ASCII value)
        Console.WriteLine("ASCII value of '" + c + "': " + asciiValue);

        // String Type (string)
        string message = "Hello, World!";
        Console.WriteLine("String: " + message);

        // String Equality
        string a = "test";
        string b = "test";
        Console.WriteLine("String equality: " + (a == b)); // True

        // Escape Sequences in Strings
        string path = "C:\\Program Files\\MyApp"; // Use \\ for backslashes
        Console.WriteLine("File path: " + path);
    }
}
