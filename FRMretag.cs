using IdSharp.Tagging.ID3v1;
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Ntag
{
    public partial class FRMretag : Form
    {
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath);

        public FRMretag()
        {
            this.InitializeComponent();
            this.CMBgenre.Sorted = true;
            this.CMBgenre.Items.AddRange(GenreHelper.GenreByIndex);
        }

        public void Addtrack(string tn, string track)
        {
            ListViewItem lvi;
            string[] aHeaders = new string[2];
            aHeaders[0] = tn;
            aHeaders[1] = track;
            lvi = new ListViewItem(aHeaders);
            this.LSVtrack.Items.Add(lvi);
        }

        public void Addnewtrack(string tn, string track)
        {
            ListViewItem lvi;
            string[] aHeaders = new string[2];
            aHeaders[0] = tn;
            aHeaders[1] = track;
            lvi = new ListViewItem(aHeaders);
            this.LSVnewtrack.Items.Add(lvi);
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

        public string Year
        {
            get { return this.TXTyear.Text; }
            set { this.TXTyear.Text = value; }
        }

        public String Genre
        {
            get { return this.CMBgenre.Text; }
            set { this.CMBgenre.Text = value; }
        }

        public string gettrackname(int indexno)
        {
            return (this.LSVtrack.Items[indexno].Text);
        }

        public int gettrack_count()
        {
            return (this.LSVtrack.Items.Count);
        }

        public string[] getnewtrackname(int indexno)
        {
            string[] tn = new string[2];
            tn[0] = this.LSVnewtrack.Items[indexno].Text;
            tn[1] = this.LSVnewtrack.Items[indexno].SubItems[1].Text;

            return (tn);
        }

        public int getnewtrack_count()
        {
            return (this.LSVnewtrack.Items.Count);
        }

        private void BTNup_Click(object sender, EventArgs e)
        {
            if (1 == LSVtrack.SelectedItems.Count)
            {
                ListViewItem item = LSVtrack.SelectedItems[0];
                int index = item.Index;
                index--;
                if (index >= 0)
                {
                    LSVtrack.Items.Remove(item);
                    LSVtrack.Items.Insert(index, item);
                    item.Selected = true;
                }
            }
        }

        private void BTNdown_Click(object sender, EventArgs e)
        {
            try
            {
                if (1 == LSVtrack.SelectedItems.Count)
                {
                    ListViewItem item = LSVtrack.SelectedItems[0];
                    int index = item.Index;
                    index++;
                    if (index < LSVtrack.Items.Count)
                    {
                        LSVtrack.Items.Remove(item);
                        LSVtrack.Items.Insert(index, item);
                        item.Selected = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                   
                    pictureBox.Load(openFileDialog.FileName);
                }
            }
        }

        public Bitmap Getimage()
        {
            return (Bitmap)pictureBox.Image;
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