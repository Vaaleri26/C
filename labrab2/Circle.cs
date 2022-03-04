using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab2
{
    class Circle:Figure
    {
        public double R { get; set; }
        public override double getArea()
        {
            return 3.14*R*R;
        }
    }
}
