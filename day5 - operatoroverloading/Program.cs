using System;

public struct Weight : IComparable<Weight>
{
    private double kg;

    public Weight(double kilograms) => kg = kilograms;

    // Operator Aritmetika
    public static Weight operator + (Weight w, double kg) => new Weight(w.kg + kg);
    public static Weight operator - (Weight w, double kg) => new Weight(w.kg - kg);

    // Operator Perbandingan
    public static bool operator == (Weight w1, Weight w2) => w1.kg == w2.kg;
    public static bool operator != (Weight w1, Weight w2) => w1.kg != w2.kg;
    public static bool operator < (Weight w1, Weight w2) => w1.kg < w2.kg;
    public static bool operator > (Weight w1, Weight w2) => w1.kg > w2.kg;

    // Konversi ke dan dari gram
    public static implicit operator double(Weight w) => w.kg * 1000; // Kg ke gram
    public static explicit operator Weight(double grams) => new Weight(grams / 1000); // Gram ke Kg

    // Implementasi IComparable untuk sorting
    public int CompareTo(Weight other) => this.kg.CompareTo(other.kg);

    public override string ToString() => $"{kg} kg";
}

class Program
{
    static void Main()
    {
        Weight box1 = new Weight(5);
        Weight box2 = box1 + 3;
        Weight box3 = box2 - 2;

        Console.WriteLine(box1); // 5 kg
        Console.WriteLine(box2); // 8 kg
        Console.WriteLine(box3); // 6 kg

        Console.WriteLine(box1 == box2); // False
        Console.WriteLine(box1 < box2);  // True

        double grams = box2;
        Console.WriteLine($"{grams} g"); // 8000 g

        Weight boxFromGram = (Weight)2500;
        Console.WriteLine(boxFromGram); // 2.5 kg
    }
}
