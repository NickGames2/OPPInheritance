using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Kite : Rhombus
    {
        private double _b;

        public Kite(double b, double d1, double d2, double a, string name) : base(d1, d2, a, name)
        {
            A = a;
            D1 = d1;
            D2 = d2;
            B = b;
            name = "Kite";
        }

        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                if (ValidateB(value))
                {
                    _b = value;
                }
            }
        }

        private bool ValidateB(double B)
        {
            return B > 0;
        }
        public override double GetArea() => (D1 * D2) / 2;

        public override double GetPerimeter() => 2 * (A + B);

    }
}

