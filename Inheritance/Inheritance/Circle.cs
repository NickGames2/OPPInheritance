using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public Circle(double r)
        {
            R = r;
            Name = "Circle";
        }
        public double R
        {
            get
            {
                return _r;
            }
            set
            {
                if (ValidateR(value))
                {
                    _r = value;
                }
            }
        }

        private bool ValidateR(double r) => _r > 0;

        public override double GetArea() => 3.14 * R * R;

        public override double GetPerimeter() => 2 * 3.14 * R;


    }
}
