using System;
using System.Xml;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        // Convert class examples
        double d = 3.9;
        int i = Convert.ToInt32(d); // Pembulatan ke integer
        Console.WriteLine($"Convert.ToInt32(3.9) = {i}"); // output: 4

        // Parsing angka dalam basis 16 (Hexadecimal)
        int thirty = Convert.ToInt32("1E", 16);
        uint five = Convert.ToUInt32("101", 2);
        Console.WriteLine($"Hex '1E' to Int = {thirty}, Binary '101' to UInt = {five}"); // Output: 30, 5

       // Konversi dinamis menggunakan Conver.ChangeType
       object source = "42";
       Type targetType = typeof(int);
       object result = Convert.ChangeType(source, targetType);
        Console.WriteLine($"Convert.ChangeType(\"42\", typeof(int)) = {result}"); // Output: 42

        //Base-64 encoding and decoding
        byte[] byteArray = new byte[] { 0, 1, 2, 3, 4};
        string base64String = Convert.ToBase64String(byteArray);
        Console.WriteLine($"Base64 Encoded: {base64String}"); 

        byte[] decodedBytes = Convert.FromBase64String(base64String);
        Console.WriteLine($"Base64 Decoded: {BitConverter.ToString(decodedBytes)}");

        //XMLConvert examples
        string boolStr = XmlConvert.ToString(true);
        bool boolVal = XmlConvert.ToBoolean(boolStr);
        Console.WriteLine($"XmlConvert: Boolean to String = {boolStr}, String to Boolean = {boolVal}"); // Output: true, true

        DateTime dt = DateTime.Now;
        string xmlDateTime = XmlConvert.ToString(dt, XmlDateTimeSerializationMode.RoundtripKind);
        Console.WriteLine($"XmlConvert DateTime = {xmlDateTime}"); 

         // TypeConverter example
        TypeConverter colorConverter = TypeDescriptor.GetConverter(typeof(System.Drawing.Color));
        var beige = (System.Drawing.Color)colorConverter.ConvertFromString("Beige");
        Console.WriteLine($"Color Convert: Beige = {beige}"); // Output: Color [Beige]

        // BitConverter examples
        byte[] byteArrayFromDouble = BitConverter.GetBytes(3.5);
        Console.WriteLine("BitConverter from double:");
        foreach (byte b in byteArrayFromDouble)
            Console.Write(b + " ");  // Output: 0 0 0 0 0 0 12 64

        double dConvertedBack = BitConverter.ToDouble(byteArrayFromDouble, 0);
        Console.WriteLine($"\nBitConverter to double: {dConvertedBack}"); // Output: 3.5



    }
}