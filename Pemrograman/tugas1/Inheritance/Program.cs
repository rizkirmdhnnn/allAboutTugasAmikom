namespace Inheritance;
using System;

// class induk (superclass)
public class Pembayaran
{
    // Menyimpan jumlah pembayaran
    private double jumlah;
    // Menyimpan mata uang pembayaran
    private string mataUang;

    public double Jumlah
    {
        // Getter untuk mendapatkan nilai jumlah
        get { return jumlah; }
        // Setter untuk mengatur nilai jumlah
        set { jumlah = value; }
    }

    public string MataUang
    {
        // Getter untuk mendapatkan nilai mataUang
        get { return mataUang; }
        // Setter untuk mengatur nilai mataUang
        set { mataUang = value; }
    }

    // Metode virtual yang akan di override oleh subclass
    public virtual void ProsesPembayaran()
    {
        Console.WriteLine("Memproses pembayaran sejumlah {0} {1}...", jumlah, mataUang);
        Console.WriteLine("Pembayaran berhasil diproses!");
    }
}

// class anak (subclass)
public class PembayaranKartuKredit : Pembayaran
{
    // Menyimpan nomor kartu kredit
    private string nomorKartu;
    // Menyimpan nama pemegang kartu kredit
    private string namaPemegangKartu;
    // Menyimpan tanggal kadaluarsa kartu kredit
    private string tanggalKadaluarsa;


    public string NomorKartu
    {
        // Getter untuk mendapatkan nilai nomorKartu
        get { return nomorKartu; }
        // Setter untuk mengatur nilai nomorKartu
        set { nomorKartu = value; }
    }

    public string NamaPemegangKartu
    {
        // Getter untuk mendapatkan nilai namaPemegangKartu
        get { return namaPemegangKartu; }
        // Setter untuk mengatur nilai namaPemegangKartu
        set { namaPemegangKartu = value; }
    }

    public string TanggalKadaluarsa
    {
        // Getter untuk mendapatkan nilai tanggalKadaluarsa
        get { return tanggalKadaluarsa; }
        // Setter untuk mengatur nilai tanggalKadaluarsa
        set { tanggalKadaluarsa = value; }
    }

    // Metode override yang menggantikan metode virtual pada superclass
    public override void ProsesPembayaran()
    {
        Console.WriteLine("Memproses pembayaran kartu kredit dengan nomor {0} atas nama {1}...", nomorKartu, namaPemegangKartu);
        Console.WriteLine("Pembayaran kartu kredit berhasil diproses!");
    }
}

public class Program
{
    public static void Main(string[] args)
    { 
        // Membuat objek pembayaran
        Pembayaran pembayaran = new Pembayaran();

        Console.Write("Masukkan jumlah pembayaran: ");
        double jumlah = Convert.ToDouble(Console.ReadLine()); 

        Console.Write("Masukkan mata uang: ");
        string mataUang = Console.ReadLine();

        // Mengatur nilai jumlah pada objek pembayaran
        pembayaran.Jumlah = jumlah;
        // Mengatur nilai mataUang pada objek pembayaran
        pembayaran.MataUang = mataUang;

        // Memanggil metode ProsesPembayaran pada objek pembayaran
        pembayaran.ProsesPembayaran();

        Console.WriteLine();

        // Membuat objek pembayaran kartu kredit
        PembayaranKartuKredit pembayaranKartuKredit = new PembayaranKartuKredit();
        Console.Write("Masukkan jumlah pembayaran kartu kredit: ");
        double jumlahKartuKredit = Convert.ToDouble(Console.ReadLine());
        Console.Write("Masukkan mata uang kartu kredit: ");
        string mataUangKartuKredit = Console.ReadLine();
        Console.Write("Masukkan nomor kartu kredit: ");
        string nomorKartuKredit = Console.ReadLine();
        Console.Write("Masukkan nama pemegang kartu kredit: ");
        string namaPemegangKartuKredit = Console.ReadLine();
        Console.Write("Masukkan tanggal kadaluarsa kartu kredit: ");
        string tanggalKadaluarsaKartuKredit = Console.ReadLine();

         // Mengatur nilai jumlah pada objek pembayaran kartu kredit
        pembayaranKartuKredit.Jumlah = jumlahKartuKredit;
        // Mengatur nilai mataUang pada objek pembayaran kartu kredit
        pembayaranKartuKredit.MataUang = mataUangKartuKredit;
        // Mengatur nilai nomorKartu pada objek pembayaran kartu kredit
        pembayaranKartuKredit.NomorKartu = nomorKartuKredit;
        // Mengatur nilai namaPemegangKartu pada objek pembayaran kartu kredit
        pembayaranKartuKredit.NamaPemegangKartu = namaPemegangKartuKredit;
        // Mengatur nilai tanggalKadaluarsa pada objek pembayaran kartu kredit
        pembayaranKartuKredit.TanggalKadaluarsa = tanggalKadaluarsaKartuKredit;
        
        // Memanggil metode ProsesPembayaran pada objek pembayaran kartu kredit
        pembayaranKartuKredit.ProsesPembayaran();
        Console.ReadLine();
    }
}
