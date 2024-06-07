using System.Windows.Forms;

namespace RWP2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ControlOfGraphic = new System.Windows.Forms.GroupBox();
            this.Add_Spline = new System.Windows.Forms.Button();
            this.Cancel_Spline = new System.Windows.Forms.Button();
            this.Create_Bezier = new System.Windows.Forms.Button();
            this.MusicSettings = new System.Windows.Forms.GroupBox();
            this.VolumeOfMusic = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ActualVolume = new System.Windows.Forms.Label();
            this.SelectBackgroundStyle = new System.Windows.Forms.Button();
            this.SelectColorOfGraphic = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Random_Func = new System.Windows.Forms.Button();
            this.ColorOfGraphic = new System.Windows.Forms.ColorDialog();
            this.Delete_Point = new System.Windows.Forms.Button();
            this.graphic = new RWP2.MyPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ControlOfGraphic.SuspendLayout();
            this.MusicSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeOfMusic)).BeginInit();
            this.graphic.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlOfGraphic
            // 
            this.ControlOfGraphic.Controls.Add(this.Delete_Point);
            this.ControlOfGraphic.Controls.Add(this.Add_Spline);
            this.ControlOfGraphic.Controls.Add(this.Cancel_Spline);
            this.ControlOfGraphic.Controls.Add(this.Create_Bezier);
            this.ControlOfGraphic.Controls.Add(this.MusicSettings);
            this.ControlOfGraphic.Controls.Add(this.SelectBackgroundStyle);
            this.ControlOfGraphic.Controls.Add(this.SelectColorOfGraphic);
            this.ControlOfGraphic.Controls.Add(this.Save);
            this.ControlOfGraphic.Controls.Add(this.Random_Func);
            this.ControlOfGraphic.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlOfGraphic.Location = new System.Drawing.Point(482, 0);
            this.ControlOfGraphic.Name = "ControlOfGraphic";
            this.ControlOfGraphic.Size = new System.Drawing.Size(432, 496);
            this.ControlOfGraphic.TabIndex = 0;
            this.ControlOfGraphic.TabStop = false;
            this.ControlOfGraphic.Text = "Управление графиком";
            // 
            // Add_Spline
            // 
            this.Add_Spline.Location = new System.Drawing.Point(311, 107);
            this.Add_Spline.Name = "Add_Spline";
            this.Add_Spline.Size = new System.Drawing.Size(91, 43);
            this.Add_Spline.TabIndex = 12;
            this.Add_Spline.Text = "Добавить график";
            this.Add_Spline.UseVisualStyleBackColor = true;
            this.Add_Spline.Click += new System.EventHandler(this.Add_Spline_Click);
            // 
            // Cancel_Spline
            // 
            this.Cancel_Spline.Location = new System.Drawing.Point(190, 107);
            this.Cancel_Spline.Name = "Cancel_Spline";
            this.Cancel_Spline.Size = new System.Drawing.Size(103, 43);
            this.Cancel_Spline.TabIndex = 11;
            this.Cancel_Spline.Text = "Отменить построение";
            this.Cancel_Spline.UseVisualStyleBackColor = true;
            this.Cancel_Spline.Click += new System.EventHandler(this.Cancel_Spline_Click);
            // 
            // Create_Bezier
            // 
            this.Create_Bezier.Location = new System.Drawing.Point(17, 146);
            this.Create_Bezier.Name = "Create_Bezier";
            this.Create_Bezier.Size = new System.Drawing.Size(132, 43);
            this.Create_Bezier.TabIndex = 10;
            this.Create_Bezier.Text = "Построить сплайн Безье";
            this.Create_Bezier.UseVisualStyleBackColor = true;
            this.Create_Bezier.Click += new System.EventHandler(this.Create_Bezier_Click);
            // 
            // MusicSettings
            // 
            this.MusicSettings.Controls.Add(this.VolumeOfMusic);
            this.MusicSettings.Controls.Add(this.label4);
            this.MusicSettings.Controls.Add(this.label5);
            this.MusicSettings.Controls.Add(this.ActualVolume);
            this.MusicSettings.Location = new System.Drawing.Point(51, 360);
            this.MusicSettings.Name = "MusicSettings";
            this.MusicSettings.Size = new System.Drawing.Size(332, 130);
            this.MusicSettings.TabIndex = 9;
            this.MusicSettings.TabStop = false;
            this.MusicSettings.Text = "Громкость музыки";
            this.MusicSettings.Visible = false;
            // 
            // VolumeOfMusic
            // 
            this.VolumeOfMusic.Location = new System.Drawing.Point(28, 45);
            this.VolumeOfMusic.Maximum = 100;
            this.VolumeOfMusic.Name = "VolumeOfMusic";
            this.VolumeOfMusic.Size = new System.Drawing.Size(274, 56);
            this.VolumeOfMusic.TabIndex = 4;
            this.VolumeOfMusic.Value = 50;
            this.VolumeOfMusic.Scroll += new System.EventHandler(this.VolumeOfMusic_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "100";
            // 
            // ActualVolume
            // 
            this.ActualVolume.AutoSize = true;
            this.ActualVolume.Location = new System.Drawing.Point(155, 104);
            this.ActualVolume.Name = "ActualVolume";
            this.ActualVolume.Size = new System.Drawing.Size(21, 16);
            this.ActualVolume.TabIndex = 8;
            this.ActualVolume.Text = "50";
            // 
            // SelectBackgroundStyle
            // 
            this.SelectBackgroundStyle.Location = new System.Drawing.Point(80, 317);
            this.SelectBackgroundStyle.Name = "SelectBackgroundStyle";
            this.SelectBackgroundStyle.Size = new System.Drawing.Size(274, 26);
            this.SelectBackgroundStyle.TabIndex = 3;
            this.SelectBackgroundStyle.Text = "Выбрать стиль фона";
            this.SelectBackgroundStyle.UseVisualStyleBackColor = true;
            this.SelectBackgroundStyle.Click += new System.EventHandler(this.SelectBackgroundStyle_Click);
            // 
            // SelectColorOfGraphic
            // 
            this.SelectColorOfGraphic.Location = new System.Drawing.Point(79, 259);
            this.SelectColorOfGraphic.Name = "SelectColorOfGraphic";
            this.SelectColorOfGraphic.Size = new System.Drawing.Size(274, 30);
            this.SelectColorOfGraphic.TabIndex = 2;
            this.SelectColorOfGraphic.Text = "Выбрать цвет графика";
            this.SelectColorOfGraphic.UseVisualStyleBackColor = true;
            this.SelectColorOfGraphic.Click += new System.EventHandler(this.SelectColorOfGraphic_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(254, 35);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 42);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Random_Func
            // 
            this.Random_Func.Location = new System.Drawing.Point(80, 35);
            this.Random_Func.Name = "Random_Func";
            this.Random_Func.Size = new System.Drawing.Size(112, 42);
            this.Random_Func.TabIndex = 0;
            this.Random_Func.Text = "Случайная функция";
            this.Random_Func.UseVisualStyleBackColor = true;
            this.Random_Func.Click += new System.EventHandler(this.Random_Func_Click);
            // 
            // ColorOfGraphic
            // 
            this.ColorOfGraphic.FullOpen = true;
            this.ColorOfGraphic.ShowHelp = true;
            // 
            // Delete_Point
            // 
            this.Delete_Point.Location = new System.Drawing.Point(190, 170);
            this.Delete_Point.Name = "Delete_Point";
            this.Delete_Point.Size = new System.Drawing.Size(212, 51);
            this.Delete_Point.TabIndex = 13;
            this.Delete_Point.Text = "Удалить последнюю добавленную точку";
            this.Delete_Point.UseVisualStyleBackColor = true;
            this.Delete_Point.Click += new System.EventHandler(this.Delete_Point_Click);
            // 
            // graphic
            // 
            this.graphic.Controls.Add(this.label3);
            this.graphic.Controls.Add(this.label1);
            this.graphic.Controls.Add(this.label2);
            this.graphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphic.Location = new System.Drawing.Point(0, 0);
            this.graphic.Name = "graphic";
            this.graphic.Size = new System.Drawing.Size(482, 496);
            this.graphic.TabIndex = 1;
            this.graphic.Paint += new System.Windows.Forms.PaintEventHandler(this.graphic_Paint);
            this.graphic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphic_MouseClick);
            this.graphic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphic_MouseDown);
            this.graphic.MouseHover += new System.EventHandler(this.graphic_MouseHover);
            this.graphic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphic_MouseMove);
            this.graphic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphic_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(193, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(412, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 496);
            this.Controls.Add(this.graphic);
            this.Controls.Add(this.ControlOfGraphic);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "График";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ControlOfGraphic.ResumeLayout(false);
            this.MusicSettings.ResumeLayout(false);
            this.MusicSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeOfMusic)).EndInit();
            this.graphic.ResumeLayout(false);
            this.graphic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ControlOfGraphic;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Random_Func;
        private System.Windows.Forms.ColorDialog ColorOfGraphic;
        private System.Windows.Forms.Button SelectColorOfGraphic;
        private System.Windows.Forms.Button SelectBackgroundStyle;
        private MyPanel graphic;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label ActualVolume;
        private Label label5;
        private Label label4;
        private TrackBar VolumeOfMusic;
        private GroupBox MusicSettings;
        private Button Create_Bezier;
        private Button Cancel_Spline;
        private Button Add_Spline;
        private Button Delete_Point;
    }
}

