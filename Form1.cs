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
using System.Diagnostics;

namespace Slide_Show
{
    public partial class Form1 : Form
    {
        int counter = 0;
        FolderBrowserDialog fdb = new FolderBrowserDialog();
        bool playing = false;
        private List<string> Files;

        private string[] Images { get; set; }

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
            if (!String.IsNullOrEmpty(fdb.SelectedPath)) {
                startButton.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
                Images = Directory.GetFiles(fdb.SelectedPath, "*.*", System.IO.SearchOption.AllDirectories).
                    Where(s => s.EndsWith(".jpg", StringComparison.InvariantCultureIgnoreCase)
                    || s.EndsWith(".gif", StringComparison.InvariantCultureIgnoreCase)
                    || s.EndsWith(".png", StringComparison.InvariantCultureIgnoreCase))
                    .ToArray();
                //images.ToList().ForEach(i => Console.WriteLine(i));
                Console.WriteLine($"images len: {Images.Length}");

                if (!playing)
                {
                    startButton.Text = "Stop";
                    playing = true;
                    timer1.Start();
                    displayImage();
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

            //string[] images = Directory.GetFiles(fdb.SelectedPath, "*.*", System.IO.SearchOption.AllDirectories).
            //    Where(s => s.EndsWith(".jpg", StringComparison.InvariantCultureIgnoreCase) 
            //    || s.EndsWith(".gif", StringComparison.InvariantCultureIgnoreCase) 
            //    || s.EndsWith(".png", StringComparison.InvariantCultureIgnoreCase))
            //    .ToArray();

            if (randomButton.BackColor != SystemColors.ButtonFace)
            {
                Random rand = new Random();
                counter = rand.Next(Images.Length);
                displayImage();
            }
            else
            {
                if (counter >= Images.Length - 1)
                {
                    displayImage();
                    counter = 0;
                } else
                {
                    counter++;
                    displayImage();
                }
            }
            
        }

        private void displayImage()
        {
            Console.WriteLine($"Displaying image #: {counter}");
            picBox.Image = Image.FromFile(Images[counter]);

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

        private void speedButton_Click(object sender, EventArgs e)
        {

            if (speedInput.Text == string.Empty)
            {
                speedInput.Focus();
            }
            //Need to throw error for empty string

            string userSpeedInput = speedInput.Text;

            int imageSpeed;

            bool isParsable = Int32.TryParse(userSpeedInput, out imageSpeed) && imageSpeed > 50;
            if (isParsable)
            {
                Console.WriteLine(imageSpeed);
                timer1.Interval = imageSpeed;
            }
            else
            {
                Console.WriteLine("please enter a number over 50");
                string message = "The interval may only contain valid numbers";
                string title = "Parse Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            }

            //Control speedInputCont = new Control();
            //speedInputCont.Text = speedInput.Text;

            //try
            //{
            //    int x = Int32.Parse(speedInputCont.Text);
            //    errorProvider1.SetError(speedInputCont, "");
            //}
            //catch (Exception ex)
            //{
            //    errorProvider1.SetError(speedInputCont, "Not an integer value.");
            //}
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (randomButton.BackColor == SystemColors.ButtonFace)
            {
            randomButton.BackColor = SystemColors.ButtonShadow;
            }
            else
            {
                randomButton.BackColor = SystemColors.ButtonFace;
            }


            //Need to create toggle that sets state of random images
        }
    }
}
