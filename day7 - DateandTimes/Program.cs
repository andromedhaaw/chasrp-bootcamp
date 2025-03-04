using System;

class Program
{
    static void Main()
    {
        // 1. Menggunakan TimeSpan
        TimeSpan durasi = new TimeSpan(2, 30, 0); // 2 jam 30 menit
        Console.WriteLine("TimeSpan durasi: " + durasi); // Output: 02:30:00

        // Menggunakan metode statis untuk membuat TimeSpan
        Console.WriteLine("TimeSpan dari 2.5 jam: " + TimeSpan.FromHours(2.5)); // Output: 02:30:00
        Console.WriteLine("TimeSpan dari 90 menit: " + TimeSpan.FromMinutes(90)); // Output: 01:30:00

        // Menghitung selisih waktu antara dua DateTime
        DateTime start = new DateTime(2021, 1, 1);
        DateTime end = new DateTime(2021, 1, 2);
        TimeSpan duration = end - start;
        Console.WriteLine("Selisih waktu dalam hari: " + duration.TotalDays); // Output: 1.0

        // 2. Menggunakan DateTime
        DateTime dt = new DateTime(2021, 12, 15, 8, 30, 0); // 15 Desember 2021, jam 08:30
        Console.WriteLine("DateTime: " + dt); // Output: 12/15/2021 08:30:00

        // Operasi dengan DateTime (Menambah hari)
        DateTime dt2 = dt.AddDays(10); // Menambah 10 hari
        Console.WriteLine("Tanggal setelah 10 hari: " + dt2); // Output: 12/25/2021 08:30:00

        // Format DateTime
        Console.WriteLine("Tanggal sekarang (format yyyy-MM-dd HH:mm:ss): " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

        // 3. Menggunakan DateTimeOffset
        DateTimeOffset dtOffset = new DateTimeOffset(2021, 12, 15, 8, 30, 0, TimeSpan.FromHours(-5));
        Console.WriteLine("DateTimeOffset: " + dtOffset); // Output: 12/15/2021 8:30:00 AM -05:00

        // 4. Menggunakan DateOnly (hanya tanggal)
        DateOnly tanggal = new DateOnly(2021, 12, 15);
        Console.WriteLine("DateOnly: " + tanggal); // Output: 12/15/2021

        // 5. Menggunakan TimeOnly (hanya waktu)
        TimeOnly waktu = new TimeOnly(8, 30);
        Console.WriteLine("TimeOnly: " + waktu); // Output: 08:30:00
    }
}
