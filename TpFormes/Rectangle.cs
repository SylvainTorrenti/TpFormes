
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal class Rectangle : Form
    {
        #region Props
        /// <summary>
        /// Longueur
        /// </summary>
        public int Length { get; private set; }
        /// <summary>
        /// Largeur
        /// </summary>
        public int Width { get; private set; } 
        #endregion
        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="lenght"></param>
        /// <param name="width"></param>
        public Rectangle(Point origin, int lenght, int width) : base(origin)
        {
            Length = lenght;
            Width = width;
        } 
        #endregion
        #region Methode
        /// <summary>
        /// Calcule le perimetre
        /// </summary>
        /// <returns></returns>
        public override double GetPerimetre()
        {
            return (Length * 2) + (Width * 2);
        }
        /// <summary>
        /// Calcule la surface
        /// </summary>
        /// <returns></returns>
        public override double GetSurface()
        {
            return Length * Width;
        }
        /// <summary>
        /// affiche les details
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $@"Rectangle:
Le point d'origine du rectangle est : {Origin.ToString()}
La largeur est de : {Width} cm
La longeur est de : {Length} cm
--------------------------------";
        } 
        #endregion

    }
}
