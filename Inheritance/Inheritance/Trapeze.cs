using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Trapeze : Triangle
    {
        private double _d;

        public Trapeze(double a, double b, double c, double d, double h, string name) : base(h, a, b, c, name)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            H = h;
            name = "Trapece";
        }
        public double D
        {
            get
            {
                return _d;
            }
            set
            {
                if (ValidateD(value))
                {
                    _d = value;
                }
            }
        }

        public override double GetArea() => (B + D) * H / 2;

        public override double GetPerimeter() => A + B + C + D;

        private bool ValidateD(double D)
        {
            return D > 0;
        }

    }
}
