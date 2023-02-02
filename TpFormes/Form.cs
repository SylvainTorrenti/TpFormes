using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal abstract class Form : IComparable
    {
        #region Props
        /// <summary>
        /// origine de la forme
        /// </summary>
        public Point Origin { get; protected set; } 
        #endregion
        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="origin"></param>       
        public Form(Point origin)
        {
            Origin = origin;
        } 
        #endregion
        #region Methode
        /// <summary>
        /// Methode absbtraite de calcul du permietre
        /// </summary>
        /// <returns></returns>
        public abstract double GetPerimetre();
        /// <summary>
        /// Methode abstraite de calcul de la surface
        /// </summary>
        /// <returns></returns>
        public abstract double GetSurface();
        /// <summary>
        /// Compare les surfaces de differente forme
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            Form otherForm = obj as Form;
            if (otherForm != null)
                return GetSurface().CompareTo(otherForm.GetSurface());
            else
                throw new ArgumentException("L'objet n'est pas une forme");
        } 
        #endregion
    }
}
