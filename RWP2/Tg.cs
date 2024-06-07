using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RWP2
{
    internal class Tg: Basic
    {
        public override void Draw(ForDraw fd)
        {
            int CountOfInfinity = (int)((double)((fd.width + fd.shiftx / fd.zoom) / 2) / (Math.PI / 2));
            int now_infinity = -CountOfInfinity;
            for (float x = -fd.width; x < fd.width - 0.1; x += 0.1f)
            {
                if ((x <= (float)(Math.PI / 2) * (now_infinity) - 0.1f))
                {
                    fd.graphics.DrawLine(fd.graphic_pen, x * fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - this.Calc(x) * fd.zoom + fd.shifty, (x + 0.1f) * fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - this.Calc(x + 0.1f) * fd.zoom + fd.shifty);
                }
                else
                {
                    if (Math.Abs(now_infinity % 2) == 1)
                    {
                        if ((x <= (float)(Math.PI / 2) * (now_infinity)) && (x > (float)(Math.PI / 2) * (now_infinity) - 0.1f))
                        {
                            fd.graphics.DrawLine(fd.graphic_pen, (x) * fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - this.Calc(x) * fd.zoom + fd.shifty, (x + 0.1f) * fd.zoom + fd.width / 2 + fd.shiftx, -100000 + fd.shifty);
                            fd.graphics.DrawLine(fd.graphic_pen, (x + 0.1f) * fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - this.Calc(x + 0.1f) * fd.zoom + fd.shifty, (x) * fd.zoom + fd.width / 2 + fd.shiftx, 10000 + fd.shifty);
                        }
                        //graphics.DrawLine(pen4, (float)(Math.PI / 2) * (now_infinity) * zoom + width / 2, 0, (float)(Math.PI / 2) * (now_infinity) * zoom + width / 2, height);

                    }
                    else
                    {
                        fd.graphics.DrawLine(fd.graphic_pen, x * fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - this.Calc(x) * fd.zoom + fd.shifty, (x + 0.1f) * fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - this.Calc(x + 0.1f) * fd.zoom + fd.shifty);
                    }
                    now_infinity += 1;
                }
            }
        }
        public override float Calc(double x)
        {
            return (float)Math.Tan(x);
        }
    }
}
