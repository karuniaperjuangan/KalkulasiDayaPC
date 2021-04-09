using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{
    //Tidak semua Komponen PC memiliki ukuran Clock
    interface IClockDependent
    {
        void ChangeFrequency(); //Overclock or Underclocking
    }
    interface IComponent
    {
        double drawPower();
    }
}
