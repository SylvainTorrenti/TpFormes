using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal class Segment
    {
        #region Props
        /// <summary>
        /// point d'origine
        /// </summary>
        public Point FirsPoint { get; private set; }
        /// <summary>
        /// Point de destination
        /// </summary>
        public Point EndPoint { get; private set; } 
        #endregion
        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="firsPoint"></param>
        /// <param name="endPoint"></param>
        public Segment(Point firsPoint, Point endPoint)
        {
            FirsPoint = firsPoint;
            EndPoint = endPoint;
        } 
        #endregion
        #region methode
        /// <summary>
        /// Calcul de la norme
        /// </summary>
        /// <returns></returns>
        public double NormeSegment()
        {
            return Math.Sqrt(Math.Pow(FirsPoint.Abscissa - EndPoint.Abscissa, 2) + Math.Pow(FirsPoint.Ordered - EndPoint.Ordered, 2));
        }
        /// <summary>
        /// affiche les details du segment
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return @$"
Le point d'origine est :({FirsPoint.Abscissa},{FirsPoint.Ordered})
Le point de destination est : ({EndPoint.Abscissa},{EndPoint.Ordered})";
        } 
        #endregion
    }
}
