using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04.Entities
{
    internal class ComboDevice : Device, IPrinter, IScanner
    {
        public ComboDevice(string serialNumber) : base(serialNumber)
        {
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("ComboDevice process...");
        }
        public void Print(string document)
        {
            Console.WriteLine("Printing: " + document);
        }
        public string Scanner()
        {
            return "Scanning document...";
        }

    }
}
