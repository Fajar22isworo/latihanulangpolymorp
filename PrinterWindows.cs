using System;
using System.Collections.Generic;
using System.Text;

namespace Latihanpoly
{
    class PrinterWindows :IPrinterWindows
    {
        public void Show()
    
        {
            Console.WriteLine("Printer Windows masuk tampilan:");
        }
            public void Print()
        {
            Console.WriteLine("Printer Windows printing.....");
        }
      }
}
