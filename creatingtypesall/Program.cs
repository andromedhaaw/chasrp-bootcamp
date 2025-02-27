using System;
using System.Collections.Generic;

// Enum: Jenis kendaraan
public enum VehicleType
{
    Car,
    Bike
}

// Interface: Kontrak untuk kendaraan yang bisa dikendarai
public interface IDriveable
{
    void Drive();
}

// Struct: Struktur mesin kendaraan
public struct Engine
{
    public int HorsePower;
    public string FuelType;

    public Engine(int horsePower, string fuelType)
    {
        HorsePower = horsePower;
        FuelType = fuelType;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Engine: {HorsePower} HP, Fuel Type: {FuelType}");
    }
}

// Class utama dengan Inheritance & Access Modifiers
public class Vehicle : IDriveable
{
    protected string Brand;  // Protected: Bisa diakses oleh class turunannya
    private Engine engine;   // Private: Hanya bisa diakses dalam class ini
    public VehicleType Type { get; private set; } // Public: Bisa diakses semua

    // Constructor
    public Vehicle(string brand, VehicleType type, int horsePower, string fuelType)
    {
        Brand = brand;
        Type = type;
        engine = new Engine(horsePower, fuelType);
    }

    // Nested Type: Class dalam class
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Manufacturer(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Manufacturer: {Name}, Country: {Country}");
        }
    }

    // Virtual method untuk diwariskan
    public virtual void Drive()
    {
        Console.WriteLine($"Driving a {Brand} {Type}");
        engine.ShowInfo();
    }
}

// Class turunan: Car
public class Car : Vehicle
{
    public int NumberOfDoors { get; private set; }

    public Car(string brand, int doors, int horsePower, string fuelType)
        : base(brand, VehicleType.Car, horsePower, fuelType)
    {
        NumberOfDoors = doors;
    }

    public override void Drive()
    {
        Console.WriteLine($"Driving a {Brand} car with {NumberOfDoors} doors.");
        base.Drive();
    }
}

// Class turunan: Bike
public class Bike : Vehicle
{
    public bool HasCarrier { get; private set; }

    public Bike(string brand, bool hasCarrier, int horsePower, string fuelType)
        : base(brand, VehicleType.Bike, horsePower, fuelType)
    {
        HasCarrier = hasCarrier;
    }

    public override void Drive()
    {
        Console.WriteLine($"Riding a {Brand} bike with carrier: {HasCarrier}");
        base.Drive();
    }
}

// Generic Class: Garage<T> bisa menyimpan kendaraan dari berbagai jenis
public class Garage<T> where T : Vehicle
{
    private List<T> vehicles = new List<T>();

    public void AddVehicle(T vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ShowVehicles()
    {
        Console.WriteLine("Vehicles in garage:");
        foreach (var v in vehicles)
        {
            v.Drive();
        }
    }
}

// Program utama
class Program
{
    static void Main()
    {
        // Menggunakan class turunan dan inheritance
        Car myCar = new Car("Toyota", 4, 120, "Petrol");
        Bike myBike = new Bike("Honda", true, 15, "Gasoline");

        // Menggunakan Nested Type
        Vehicle.Manufacturer toyotaManufacturer = new Vehicle.Manufacturer("Toyota", "Japan");
        toyotaManufacturer.DisplayInfo();

        // Menjalankan metode Drive
        myCar.Drive();
        myBike.Drive();

        // Menggunakan Generic Class
        Garage<Vehicle> myGarage = new Garage<Vehicle>();
        myGarage.AddVehicle(myCar);
        myGarage.AddVehicle(myBike);
        myGarage.ShowVehicles();

        // Contoh penggunaan Object Type
        object obj = myCar; // Menyimpan objek Car dalam tipe object
        Vehicle retrievedVehicle = (Vehicle)obj; // Unboxing kembali ke Vehiclee
        Console.WriteLine($"Unboxed Vehicle Type: {retrievedVehicle.Type}");
    }
}
