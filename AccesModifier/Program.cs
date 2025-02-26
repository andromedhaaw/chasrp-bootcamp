using System;

namespace AccessModifiersDemo
{
    // INTERNAL: Hanya bisa diakses dalam proyek ini
    internal class AkunPengguna
    {
        // PRIVATE: Hanya bisa diakses dalam kelas ini
        private string password = "rahasia123";

        // PROTECTED: Bisa diakses dalam kelas ini dan kelas turunannya
        protected string username;

        // PUBLIC: Bisa diakses dari mana saja
        public string Email { get; set; }

        // Konstruktor
        public AkunPengguna(string username, string email)
        {
            this.username = username;
            this.Email = email;
        }

        // PUBLIC: Bisa diakses dari mana saja
        public void TampilkanInfo()
        {
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Email: {Email}");
        }

        // PRIVATE: Hanya bisa diakses dalam kelas ini
        private bool VerifikasiPassword(string inputPassword)
        {
            return inputPassword == password;
        }

        // INTERNAL: Hanya bisa diakses dalam proyek ini
        internal void GantiPassword(string lama, string baru)
        {
            if (VerifikasiPassword(lama))
            {
                password = baru;
                Console.WriteLine("Password berhasil diganti.");
            }
            else
            {
                Console.WriteLine("Password lama salah!");
            }
        }
    }

    // Kelas Turunan
    class AkunPremium : AkunPengguna
    {
        public AkunPremium(string username, string email) : base(username, email) {}

        // PROTECTED bisa diakses oleh kelas turunan
        public void TampilkanUsername()
        {
            Console.WriteLine($"Akun premium dengan username: {username}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Membuat akun biasa
            AkunPengguna user1 = new AkunPengguna("Alice", "alice@example.com");
            user1.TampilkanInfo();

            // Mengubah password (internal)
            user1.GantiPassword("rahasia123", "passwordBaru"); 

            Console.WriteLine();

            // Membuat akun premium
            AkunPremium premiumUser = new AkunPremium("Bob", "bob@example.com");
            premiumUser.TampilkanInfo();
            premiumUser.TampilkanUsername(); // Bisa mengakses protected username

            // Tidak bisa mengakses password karena private
            // Console.WriteLine(user1.password);  ❌ ERROR
        }
    }
}
