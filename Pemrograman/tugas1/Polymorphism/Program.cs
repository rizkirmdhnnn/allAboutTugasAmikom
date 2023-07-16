using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pembayaran pembayaran;

            Console.WriteLine("Pilih Metode Pembayaran");
            Console.WriteLine("1. Kartu Kredit");
            Console.WriteLine("2. Transfer Bank");
            Console.WriteLine("3. E-Wallet\n");

            Console.Write("Nomor Metode Pembayaran [1..3]: ");
            int nomorMetode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Jumlah Pembayaran: ");
            double jumlahPembayaran = Convert.ToDouble(Console.ReadLine());

            if (nomorMetode == 1)
            {
                pembayaran = new PembayaranKartuKredit();
            }
            else if (nomorMetode == 2)
            {
                pembayaran = new PembayaranTransferBank();
            }
            else
            {
                pembayaran = new PembayaranEWallet();
            }

            pembayaran.Show();
            pembayaran.ProcessPayment(jumlahPembayaran);

            Console.ReadKey();
        }
    }

    public class Pembayaran
    {
        public virtual void Show()
        {
            Console.WriteLine("Metode Pembayaran Tersedia");
        }

        public virtual void ProcessPayment(double jumlah)
        {
            Console.WriteLine("Silahkan Pilih Metode Pembayaran");
        }
    }

    public class PembayaranKartuKredit : Pembayaran
    {
        public override void Show()
        {
            Console.WriteLine("Metode Pembayaran dengan Kartu Kredit");
        }

        public override void ProcessPayment(double jumlah)
        {
            Console.WriteLine("Memproses pembayaran sejumlah {0} dengan kartu kredit...", jumlah);
        }
    }

    public class PembayaranTransferBank : Pembayaran
    {
        public override void Show()
        {
            Console.WriteLine("Metode Pembayaran Transfer Bank");
        }

        public override void ProcessPayment(double jumlah)
        {
            Console.WriteLine("Memproses pembayaran sejumlah {0} melalui transfer bank...", jumlah);
        }
    }

    public class PembayaranEWallet : Pembayaran
    {
        public override void Show()
        {
            Console.WriteLine("Metode Pembayaran E-Wallet");
        }

        public override void ProcessPayment(double jumlah)
        {
            Console.WriteLine("Memproses pembayaran sejumlah {0} melalui E-Wallet...", jumlah);
        }
    }
}
