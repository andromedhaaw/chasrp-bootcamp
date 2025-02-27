using System;

// Kelas dasar (Superclass) yang akan diwarisi oleh kelas lain
class Pelajar
{
    protected string nama; // Field protected agar bisa diakses oleh kelas turunan

    // Konstruktor untuk menginisialisasi nama pelajar
    public Pelajar(string nama)
    {
        this.nama = nama;
    }

    // Metode virtual yang bisa di-override oleh subclass
    public virtual void Belajar()
    {
        Console.WriteLine($"{nama} sedang belajar.");
    }
}

// Kelas turunan (Subclass) dari Pelajar untuk siswa sekolah
class Siswa : Pelajar
{
    // Konstruktor yang memanggil konstruktor dari kelas induk menggunakan base()
    public Siswa(string nama) : base(nama) {}

    // Override metode Belajar() dengan implementasi khusus untuk siswa
    public override void Belajar()
    {
        Console.WriteLine($"{nama} adalah seorang siswa sekolah yang belajar mata pelajaran umum.");
    }
}

// Kelas turunan (Subclass) dari Pelajar untuk mahasiswa
class Mahasiswa : Pelajar
{
    // Konstruktor yang memanggil konstruktor dari kelas induk menggunakan base()
    public Mahasiswa(string nama) : base(nama) {}

    // Override metode Belajar() dengan implementasi khusus untuk mahasiswa
    public override void Belajar()
    {
        Console.WriteLine($"{nama} adalah seorang mahasiswa yang belajar mata kuliah spesifik.");
    }
}

// Kelas utama untuk menjalankan program
class Program
{
    static void Main()
    {
        // Polymorphism: Objek dari subclass bisa disimpan dalam variabel tipe superclass
        Pelajar p1 = new Siswa("Rina");  // p1 adalah objek Siswa, tetapi disimpan dalam variabel Pelajar
        Pelajar p2 = new Mahasiswa("Budi"); // p2 adalah objek Mahasiswa, tetapi disimpan dalam variabel Pelajar

        // Memanggil metode Belajar(), tetapi yang dipanggil adalah versi dari subclass masing-masing
        p1.Belajar(); // Memanggil versi Belajar() dari kelas Siswa
        p2.Belajar(); // Memanggil versi Belajar() dari kelas Mahasiswa
    }
}
