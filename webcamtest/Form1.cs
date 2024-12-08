using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HNUDIP;
using WebCamLib;

namespace webcamtest
{
    public partial class Form1 : Form
    {
       
        Bitmap source;
        Bitmap result;
        Device[] mgaDevice;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mgaDevice = DeviceManager.GetAllDevices();
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mgaDevice[0].ShowWindow(pictureBox1);
           
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mgaDevice[0].Stop();
            
        }

        private void snapshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            source = new Bitmap(bmap);
            pictureBox2.Image = source;
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            source = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = source;
        }

        private void hayagToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.Brightness(ref source, ref result, 100);
            pictureBox2.Image = result;
        }

        private void awayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.Equalisation(ref source, ref result, 100);
            pictureBox2.Image = result;
        }

        private void tuyokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.Rotate(ref source, ref result, 65);
            pictureBox2.Image = result;
        } 

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ImageProcess.Rotate(ref source, ref result,trackBar1.Value);
            pictureBox2.Image = result;
        }

        private void dakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.Scale(ref source, ref result,5000,5000);
            pictureBox2.Image = result;
        }

        private void gamayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.Threshold(ref source, ref result,128);
            pictureBox2.Image = result;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.Histogram(ref source, ref result);
            pictureBox2.Image = result;
        }

        private void baliVertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.FlipVertical(ref source, ref result);
            pictureBox2.Image = result;
        }

        private void baliHorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.Fliphorizontal(ref source, ref result);
            ImageProcess.FlipVertical(ref source, ref result);
            pictureBox2.Image = result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cameraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void daganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            //mgacamera[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            source = new Bitmap(bmap);
            ImageProcess.GrayScale(ref source, ref result);
            pictureBox2.Image = result;

        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            mgaDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);
            ImageProcess.GrayScale(ref b, ref result);
            pictureBox2.Image = result;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            mgaDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);
            ImageProcess.Threshold(ref b, ref result,75);
            pictureBox2.Image = result;
        }
    }
}
