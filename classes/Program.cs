﻿class Mobil
{
    public string merk;

    // Constructor
    public Mobil(string merk)
    {
        this.merk = merk;
    }

    public void Nyalamesin()
    {
        Console.WriteLine("Mesin menyala..");
    }
}

class MobilBalap : Mobil
{
    public int kecepatan;

    // Constructor untuk MobilBalap
    public MobilBalap(string merk, int kecepatan) : base(merk)
    {
        this.kecepatan = kecepatan;
    }

    public void GasPol()
    {
        Console.WriteLine($"Mobil {merk} ngebut dengan kecepatan {kecepatan} km/jam");
    }
}

class Program
{
    static void Main()
    {
        MobilBalap ferrari = new MobilBalap("Ferrari", 300);
        ferrari.Nyalamesin();
        ferrari.GasPol();
    }
}
