using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab2
{
    class Pentagon:Figure
    {
        public double a { get; set; }
        public override double getArea()
        {
            return a*a/4*Math.Sqrt((25)+10*Math.Sqrt(5));
        }
    }
}
