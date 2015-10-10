using IdSharp.Tagging.ID3v1;
using System;
using System.Windows.Forms;

namespace Ntag
{
    public partial class FRMcopy : Form
    {
        public FRMcopy()
        {
            InitializeComponent();
            CMBgenre.Items.AddRange(GenreHelper.GenreByIndex);
           // bool itemExists = false;
        }

        public bool CopyV1
        {
            get { return this.RBv1.Checked; }
            set { this.RBv1.Checked = value; }
        }

        public bool CopyV2
        {
            get { return this.RBv2.Checked; }
            set { this.RBv2.Checked = value; }
        }

        public string GetGenre
        {
            get { return this.CMBgenre.Text; }
            set
            {
                if (CMBgenre.Items.Contains(value))
                { this.CMBgenre.Text = value; }
                else CMBgenre.Text = "Other";

                this.CMBgenre.Text = value;
            }
        }

        private void RBv2_CheckedChanged(object sender, EventArgs e)
        {
            CMBgenre.Visible = true;
            label1.Visible = true;
        }

        private void RBv1_CheckedChanged(object sender, EventArgs e)
        {
            CMBgenre.Visible = false;
            label1.Visible = false;
        }
    }
}