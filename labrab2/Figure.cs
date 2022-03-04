using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab2
{
    public abstract class Figure
    {
        public string name { get; set; }
        public abstract double getArea();
    }
}
