namespace Encapsulation;

using System;

public class Pembayaran
{
    private double jumlah; // Menyimpan jumlah pembayaran sebagai variabel private
    private string mataUang; // Menyimpan mata uang pembayaran sebagai variabel private

    public double Jumlah
    {
        get { return jumlah; } // Getter untuk mendapatkan nilai jumlah
        set { jumlah = value; } // Setter untuk mengatur nilai jumlah
    }

    public string MataUang
    {
        get { return mataUang; } // Getter untuk mendapatkan nilai mataUang
        set { mataUang = value; } // Setter untuk mengatur nilai mataUang
    }

    public void ProsesPembayaran()
    {
        Console.WriteLine("Memproses pembayaran sejumlah {0} {1}...", jumlah, mataUang);
        // Logika untuk memproses pembayaran (dapat ditambahkan di sini)
        Console.WriteLine("Pembayaran berhasil diproses!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Pembayaran pembayaran = new Pembayaran(); // Membuat objek pembayaran

        Console.Write("Masukkan jumlah pembayaran: ");
        double jumlah = Convert.ToDouble(Console.ReadLine()); // Mengambil input jumlah dari pengguna

        Console.Write("Masukkan mata uang: ");
        string mataUang = Console.ReadLine(); // Mengambil input mata uang dari pengguna

        pembayaran.Jumlah = jumlah; // Mengatur nilai jumlah pada objek pembayaran menggunakan setter
        pembayaran.MataUang = mataUang; // Mengatur nilai mataUang pada objek pembayaran menggunakan setter

        pembayaran.ProsesPembayaran(); // Memanggil metode ProsesPembayaran pada objek pembayaran

        Console.ReadLine();
    }
}
