using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3unit
{
    class TriangleSides
    {
        public bool Sides(double a, double b, double c)
        {
            if (Math.Max(Math.Max(a, b), c) < a + b + c - Math.Max(Math.Max(a, b), c))
            {
                return true;
            }
            return false;
        }
    }
}
