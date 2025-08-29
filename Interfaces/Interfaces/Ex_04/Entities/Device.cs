using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04.Entities
{
    abstract class Device
    {
        string SerialNumber { get; set; }

        public Device(string serialNumber)
        {
            SerialNumber = serialNumber;
        }

        public abstract void ProcessDoc(string doc);
    }
}
