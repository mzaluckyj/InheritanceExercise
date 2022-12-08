using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird()
        {
            LegCount= 2;
            HasFeathers= true;
            HasTail =  false;
            Age = 0;

        }
            public string featherColor { get; set; }
            public bool canFly { get; set; }
             public bool WillMigrate { get; set;}
            public double BeakLength { get; set; }
    }
}
