using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;


namespace Process07
{
    public partial class Form1 : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap.CopyToSquareCanvas(pictureBox1.Width);
                pictureBox1.Image = previewBitmap;

               // ApplyFilter(true);
            }

        }


        ////  Define 3 points   ////

        private System.Drawing.Point p1, p2, p3;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (p1.X == 0)
            {
                p1.X = e.X;
                p1.Y = e.Y;
            }
            else if (p2.X == 0)
            {
                p2.X = e.X;
                p2.Y = e.Y;
            }
            else if (p3.X == 0)
            {
                p3.X = e.X;
                p3.Y = e.Y;
            }

            pictureBox1.Invalidate();
            //pictureBox1.Refresh();
        }


        ////  Draw lines   ////
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            ////   Not to draw any line when p1=0 and p2=0  ////
            if (p1.X != 0 & p2.X != 0 & p3.X != 0)
            {
                Pen p = new Pen(Color.Aqua, 3);
                e.Graphics.DrawLine(p, p1, p2);
                e.Graphics.DrawLine(p, p2, p3);
            }
        }

        ////  To clean the lines on  pictureBox1 everytime  ////
        private void button5_Click(object sender, EventArgs e)
        {
            p1.X = 0;
            p2.X = 0;
            p3.X = 0;
            pictureBox1.Refresh();
        }


        private void shrink()
        {

            Graphics e = pictureBox2.CreateGraphics();
            System.Drawing.Point[] destinationPoints = { p1, p2, p3 };

            // Draw the image unaltered with its upper-left corner at (0, 0).
            e.DrawImage(pictureBox1.Image, 0, 0);
            this.Refresh();
            // Draw the image mapped to the parallelogram.
            e.DrawImage(pictureBox1.Image, destinationPoints);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            shrink();
        }


        private void slide()
        {
            string s = textBox1.Text;
            string o = textBox2.Text;

            if (s == "" || o == "")
            {
                MessageBox.Show("Please enter a value for Slide Size and Off Set");

            }
            else
            {

                int slideSize = int.Parse(s);
                int offSet = int.Parse(o);


                int width = (pictureBox1.Image).Width;
                int height = (pictureBox1.Image).Height;

                IntPoint[,] warpMap = new IntPoint[height, width];

                int maxOffset = -slideSize + offSet;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int dx = (x / slideSize) * slideSize - x;
                        int dy = (y / slideSize) * slideSize - y;

                        if (dx + dy <= maxOffset)
                        {
                            dx = (x / slideSize + 1) * slideSize - 1 - x;
                        }

                        warpMap[y, x] = new IntPoint(dx, dy);
                    }
                }
                ImageWarp filter = new ImageWarp(warpMap);
                Bitmap newImage = filter.Apply(new Bitmap(pictureBox1.Image));
                pictureBox2.Image = newImage;
            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            slide();
        }



        private void ApplyFilter(bool preview)
        {
            if (previewBitmap == null)
            {
                return;
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

            if (preview == true)
            {
                selectedSource = previewBitmap;
            }
            else
            {
                selectedSource = originalBitmap;
            }

            if (selectedSource != null)
            {
                bitmapResult = selectedSource.RotateImage((double)numDegreesBlue.Value, (double)numDegreesGreen.Value, (double)numDegreesRed.Value);
            }

            if (bitmapResult != null)
            {
                if (preview == true)
                {
                    pictureBox2.Image = bitmapResult;
                }
                else
                {
                    resultBitmap = bitmapResult;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }

        
        private void button3_Click(object sender, EventArgs e)
            {

            ApplyFilter(false);

            if (resultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    resultBitmap = null;
                }
            }

        }

        

    }


}


