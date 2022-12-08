using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {     
            Age= 0;
            HasFeathers = false;
            LegCount= 4;
            HasTail = true;

        }

        public bool IsColdBlooded { get; set; }
        public bool isScaly { get; set; }
        public string Habitat { get; set; }
        public bool TailRegen { get; set; }

    }
}
