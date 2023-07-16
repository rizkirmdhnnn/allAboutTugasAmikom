using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IODevice device;

            Console.WriteLine("Pilih Perangkat Input/Output");
            Console.WriteLine("1. Keyboard");
            Console.WriteLine("2. Mouse");
            Console.WriteLine("3. Monitor\n");

            Console.WriteLine("Nomor Perangkat [1..3]: ");
            int deviceNumber = Convert.ToInt32(Console.ReadLine());

            if (deviceNumber == 1)
            {
                device = new Keyboard();
            }
            else if (deviceNumber == 2)
            {
                device = new Mouse();
            }
            else
            {
                device = new Monitor();
            }

            device.Show();
            device.ProcessInput();

            Console.ReadKey();
        }
    }

    public abstract class IODevice
    {
        public abstract void Show();
        public abstract void ProcessInput();
    }

    public class Keyboard : IODevice
    {
        public override void Show()
        {
            Console.WriteLine("Keyboard connected");
        }

        public override void ProcessInput()
        {
            Console.WriteLine("Processing keyboard input...");
        }
    }

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
