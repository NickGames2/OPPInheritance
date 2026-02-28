using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Trapece : Triangle
    {
        private double _d;

        public Trapece(double sideA, double sideB, double sideC, double sideD, double h) : base(h, sideA, sideB, sideC)
        {
            A = sideA;
            B = sideB;
            C = sideC;
            D = sideD;
            H = h;
            Name = "Trapece";
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
