using System;

namespace DelegateEventExceptionDemo
{
    // Langkah 1: Definisikan delegate untuk operasi matematika
    public delegate double OperasiMatematika(double a, double b);

    // Langkah 2: Buat kelas Kalkulator yang memiliki event
    public class Kalkulator
    {
        // Event yang akan dipicu setelah perhitungan selesai
        public event EventHandler<string> PerhitunganSelesai;

        // Metode untuk memicu event
        protected virtual void PemicuPerhitungan(string pesan)
        {
            if (PerhitunganSelesai != null)
                PerhitunganSelesai(this, pesan);
        }

        // Metode untuk melakukan perhitungan
        public double Hitung(OperasiMatematika operasi, double x, double y)
        {
            double hasil = 0;
            try
            {
                hasil = operasi(x, y); // Melakukan operasi matematika
                PemicuPerhitungan($"Perhitungan berhasil! Hasil: {hasil}"); // Memicu event jika berhasil
            }
            catch (Exception ex)
            {
                PemicuPerhitungan($"Terjadi kesalahan: {ex.Message}"); // Memicu event jika terjadi error
            }
            return hasil;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator();

            // Mendaftarkan event handler
            kalkulator.PerhitunganSelesai += (sender, pesan) =>
            {
                Console.WriteLine(pesan);
            };

            // Definisi operasi menggunakan delegate
            OperasiMatematika tambah = (a, b) => a + b;
            OperasiMatematika kurang = (a, b) => a - b;
            OperasiMatematika kali = (a, b) => a * b;
            OperasiMatematika bagi = (a, b) =>
            {
                if (b == 0)
                    throw new DivideByZeroException("Tidak bisa membagi dengan nol!"); // Menangani pembagian dengan nol
                return a / b;
            };

            try
            {
                // Meminta input angka pertama dari pengguna
                Console.WriteLine("Masukkan angka pertama: ");
                double angka1 = Convert.ToDouble(Console.ReadLine());

                // Meminta input angka kedua dari pengguna
                Console.WriteLine("Masukkan angka kedua: ");
                double angka2 = Convert.ToDouble(Console.ReadLine());

                // Meminta pengguna memilih operasi matematika
                Console.WriteLine("Pilih operasi: +, -, *, /");
                char operasi = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Baris baru agar tampilan lebih rapi

                // Menentukan operasi yang dipilih oleh pengguna
                switch (operasi)
                {
                    case '+':
                        kalkulator.Hitung(tambah, angka1, angka2);
                        break;
                    case '-':
                        kalkulator.Hitung(kurang, angka1, angka2);
                        break;
                    case '*':
                        kalkulator.Hitung(kali, angka1, angka2);
                        break;
                    case '/':
                        kalkulator.Hitung(bagi, angka1, angka2);
                        break;
                    default:
                        Console.WriteLine("Operasi tidak valid."); // Menangani input operasi yang salah
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input tidak valid. Harap masukkan angka."); // Menangani kesalahan format input
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Kesalahan tidak terduga: {ex.Message}"); // Menangani kesalahan lainnya
            }
        }
    }
}
