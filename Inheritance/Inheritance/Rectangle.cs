using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Rectangle : Square
    {
        private double _b;

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            A = a;
            B = b;
            name = "Rectangle";
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
