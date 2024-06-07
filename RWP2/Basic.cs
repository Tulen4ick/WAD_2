using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWP2
{
    abstract class Basic: IFunction
    {
        public virtual void Draw(ForDraw fd)
        {
            for (float x = -fd.width / fd.zoom; x < fd.width / fd.zoom - 0.1; x += 0.1f)
            {
                fd.graphics.DrawLine(fd.graphic_pen, x * fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - this.Calc(x) * fd.zoom + fd.shifty, (x + 0.1f) * fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - this.Calc(x + 0.1f) * fd.zoom + fd.shifty);
            }
        }
        public abstract float Calc(double x);
    }
}
