
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal class Rectangle : Form
    {
        public int Length { get; private set; }

        public int Width { get; private set; }

        public Rectangle(Point origin, int lenght, int width) : base(origin)
        {
            Length = lenght;
            Width = width;
        }
        public override double GetPerimetre()
        {
            return (Length * 2) + (Width * 2);
        }

        public override double GetSurface()
        {
            return Length * Width;
        }

        public override string? ToString()
        {
            return $@"Rectangle:
Le point d'origine du rectangle est : {Origin.ToString()}
La largeur est de : {Width} cm
La longeur est de : {Length} cm
--------------------------------";
        }
       
    }
}
