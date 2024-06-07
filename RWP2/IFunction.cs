using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWP2
{
    public interface IFunction
    {

        void Draw(ForDraw fd);
        float Calc(double x);
    }
}
