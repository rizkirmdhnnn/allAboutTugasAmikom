using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IODevice device; // deklarasi variabel device dengan tipe data IODevice (superclass)

            Console.WriteLine("Pilih Perangkat Input/Output");
            Console.WriteLine("1. Keyboard");
            Console.WriteLine("2. Mouse");
            Console.WriteLine("3. Monitor\n");

            Console.WriteLine("Nomor Perangkat [1..3]: ");
            int deviceNumber = Convert.ToInt32(Console.ReadLine()); // konversi string ke int

            if (deviceNumber == 1)
            {
                device = new Keyboard(); // inisialisasi variabel device dengan objek Keyboard (subclass)
            }
            else if (deviceNumber == 2)
            {
                device = new Mouse();   // inisialisasi variabel device dengan objek Mouse (subclass)
            }
            else
            {
                device = new Monitor(); // inisialisasi variabel device dengan objek Monitor (subclass)
            }

            device.Show(); // memanggil method Show() dari objek device
            device.ProcessInput(); // memanggil method ProcessInput() dari objek device

            Console.ReadKey();
        }
    }

    //public class IODevice (superclass)
    //abstract adalah class yang tidak dapat di instansiasi (tidak dapat dibuat objeknya)
    //class ini hanya dapat diwarisi oleh subclass
    public abstract class IODevice
    {
        public abstract void Show();
        public abstract void ProcessInput();
    }

    //public class Keyboard : IODevice (subclass)
    public class Keyboard : IODevice
    {
        //public override void Show() (method override)
        //override adalah method yang menggantikan method virtual dari superclass
        public override void Show()
        {
            Console.WriteLine("Keyboard connected");
        }

        public override void ProcessInput()
        {
            Console.WriteLine("Processing keyboard input...");
        }
    }

    //public class Mouse : IODevice (subclass)
    public class Mouse : IODevice
    {
        public override void Show()
        {
            Console.WriteLine("Mouse connected");
        }

        public override void ProcessInput()
        {
            Console.WriteLine("Processing mouse input...");
        }
    }

    //public class Monitor : IODevice (subclass)
    public class Monitor : IODevice
    {
        public override void Show()
        {
            Console.WriteLine("Monitor connected");
        }

        public override void ProcessInput()
        {
            Console.WriteLine("Processing monitor output...");
        }
    }
}
