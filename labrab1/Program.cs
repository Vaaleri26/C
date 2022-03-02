using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1-Инкапсуляция");
            Console.WriteLine("Выполнила - Иванова Валерия");
            Complex a = new Complex() { Real = 1, Imag = 3 };
            Complex b = new Complex() { Real = 4, Imag = 6 };

           a.Add(b);
           b.Substract(a);
           a.Multiplay(b);
           b.Divide(a);

           Console.WriteLine("a = {0} + {1}i",a.Real,a.Imag);
           Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);
           Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
           Console.WriteLine("a = {0} + {1}i", b.Real, b.Imag);

          
            Student c = new Student() { name="Ira", sex="Women", hair="Red", old=21 };
            Student d = new Student() { name="Lera", sex="Women", hair="Blond", old=20 };
            Student e = new Student() { name="Mike", sex="Men", hair="Black", old=23 };
            Student f = new Student() { name="Kyle", sex="Men", hair="Brown", old=28 };

            c.addTwo(d);

            Console.WriteLine("a = {0} ; {1}; {2}; {3}", c.sex,c.old,c.name,c.hair);


            f.addThree(d, e);

            Console.WriteLine("a = {0} ; {1}; {2}; {3}", f.sex, f.old, f.name, f.hair);
        }
    }
    }
