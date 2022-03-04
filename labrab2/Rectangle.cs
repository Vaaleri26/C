using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab2
{
    class Rectangle:Figure
    {public double width { get; set; }
    public double height { get; set; }
        public override double getArea()
        {
            return width*height;
        }
    }
}
