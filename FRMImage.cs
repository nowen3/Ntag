using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Ntag
{
    public partial class FRMImage : Form
    {
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath);

        public FRMImage()
        {
            InitializeComponent();
        }

        private void BTNopenimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    TXTimagepath.Text = openFileDialog.FileName;
                    pictureBox.Load(openFileDialog.FileName);
                }
            }
        }

        public string Artist
        {
            get { return this.TXTartist.Text; }
            set { this.TXTartist.Text = value; }
        }

        public string Album
        {
            get { return this.TXTalbum.Text; }
            set { this.TXTalbum.Text = value; }
        }

        public string  Getimagefilename()
        {
            return TXTimagepath.Text;
        }

        public Bitmap Getimage()
        {
            return (Bitmap) pictureBox.Image;
        }

        public bool isimage()
        {
            if (pictureBox.Image != null)
                return true;
            else return false;
        }

        private void BTNsearch_Click(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles(appPath, "*.jpg");
            foreach (string filePath in filePaths)
                File.Delete(filePath);
            FRMimagesearch searchimage = new FRMimagesearch();
            searchimage.Artist = TXTartist.Text;
            searchimage.Album = TXTalbum.Text;
            if (searchimage.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox.Image = (Bitmap)searchimage.Getimage();

            }
        }
    }
}
