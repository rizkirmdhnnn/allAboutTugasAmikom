namespace Inheritance;
using System;

// class induk (superclass)
public class Pembayaran
{
    private double jumlah; // Menyimpan jumlah pembayaran
    private string mataUang; // Menyimpan mata uang pembayaran

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

    public virtual void ProsesPembayaran()
    {
        Console.WriteLine("Memproses pembayaran sejumlah {0} {1}...", jumlah, mataUang);
        Console.WriteLine("Pembayaran berhasil diproses!");
    }
}

// class anak (subclass)
public class PembayaranKartuKredit : Pembayaran
{
    private string nomorKartu; // Menyimpan nomor kartu kredit
    private string namaPemegangKartu; // Menyimpan nama pemegang kartu kredit
    private string tanggalKadaluarsa; // Menyimpan tanggal kadaluarsa kartu kredit

    public string NomorKartu
    {
        get { return nomorKartu; } // Getter untuk mendapatkan nilai nomorKartu
        set { nomorKartu = value; } // Setter untuk mengatur nilai nomorKartu
    }

    public string NamaPemegangKartu
    {
        get { return namaPemegangKartu; } // Getter untuk mendapatkan nilai namaPemegangKartu
        set { namaPemegangKartu = value; } // Setter untuk mengatur nilai namaPemegangKartu
    }

    public string TanggalKadaluarsa
    {
        get { return tanggalKadaluarsa; } // Getter untuk mendapatkan nilai tanggalKadaluarsa
        set { tanggalKadaluarsa = value; } // Setter untuk mengatur nilai tanggalKadaluarsa
    }

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
        Pembayaran pembayaran = new Pembayaran(); // Membuat objek pembayaran

        Console.Write("Masukkan jumlah pembayaran: ");
        double jumlah = Convert.ToDouble(Console.ReadLine()); // Mengambil input jumlah dari pengguna

        Console.Write("Masukkan mata uang: ");
        string mataUang = Console.ReadLine(); // Mengambil input mata uang dari pengguna

        pembayaran.Jumlah = jumlah; // Mengatur nilai jumlah pada objek pembayaran
        pembayaran.MataUang = mataUang; // Mengatur nilai mataUang pada objek pembayaran

        pembayaran.ProsesPembayaran(); // Memanggil metode ProsesPembayaran pada objek pembayaran

        Console.WriteLine();

        PembayaranKartuKredit pembayaranKartuKredit = new PembayaranKartuKredit(); // Membuat objek pembayaran kartu kredit

        Console.Write("Masukkan jumlah pembayaran kartu kredit: ");
        double jumlahKartuKredit = Convert.ToDouble(Console.ReadLine()); // Mengambil input jumlah pembayaran kartu kredit

        Console.Write("Masukkan mata uang kartu kredit: ");
        string mataUangKartuKredit = Console.ReadLine(); // Mengambil input mata uang kartu kredit

        Console.Write("Masukkan nomor kartu kredit: ");
        string nomorKartuKredit = Console.ReadLine(); // Mengambil input nomor kartu kredit

        Console.Write("Masukkan nama pemegang kartu kredit: ");
        string namaPemegangKartuKredit = Console.ReadLine(); // Mengambil input nama pemegang kartu kredit

        Console.Write("Masukkan tanggal kadaluarsa kartu kredit: ");
        string tanggalKadaluarsaKartuKredit = Console.ReadLine(); // Mengambil input tanggal kadaluarsa kartu kredit

        pembayaranKartuKredit.Jumlah = jumlahKartuKredit; // Mengatur nilai jumlah pada objek pembayaran kartu kredit
        pembayaranKartuKredit.MataUang = mataUangKartuKredit; // Mengatur nilai mataUang pada objek pembayaran kartu kredit
        pembayaranKartuKredit.NomorKartu = nomorKartuKredit; // Mengatur nilai nomorKartu pada objek pembayaran kartu kredit
        pembayaranKartuKredit.NamaPemegangKartu = namaPemegangKartuKredit; // Mengatur nilai namaPemegangKartu pada objek pembayaran kartu kredit
        pembayaranKartuKredit.TanggalKadaluarsa = tanggalKadaluarsaKartuKredit; // Mengatur nilai tanggalKadaluarsa pada objek pembayaran kartu kredit

        pembayaranKartuKredit.ProsesPembayaran(); // Memanggil metode ProsesPembayaran pada objek pembayaran kartu kredit

        Console.ReadLine();
    }
}
