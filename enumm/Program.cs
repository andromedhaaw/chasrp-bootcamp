using System;

// Definisi Enum untuk Status Pesanan
public enum StatusPesanan
{
    Dipesan, // 0
    Dimasak, // 1
    Dikirim, // 2
    Selesai  // 3
}

// Kelas Pesanan
class Pesanan
{
    public string NamaMakanan { get; set; } 
    public StatusPesanan Status { get; set; } // Menggunakan Enum

    public Pesanan(string NamaMakanan)
    {
        this.NamaMakanan = NamaMakanan; 
        Status = StatusPesanan.Dipesan; // Set status awal sebagai "Dipesan"
    }

    public void UbahStatus(StatusPesanan statusBaru)
    {
        Status = statusBaru;
        Console.WriteLine($"Pesanan {NamaMakanan} sekarang berstatus: {Status}");
    }
}

// Program utama
class Program
{
    static void Main()
    {
        Pesanan pesanan1 = new Pesanan("Nasi Goreng");
        pesanan1.UbahStatus(StatusPesanan.Dimasak);
        pesanan1.UbahStatus(StatusPesanan.Dikirim);
        pesanan1.UbahStatus(StatusPesanan.Selesai); 
    }
}
