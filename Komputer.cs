using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{
    //Selain sebagai bentuk relationship Composition, class Komputer dibentuk agar di kemudian hari dapat dilakukan modifikasi jenis komputer baru
    public class Komputer
    {
        private double totalPower=0;
        public double dailyUsage=8;
        public double efficiencyPSU=0.75;

        public Motherboard MotherboardPC;
        public RAM RAMPC;
        public CPU ProcessorPC;
        public GPU GraphicsPC;
        public Drive DrivePC;

        public double PurePower()
        {
            totalPower = 0;
            totalPower += this.MotherboardPC.DrawPower();
            totalPower += this.ProcessorPC.DrawPower();
            totalPower += this.GraphicsPC.DrawPower();
            totalPower += this.RAMPC.DrawPower();
            totalPower += this.DrivePC.DrawPower();
            return totalPower;
        }
    }
    
}
