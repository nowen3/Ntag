using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ntag
{
    public partial class FRMimagesearch : Form
    {
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public FRMimagesearch()
        {
            InitializeComponent();
        }

        public string Album
        {
            get { return TXTalbum.Text; }
            set { TXTalbum.Text = value; }
        }

        public string Artist
        {
            get { return TXTartist.Text; }
            set { TXTartist.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string args = "";
            string fname = appPath + "\\"+ "DisCoverArt.exe";
            
            args = "\"" + TXTartist.Text + "\"" + " " + "\""+  TXTalbum.Text + "\"" + " " + "all 1 0 300 300 jpg 10 1";

            string temp;
            try
            {
                var bg = new Buildargs();
                bg.addeffect(args);
                temp = bg.Callcoverart(fname);

               // MessageBox.Show("Finished Search");

                this.AutoScroll = true;
                string[] list = Directory.GetFiles(appPath , "*.jpg");
               // PictureBox[] picturebox = new PictureBox[list.Length];
                int y = -140;
                int x = 20;
                for (int index = 0; index < list.Length; index++)
                {
                    PictureBox picturebox = new PictureBox();
                    if (index % 3 == 0)
                    {
                        y = y + 150; // 3 images per rows, first image will be at (20,150)
                        x = 20;
                    }
                    
                    picturebox.Location = new Point(x, y);
                    picturebox.Size = new Size(100, 120);
                    picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picturebox.BorderStyle = BorderStyle.FixedSingle;
                    picturebox.Click += new EventHandler(picturebox_Click);
                    picturebox.MouseHover += new EventHandler(picturebox_hover);
                    picturebox.MouseLeave += new EventHandler(picturebox_reset);
                    Image im = GetCopyImage(list[index]);
                    if (im != null)
                    {
                        picturebox.Image = im;
                        picturebox.ImageLocation = list[index];
                    } else
                    {
                        picturebox.Image = new Bitmap(appPath + "\\badimage.png");
                        picturebox.ImageLocation = appPath + "\\badimage.png";
                     }
                    panel2.Controls.Add(picturebox);
                    x = x + 120;


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(" Error converting file--" + ex.ToString());
            }
        }

        private Image GetCopyImage(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (Image im = Image.FromFile(path))
                    {
                        Bitmap bm = new Bitmap(im);
                        return bm;
                    }
                }
                else return null;
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        private void picturebox_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb != null)
            {
                selectedimage.Image = pb.Image;
            }
        }

        private void picturebox_hover(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb != null)
            {
                pb.Size = new Size(300, 300);
            }
        }

        private void picturebox_reset(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb != null)
            {
                pb.Size = new Size(100, 120);

            }
        }

        public Bitmap Getimage()
        {
            return (Bitmap)selectedimage.Image;
        }

    }
}
