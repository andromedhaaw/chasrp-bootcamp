using System;

class Akun
{
    private string username;
    private Keamanan keamanan; // Nested Class sebagai objek

    // Nested Class untuk menangani keamanan
    private class Keamanan
    {
        private string password;
        public Keamanan(string pass)
        {
            password = pass;
        }

        public bool VerifikasiPassword(string input)
        {
            return input == password;
        }
    }

    public Akun(string nama, string pass)
    {
        username = nama;
        keamanan = new Keamanan(pass);
    
    }

    public void Login(string pass)
    {
        if (keamanan.VerifikasiPassword(pass))
        {
            Console.WriteLine($"Login Berhasil!, Selamat datang, {username}.");

        }
        else
        {
            Console.WriteLine("Login gagal! Password Salah.");
        }

    }

}

class Program
{
    static void Main()
    {
        Akun akun1 = new Akun("Budi", "12345");
        akun1.Login("12345"); //Berhasil
        akun1.Login("54321"); //Gagal
    }
}