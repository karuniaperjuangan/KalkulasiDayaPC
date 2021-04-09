using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{
    public class Komputer
    {
        public double totalPower=0;
        public string PSUType;

        public Motherboard MotherboardPC;
        public RAM RAMPC;
        public CPU ProcessorPC;
        public GPU GraphicsPC;
        public Drive DrivePC;
    }
}
