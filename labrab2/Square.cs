using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab2
{
    class Square : Figure
    {
        public double a { get; set; }
        public override double getArea()
        {
            return a*a;
        }
    }
}
