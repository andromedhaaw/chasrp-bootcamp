using System;

class Mahasiswa
{
    //Field Private (tidak bisa diakses langsung dari luar class)
    private string nama;
    private int umur;

    //Properti untuk mengakses nama
    public string Nama{
        get { return nama; }
        set { nama = value; }
    }

    //properti dengan validasi untuk umur
    public int Umur{
        get { return umur;}
        set 
        {
            if (value > 0) // validasi umur tidak boleh negatif
                umur = value;
            else
                Console.WriteLine("Umur harus lebih dari 0!");
            
            
        }
    }
}

class Program
{
    static void Main()
    {
        Mahasiswa mhs = new Mahasiswa();
        mhs.Nama = "Wise";
        mhs.Umur = 21;

        Console.WriteLine($"Nama: {mhs.Nama}, Umur: {mhs.Umur}");
    }
}