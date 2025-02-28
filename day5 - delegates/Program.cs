using System;
using System.IO;

class Program
{
    // 1. Deklarasi Delegate
    delegate int Transformer(int x);
    delegate void ProgressReporter(int percentComplete);
    delegate object ObjectRetriever();
    delegate void StringAction(string s);
    delegate T TransformerGeneric<T>(T arg); // Memindahkan ke dalam Program agar dikenali di Main()

    static void Main()
    {
        // 2. Menggunakan Delegate dengan Metode Statis
        Transformer square = Square;  // Square sudah dideklarasikan di bawah
        Console.WriteLine($"Square of 3: {square(3)}"); // Output: 9

        // 3. Menggunakan Delegate dengan Metode Instance
        Test instance = new Test();
        Transformer instanceDelegate = instance.Cube;
        Console.WriteLine($"Cube of 3: {instanceDelegate(3)}"); // Output: 27

        // 4. Delegate sebagai Parameter (Plugin Function)
        int[] numbers = { 1, 2, 3 };
        Util.Transform(numbers, Square); // Square dipanggil dengan benar
        Console.WriteLine("Transformed array (Square): " + string.Join(", ", numbers)); // Output: 1, 4, 9

        // 5. Multicast Delegate
        ProgressReporter reporter = WriteProgressToConsole;
        reporter += WriteProgressToFile;
        reporter(50); // Akan menulis ke console dan file

        // 6. Generic Delegates
        TransformerGeneric<double> doubleSquare = x => x * x;
        Console.WriteLine($"Square of 4.5: {doubleSquare(4.5)}"); // Output: 20.25

        // 7. Built-in Delegates (Func & Action)
        Func<int, int, int> add = (x, y) => x + y;
        Console.WriteLine($"Addition (3 + 5): {add(3, 5)}"); // Output: 8

        Action<string> printMessage = message => Console.WriteLine(message);
        printMessage("Hello, delegates!"); // Output: Hello, delegates!

        // 8. Covariance dalam Delegates
        ObjectRetriever retriever = RetrieveString;
        Console.WriteLine($"Covariant delegate result: {retriever()}"); // Output: "Hello from RetrieveString"

        // 9. Contravariance dalam Delegates
        StringAction stringAction = ActOnObject;
        stringAction("Hello contravariance!"); // Output: Hello contravariance!
    }

    // Metode statis yang sesuai dengan delegate Transformer
    static int Square(int x) => x * x;

    // Metode instance yang cocok untuk delegate
    class Test
    {
        public int Cube(int x) => x * x * x;
    }

    // Metode yang menerima delegate sebagai parameter
    public class Util
    {
        public delegate int Transformer(int x); // Delegate dipindahkan agar bisa digunakan dalam Util

        public static void Transform(int[] values, Transformer transformer)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = transformer(values[i]);
            }
        }
    }

    // Multicast Delegate - Metode yang dipanggil oleh ProgressReporter
    static void WriteProgressToConsole(int percentComplete)
    {
        Console.WriteLine($"Progress: {percentComplete}%");
    }

    static void WriteProgressToFile(int percentComplete)
    {
        File.WriteAllText("progress.txt", $"Progress: {percentComplete}%");
    }

    // Metode untuk Covariant Delegates
    static string RetrieveString() => "Hello from RetrieveString";

    // Metode untuk Contravariant Delegates
    static void ActOnObject(object o) => Console.WriteLine(o);
}
