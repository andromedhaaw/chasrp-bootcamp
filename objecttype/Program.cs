using System;

//Kelas StackBarang menggunakan object agar bisa menyimpan berbagai tipe data
public class StackBarang
{
    int posisi = 0;
    object[] data = new object[10]; // array untuk menyimpan data

    public void TambahBarang(object barang)
    {
        data[posisi++] = barang; // menyimpan barang ke stack
    }

    public object AmbilBarang()
    {
        return data[--posisi]; // mengambil barang dari stack
    }
}

class Program {
    static void Main()
    {
        StackBarang tumpukan = new StackBarang();

        // Menambahkan berbagai jenis barang ke dalam stack
        tumpukan.TambahBarang("Laptop"); // String
        tumpukan.TambahBarang(5); // integer
        tumpukan.TambahBarang(99.99); // Double

        //Mengambil barang dari stack dan menampilkan isinya
        Console.WriteLine(tumpukan.AmbilBarang()); // 
        Console.WriteLine(tumpukan.AmbilBarang());
        Console.WriteLine(tumpukan.AmbilBarang());
        
    }
}