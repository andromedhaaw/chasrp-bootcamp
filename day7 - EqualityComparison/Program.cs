using System;

public class Program
{
    public static void Main()
    {
        // Kesetaraan Nilai
        int x = 5, y = 5;
        Console.WriteLine(x == y); // True, karena nilai keduanya sama.

        var dt1 = new DateTimeOffset(2010, 1, 1, 1, 1, 1, TimeSpan.FromHours(8));
        var dt2 = new DateTimeOffset(2010, 1, 1, 2, 1, 1, TimeSpan.FromHours(9));
        Console.WriteLine(dt1.DateTime == dt2.DateTime); // False, karena waktunya berbeda.

        // Kesetaraan Referensi
        Foo f1 = new Foo { X = 5 };
        Foo f2 = new Foo { X = 5 };
        Console.WriteLine(f1 == f2); // True, karena keduanya memiliki nilai X yang sama.

        // Referensi yang sama
        Foo f3 = f1;
        Console.WriteLine(f1 == f3); // True, karena f1 dan f3 menunjuk ke objek yang sama.

        // Implementasi Uri yang menggunakan kesetaraan nilai
        Uri uri1 = new Uri("http://www.linqpad.net");
        Uri uri2 = new Uri("http://www.linqpad.net");
        Console.WriteLine(uri1 == uri2); // True, karena URIs dianggap setara berdasarkan nilai.

        // Implementasi string yang menggunakan kesetaraan nilai
        string s1 = "http://www.linqpad.net";
        string s2 = "http://" + "www.linqpad.net";
        Console.WriteLine(s1 == s2); // True, karena string dibandingkan berdasarkan nilai.

        // Penggunaan Equals pada objek dengan tipe nilai
        object obj1 = 5;
        object obj2 = 5;
        Console.WriteLine(obj1.Equals(obj2)); // True, karena Equals menggunakan kesetaraan nilai.

        // Menggunakan metode Equals statis untuk perbandingan null
        object obj3 = null;
        Console.WriteLine(object.Equals(obj3, obj2)); // False
        obj3 = obj2;
        Console.WriteLine(object.Equals(obj3, obj2)); // True
    }
}

public class Foo
{
    public int X;

    public static bool operator ==(Foo f1, Foo f2)
    {
        if (ReferenceEquals(f1, null) || ReferenceEquals(f2, null))
            return false;
        return f1.X == f2.X;
    }

    public static bool operator !=(Foo f1, Foo f2) => !(f1 == f2);

    public override bool Equals(object obj)
    {
        if (obj is Foo foo)
        {
            return X == foo.X;
        }
        return false;
    }

    public override int GetHashCode() => X.GetHashCode();
}
