using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RWP2
{
    internal class Spline_Bezier: Basic
    {

        public List<PointF> points = new List<PointF>();

        public override void Draw(ForDraw fd)
        {
            /*fd.graphics.DrawBezier(fd.graphic_pen, points[0].X*fd.zoom + fd.width/2 + fd.shiftx, fd.height/2 - points[0].Y*fd.zoom + fd.shifty, points[1].X*fd.zoom + fd.width/2 + fd.shiftx, fd.height/2 - points[1].Y * fd.zoom  + fd.shifty, points[2].X*fd.zoom + fd.width/2 + fd.shiftx,fd.height/2 -  points[2].Y*fd.zoom  + fd.shifty, points[3].X*fd.zoom + fd.width/2  + fd.shiftx,fd.height/2 - points[3].Y*fd.zoom + fd.shifty);*/
            if((points.Count() - 1) % 3 == 0)
            {
                for (int i = 0; i < points.Count; ++i)
                {
                    points[i] = new PointF(points[i].X * fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - points[i].Y * fd.zoom + fd.shifty);
                }
                fd.graphics.DrawBeziers(fd.graphic_pen, points.ToArray());
                for (int i = 0; i < points.Count; ++i)
                {
                    points[i] = new PointF((points[i].X - fd.shiftx - fd.width / 2) / (float)fd.zoom, (fd.height / 2 - points[i].Y + fd.shifty) / (float)fd.zoom);
                }
            }
            for (int i = 0; i < points.Count(); ++i)
            {
                fd.graphics.FillEllipse(fd.points_brush, points[i].X*(float)fd.zoom + fd.width/2 - (float)fd.zoom / 8 + fd.shiftx, fd.height/2 - points[i].Y*(float)fd.zoom - (float)fd.zoom / 8 + fd.shifty, (float)fd.zoom / 4, (float)fd.zoom / 4);
                string title = "";
                if (i == 0)
                    title = "Start";
                if ((i > 0) && (i < points.Count() - 1))
                    title = "Point" + i.ToString();
                if (i == points.Count() - 1)
                    title = "End";
                fd.graphics.DrawString(title, fd.DefaultFont, fd.points_brush, points[i].X*(float)fd.zoom + fd.width/2 + fd.shiftx, fd.height/2 - points[i].Y*(float)fd.zoom + fd.shifty - (float)fd.zoom);
            }
            Pen stroke = new Pen(Color.Black, 2);
            stroke.DashStyle = DashStyle.Dash;
            for(int i = 0; i < points.Count - 1; ++i)
            {
                fd.graphics.DrawLine(stroke, points[i].X * (float)fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - points[i].Y * (float)fd.zoom + fd.shifty, points[i+1].X * (float)fd.zoom + fd.width / 2 + fd.shiftx, fd.height / 2 - points[i+1].Y * (float)fd.zoom + fd.shifty);
            }
        }

        public override float Calc(double x)
        {
            return 0;
        }
    }
}
