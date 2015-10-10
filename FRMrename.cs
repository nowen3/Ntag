using IdSharp.Tagging.ID3v1;
using IdSharp.Tagging.ID3v2;
using System;
using System.IO;
using System.Windows.Forms;

namespace Ntag
{
    public partial class FRMrename : Form
    {
        public FRMrename()
        {
            InitializeComponent();
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        }

        public int Gettrack_Count_Before()
        {
            return (this.LSVbefore.Items.Count);
        }

        public int Gettrack_Count_After()
        {
            return (this.LSVafter.Items.Count);
        }

        public string Getoldtrackname(int indexno)
        {
            return (LSVbefore.Items[indexno].Text + "\\" + LSVbefore.Items[indexno].SubItems[1].Text);
        }

        public string Getnewtrackname(int indexno)
        {
            return (LSVafter.Items[indexno].Text + "\\" + LSVafter.Items[indexno].SubItems[1].Text);
        }

        public void Addtrack(string path, string track)
        {
            ListViewItem lvi;
            string ntn;
            string[] aHeaders = new string[2];
            string[] aHeaders1 = new string[2];
            aHeaders[0] = path;
            aHeaders[1] = track;
            lvi = new ListViewItem(aHeaders);
            this.LSVbefore.Items.Add(lvi);
            ntn = Getnewtrack(path + "\\" + track);
            aHeaders1[0] = path;
            aHeaders1[1] = ntn;
            lvi = new ListViewItem(aHeaders1);
            this.LSVafter.Items.Add(lvi);
            TXTpath.Text = path;
        }

        private string Getnewtrack(string fname)
        {
            string ntn = COMBrename.Text;
            Track mytrack = new Track("", "", "", "", "", "", "", "");
            string extn = Path.GetExtension(fname);
            if (ID3v1Tag.DoesTagExist(fname)) { mytrack = Miscutils.Getv1tags(fname); }
            else if (ID3v2Tag.DoesTagExist(fname)) { mytrack = Miscutils.Getv2tags(fname); }
            if (ntn.Contains("%TRACKNUMBER%"))
            {
                ntn = ntn.Replace("%TRACKNUMBER%", Miscutils.PaddedNumber(mytrack.Trackno));
            }

            if (ntn.Contains("%ARTIST%"))
            {
                ntn = ntn.Replace("%ARTIST%", mytrack.Artist);
            }

            if (ntn.Contains("%ALBUM%"))
            {
                ntn = ntn.Replace("%ALBUM%", mytrack.Album);
            }
            if (ntn.Contains("%TITLE%"))
            {
                ntn = ntn.Replace("%TITLE%", mytrack.Title);
            }
            if (ntn.Contains("%FILENAME%"))
            {
                ntn = ntn.Replace("%FILENAME%", Path.GetFileNameWithoutExtension(fname));
            }
            ntn = Miscutils.stripchar(ntn);
            if (TXTrepbefore.Text != "")
            {
                ntn = ntn.Replace(TXTrepbefore.Text, TXTrepafter.Text);
            }
            return ntn + extn;
        }

        private void BTNupdate_Click(object sender, EventArgs e)
        {
        }

        private void BTNfname_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.SelectedPath = "E:\\Music\\air\\";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TXTpath.Text = folderBrowserDialog.SelectedPath;
                foreach (ListViewItem item in LSVafter.Items)
                {
                    item.Text = TXTpath.Text;
                }
            }
        }

        private void COMBrename_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lvi;
            string ntn;
            string[] aHeaders = new string[2];
            LSVafter.Items.Clear();
            foreach (ListViewItem item in LSVbefore.Items)
            {
                ntn = Getnewtrack(item.Text + "\\" + item.SubItems[1].Text);
                aHeaders[0] = TXTpath.Text;
                aHeaders[1] = ntn;
                lvi = new ListViewItem(aHeaders);
                this.LSVafter.Items.Add(lvi);
            }
        }
    }
}