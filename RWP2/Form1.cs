using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace RWP2
{
    public partial class Form1 : Form
    {
        Pen graphic_pen = new Pen(Color.Red, 2);
        Pen pen2 = new Pen(Color.Black, 1);
        Pen pen = new Pen(Color.Black, 4);
        int IndexOfFunction = -1;
        int CountsOfPointsInSpline = 0;
        const int default_zoom = 30;
        int zoom = default_zoom;
        float shiftx = 0;
        float shifty = 0;
        float OldX;
        float OldY;
        bool IsPressed = false;
        Color BackColorMain = Color.White;
        Color BackColorMinor = Color.White;
        public bool Prinyat;
        string SelectedMusic = "";
        string path = @"C:\\Users\\zahar\\source\\repos\\RWP2\\";
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        List <IFunction> functions = new List<IFunction>() {new Sin(), new XX(), new XXX(), new _2Xplus5(),  new Tg()};
        Spline_Bezier spline = new Spline_Bezier();
        SolidBrush points_brush = new SolidBrush(Color.Black);
        bool InPoint = false;
        int PointIndex = -1;
        float OldPointX;
        float OldPointY;
        public Form1()
        {
            InitializeComponent();
            graphic.MouseWheel += graphic_MouseWheel;
            this.DoubleBuffered = true;
            Cancel_Spline.Visible = false;
            Add_Spline.Visible = false;
            Delete_Point.Visible = false;
            ControlOfGraphic.BackColor = Color.White;
        }

        private void Random_Func_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            IndexOfFunction = rnd.Next(0, functions.Count());
            zoom = default_zoom;
            shiftx = 0;
            shifty = 0;
            InPoint = false;
            graphic.Refresh();
        }

        private void SelectColorOfGraphic_Click(object sender, EventArgs e)
        {
            if(ColorOfGraphic.ShowDialog() == DialogResult.OK)
            {
                graphic_pen = new Pen(ColorOfGraphic.Color, 2);
                graphic.Refresh();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Bitmap btm = new Bitmap(graphic.Width, graphic.Height);
            graphic.DrawToBitmap(btm, new Rectangle(0, 0, graphic.Width, graphic.Height));
            SaveFileDialog saveGraphic = new SaveFileDialog();
            saveGraphic.Filter = "Jpg Files (*.jpg)|*.jpg|Png Files (*.png)|*.png|All files(*.*)|*.*";
            saveGraphic.FilterIndex = 0;
            saveGraphic.RestoreDirectory = true;
            saveGraphic.InitialDirectory = "C:\\Users\\zahar\\source\\repos\\RWP2\\RWP2\\Images";
            saveGraphic.Title = "Сохранение графика";
            if(saveGraphic.ShowDialog() == DialogResult.OK)
            {
                if (saveGraphic.FileName != "")
                {
                    btm.Save(saveGraphic.FileName);
                    btm.Dispose();
                }
                else
                {
                    MessageBox.Show("Вы ввели пустое имя файла", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            graphic.Refresh();
        }

        private void SelectBackgroundStyle_Click(object sender, EventArgs e)
        {
            Prinyat = false;
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Now_Style(pen2, BackColorMain, BackColorMinor, SelectedMusic);
            f2.ShowDialog();
            if (Prinyat)
            {
                pen2 = f2.New_Pen();
                BackColorMain = f2.New_Main_Color();
                BackColorMinor = f2.New_Minor_Color();
                if(SelectedMusic != f2.New_Track())
                {
                    SelectedMusic = f2.New_Track();
                    wplayer.URL = (path + SelectedMusic);
                    wplayer.settings.volume = 150;
                    if (SelectedMusic == "Track2.mp3")
                    {
                        wplayer.settings.volume = 50;
                    }
                    VolumeOfMusic.Value = wplayer.settings.volume / 2;
                    ActualVolume.Text = VolumeOfMusic.Value.ToString();
                    if (SelectedMusic == "")
                    {
                        MusicSettings.Visible = false;
                    }
                    else
                    {
                        MusicSettings.Visible = true;
                    }
                    wplayer.controls.play();
                    wplayer.controls.next();
                }
                graphic.Refresh();
            }
        }
        private void graphic_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            zoom += e.Delta/40;
            if (zoom < 6)
                zoom = 6;
            if(zoom != default_zoom){
                label3.Text = "Масштаб: " + ((double)zoom / (double)default_zoom).ToString();
            }
            graphic.Refresh();
        }

        private void graphic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bitmap;
            if (graphic != null)
                bitmap = new Bitmap(graphic.Width, graphic.Height);
            else
            {
                bitmap = new Bitmap(0, 0);
            }
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            LinearGradientBrush BackBrush = new LinearGradientBrush(new Rectangle(0, 0, graphic.Width, graphic.Height), BackColorMain, BackColorMinor, LinearGradientMode.Horizontal);
            Pen back = new Pen(BackBrush);
            graphics.FillRectangle(BackBrush, new Rectangle(0, 0, graphic.Width, graphic.Height));
            int width = graphic.Width;
            int height = graphic.Height;
            label1.Location = new Point(width / 2 - 15 + (int)shiftx, 10);
            label2.Location = new Point(width - 10, height / 2 + 10 + (int)shifty);
            label3.Location = new Point(width - 80, 5);

            int i = 0;
            while (width / 2 - i + shiftx > 0)
            {
                graphics.DrawLine(pen2, width / 2 - i + shiftx, 0, width / 2 - i + shiftx, height);
                i += zoom;
            }
            i = 0;
            while (width / 2 + i + shiftx < width)
            {
                graphics.DrawLine(pen2, width / 2 + i + shiftx, 0, width / 2 + i + shiftx, height);
                i += zoom;
            }
            i = 0;
            while (height / 2 - i + shifty > 0)
            {
                graphics.DrawLine(pen2, 0, height / 2 - i + shifty, width, height / 2 - i + shifty);
                i += zoom;
            }
            i = 0;
            while (height / 2 + i + shifty < height)
            {
                graphics.DrawLine(pen2, 0, height / 2 + i + shifty, width, height / 2 + i + shifty);
                i += zoom;
            }
            graphics.DrawLine(pen, 0, height / 2 + shifty, width - 10, height / 2 + shifty);
            graphics.DrawLine(pen, width / 2 + shiftx, 10, width / 2 + shiftx, height);
            Point[] points = new Point[3];
            points[0] = new Point(width / 2 + (int)shiftx, 0);
            points[1] = new Point(width / 2 - 5 + (int)shiftx, 10);
            points[2] = new Point(width / 2 + 5 + (int)shiftx, 10);
            graphics.FillPolygon(Brushes.Black, points);
            points[0] = new Point(width, height / 2 + (int)shifty);
            points[1] = new Point(width - 10, height / 2 - 5 + (int)shifty);
            points[2] = new Point(width - 10, height / 2 + 5 + (int)shifty);
            graphics.FillPolygon(Brushes.Black, points);
            Pen pen4 = new Pen(Color.Black, 2);
            pen4.DashStyle = DashStyle.Dash;
            graphics.DrawEllipse(pen4, width / 2 - zoom + shiftx, height / 2 - zoom + shifty, zoom * 2, zoom * 2);
            IFunction func;
            ForDraw fd = new ForDraw(graphics, graphic_pen, points_brush, zoom, width, height, shiftx, shifty, DefaultFont);
            if(IndexOfFunction > -1)
            {
                func = functions[IndexOfFunction];
                func.Draw(fd);
            }
           /* if((CountsOfPointsInSpline > 0) && (IndexOfFunction == -2))
            {
                for(i = 0; i < CountsOfPointsInSpline; ++i)
                {
                    graphics.FillEllipse(points_brush, (spline.points[i].X * zoom + width/2) - zoom/8, (height/2 - spline.points[i].Y * zoom) - zoom/8, zoom/4, zoom/4);
                    string title = "";
                    if (i == 0)
                        title = "Start";
                    if ((i > 0) && (i < points.Count() - 1))
                        title = "Point" + i.ToString();
                    if (i == points.Count() - 1)
                        title = "End";
                    fd.graphics.DrawString(title, DefaultFont, points_brush, points[i].X * (float)zoom + width / 2 + shiftx, height / 2 - points[i].Y * (float)zoom + shifty - (float)zoom);
                }
            }
            if(CountsOfPointsInSpline == 4)
            {
                spline.Draw(fd);
            }*/
           if((CountsOfPointsInSpline > 0) && (IndexOfFunction == -2))
            {
                spline.Draw(fd);
            }
            g.DrawImage(bitmap, 0, 0);
        }

        private void graphic_MouseHover(object sender, EventArgs e)
        {
            graphic.Focus();
        }

        private void graphic_MouseDown(object sender, MouseEventArgs e)
        {
            if(IndexOfFunction > 4)
            {
                spline = (Spline_Bezier)functions[IndexOfFunction];
                for (int i = 0; i < spline.points.Count; ++i)
                {
                    if ((((e.X >= spline.points[i].X*(float)zoom + graphic.Width/2- 20 + shiftx) && (e.X <= spline.points[i].X*(float)zoom + graphic.Width/2 + 20 + shiftx)) && ((e.Y >= graphic.Height/2 - spline.points[i].Y*(float)zoom - 20 + shifty) && (e.Y <= graphic.Height/2 - spline.points[i].Y*(float)zoom + 20 + shifty))))
                    {
                        InPoint = true;
                        PointIndex = i;
                        break;
                    }
                    else
                    {
                        InPoint = false;
                    }
                }
            }
            if ((ControlOfGraphic.BackColor == Color.White) && (e.Button == MouseButtons.Left))
            {
                IsPressed = true;
                OldX = e.X;
                OldY = e.Y;
                if (InPoint)
                {
                    OldPointX = (e.X - graphic.Width/2)/(float)zoom + shiftx;
                    OldPointY = (graphic.Height/2 - e.Y)/(float)zoom + shiftx;
                }
            }
        }

        private void graphic_MouseUp(object sender, MouseEventArgs e)
        {
            IsPressed = false;
        }

        private void graphic_MouseMove(object sender, MouseEventArgs e)
        {
            if ((IsPressed) && (!InPoint))
            {
                shiftx += e.X - OldX;
                shifty += e.Y - OldY;
                OldX = e.X;
                OldY = e.Y;
                graphic.Refresh();
            }
            if((IsPressed) && (InPoint))
            {
                spline.points[PointIndex] = new PointF((e.X - graphic.Width / 2 - shiftx) /(float)zoom, (graphic.Height / 2 - e.Y + shifty)/(float)zoom);
                functions[IndexOfFunction] = spline;
                OldPointX = (e.X - graphic.Width / 2 - shiftx) / (float)zoom;
                OldPointY = (graphic.Height / 2 - e.Y + shiftx) / (float)zoom;
                graphic.Refresh();
            }
        }

        private void VolumeOfMusic_Scroll(object sender, EventArgs e)
        {
            wplayer.settings.volume = VolumeOfMusic.Value * 2;
            ActualVolume.Text = VolumeOfMusic.Value.ToString();
        }

        private void Create_Bezier_Click(object sender, EventArgs e)
        {
            shiftx = 0;
            shifty = 0;
            zoom = default_zoom;
            CountsOfPointsInSpline = 0;
            IndexOfFunction = -2;
            ControlOfGraphic.BackColor = Color.Aqua;
            Random_Func.Enabled = false;
            Save.Enabled = false;
            Create_Bezier.Enabled = false;
            Cancel_Spline.Visible = true;
            Delete_Point.Visible = true;
            Add_Spline.Visible = true;
            SelectColorOfGraphic.Enabled = false;
            SelectBackgroundStyle.Enabled = false;
            /*if (spline.points.Count == 4)
            {
                for (int i = 0; i < spline.points.Count; i++)
                {
                    spline.points[i] = new PointF(0 + shiftx, 0 + shifty);
                }
            }
            else
            {
                for (int i = spline.points.Count; i < 4; ++i)
                {
                    spline.points.Add(new PointF(0 + shiftx, 0 + shifty));
                }
            }*/
            spline.points.Clear();
            CountsOfPointsInSpline = 0;
            graphic.Refresh();
        }

        private void graphic_MouseClick(object sender, MouseEventArgs e)
        {
            if ((IndexOfFunction == -2) && (e.Button == MouseButtons.Left))
            {
                CountsOfPointsInSpline++;
                /*spline.points[CountsOfPointsInSpline] = new PointF((e.X - graphic.Width/2)/(float)zoom + shiftx, (graphic.Height/2 - e.Y)/(float)zoom - shifty);*/
                spline.points.Add(new PointF((e.X - graphic.Width / 2) / (float)zoom + shiftx, (graphic.Height / 2 - e.Y) / (float)zoom - shifty));
            }
            graphic.Refresh();
        }

        private void Cancel_Spline_Click(object sender, EventArgs e)
        {
            ControlOfGraphic.BackColor = Color.White;
            Random_Func.Enabled = true;
            Save.Enabled = true;
            Create_Bezier.Enabled = true;
            Cancel_Spline.Visible = false;
            Delete_Point.Visible = false;
            Add_Spline.Visible = false;
            SelectColorOfGraphic.Enabled = true;
            SelectBackgroundStyle.Enabled = true;
            CountsOfPointsInSpline = 0;
            IndexOfFunction = -1;
            graphic.Refresh();

        }

        private void Add_Spline_Click(object sender, EventArgs e)
        {
            if(((spline.points.Count() - 1) %3 == 0) && (spline.points.Count() > 0))
            {
                functions.Add(spline);
                ControlOfGraphic.BackColor = Color.White;
                Random_Func.Enabled = true;
                Save.Enabled = true;
                Create_Bezier.Enabled = true;
                Cancel_Spline.Visible = false;
                Add_Spline.Visible = false;
                Delete_Point.Visible = false;
                SelectColorOfGraphic.Enabled = true;
                SelectBackgroundStyle.Enabled = true;
                CountsOfPointsInSpline = 0;
                IndexOfFunction = -1;
                graphic.Refresh();
            }
            else
            {
                if(spline.points.Count() > 4)
                {
                    MessageBox.Show("Необходимо добавить ещё " + (3 - ((spline.points.Count() - 1) % 3)).ToString() + " точки для построения сплайна Безье (либо удалить " + ((spline.points.Count() - 1) % 3).ToString() + ")", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Необходимо добавить ещё " + (3 - ((spline.points.Count() - 1) % 3)).ToString() + " точки для построения сплайна Безье", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void Delete_Point_Click(object sender, EventArgs e)
        {
            if(CountsOfPointsInSpline > 0)
            {
               spline.points.RemoveAt(CountsOfPointsInSpline-1);
               CountsOfPointsInSpline--;
               graphic.Refresh();
            }
        }
    }

}
