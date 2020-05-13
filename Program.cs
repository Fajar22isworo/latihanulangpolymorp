using System;

namespace Latihanpoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama :Fajar Isworo");
            Console.WriteLine("NIM : 19.11.2793");
            Console.WriteLine("Kelas : 19 IF 03");

            Console.WriteLine();
            Console.WriteLine("Pilih Printer: \n1. Canon\n2. Epson\n3. LaserJet");

            Console.Write("\nPilih Nomor Printer [1 ... 3] : ");
            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            IPrinterWindows printer = new PrinterWindows();

            if (pilihPrinter > 0 && pilihPrinter < 4)
            {
                if (pilihPrinter == 1)
                {
                    printer = new Canon();
                }
                else if (pilihPrinter == 2)
                {
                    printer = new Epson();
                }
                else
                {
                    printer = new LaserJet();
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak tersedia \n");
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
