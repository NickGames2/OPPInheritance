using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public Parallelogram(double h, double sideB, double sideA) : base(sideA, sideB)
        {
            H = h;
            A = sideA;
            B = sideB;
            Name = "Parallelogran";
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

        private bool ValidateH(double H)
        {
            return H < 0;
        }
    }
}
