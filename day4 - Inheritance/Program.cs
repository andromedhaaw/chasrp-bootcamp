using System;

class Karyawan
{
    protected string nama;
    protected double gaji;

    public Karyawan(string nama, double gaji)
    {
        this.nama = nama;
        this.gaji = gaji;
    }

    public void InfoKaryawan()
    {
        Console.WriteLine($"Nama: {nama}, Gaji: {gaji:C}");
    }
}

class Manager : Karyawan
{
    public Manager(string nama, double gaji) : base(nama, gaji) {}
    public void KelolaTim()
    {
        Console.WriteLine($"{nama} sedang mengelola tim.");
    }

}

class Programmer : Karyawan
{
    public Programmer(string nama, double gaji) : base(nama, gaji) {}
    public void Koding()
    {
        Console.WriteLine($"{nama} sedang menulis kode.");
    }
}

class Program
{
    static void Main()
    {
        Manager boss = new Manager("Budi", 15000000);
        boss.InfoKaryawan();
        boss.KelolaTim();

        Console.WriteLine();

        Programmer dev = new Programmer("Anna", 1000000);
        dev.InfoKaryawan();
        dev.Koding();

    }
}