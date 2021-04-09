using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{
    public class GPU : PCComponent, IClockDependent
    {
        public GPU(string Name) : base(Name) { }
        public double base_clock;
        public double TDP;
        public double boosted_clock;
        public double clock_ratio;


        public void ChangeFrequency()
        {
            clock_ratio = boosted_clock / base_clock;
        }

        public override double DrawPower()
        {
            return TDP * clock_ratio;
        }

    }
}
