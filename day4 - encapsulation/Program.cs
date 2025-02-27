class Mahasiswa
{
    private string nama = string.Empty; // Initialized with a default value
    private int umur;

    // Constructor to initialize values
    public Mahasiswa(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public int Umur
    {
        get { return umur; }
        set
        {
            if (value > 0)
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
        Mahasiswa mhs = new Mahasiswa("Wise", 21);
        Console.WriteLine($"Nama: {mhs.Nama}, Umur: {mhs.Umur}");
    }
}
