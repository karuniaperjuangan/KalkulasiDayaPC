using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{
    public class CPU : PCComponent, IClockDependent, INameisBrand
    {
        public CPU(string Name) : base(Name) { }
        public double base_clock;
        public double TDP;
        public double boosted_clock;
        public double clock_ratio =1;



        public override double DrawPower()
        {
            return TDP*clock_ratio;
        }

        public void ChangeFrequency(double boostClock)
        {
            clock_ratio = boostClock / base_clock;
        }

        public string ShowBrand()
        {
            string s = string.Format("This component name is {0} ", this.name);
            return s;
        }
    }
}
