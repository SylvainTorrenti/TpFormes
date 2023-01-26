using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal class Point
    {
        #region Get & Set Abscissa
        /// <summary>
        /// Abscissa
        /// </summary>
        public int Abscissa { get; private set; }
        #endregion
        #region Get & Set Ordered
        /// <summary>
        /// Ordered
        /// </summary>
        public int Ordered { get; private set; }
        #endregion      
        public Point(int abscissa, int ordered)
        {
            Abscissa = abscissa;
            Ordered = ordered;
        }
        public Point(Point point) 
        {
            Abscissa = point.Abscissa;
            Ordered = point.Ordered;
        }
        public double Norme(Point point)
        {
            return Math.Sqrt(Math.Pow(Abscissa - point.Abscissa, 2) + Math.Pow(Ordered - point.Ordered, 2));
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point)
            {
                return obj is Point p && (p.Ordered == Ordered) && (p.Abscissa == Abscissa); 
                    
            }
            return false;
        }

        public override string? ToString()
        {
            return $"({Abscissa};{Ordered})";
        }

    }
}
