// Kelas Induk (Parent Class)
class Mobil
{
    public string merk = ""; // Inisialisasi dengan string kosong

    public void Nyalamesin()
    {
        Console.WriteLine("Mesin menyala..");
    }
}

// Kelas Turunan (Child Class)
class MobilBalap : Mobil
{
    public int kecepatan;

    public void GasPol()
    {
        Console.WriteLine($"Mobil {merk} ngebut dengan kecepatan {kecepatan} km/jam");
    }
}

class Program
{
    static void Main()
    {
        MobilBalap ferrari = new MobilBalap();
        ferrari.merk = "Ferrari";  // Mengisi nilai merk
        ferrari.kecepatan = 300;
        ferrari.Nyalamesin();
        ferrari.GasPol();
    }
}
