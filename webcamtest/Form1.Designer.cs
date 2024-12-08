namespace webcamtest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snapshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hayagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuyokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katawAnananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaLiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indonesiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baliVertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baliHorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(370, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 305);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.hayagToolStripMenuItem,
            this.loadImageToolStripMenuItem,
            this.katawAnananToolStripMenuItem,
            this.anaLiesToolStripMenuItem,
            this.indonesiaToolStripMenuItem,
            this.liveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem,
            this.snapshotToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cameraToolStripMenuItem.Text = "Camera";
            this.cameraToolStripMenuItem.Click += new System.EventHandler(this.cameraToolStripMenuItem_Click);
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onToolStripMenuItem.Text = "on";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.offToolStripMenuItem.Text = "off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // snapshotToolStripMenuItem
            // 
            this.snapshotToolStripMenuItem.Name = "snapshotToolStripMenuItem";
            this.snapshotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.snapshotToolStripMenuItem.Text = "snapshot";
            this.snapshotToolStripMenuItem.Click += new System.EventHandler(this.snapshotToolStripMenuItem_Click);
            // 
            // hayagToolStripMenuItem
            // 
            this.hayagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.awayToolStripMenuItem,
            this.sigaToolStripMenuItem,
            this.tuyokToolStripMenuItem});
            this.hayagToolStripMenuItem.Name = "hayagToolStripMenuItem";
            this.hayagToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hayagToolStripMenuItem.Text = "hayag";
            this.hayagToolStripMenuItem.Click += new System.EventHandler(this.hayagToolStripMenuItem_Click);
            // 
            // awayToolStripMenuItem
            // 
            this.awayToolStripMenuItem.Name = "awayToolStripMenuItem";
            this.awayToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.awayToolStripMenuItem.Text = "away";
            this.awayToolStripMenuItem.Click += new System.EventHandler(this.awayToolStripMenuItem_Click);
            // 
            // sigaToolStripMenuItem
            // 
            this.sigaToolStripMenuItem.Name = "sigaToolStripMenuItem";
            this.sigaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sigaToolStripMenuItem.Text = "siga";
            this.sigaToolStripMenuItem.Click += new System.EventHandler(this.sigaToolStripMenuItem_Click);
            // 
            // tuyokToolStripMenuItem
            // 
            this.tuyokToolStripMenuItem.Name = "tuyokToolStripMenuItem";
            this.tuyokToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.tuyokToolStripMenuItem.Text = "tuyok";
            this.tuyokToolStripMenuItem.Click += new System.EventHandler(this.tuyokToolStripMenuItem_Click);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.loadImageToolStripMenuItem.Text = "load image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // katawAnananToolStripMenuItem
            // 
            this.katawAnananToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dakoToolStripMenuItem,
            this.gamayToolStripMenuItem});
            this.katawAnananToolStripMenuItem.Name = "katawAnananToolStripMenuItem";
            this.katawAnananToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.katawAnananToolStripMenuItem.Text = "kataw ananan";
            // 
            // dakoToolStripMenuItem
            // 
            this.dakoToolStripMenuItem.Name = "dakoToolStripMenuItem";
            this.dakoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.dakoToolStripMenuItem.Text = "dako";
            this.dakoToolStripMenuItem.Click += new System.EventHandler(this.dakoToolStripMenuItem_Click);
            // 
            // gamayToolStripMenuItem
            // 
            this.gamayToolStripMenuItem.Name = "gamayToolStripMenuItem";
            this.gamayToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.gamayToolStripMenuItem.Text = "gamay";
            this.gamayToolStripMenuItem.Click += new System.EventHandler(this.gamayToolStripMenuItem_Click);
            // 
            // anaLiesToolStripMenuItem
            // 
            this.anaLiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem});
            this.anaLiesToolStripMenuItem.Name = "anaLiesToolStripMenuItem";
            this.anaLiesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.anaLiesToolStripMenuItem.Text = "Ana Lies";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // indonesiaToolStripMenuItem
            // 
            this.indonesiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baliVertToolStripMenuItem,
            this.baliHorToolStripMenuItem});
            this.indonesiaToolStripMenuItem.Name = "indonesiaToolStripMenuItem";
            this.indonesiaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.indonesiaToolStripMenuItem.Text = "Indonesia";
            // 
            // baliVertToolStripMenuItem
            // 
            this.baliVertToolStripMenuItem.Name = "baliVertToolStripMenuItem";
            this.baliVertToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.baliVertToolStripMenuItem.Text = "Bali vert";
            this.baliVertToolStripMenuItem.Click += new System.EventHandler(this.baliVertToolStripMenuItem_Click);
            // 
            // baliHorToolStripMenuItem
            // 
            this.baliHorToolStripMenuItem.Name = "baliHorToolStripMenuItem";
            this.baliHorToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.baliHorToolStripMenuItem.Text = "Bali Hor";
            this.baliHorToolStripMenuItem.Click += new System.EventHandler(this.baliHorToolStripMenuItem_Click);
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daganToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.mirrorToolStripMenuItem});
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.liveToolStripMenuItem.Text = "live";
            // 
            // daganToolStripMenuItem
            // 
            this.daganToolStripMenuItem.Name = "daganToolStripMenuItem";
            this.daganToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.daganToolStripMenuItem.Text = "dagan";
            this.daganToolStripMenuItem.Click += new System.EventHandler(this.daganToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(311, 27);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(373, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.greyscaleToolStripMenuItem.Text = "greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.invertToolStripMenuItem.Text = "invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // mirrorToolStripMenuItem
            // 
            this.mirrorToolStripMenuItem.Name = "mirrorToolStripMenuItem";
            this.mirrorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mirrorToolStripMenuItem.Text = "mirror";
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 440);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snapshotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hayagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem awayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem sigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuyokToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem katawAnananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaLiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indonesiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baliVertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baliHorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daganToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

