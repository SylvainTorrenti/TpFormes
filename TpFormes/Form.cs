using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal abstract class Form
    {
        public Point Origin { get; protected set; }
        public abstract double GetPerimetre();
        public abstract double GetSurface();

    }
}
