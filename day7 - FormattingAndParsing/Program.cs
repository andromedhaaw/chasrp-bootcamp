using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // ToString() dan Parse()
        string boolStr = true.ToString(); // Mengubah boolean ke string
        Console.WriteLine($"ToString: {boolStr}"); // Output: True

        bool parsedBool = bool.Parse(boolStr); // Mengubah string ke boolean
        Console.WriteLine($"Parse: {parsedBool}"); // Output: True

        // TryParse() untuk aman dari pengecualian
        bool success = int.TryParse("123", out int result);
        Console.WriteLine($"TryParse success: {success}, Result: {result}"); // output

        bool failure = int.TryParse("qwerty", out int failedResult);
        Console.WriteLine($"TryParse failure: {failure}, Failed Result: {failedResult}"); // output

        // Parsing dengan CultureInfo untuk konsistensi
        double parsedNumber = double.Parse("1.234", CultureInfo.InvariantCulture); // Corrected this line
        Console.WriteLine($"Parsed number (InvariantCulture): {parsedNumber}");

        // Format Providers dan IFormattable
        NumberFormatInfo formatInfo = new NumberFormatInfo();
        formatInfo.CurrencySymbol = "$$";
        Console.WriteLine(3.ToString("C", formatInfo)); // Output: $$ 3.00

        // Menggunakan CultureInfo untuk format budaya tertentu
        CultureInfo uk = CultureInfo.GetCultureInfo("en-GB");
        Console.WriteLine(3.ToString("C", uk)); //Output: £3.00

        

    }
}
