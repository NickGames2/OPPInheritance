using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public Triangle(double h, double a, double b, double c, string name) : base(name,a, b)
        {
            A = a;
            B = b;
            C = c;
            H = h;
            name = "Triangle";
        }

        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (ValidateC(value))
                {
                    _c = value;
                }
            }
        }

        public double H
        {
            get
            {
                return _h;
            }
            set
            {
                if (ValidateH(value))
                {
                    _h = value;
                }
            }
        }

        public override double GetArea() => (B * H) / 2;

        public override double GetPerimeter() => A + B + C;

        public bool ValidateC(double C)
        {
            return C > 0;
        }

        public bool ValidateH(double H)
        {
            return H > 0;
        }


    }
}
