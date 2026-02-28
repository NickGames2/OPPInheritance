using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get { return _a; }
            set
            {
                if (ValidateA(value))
                {
                    _a = value;
                }
            }
        }

        public Square(double side)
        {
            A = side;
            Name = "Square";
        }

        private bool ValidateA(double value)
        {
            return value > 0;
        }

        public override double GetArea()
        {
            return _a * _a;
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }
    }
}
