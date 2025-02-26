using System;
using System.Runtime.CompilerServices;

struct PosisiKarakter
{
    public int X, Y;
    public string Nama;

    //Konstruktor untuk mengatur posisi awal karakter
    public PosisiKarakter(string nama, int x, int y)
    {
        Nama = nama;
        X = x;
        Y = y;
    }

    public void Geser(int dx, int dy)
    {
        X += dx;
        Y += dy;
    }

    public void Tampilkan()
    {
        Console.WriteLine($"{Nama} berada di posisi ({X},{Y})");
    }
}

class Program
{
    static void Main()
    {
        PosisiKarakter pemain1 = new PosisiKarakter("Hero", 5, 10);
        PosisiKarakter pemain2 = pemain1; // salin nilai ke pemain2

        pemain2.Geser(3, -2);

        pemain1.Tampilkan();
        pemain2.Tampilkan(); // tampilkan posisi kedua pemain yang sama
    }
}