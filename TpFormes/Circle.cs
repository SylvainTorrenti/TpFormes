using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal class Circle : Form
    {
        #region Props
        /// <summary>
        /// Rayon
        /// </summary>
        public float Radius { get; private set; } 
        #endregion
        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="radius"></param>
        public Circle(Point origin, float radius) : base(origin)
        {
            Radius = radius;
        } 
        #endregion
        #region Methode
        /// <summary>
        /// Calcul le perimetre
        /// </summary>
        /// <returns></returns>
        public override double GetPerimetre()
        {
            return Math.PI * Radius;
        }
        /// <summary>
        /// Calcul la surface
        /// </summary>
        /// <returns></returns>
        public override double GetSurface()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
        /// <summary>
        /// Affiche les details
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return @$"
Cercle ayant pour centre = ({Origin.Abscissa};{Origin.Ordered}), Rayon = {Radius} 
--------------------------------";
        } 
        #endregion




    }
}

