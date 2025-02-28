using System;

//Step 1: Buat EventArgs khusus untuk menyimpan data perubahan harga
public class PriceChangedEventArgs : EventArgs
{
    public decimal OldPrice { get; }
}