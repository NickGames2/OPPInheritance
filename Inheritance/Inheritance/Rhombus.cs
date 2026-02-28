using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public Rhombus(double d1, double d2, double sideA) : base(sideA)
        {
            A = sideA;
            D1 = d1;
            D2 = d2;
            Name = "Rhombus";
        }
        public double D1
        {
            get
            {
                return _d1;
            }
            set
            {
                if (ValidateD1(value))
                {
                    _d1 = value;
                }
            }
        }
        public double D2
        {
            get
            {
                return _d2;
            }

            set
            {
                if (ValidateD2(value))
                {
                    _d2 = value;
                }
            }
        }

        private bool ValidateD1(double D1)
        {
            return D1 > 0;
        }

        private bool ValidateD2(double D2)
        {
            return D2 > 0;
        }

        public override double GetArea() => (D1 * D2) / 2;

        public override double GetPerimeter() => 4 * A;


    }
}
