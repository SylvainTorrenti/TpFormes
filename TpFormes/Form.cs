using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal abstract class Form : IComparable
    {
        public Point Origin { get; protected set; }

    public Form(Point origin)
        {
            Origin = origin;
        }      
        public abstract double GetPerimetre();
        public abstract double GetSurface();
        

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            Form otherForm = obj as Form;
            if (otherForm != null)
                return GetSurface().CompareTo(otherForm.GetSurface());
            else
                throw new ArgumentException("Object is not a Temperature");
        }
    }
}
