using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab2
{
    class Trapeze:Figure
    {
        public double a { get; set; }
        public double h { get; set; }
        public double b { get; set; }
        public override double getArea()
        {
            return (a+b)/2*h;
        }
    }
}
