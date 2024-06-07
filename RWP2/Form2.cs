using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWP2
{
    public partial class Form2 : Form
    {
        Pen CoordinateLines;
        Color MainColor;
        Color MinorColor;
        String MusicName;
        public Form2()
        {
            InitializeComponent();
            Form1 f1 = (Form1)this.Owner;
        }

        private void visibility_Scroll(object sender, EventArgs e)
        {
            CoordinateLines = new Pen(Color.FromArgb(visibility.Value, CoordinateLines.Color));
            ActualVisibility.Text = visibility.Value.ToString();
        }
        public void Now_Style(Pen Line, Color color1, Color color2, String SelectedTrack)
        {
            CoordinateLines = Line;
            MainColor = color1;
            MinorColor = color2;
            MainColorSelect.BackColor = color1;
            MinorColorSelect.BackColor = color2;
            LinesColorSelect.BackColor = Line.Color;
            visibility.Value = CoordinateLines.Color.A;
            ActualVisibility.Text = visibility.Value.ToString();
            if(color2 == color1)
            {
                Gradient.Checked = false;
                ColorOfGradient.Enabled = false;
            }
            else
            {
                Gradient.Checked = true;
                ColorOfGradient.Enabled = true;
            }
            if (CoordinateLines.DashStyle == DashStyle.Solid)
                LineFonts.SelectedIndex = 0;
            if (CoordinateLines.DashStyle == DashStyle.Dash)
                LineFonts.SelectedIndex = 1;
            if (CoordinateLines.DashStyle == DashStyle.DashDot)
                LineFonts.SelectedIndex = 2;
            if (CoordinateLines.DashStyle == DashStyle.Dot)
                LineFonts.SelectedIndex = 3;
            MusicName = SelectedTrack;
            if (MusicName == "")
                Music.SelectedIndex = 0;
            if (MusicName == "Track1.mp3")
                Music.SelectedIndex = 1;
            if (MusicName == "Track2.mp3")
                Music.SelectedIndex = 2;
            if (MusicName == "Track3.mp3")
                Music.SelectedIndex = 3;

        }
        public Pen New_Pen()
        {
            return CoordinateLines;
        }
        public Color New_Main_Color()
        {
            return MainColor;
        }
        public Color New_Minor_Color()
        {
            return MinorColor;  
        }
        public String New_Track()
        {
            return MusicName;
        }

        private void Gradient_CheckedChanged(object sender, EventArgs e)
        {
            if (Gradient.Checked == true)
                ColorOfGradient.Enabled = true;
            else
            {
                ColorOfGradient.Enabled = false;
                MinorColor = MainColor;
                MinorColorSelect.BackColor = MainColor;
            }
        }

        private void Color1_Click(object sender, EventArgs e)
        {
            if (BackColor1.ShowDialog() == DialogResult.OK)
            {
                MainColor = BackColor1.Color;
                MainColorSelect.BackColor = BackColor1.Color;
                if(Gradient.Checked == false)
                {
                    MinorColor = BackColor1.Color;
                    MinorColorSelect.BackColor = BackColor1.Color;
                }
            }
        }

        private void ColorOfGradient_Click(object sender, EventArgs e)
        {
            if (BackColor2.ShowDialog() == DialogResult.OK)
            {
                MinorColor = BackColor2.Color;
                MinorColorSelect.BackColor = BackColor2.Color;
            }
        }

        private void DefaultGraphic_Click(object sender, EventArgs e)
        {
            CoordinateLines = new Pen(Color.FromArgb(255, CoordinateLines.Color));
            visibility.Value = 255;
            MainColor = Color.White;
            MainColorSelect.BackColor = Color.White;
            MinorColor = Color.White;
            MinorColorSelect.BackColor = Color.White;
            Gradient.Checked = false;
            CoordinateLines.DashStyle = DashStyle.Solid;
            CoordinateLines.Color = Color.Black;
            LinesColorSelect.BackColor = Color.Black;
            LineFonts.SelectedIndex = 0;
            Music.SelectedIndex = 0;
            MusicName = "";
        }

        private void ColorOfCoordinates_Click(object sender, EventArgs e)
        {
            if (CoordinateColor.ShowDialog() == DialogResult.OK)
            {
                CoordinateLines.Color = CoordinateColor.Color;
                LinesColorSelect.BackColor = CoordinateColor.Color;
            }
        }

        private void LineFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LineFonts.SelectedIndex == -1)
                LineFonts.SelectedIndex = 0;
            if (LineFonts.SelectedIndex == 0)
                CoordinateLines.DashStyle = DashStyle.Solid;
            if (LineFonts.SelectedIndex == 1)
                CoordinateLines.DashStyle = DashStyle.Dash;
            if (LineFonts.SelectedIndex == 2)
                CoordinateLines.DashStyle = DashStyle.DashDot;
            if (LineFonts.SelectedIndex == 3)
                CoordinateLines.DashStyle = DashStyle.Dot;
        }

        private void Access_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            f1.Prinyat = true;
            this.Close();
        }

        private void Music_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Music.SelectedIndex == -1)
                Music.SelectedIndex = 0;
            if (Music.SelectedIndex == 0)
                MusicName = "";
            if (Music.SelectedIndex == 1)
                MusicName = "Track1.mp3";
            if (Music.SelectedIndex == 2)
                MusicName = "Track2.mp3";
            if (Music.SelectedIndex == 3)
                MusicName = "Track3.mp3";
        }
    }
}
