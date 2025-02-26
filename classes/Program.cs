//membuat kelas bernama mobil
class Mobil
{
    public string merk;
    public int tahun;

    public void Info()
    {
        Console.WriteLine($"Mobil {merk}, Tahun {tahun}");
    }
}
 
 // Program Utama   
class Program
{
    static void Main()
    {
        Mobil mobilsaya = new Mobil(); // Membuat objek dari kelas Mobil
        mobilsaya.merk = "Toyota";
        mobilsaya.tahun = 2002;
        mobilsaya.Info(); // output: Mobil Toyota, Tahun 2002
    }
}