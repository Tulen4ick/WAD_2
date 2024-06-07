using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RWP2
{
    public class ForDraw
    {
        public Graphics graphics;
        public Pen graphic_pen;
        public SolidBrush points_brush;
        public int zoom;
        public int width;
        public int height;
        public float shiftx;
        public float shifty;
        public Font DefaultFont;
        public ForDraw(Graphics g, Pen gp, SolidBrush pb, int z, int w, int h, float sx, float sy, Font dF)
        {
            graphics = g;
            graphic_pen = gp;
            points_brush = pb;
            zoom = z;
            width = w;
            height = h;
            shiftx = sx;
            shifty = sy;
            DefaultFont = dF;
        }
    }
}
