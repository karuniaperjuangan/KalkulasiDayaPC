using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{
    //Interface Segregation Principle : Tidak semua method dipaksakan ke semua komponen, hanya yang memiliki sifat tertentu saja yang perlu diberi interface

    //Tidak semua Komponen PC memiliki ukuran Clock
    interface IClockDependent
    {
        void ChangeFrequency(double boostClock); //Overclock or Underclocking
    }
    interface NameisBrand //Khusus Komponen yang memiliki nama khusus/Branding yang mempengaruhi performa PC
    {
        string ShowBrand();
    }
}
