

public abstract class Pemesanan
{
    private string nama; // field nama 
    private string nik; // field nik
    private string nomorTelepon; // field nomorTelepon

    // property nama
    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    // property nik
    public string NIK
    {
        get { return nik; }
        set { nik = value; }
    }

    // property nomorTelepon
    public string NomorTelepon
    {
        get { return nomorTelepon; }
        set { nomorTelepon = value; }
    }

    // method abstrak ProsesPemesanan yang akan diimplementasikan di kelas turunan
    public abstract void ProsesPemesanan();
}

// kelas PemesananTiket yang merupakan turunan dari kelas Pemesanan
public class PemesananTiket : Pemesanan
{
    private string nomorKartuVaksin; // field nomorKartuVaksin
    private string alamatRumah; // field alamatRumah

    // property nomorKartuVaksin
    public string NomorKartuVaksin
    {
        get { return nomorKartuVaksin; }
        set { nomorKartuVaksin = value; }
    }

    // property alamatRumah
    public string AlamatRumah
    {
        get { return alamatRumah; }
        set { alamatRumah = value; }
    }

    // implementasi method ProsesPemesanan yang diwarisi dari kelas Pemesanan
    public override void ProsesPemesanan()
    {
        Console.WriteLine();
        Console.WriteLine("===== Detail Pemesanan Tiket =====");
        Console.WriteLine("Pemesanan tiket untuk {0} dengan NIK {1} telah diproses.", Nama, NIK);
        Console.WriteLine("Nomor telepon yang dapat dihubungi: {0}", NomorTelepon);
        Console.WriteLine("Nomor kartu vaksin: {0}", nomorKartuVaksin);
        Console.WriteLine("Alamat rumah: {0}", alamatRumah);
        Console.WriteLine("Terima kasih atas pemesanan tiket Anda!");
        Console.WriteLine();
    }
}


public class Program
{
    // list daftarPemesanan untuk menyimpan objek Pemesanan
    static List<Pemesanan> daftarPemesanan = new List<Pemesanan>();

    public static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("=== Aplikasi Pemesanan Tiket Transportasi ===");
        Console.WriteLine();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Pesan Tiket");
            Console.WriteLine("2. Lihat Daftar Tiket Terpesan");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilihan Anda: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    PesanTiket();
                    break;
                case "2":
                    LihatDaftarTiketTerpesan();
                    break;
                case "3":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                    break;
            }
            Console.WriteLine();
        }
    }

    public static void PesanTiket()
    {
        Console.WriteLine();
        Console.WriteLine("===== Pesan Tiket =====");
        Console.WriteLine();

        Console.Write("Masukkan Nama: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan NIK: ");
        string nik = Console.ReadLine();

        Console.Write("Masukkan Nomor Telepon: ");
        string nomorTelepon = Console.ReadLine();

        Console.Write("Masukkan Nomor Kartu Vaksin: ");
        string nomorKartuVaksin = Console.ReadLine();

        Console.Write("Masukkan Alamat Rumah: ");
        string alamatRumah = Console.ReadLine();

        // membuat objek PemesananTiket dan menyimpannya di variabel pemesanan
        Pemesanan pemesanan = new PemesananTiket
        {
            Nama = nama,
            NIK = nik,
            NomorTelepon = nomorTelepon,
            NomorKartuVaksin = nomorKartuVaksin,
            AlamatRumah = alamatRumah
        };


        daftarPemesanan.Add(pemesanan);
        pemesanan.ProsesPemesanan();
        Console.WriteLine();
    }

    public static void LihatDaftarTiketTerpesan()
    {

        Console.WriteLine();
        Console.WriteLine("===== Daftar Tiket Terpesan =====");
        Console.WriteLine();

        // mengecek apakah daftarPemesanan memiliki isi atau tidak 
        if (daftarPemesanan.Count > 0)
        {
            foreach (Pemesanan pemesanan in daftarPemesanan)
            {
                Console.WriteLine("Nama: {0}", pemesanan.Nama);
                Console.WriteLine("NIK: {0}", pemesanan.NIK);
                Console.WriteLine("Nomor Telepon: {0}", pemesanan.NomorTelepon);

                // mengecek apakah pemesanan merupakan objek PemesananTiket
                if (pemesanan is PemesananTiket pemesananTiket)
                {
                    Console.WriteLine("Nomor Kartu Vaksin: {0}", pemesananTiket.NomorKartuVaksin);
                    Console.WriteLine("Alamat Rumah: {0}", pemesananTiket.AlamatRumah);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Belum ada tiket yang terpesan.");
        }

        Console.WriteLine();
    }
}
