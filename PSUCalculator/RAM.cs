using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{
    public class RAM : PCComponent
    {
        public RAM(string Name) : base(Name) { }
        public int memory_size;

        public override double DrawPower()
        {
            return 1/2 * memory_size;
        }
    }
    // Ternyata pada teknologi saat ini, RAM lebih hemat 75%
    public class RevisedRAM : RAM
    {
        public RevisedRAM(string Name) : base(Name) { }

        public override double DrawPower()
        {
            return base.DrawPower() * 0.75;
        }
    }
}
