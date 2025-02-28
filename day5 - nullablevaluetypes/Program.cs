using System;
using System.Runtime.InteropServices.Marshalling;

class Program{
    static void Main()
    {
        //1. Deklarasi Nullables Value Types
        int? angka = null;
        Console.WriteLine($"Apakah angka null? {angka = null}"); // Output: True

        //2. Menggunakan  HasValue dan GetValueOrDefault
        Console.WriteLine($"Apakah angka memiliki nilai? {angka.HasValue}"); // Output : False
        Console.WriteLine($"Nilai default jika angka null: {angka.GetValueOrDefault()}"); // Output :100

        //3. Mengisi Nilai angka
        angka = 10;
        Console.WriteLine($"Nilai angka setelah diisi: {angka}"); // output = 10

        //4. Operator Null-Coalescing (???)
        int nilaiAkhir = angka ?? 5;
        Console.WriteLine($"Nilai akhir: {nilaiAkhir}"); // Output: 10

        //5. Boxing dan Unboxing Nullable Value Types
        object obj = angka; // Boxing
        int? angkaLain = obj as int?; // Unboxing
        Console.WriteLine($"Nilai angka setelah unboxing: {angkaLain}"); // Output : 10

        //6. Operator Perbandingan (Operator Lifting)
        int? x = 5;
        int? y = 10;
        Console.WriteLine($"Apakah x < y? {x < y}"); // Output: True
        Console.WriteLine($"Apakah x == y? {x == y}"); // Output: False
        
        //7. Operator Aritmatika dengan Nullable
        int? hasilTambah = x + null;
        Console.WriteLine($"Hasil x + null: {hasilTambah}"); // output: null)

        //8. Mixing Nullable dan Non-Nullable Types
        int? a = null;
        int b = 2;
        int? c = a + b;
        Console.WriteLine($"Hasil a + b: {c}"); // Output: null

        //9. Nullable bool dan Operator Logika
        bool? isAvailable = null;
        bool? isFalse = false;
        bool? isTrue = true;

        Console.WriteLine($"null | false: {isAvailable | isFalse}"); // Output: null
        Console.WriteLine($"null | true: {isAvailable | isTrue}"); // Output: True
        Console.WriteLine($"null & false: {isAvailable & isFalse}"); // Output: False

        //10. Penggunaan dalam database (Simulasi)
        Customer pelanggan = new Customer { AccountBalance = null};
        Console.WriteLine($"Saldo pelanggan: {pelanggan.AccountBalance}"); // Output: 150.75
        
        pelanggan.AccountBalance = 150.75m;
        Console.WriteLine($"Saldo pelanggan setelah update: {pelanggan.AccountBalance}"); // Output: 150.75

    }
}

// Contoh class yang mensimulkan data dari database
public class Customer
{
    public decimal? AccountBalance; // Bisa null jika tidak ada data saldo
}