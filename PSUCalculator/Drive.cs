using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{
    public class Drive : PCComponent
    {
        public Drive(string Name) : base(Name) { }

        public int drive_count;

        public override double DrawPower()
        {
            return 15*drive_count;
        }
    }
}
