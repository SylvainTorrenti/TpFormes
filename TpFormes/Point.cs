using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal class Point
    {
        #region Props
        /// <summary>
        /// Abscissa
        /// </summary>
        public int Abscissa { get; private set; }
        /// <summary>
        /// Ordered
        /// </summary>
        public int Ordered { get; private set; } 
        #endregion
        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="abscissa"></param>
        /// <param name="ordered"></param>
        public Point(int abscissa, int ordered)
        {
            Abscissa = abscissa;
            Ordered = ordered;
        }
        /// <summary>
        /// Constructeur de copie
        /// </summary>
        /// <param name="point"></param>
        public Point(Point point)
        {
            Abscissa = point.Abscissa;
            Ordered = point.Ordered;
        } 
        #endregion
        #region Methode
        /// <summary>
        /// Calcul la norme
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public double Norme(Point point)
        {
            return Math.Sqrt(Math.Pow(Abscissa - point.Abscissa, 2) + Math.Pow(Ordered - point.Ordered, 2));
        }
        /// <summary>
        /// Verifie si deux points sont egaux
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is Point)
            {
                return obj is Point p && (p.Ordered == Ordered) && (p.Abscissa == Abscissa);

            }
            return false;
        }
        /// <summary>
        /// affiche les details
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"({Abscissa};{Ordered})";
        } 
        #endregion

    }
}
