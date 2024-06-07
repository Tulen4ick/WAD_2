namespace RWP2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Presets = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ActualVisibility = new System.Windows.Forms.Label();
            this.MainColorSelect = new System.Windows.Forms.Panel();
            this.LinesColorSelect = new System.Windows.Forms.Panel();
            this.MinorColorSelect = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Music = new System.Windows.Forms.ComboBox();
            this.DefaultGraphic = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LineFonts = new System.Windows.Forms.ComboBox();
            this.ColorOfCoordinates = new System.Windows.Forms.Button();
            this.Gradient = new System.Windows.Forms.CheckBox();
            this.visibility = new System.Windows.Forms.TrackBar();
            this.ColorOfGradient = new System.Windows.Forms.Button();
            this.Color1 = new System.Windows.Forms.Button();
            this.BackColor1 = new System.Windows.Forms.ColorDialog();
            this.BackColor2 = new System.Windows.Forms.ColorDialog();
            this.Access = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.CoordinateColor = new System.Windows.Forms.ColorDialog();
            this.Presets.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visibility)).BeginInit();
            this.SuspendLayout();
            // 
            // Presets
            // 
            this.Presets.Controls.Add(this.label5);
            this.Presets.Controls.Add(this.Music);
            this.Presets.Controls.Add(this.DefaultGraphic);
            this.Presets.Controls.Add(this.label4);
            this.Presets.Controls.Add(this.label3);
            this.Presets.Controls.Add(this.label2);
            this.Presets.Controls.Add(this.label1);
            this.Presets.Controls.Add(this.LineFonts);
            this.Presets.Controls.Add(this.ColorOfCoordinates);
            this.Presets.Controls.Add(this.Gradient);
            this.Presets.Controls.Add(this.visibility);
            this.Presets.Controls.Add(this.ColorOfGradient);
            this.Presets.Controls.Add(this.Color1);
            this.Presets.Location = new System.Drawing.Point(13, 12);
            this.Presets.Name = "Presets";
            this.Presets.Size = new System.Drawing.Size(471, 487);
            this.Presets.TabIndex = 0;
            this.Presets.TabStop = false;
            this.Presets.Text = "Характеристики";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ActualVisibility);
            this.groupBox1.Controls.Add(this.MainColorSelect);
            this.groupBox1.Controls.Add(this.LinesColorSelect);
            this.groupBox1.Controls.Add(this.MinorColorSelect);
            this.groupBox1.Location = new System.Drawing.Point(391, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 487);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // ActualVisibility
            // 
            this.ActualVisibility.AutoSize = true;
            this.ActualVisibility.Location = new System.Drawing.Point(31, 237);
            this.ActualVisibility.Name = "ActualVisibility";
            this.ActualVisibility.Size = new System.Drawing.Size(28, 16);
            this.ActualVisibility.TabIndex = 19;
            this.ActualVisibility.Text = "255";
            // 
            // MainColorSelect
            // 
            this.MainColorSelect.Location = new System.Drawing.Point(33, 34);
            this.MainColorSelect.Name = "MainColorSelect";
            this.MainColorSelect.Size = new System.Drawing.Size(26, 23);
            this.MainColorSelect.TabIndex = 16;
            // 
            // LinesColorSelect
            // 
            this.LinesColorSelect.Location = new System.Drawing.Point(33, 146);
            this.LinesColorSelect.Name = "LinesColorSelect";
            this.LinesColorSelect.Size = new System.Drawing.Size(26, 27);
            this.LinesColorSelect.TabIndex = 18;
            // 
            // MinorColorSelect
            // 
            this.MinorColorSelect.Location = new System.Drawing.Point(33, 84);
            this.MinorColorSelect.Name = "MinorColorSelect";
            this.MinorColorSelect.Size = new System.Drawing.Size(26, 26);
            this.MinorColorSelect.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Фоновая музыка";
            // 
            // Music
            // 
            this.Music.FormattingEnabled = true;
            this.Music.Items.AddRange(new object[] {
            "Без музыки",
            "Трек 1",
            "Трек 2",
            "Трек 3"});
            this.Music.Location = new System.Drawing.Point(82, 365);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(228, 24);
            this.Music.TabIndex = 14;
            this.Music.SelectedIndexChanged += new System.EventHandler(this.Music_SelectedIndexChanged);
            // 
            // DefaultGraphic
            // 
            this.DefaultGraphic.Location = new System.Drawing.Point(139, 424);
            this.DefaultGraphic.Name = "DefaultGraphic";
            this.DefaultGraphic.Size = new System.Drawing.Size(123, 33);
            this.DefaultGraphic.TabIndex = 7;
            this.DefaultGraphic.Text = "Сброс стиля";
            this.DefaultGraphic.UseVisualStyleBackColor = true;
            this.DefaultGraphic.Click += new System.EventHandler(this.DefaultGraphic_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Шрифт координатной сетки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Прозрачность сетки";
            // 
            // LineFonts
            // 
            this.LineFonts.FormattingEnabled = true;
            this.LineFonts.Items.AddRange(new object[] {
            "Сплошная линия",
            "Штриховая линия",
            "Штрих-пунктирная линия",
            "Линия из точек"});
            this.LineFonts.Location = new System.Drawing.Point(82, 307);
            this.LineFonts.Name = "LineFonts";
            this.LineFonts.Size = new System.Drawing.Size(228, 24);
            this.LineFonts.TabIndex = 9;
            this.LineFonts.SelectedIndexChanged += new System.EventHandler(this.LineFonts_SelectedIndexChanged);
            // 
            // ColorOfCoordinates
            // 
            this.ColorOfCoordinates.Location = new System.Drawing.Point(87, 146);
            this.ColorOfCoordinates.Name = "ColorOfCoordinates";
            this.ColorOfCoordinates.Size = new System.Drawing.Size(223, 31);
            this.ColorOfCoordinates.TabIndex = 8;
            this.ColorOfCoordinates.Text = "Цвет координатной сетки";
            this.ColorOfCoordinates.UseVisualStyleBackColor = true;
            this.ColorOfCoordinates.Click += new System.EventHandler(this.ColorOfCoordinates_Click);
            // 
            // Gradient
            // 
            this.Gradient.AutoSize = true;
            this.Gradient.Location = new System.Drawing.Point(15, 87);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(91, 20);
            this.Gradient.TabIndex = 7;
            this.Gradient.Text = "Градиент";
            this.Gradient.UseVisualStyleBackColor = true;
            this.Gradient.CheckedChanged += new System.EventHandler(this.Gradient_CheckedChanged);
            // 
            // visibility
            // 
            this.visibility.Location = new System.Drawing.Point(87, 227);
            this.visibility.Maximum = 255;
            this.visibility.Name = "visibility";
            this.visibility.Size = new System.Drawing.Size(207, 56);
            this.visibility.TabIndex = 6;
            this.visibility.Value = 255;
            this.visibility.Scroll += new System.EventHandler(this.visibility_Scroll);
            // 
            // ColorOfGradient
            // 
            this.ColorOfGradient.Location = new System.Drawing.Point(148, 83);
            this.ColorOfGradient.Name = "ColorOfGradient";
            this.ColorOfGradient.Size = new System.Drawing.Size(207, 27);
            this.ColorOfGradient.TabIndex = 1;
            this.ColorOfGradient.Text = "Доп. цвет для градиента";
            this.ColorOfGradient.UseVisualStyleBackColor = true;
            this.ColorOfGradient.Click += new System.EventHandler(this.ColorOfGradient_Click);
            // 
            // Color1
            // 
            this.Color1.Location = new System.Drawing.Point(87, 34);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(223, 23);
            this.Color1.TabIndex = 0;
            this.Color1.Text = "Основной цвет";
            this.Color1.UseVisualStyleBackColor = true;
            this.Color1.Click += new System.EventHandler(this.Color1_Click);
            // 
            // BackColor1
            // 
            this.BackColor1.FullOpen = true;
            // 
            // BackColor2
            // 
            this.BackColor2.FullOpen = true;
            // 
            // Access
            // 
            this.Access.Location = new System.Drawing.Point(554, 99);
            this.Access.Name = "Access";
            this.Access.Size = new System.Drawing.Size(111, 41);
            this.Access.TabIndex = 1;
            this.Access.Text = "Принять";
            this.Access.UseVisualStyleBackColor = true;
            this.Access.Click += new System.EventHandler(this.Access_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(554, 301);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(111, 42);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // CoordinateColor
            // 
            this.CoordinateColor.FullOpen = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Access);
            this.Controls.Add(this.Presets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Стиль фона";
            this.Presets.ResumeLayout(false);
            this.Presets.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visibility)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Presets;
        private System.Windows.Forms.Button ColorOfGradient;
        private System.Windows.Forms.Button Color1;
        private System.Windows.Forms.Button DefaultGraphic;
        private System.Windows.Forms.TrackBar visibility;
        private System.Windows.Forms.ColorDialog BackColor1;
        private System.Windows.Forms.ColorDialog BackColor2;
        private System.Windows.Forms.CheckBox Gradient;
        private System.Windows.Forms.Button Access;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button ColorOfCoordinates;
        private System.Windows.Forms.ColorDialog CoordinateColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Music;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LineFonts;
        private System.Windows.Forms.Panel MinorColorSelect;
        private System.Windows.Forms.Panel MainColorSelect;
        private System.Windows.Forms.Panel LinesColorSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ActualVisibility;
    }
}