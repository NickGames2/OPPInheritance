using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Rectangle : Square
    {
        private double _b;

        public Rectangle(double sideA, double sideB) : base(sideA)
        {
            A = sideA;
            B = sideB;
            Name = "Rectangle";
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

        public override double GetArea() => A * B;

        public override double GetPerimeter() => 2 * (A + B);
    }
}
