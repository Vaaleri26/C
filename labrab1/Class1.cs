using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab1
{
     class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        //сложение
        public void Add(Complex x)
        {
            Real+=x.Real;
            Imag+=x.Imag;
        }

        //вычитание
        public void Substract(Complex x)
        {
            Real-=x.Real;
            Imag-=x.Imag;
        }

        //умножение
        public void Multiplay(Complex x)
        {
            // double z=(Real*x.Real-Imag*x.Imag)+(Real*x.Imag+Imag*x.Real);
            Real=(Real*x.Real-Imag*x.Imag);
            Imag=(Real*x.Imag+Imag*x.Real);
        }
        //деление
        public void Divide(Complex x)
        {
            Real=(Real*x.Real+Imag*x.Imag)/(x.Real*x.Real+x.Imag*x.Imag);
            Imag=(Imag*x.Real-Real*x.Imag)/(x.Real*x.Real+x.Imag*x.Imag);
        }

    }
}
