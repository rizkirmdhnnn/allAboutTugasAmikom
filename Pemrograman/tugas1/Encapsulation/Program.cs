namespace Encapsulation;

using System;

public class Pembayaran
{
    // Menyimpan jumlah pembayaran sebagai variabel private
    private double jumlah;
    // Menyimpan mata uang pembayaran sebagai variabel private
    private string mataUang;

    public double Jumlah
    {
        // getter untuk variabel jumlah
        get { return jumlah; }
        // setter untuk variabel jumlah
        set { jumlah = value; }
    }

    public string MataUang
    {
        // getter untuk variabel mataUang
        get { return mataUang; }
        // setter untuk variabel mataUang
        set { mataUang = value; }
    }

    public void ProsesPembayaran()
    {
        Console.WriteLine("Memproses pembayaran sejumlah {0} {1}...", jumlah, mataUang);
        Console.WriteLine("Pembayaran berhasil diproses!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Membuat objek pembayaran dari kelas Pembayaran
        Pembayaran pembayaran = new Pembayaran();

        Console.Write("Masukkan jumlah pembayaran: ");
        double jumlah = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan mata uang: ");
        string mataUang = Console.ReadLine();

        // Mengatur nilai jumlah pada objek pembayaran menggunakan setter
        pembayaran.Jumlah = jumlah;

        // Mengatur nilai mataUang pada objek pembayaran menggunakan setter
        pembayaran.MataUang = mataUang;

        // Memanggil metode ProsesPembayaran pada objek pembayaran
        pembayaran.ProsesPembayaran();

        Console.ReadLine();
    }
}
