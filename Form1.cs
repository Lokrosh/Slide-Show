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
        private List<string> Files;

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult result = fdb.ShowDialog();
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

            string[] images = Directory.GetFiles(fdb.SelectedPath, "*.*",System.IO.SearchOption.AllDirectories);

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

        private void picBox_Click(object sender, EventArgs e)
        {
            counter++;
        }
        //want to move to next pick on pic click

        private void speedInput_Click(object sender, EventArgs e)
        {

        }

        private void speedButton_Click(object sender, EventArgs e)
        {

            if (speedInput.Text == string.Empty)
            {
                speedInput.Focus();
            }
            //Need to throw error for empty string

            string userSpeedInput = speedInput.Text;

            int imageSpeed;

            bool isParsable = Int32.TryParse(userSpeedInput, out imageSpeed);
            //if (isParsable)
            //    Console.WriteLine(imageSpeed);
            //else
            //    Console.WriteLine("please enter a number");
            //Need to throw error for non-int OR int out of range

            timer1.Interval = imageSpeed;
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            //Need to create toggle that sets state of random images
        }
    }
}
