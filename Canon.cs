using System;
using System.Collections.Generic;
using System.Text;

namespace Latihanpoly
{
    class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Canon Dimension:11 * 12");
        }
        public void Print()
        {
            Console.WriteLine(" Printer Canon proses printing.....");
        }
    }
}
