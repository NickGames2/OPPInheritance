using System.Xml.Linq;

namespace Inheritance
{

        public abstract class GeometricFigure
        {
            public string name { get; set; } = null!;

        public override string ToString()
            {
                return $"{name,-15} => Area.....: {GetArea(),12:N5}   Perimeter: {GetPerimeter(),12:N5}";
            }
            public abstract double GetArea();
            public abstract double GetPerimeter();
        }
    
}
