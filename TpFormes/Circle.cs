using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal class Circle : Form
    {

        public float Radius { get; private set; }

        public Circle(Point center, float radius)
        {
            Origin = center;
            Radius = radius;
        }
        public override double GetPerimetre()
        {
            return Math.PI * Radius;
        }
        public override double GetSurface()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override string? ToString()
        {
            return $"Cercle ayant pour centre = ({Origin.Abscissa};{Origin.Ordered}), Rayon = {Radius} ";
        }
    }
}
