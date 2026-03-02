using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public Parallelogram(string name,double h, double b, double a) : base(name, a, b)
        {
            H = h;
            A = a;
            B = b;
            Name = name;
            name = nameof(Parallelogram);
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

        public override double GetArea() => B * H;

        public override double GetPerimeter() => 2 * (A + B);

        private bool ValidateH(double h) => h > 0;

    }
}
