using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWP2
{
    internal class Sin: Basic
    {

        public override float Calc(double x)
        {
            return (float)(Math.Sin(x));
        }
    }
}
