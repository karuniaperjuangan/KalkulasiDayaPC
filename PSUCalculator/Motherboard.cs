using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUCalculator
{
    public class Motherboard : PCComponent
    {
        public Motherboard(string Name) : base(Name) {  }

        public string Size { get; set; }
    }

    public class MiniITX : Motherboard
    {
        public MiniITX(string Name) : base(Name) { Size = "Mini-ITX"; powerDrawn = 30; }

    }
    public class MicroATX : Motherboard
    {
        public MicroATX(string Name) : base(Name) { Size = "Micro-ATX"; powerDrawn = 60; }

    }
    public class ATX : Motherboard
    {
        public ATX(string Name) : base(Name) { Size = "ATX"; powerDrawn = 70; }

    }
    public class XLATX : Motherboard
    {
        public XLATX(string Name) : base(Name) { Size = "XL-ATX"; powerDrawn = 130; }

    }
}
