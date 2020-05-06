using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Slide_Show
{
    public partial class Form1 : Form
    {
        int counter = 1;
        FolderBrowserDialog fdb = new FolderBrowserDialog();
        bool playing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                startButton.Text = "Stop";
                playing = true;
                timer1.Start();
            }
            else
            {
                startButton.Text = "play";
                playing = false;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            string[] images = Directory.GetFiles(fdb.SelectedPath, "*.*");


            if (counter > images.Length - 1)
            {
                counter = 0;
            }

            picBox.Image = Image.FromFile(images[counter]);

            var imageSize = picBox.Image.Size;
            var fitSize = picBox.ClientSize;

            picBox.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult result = fdb.ShowDialog();
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            counter++;
        }

        private void speedInput_Click(object sender, EventArgs e)
        {

        }

        private void speedButton_Click(object sender, EventArgs e)
        {

            if (speedInput.Text == string.Empty)
            {
                speedInput.Focus();
            }
            string userSpeedInput = speedInput.Text;

            int imageSpeed;

            bool isParsable = Int32.TryParse(userSpeedInput, out imageSpeed);
            //if (isParsable)
            //    Console.WriteLine(imageSpeed);
            //else
            //    Console.WriteLine("please enter a number");

            timer1.Interval = imageSpeed;
        }
    }
}
