using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ntag
{
    public partial class FRMtagfile : Form
    {
        public FRMtagfile()
        {
            InitializeComponent();
        }

        public void Addtrack(string fname)
        {
            Parsefname(fname, "1");
        }

        private void BTNupdate_Click(object sender, EventArgs e)
        {
            List<String> flist = new List<string>();
            int tn = 1;
            foreach (ListViewItem item in LSVtrack.Items)
            {
                flist.Add(item.SubItems[6].Text);
            }
            LSVtrack.Items.Clear();

            foreach (string aaa in flist)
            {
                Parsefname(aaa, tn.ToString());
                tn++;
            }
        }

        private void Parsefname(string fname, string tn)
        {
            ListViewItem lvi;
            string[] aHeaders = new string[7];
            ParseTrack pt = new ParseTrack(fname, COMBtagfile.Text);
            if (pt.GetTrackNumber != null)
            {
                aHeaders[0] = pt.GetTrackNumber;
            }
            else aHeaders[0] = tn;

            aHeaders[1] = pt.GetTitle;
            aHeaders[2] = TXTyear.Text;//year
            if (TXTartist.Text != "")
            {
                aHeaders[3] = TXTartist.Text;
            }
            else aHeaders[3] = pt.GetArtist;

            aHeaders[4] = TXTalbum.Text;
            aHeaders[5] = CMBgenre.Text;
            aHeaders[6] = fname;
            lvi = new ListViewItem(aHeaders);
            this.LSVtrack.Items.Add(lvi);
        }

        public int Gettrack_Count()
        {
            return (this.LSVtrack.Items.Count);
        }

        public string gettracknumber(int indexno)
        {
            return (this.LSVtrack.Items[indexno].Text);
        }

        public string gettitle(int indexno)
        {
            return (this.LSVtrack.Items[indexno].SubItems[1].Text);
        }

        public string getyear(int indexno)
        {
            return (this.LSVtrack.Items[indexno].SubItems[2].Text);
        }

        public string getartist(int indexno)
        {
            return (this.LSVtrack.Items[indexno].SubItems[3].Text);
        }

        public string getalbum(int indexno)
        {
            return (this.LSVtrack.Items[indexno].SubItems[4].Text);
        }

        public string getgenre(int indexno)
        {
            return (this.LSVtrack.Items[indexno].SubItems[5].Text);
        }

        public string getfilename(int indexno)
        {
            return (this.LSVtrack.Items[indexno].SubItems[6].Text);
        }

        private void LSVtrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection filename = this.LSVtrack.SelectedItems;
            foreach (ListViewItem item in filename)
            {
                ParseTrack pt = new ParseTrack(item.SubItems[6].Text, COMBtagfile.Text);
                TXTtrackno.Text = pt.GetTrackNumber;
            }
        }

        private void BTNadd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LSVtrack.Items)
            {
                item.SubItems[2].Text = TXTyear.Text;
                item.SubItems[3].Text = TXTartist.Text;
                item.SubItems[4].Text = TXTalbum.Text;
                item.SubItems[5].Text = CMBgenre.Text;
            }
        }
    }
}