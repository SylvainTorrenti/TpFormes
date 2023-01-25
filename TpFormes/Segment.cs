using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal class Segment
    {
        public Point FirsPoint { get; private set; }

        public Point EndPoint { get; private set; }
        public Segment(Point firsPoint, Point endPoint)
        {
            FirsPoint = firsPoint;
            EndPoint = endPoint;
        }

        public double NormeSegment()
        {
            return Math.Sqrt(Math.Pow(FirsPoint.Abscissa - EndPoint.Abscissa, 2) + Math.Pow(FirsPoint.Ordered - EndPoint.Ordered, 2));
        }

        public override string? ToString()
        {
            return @$"
Le point d'origine est :({FirsPoint.Abscissa},{FirsPoint.Ordered})
Le point de destination est : ({EndPoint.Abscissa},{EndPoint.Ordered})";
        }
    }
}
