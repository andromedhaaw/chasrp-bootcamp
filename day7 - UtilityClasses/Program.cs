using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        // 1. Console Class - Membaca input dan menampilkan output
        Console.WriteLine("Masukkan nama Anda:");
        string name = Console.ReadLine();  // Membaca input pengguna
        Console.WriteLine("Halo, " + name);  // Menampilkan output

        // Mengubah tampilan Console
        Console.WindowWidth = 80;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.CursorLeft = 5;
        Console.CursorTop = 3;
        Console.WriteLine("Selamat datang di aplikasi Console!");

        // 2. Environment Class - Menampilkan informasi tentang sistem
        Console.WriteLine("\nInformasi Sistem:");
        Console.WriteLine("Nama Mesin: " + Environment.MachineName);
        Console.WriteLine("Versi OS: " + Environment.OSVersion);
        Console.WriteLine("Nama Pengguna: " + Environment.UserName);

        // Mengakses variabel lingkungan
        string path = Environment.GetEnvironmentVariable("PATH");
        Console.WriteLine("System PATH: " + path);

        // 3. Process Class - Menjalankan aplikasi eksternal dan menangkap output
        Console.WriteLine("\nMenjalankan Notepad...");
        Process.Start("notepad.exe");

        // Menangkap output dari perintah command line
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/c ipconfig",
            RedirectStandardOutput = true,
            UseShellExecute = false
        };
        Process process = Process.Start(psi);
        string result = process.StandardOutput.ReadToEnd();
        Console.WriteLine("Output dari ipconfig:\n" + result);

        // 4. AppContext Class - Menampilkan informasi tentang aplikasi
        Console.WriteLine("\nInformasi Aplikasi:");
        Console.WriteLine("Direktori Aplikasi: " + AppContext.BaseDirectory);
        Console.WriteLine("Target Framework: " + AppContext.TargetFrameworkName);

        // Menyimpan output Console ke dalam file
        using (TextWriter writer = File.CreateText("output.txt"))
        {
            Console.SetOut(writer);
            Console.WriteLine("Ini adalah output yang disimpan dalam file.");
        }

        // Mengembalikan output Console ke layar
        Console.SetOut(Console.Out);
        Console.WriteLine("\nOutput telah disimpan ke file.");
    }
}
