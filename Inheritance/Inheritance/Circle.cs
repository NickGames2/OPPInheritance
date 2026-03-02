using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public Circle(string name, double r)
        {
            R = r;
            Name = name;
            name = "Circle";
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

        private bool ValidateR(double r) => r > 0;

        public override double GetArea() => Math.PI * R * R;

        public override double GetPerimeter() => 2 * Math.PI * R;


    }
}
