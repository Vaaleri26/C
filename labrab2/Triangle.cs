using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab2
{
    class Triangle:Figure
    {
        public double b { get; set; }
        public double h { get; set; }
        public override double getArea()
        {
            return b*h*0.5;
        }
    }
}
