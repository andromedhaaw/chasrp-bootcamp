using System;
using System.Dynamic;

//Step 1: Buat EventArgs khusus untuk menyimpan data perubahan harga
public class PriceChangedEventArgs : EventArgs
{
    public decimal OldPrice { get; }
    public decimal NewPrice { get; }

    public PriceChangedEventArgs(decimal oldPrice, decimal newPrice)
    {
        OldPrice = oldPrice;
        NewPrice = newPrice;
    }
}

//Step 2: Broadcaster (Penyiar) yang akan memberi tahu perubahan harga
public class Stock
{
    private decimal price;

    // Event menggunakan EventHandler dengan PriceChangedEventArgs
    public event EventHandler<PriceChangedEventArgs> PriceChanged;

    public decimal Price
    {
        get => price;
        set
        {
            if (price != value) // Jika harga berubah, kirim notifikasi
            {
                var oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }

    }

    // step 3: Metode untuk memanggil event dengan aman
    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        EventHandler<PriceChangedEventArgs> temp = PriceChanged;
        temp?.Invoke(this, e); // Memanggil semua subscriber yang mendengar event imi
    }
}

//Step 4: Subscriber (Pendengar) yang akan merespons perubahan harga
public class Subscriber
{
    private string _name;

    public Subscriber(string name)
    {
        _name = name;
    }

    public void OnPriceChanged(object sender, PriceChangedEventArgs e)
    {
        Console.WriteLine($"{_name} menerima notifikasi: Harga berubah dari {e.OldPrice} ke {e.NewPrice} ");

    }
}

//Step 5: Program utama untuk menghubungkan broadcaster dan subscriber
class Program
{
    static void Main()
    {
        //Buat objeck Stock (broadcaster)
        Stock stock = new Stock();

        //Buat dua subscriber
        Subscriber subscriber1 = new Subscriber("Alice");
        Subscriber subscriber2 = new Subscriber("Bobo");

        //Langganan ke Event
        stock.PriceChanged += subscriber1.OnPriceChanged;
        stock.PriceChanged += subscriber2.OnPriceChanged;

        //Ubah harga untuk memicu event
        stock.Price = 120m;
        stock.Price = 150m;

        //Hentikan langganan salah satu subscriber
        stock.PriceChanged -= subscriber1.OnPriceChanged;

        //Ubah harga lagi untuk melihat hasilnya setelah unsubscriber
        stock.Price = 200m;


    }
}