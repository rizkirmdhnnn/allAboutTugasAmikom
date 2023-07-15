using System;
using System.Collections.Generic;

// Abstraksi: Membuat kelas abstrak untuk entitas "Person"
public abstract class Person
{
    public string? Nama { get; set; } // Variabel Nama untuk menyimpan nama Person
    public int Umur { get; set; } // Variabel Umur untuk menyimpan umur Person
    public int NIM { get; set; } // Variabel NIM untuk menyimpan NIM Mahasiswa


    // Polimorfisme: Mengubah metode ToString() bawaan menjadi metode virtual yang dapat dioverride pada kelas turunan
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Nama: {this.Nama}");
        Console.WriteLine($"Umur: {this.Umur}");
    }
}

// inheritance: Menggunakan kelas turunan "Mahasiswa" dari kelas "Person"
public class Mahasiswa : Person
{
    public Mahasiswa(string nama, int umur, int nim)
    {
        this.Nama = nama;
        this.Umur = umur;
        this.NIM = nim;
    }

    // Polimorfisme: Mengoverride metode DisplayInfo() dari kelas induk untuk menampilkan informasi tambahan
    public override void DisplayInfo()
    {
        base.DisplayInfo(); // Memanggil metode DisplayInfo() pada kelas induk
        Console.WriteLine($"NIM: {this.NIM}");
    }
}

public class Program
{
    // Menggunakan List<Person> untuk menampung objek-objek dari kelas turunan
    static List<Person> orang = new List<Person>();

    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("=== Sistem Manajemen Mahasiswa ===");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Daftar Mahasiswa");
            Console.WriteLine("3. Keluar");
            Console.Write("Silakan masukkan pilihan Anda: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    TambahMahasiswa();
                    break;
                case "2":
                    TampilkanDaftarMahasiswa();
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

    // Enkapsulasi: Menggunakan access modifier private untuk membatasi akses langsung ke variabel "orang"
    static void TambahMahasiswa()
    {
        Console.Write("Masukkan nama mahasiswa: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan umur mahasiswa: ");
        int umur = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan NIM mahasiswa: ");
        int nim = Convert.ToInt32(Console.ReadLine());

        Mahasiswa mahasiswa = new Mahasiswa(nama, umur, nim);
        orang.Add(mahasiswa);

        Console.WriteLine("Mahasiswa berhasil ditambahkan!");
    }

    static void TampilkanDaftarMahasiswa()
    {
        Console.WriteLine("=== Daftar Mahasiswa ===");

        foreach (var person in orang)
        {
            // Polimorfisme: Memanggil metode DisplayInfo() yang sesuai untuk setiap objek dalam List<Person>
            person.DisplayInfo();
            Console.WriteLine();
        }
    }
}
