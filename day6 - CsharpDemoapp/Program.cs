using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpFeaturesDemo
{
    //Enumerator dan Iterator
    public class NumberCollection : IEnumerable<int>
    {
        //List angka sebagai contoh koleksi yang bisa diiterasi
        private List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        //Enumerator menggunakan iterator dengan yield return
        public IEnumerator<int> GetEnumerator()
        {
            foreach (var num in numbers)
            {
                yield return num; // Mengembalikan angka satu per satu
            }
        }

        // Implementasi eksplisit dari IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    //Nullable Value Type (Type Data Nullable)
    public class Person
    {
        public string Name { get; set; }
        public int? Age { get; set;} // Nullable int(bisa null)

        public Person(string name, int? age = null) // jika umur tidak diberikan, default null
        {
            Name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            //Mengecek apakah Age memiliki nilai, jika tidak, tampilkan "tidak diketahui"
            Console.WriteLine($"Nama: {Name}, Umur: {(Age.HasValue ? Age.Value.ToString() : "tidak diketahui")}");
        }
    }

    // Operator Overloading (Penyesuain Operator)
    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Overloading operator + untuk menjumlahkan dua titik
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        // Overloading operator - untuk mengurangkan dua titik
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})"; // Menampilkan titik dalam format (X, Y)
        }
    }

    class Program
    {
        static void Main()
        {
            // 1. Pengujian Enumerator dan Iterator
            Console.WriteLine("Koleksi Anggka:");
            NumberCollection collection = new NumberCollection();
            foreach (var num in collection)
            {
                Console.Write(num + ""); // Menampilkan angka dari koleksi

            }
            Console.WriteLine("\n");
            
            //2. Pengujian Nullable Value Types
            Console.WriteLine("Tipe Data Nullable:");
            Person p1 = new Person("Alice", 25);
            Person p2 = new Person("Bob"); // Tidak memberikan umur (null)
            p1.ShowInfo();
            p2.ShowInfo();
            Console.WriteLine();

            //3. Pengujian Operator Overloading
            Console.WriteLine("Operator Overloading:");
            Point point1 = new Point(3, 4);
            Point point2 = new Point(1, 2);

            Point resultAdd = point1 + point2; // Menjumlahkan duatitik
            Point resultSub = point1 - point2; // Mengurangkan dua titik

            Console.WriteLine($"Titik 1: {point1}");
            Console.WriteLine($"Titik 2: {point2}");
            Console.WriteLine($"Hasil Penjumlahan: {resultAdd}");
            Console.WriteLine($"Hasil Pengurangan: {resultSub}");

        }

        
    }
    

}
