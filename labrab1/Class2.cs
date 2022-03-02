using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab1
{
    internal class Student
    {
        public string name { get; set; }
        public string sex { get; set; }
        public string hair { get; set; }
        public int old { get; set; }

        public void addTwo(Student x)
        {
            sex+=x.sex;
            old+=x.old;
            hair+=x.hair;
            name+=x.name;
        }

        public void addThree(Student x, Student y)
        {
            sex+=x.sex+y.sex;
            old+=x.old+y.old;
            hair+=x.hair+y.hair;
            name+=x.name+y.name;
        }
    }
}
