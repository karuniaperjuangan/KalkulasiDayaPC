using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{

    public abstract class PCComponent
    {
        public string name;
        public double powerDrawn;

        public PCComponent(string Name)
        {
            this.name = Name;
        }

        public virtual double DrawPower()
        {
            return powerDrawn;
        }
    }

}
