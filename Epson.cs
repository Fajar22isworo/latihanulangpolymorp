using System;
using System.Collections.Generic;
using System.Text;

namespace Latihanpoly
{
    class Epson : IPrinterWindows
    {
        public void Show ()
        {
            Console.WriteLine("Printer Epson dimension: 10 *13");
        }
        public void Print()
        {
            Console.WriteLine("printer Epson proses printing.....");
        }
    }
}
