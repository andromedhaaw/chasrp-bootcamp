using System;

//Definisi interface (kontrak)
interface IKendaraan
{
    void NyalakanMesin();
    void MatikanMesin();
}
//Implementasi interface pada Mobil
class Mobil : IKendaraan
{
    public void NyalakanMesin()
    {
        Console.WriteLine("Mobil: Mesin dinyalakan!");
    }

    public void MatikanMesin()
    {
        Console.WriteLine("Mobil: Mesin dimatikan!");
    }
}

//Implementasi interface pada Motor
class Motor : IKendaraan
{
    public void NyalakanMesin()
    {
        Console.WriteLine("Motor: Mesin dinyalakan!");
    }

    public void MatikanMesin()
    {
        Console.WriteLine("Motor: Mesin dimatikan!");
    }
}

//Program Utama
class Program
{
    static void Main()
    {
        IKendaraan kendaraan1 = new Mobil();
        kendaraan1.NyalakanMesin();
        kendaraan1.MatikanMesin();

        Console.WriteLine();

        IKendaraan kendaraan2 = new Motor();
        kendaraan2.NyalakanMesin();
        kendaraan2.MatikanMesin();

    
    }
}