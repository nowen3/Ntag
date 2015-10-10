using IdSharp.Tagging.ID3v1;
using IdSharp.Tagging.ID3v2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Ntag
{
    public partial class Form1 : Form
    {
        private string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        private string myopenfilename;
        private Gnudbsearch sitem;
        public Form1()
        {
            InitializeComponent();
            CMBgenre.Sorted = true;
            CMBgenre.Items.AddRange(GenreHelper.GenreByIndex);
            LABimage.Text = "";
        }

        private delegate void OnaddtolistviewDelegate(Track mytrack);
        private delegate void UpdateProgressDelegate(Int32 progressvalue);

        public void CompressionFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // lblStatus.Text = "Task Cancelled.";
            }
            else if (e.Error != null)
            {
                //lblStatus.Text = "Error while performing background operation.";
            }
            else
            {
                // Everything completed normally.
                MessageBox.Show("Finished scanning");
            }
        }

        public void ReloadlistviewV1(ListViewItem item)
        {
            string tagstring = "No Tag";
            if (ID3v2Tag.DoesTagExist(item.SubItems[1].Text + "\\" + item.SubItems[0].Text))
            {
                tagstring = "/V2";
            }

            if (ID3v1Tag.DoesTagExist(item.SubItems[1].Text + "\\" + item.SubItems[0].Text))
            {
                var id3 = new ID3v1Tag(item.SubItems[1].Text + "\\" + item.SubItems[0].Text);
                item.SubItems[2].Text = "V1" + tagstring;
                item.SubItems[3].Text = id3.Title;
                item.SubItems[4].Text = id3.Artist;
                item.SubItems[5].Text = id3.Album;
                item.SubItems[7].Text = id3.Year;
                item.SubItems[6].Text = id3.TrackNumber.ToString();
                item.SubItems[8].Text = GenreHelper.GenreByIndex[id3.GenreIndex];
                // Miscutils.Updaterecord(item.SubItems[1].Text + "\\" + item.SubItems[0].Text, id3.Album,
                //                        id3.Artist, id3.GenreIndex.ToString(), id3.Title, id3.TrackNumber.ToString(), id3.Year);
            }
            else
            {
                item.SubItems[2].Text = tagstring;
                item.SubItems[3].Text = "";
                item.SubItems[4].Text = "";
                item.SubItems[5].Text = "";
                item.SubItems[7].Text = "";
                item.SubItems[6].Text = "";
                item.SubItems[8].Text = "";
                if (tagstring == "No Tag")
                {
                    //  Miscutils.Updaterecord(item.SubItems[1].Text + "\\" + item.SubItems[0].Text, item.SubItems[1].Text,
                    //                         "No Tag", "", "", "", "");
                }
            }
        }

        public void ReloadlistviewV2(ListViewItem item)
        {
            string tagstring = "No Tag";
            if (ID3v1Tag.DoesTagExist(item.SubItems[1].Text + "\\" + item.SubItems[0].Text))
            {
                tagstring = "V1/";
            }
            if (ID3v2Tag.DoesTagExist(item.SubItems[1].Text + "\\" + item.SubItems[0].Text))
            {
                var id3 = new ID3v2Tag(item.SubItems[1].Text + "\\" + item.SubItems[0].Text);
                item.SubItems[2].Text = tagstring + "V2";
                item.SubItems[3].Text = id3.Title;
                item.SubItems[4].Text = id3.Artist;
                item.SubItems[5].Text = id3.Album;
                item.SubItems[7].Text = id3.Year;
                item.SubItems[6].Text = id3.TrackNumber;
                item.SubItems[8].Text = id3.Genre;
                //  Miscutils.Updaterecord(item.SubItems[1].Text + "\\" + item.SubItems[0].Text, id3.Album,
                //                         id3.Artist, id3.Genre, id3.Title, id3.TrackNumber, id3.Year);
            }
            else
            {
                item.SubItems[2].Text = tagstring;
                item.SubItems[3].Text = "";
                item.SubItems[4].Text = "";
                item.SubItems[5].Text = "";
                item.SubItems[7].Text = "";
                item.SubItems[6].Text = "";
                item.SubItems[8].Text = "";
                if (tagstring == "No Tag")
                {
                    //    Miscutils.Updaterecord(item.SubItems[1].Text + "\\" + item.SubItems[0].Text, item.SubItems[1].Text,
                    //                           "No Tag", "", "", "", "");
                }
            }
        }

        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var bworker = new BackgroundWorker();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Cursor.Current = Cursors.WaitCursor;
                //if (File.Exists(appPath + "\\trackxml.xml"))
               //     File.Delete(appPath + "\\trackxml.xml");
                //var fprog = new FRMprog();
                //fprog.Dir = folderBrowserDialog.SelectedPath;
                //fprog.ShowDialog();
                musicListStore.Items.Clear();
                Add_folder(folderBrowserDialog.SelectedPath);
                //myopenfilename = folderBrowserDialog.SelectedPath; 
                //bworker.DoWork += new DoWorkEventHandler(openfolder);
                //bworker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompressionFinished);
                //bworker.WorkerReportsProgress = true;
                //bworker.WorkerSupportsCancellation = true;
                //Miscutils.SetDoubleBuffering(musicListStore, true);
                //bworker.RunWorkerAsync();
                //toolStripProgressBar.Value = 0;
                
              //  Cursor.Current = Cursors.Default;
            }
        }

        private void addFolderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
              Add_folder(folderBrowserDialog.SelectedPath);
            }

        }

        private void Add_folder(string foldername)
        {
            var bworker = new BackgroundWorker();
            if (File.Exists(appPath + "\\trackxml.xml"))
                File.Delete(appPath + "\\trackxml.xml");
            myopenfilename = foldername;
            bworker.DoWork += new DoWorkEventHandler(openfolder);
            bworker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompressionFinished);
            bworker.WorkerReportsProgress = true;
            bworker.WorkerSupportsCancellation = true;
            Miscutils.SetDoubleBuffering(musicListStore, true);
            bworker.RunWorkerAsync();
            toolStripProgressBar.Value = 0;

        }

        private void BTNcopy_Click(object sender, EventArgs e)
        {
            if (musicListStore.SelectedItems.Count > 0)
            {
                var copywin = new FRMcopy();
                string temp = "";
                ListView.SelectedListViewItemCollection filename = this.musicListStore.SelectedItems;
                copywin.GetGenre = musicListStore.SelectedItems[0].SubItems[8].Text;
                if (copywin.ShowDialog(this) == DialogResult.OK)
                {
                    if (copywin.CopyV1)
                    {
                        foreach (ListViewItem item in filename)
                        {
                            temp = item.SubItems[1].Text + "\\" + item.SubItems[0].Text;
                            if (File.Exists(temp) & ID3v1Tag.DoesTagExist(temp))
                            {
                                var id3 = new ID3v1Tag(temp);
                                Miscutils.Savev2tag(new Track(id3.Artist, id3.Title, id3.Album, id3.Year, id3.TrackNumber.ToString(), GenreHelper.GenreByIndex[id3.GenreIndex], temp, "V1/V2"));
                                ReloadlistviewV2(item);
                            }
                        }
                    }

                    if (copywin.CopyV2)
                    {
                        foreach (ListViewItem item in filename)
                        {
                            temp = item.SubItems[1].Text + "\\" + item.SubItems[0].Text;
                            if (File.Exists(temp) & ID3v2Tag.DoesTagExist(temp))
                            {
                                var id3 = new ID3v2Tag(temp);
                                string gen = copywin.GetGenre;
                                Miscutils.Savev1tag(new Track(id3.Artist, id3.Title, id3.Album, id3.Year, id3.TrackNumber.ToString(), gen, temp, "V1/V2"));
                                ReloadlistviewV1(item);
                            }
                        }
                    }
                }
            }//end musicstore setected
        }

        private void BTNdeletetag_Click(object sender, EventArgs e)
        {
            if (musicListStore.SelectedItems.Count > 0)
            {
                ListView.SelectedListViewItemCollection filename = this.musicListStore.SelectedItems;

                string temp = "";
                DialogResult result = MessageBox.Show("Delete ID3v1 tags", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in filename)
                    {
                        temp = item.SubItems[1].Text + "\\" + item.SubItems[0].Text;
                        Miscutils.removeID3v1(temp);
                        ReloadlistviewV1(item);
                    }
                }
                result = MessageBox.Show("Delete ID3v2 tags", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in filename)
                    {
                        temp = item.SubItems[1].Text + "\\" + item.SubItems[0].Text;
                        Miscutils.removeID3v2(temp);
                        ReloadlistviewV2(item);
                    }
                }
            }
        }

        private void BTNlocalsearch_Click(object sender, EventArgs e)
        {
            var trackxml = new XMLutils(appPath + "\\trackxml.xml");

            switch (COMsearch.Text)
            {
                case "No Tag":
                    poptreeview(trackxml.SeachRecords("No Tag", "Tagtype"));
                    break;

                case "V1 Tags Only":
                    poptreeview(trackxml.SeachRecords("V1/", "Tagtype"));
                    break;

                case "V2 Tags Only":
                    poptreeview(trackxml.SeachRecords("/V2", "Tagtype"));
                    break;

                case "V1/V2 Tags":
                    poptreeview(trackxml.SeachRecords("V1/V2", "Tagtype"));
                    break;

                case "":
                    poptreeview(trackxml.GetAllRecords());
                    break;

                default:
                    {
                        string si = COMsearch.Text.Substring(COMsearch.Text.IndexOf("=") + 1);
                        if (COMsearch.Text.StartsWith("Artist =")) { poptreeview(trackxml.SeachRecords(si, "Artist")); }
                        if (COMsearch.Text.StartsWith("Album =")) { poptreeview(trackxml.SeachRecords(si, "Album")); }
                        if (COMsearch.Text.StartsWith("Title =")) { poptreeview(trackxml.SeachRecords(si, "Title")); }
                        else { poptreeview(trackxml.SeachRecordsall(si )) ;}
                        break;
                    }
            }
        }

        private void BTNsavetag_Click(object sender, EventArgs e)
        {
            var mytrackv1 = new Track();
            var mytrackv2 = new Track();
            string fname = "";

            ListView.SelectedListViewItemCollection filename = this.musicListStore.SelectedItems;
           
                foreach (ListViewItem item in filename)
                {
                    fname = (item.SubItems[1].Text + "\\" + item.SubItems[0].Text);
                   
                    {
                        var mytrack = new Track();
                        mytrack = Getkeepv1(fname);
                        Miscutils.Savev1tag(mytrack);
                        ReloadlistviewV1(item);
                    }
                    // result = MessageBox.Show(string.Format("Save ID3v2 tag from '{0}'?", Path.GetFileName(TXTfilename.Text)), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // if (result == DialogResult.Yes)
                    {
                        var mytrack = new Track();
                        mytrack = Getkeepv2(fname);
                        Miscutils.Savev2tag(mytrack);
                        ReloadlistviewV2(item);
                    }
                }
          
        }

        private void BTNsearch_Click(object sender, EventArgs e)
        {
            int number;
            if (TXTsearch.Text.Trim() == "")
            {
                return;
            }
            sitem = new Gnudbsearch(TXTsearch.Text);
            CMBpageno.Items.Clear();
            if (Int32.TryParse(sitem.page, out number))
            {
                number = number / 50;
                for (int i = 1; i <= number; i++)
                    CMBpageno.Items.Add(i.ToString());
            }
            searchgnudb();
        }

        private void BTNsqlist_Click(object sender, EventArgs e)
        {
            TreeNode node, nodetemp;
            TreeNode mynode;
            var cats = new List<string>();
            var tras = new BindingList<Track>();
            var alb = new List<string>();
            var trackList = new BindingList<Track>();

            if (File.Exists(appPath + "\\trackxml.xml"))
            {
                try
                {
                    var trackxml = new XMLutils(appPath + "\\trackxml.xml");
                    treeView.Nodes.Clear();
                    cats = trackxml.Getcatagorys("Artist");
                    foreach (string art in cats)
                    {
                        node = treeView.Nodes.Add(art);
                        alb = trackxml.Getalbums(art);
                        foreach (string myalbum in alb)
                        {
                            mynode = node.Nodes.Add(myalbum);
                            tras = trackxml.Gettracks(myalbum, art);

                            for (int i = 0; i <= tras.Count - 1; i++)
                            {
                                nodetemp = mynode.Nodes.Add(tras[i].Title);
                                mynode.ToolTipText = Path.GetDirectoryName(tras[i].Filename);
                                nodetemp.ToolTipText = tras[i].Filename;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error in database " + ex.Message);
                }
            }// close file.exists
        }

        private void cleartextbox()
        {
            CMBartist.Text = "";
            CMBtitle.Text = "";
            CMBalbum.Text = "";
            CMBgenre.Text = "";
            CMBtrack.Text = "";
            CMByear.Text = "";
            CMBcomment.Text = "";
        }

        private void CMBpageno_SelectedIndexChanged(object sender, EventArgs e)
        {
            sitem.page = CMBpageno.Text;
            searchgnudb();
        }

        private Track Getkeepv1(string fname)
        {
            var mytrack = new Track();
            string tagstrV2 = "";
            if (ID3v2Tag.DoesTagExist(fname))
                tagstrV2 = "V2";
            var id3v1 = new ID3v1Tag(fname);
            mytrack.Filename = fname;
            if (CMBartist.Text == "#Keep#")
            { mytrack.Artist = id3v1.Artist; }
            else mytrack.Artist = CMBartist.Text;

            if (CMBtitle.Text == "#Keep#")
            { mytrack.Title = id3v1.Title; }
            else mytrack.Title = CMBtitle.Text;

            if (CMBalbum.Text == "#Keep#")
            { mytrack.Album = id3v1.Album; }
            else mytrack.Album = CMBalbum.Text;

            if (CMBgenre.Text == "#Keep#")
            { mytrack.Genre = GenreHelper.GenreByIndex[id3v1.GenreIndex]; }
            else mytrack.Genre = CMBgenre.Text;

            if (CMBtrack.Text == "#Keep#")
            { mytrack.Trackno = id3v1.TrackNumber.ToString(); }
            else mytrack.Trackno = CMBtrack.Text;

            if (CMByear.Text == "#Keep#")
            { mytrack.Year = id3v1.Year; }
            else mytrack.Year = CMByear.Text;

            mytrack.Tagtype = "V1" + "/" + tagstrV2;

            CMBcomment.Text = id3v1.Comment;
            return mytrack;
            //  }
            //  else return mytrack = null;
        }

        private Track Getkeepv2(string fname)
        {
            var mytrack = new Track();
            string tagstrV1 = "";
            if (ID3v1Tag.DoesTagExist(fname))
                tagstrV1 = "V1";
            var id3v2 = new ID3v2Tag(fname);
            mytrack.Filename = fname;
            if (CMBartist.Text == "#Keep#")
            { mytrack.Artist = id3v2.Artist; }
            else mytrack.Artist = CMBartist.Text;

            if (CMBtitle.Text == "#Keep#")
            { mytrack.Title = id3v2.Title; }
            else mytrack.Title = CMBtitle.Text;

            if (CMBalbum.Text == "#Keep#")
            { mytrack.Album = id3v2.Album; }
            else mytrack.Album = CMBalbum.Text;

            if (CMBgenre.Text == "#Keep#")
            { mytrack.Genre = id3v2.Genre; }
            else mytrack.Genre = CMBgenre.Text;

            if (CMBtrack.Text == "#Keep#")
            { mytrack.Trackno = id3v2.TrackNumber.ToString(); }
            else mytrack.Trackno = CMBtrack.Text;
            if (CMByear.Text == "#Keep#")

            { mytrack.Year = id3v2.Year; }
            else mytrack.Year = CMByear.Text;

            if (pictureBox.Image != null)
            {
                mytrack.coverimage = (Bitmap)pictureBox.Image;
               
            }

            mytrack.Tagtype = tagstrV1 + "/" + "V2";
            //CMBcomment.Text = id3v2.CommentsList[0].Value;
            return mytrack;
            //  }
            //  else return mytrack = null;
        }

        private void LSVsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LSVsearch.SelectedItems.Count > 0)
            {
                BindingList<Track> trackList = new BindingList<Track>();
                FRMretag retagwin = new FRMretag();
                ListView.SelectedListViewItemCollection filename = this.musicListStore.SelectedItems;
                Bitmap cimage;
                int i = 1;

                ListViewItem lvItem = LSVsearch.SelectedItems[0];
                string asin = lvItem.SubItems[0].Text;
                retagwin.Artist = lvItem.SubItems[1].Text;
                retagwin.Album = lvItem.SubItems[2].Text;
                trackList = sitem.getgnutracks(asin);
                retagwin.Year = trackList[0].Year;
                retagwin.Genre = trackList[0].Genre;

                for (int y = 0; y <= trackList.Count - 1; y++)
                {
                    retagwin.Addnewtrack(trackList[y].Trackno, trackList[y].Title);
                }

                foreach (ListViewItem item in filename)
                {
                    retagwin.Addtrack(item.SubItems[1].Text + "\\" + item.SubItems[0].Text, item.SubItems[3].Text);
                    i++;
                }
                if (retagwin.ShowDialog(this) == DialogResult.OK)
                {
                    string[] tn = new string[2];

                    for (int x = 0; x <= retagwin.gettrack_count() - 1; x++)
                    {
                        if (x <= retagwin.getnewtrack_count() - 1)
                        {
                            tn = retagwin.getnewtrackname(x);
                            int tnum = Convert.ToInt16(tn[0]);
                            if (retagwin.isimage())
                            {
                                cimage = retagwin.Getimage();
                                var mytrack = new Track(retagwin.Artist, tn[1], retagwin.Album, retagwin.Year, tn[0], retagwin.Genre, retagwin.gettrackname(x), "V1//V2", cimage);
                                Miscutils.Savev1tag(mytrack);
                                Miscutils.Savev2tag(mytrack);
                            }
                            else
                            {
                                var mytrack = new Track(retagwin.Artist, tn[1], retagwin.Album, retagwin.Year, tn[0], retagwin.Genre, retagwin.gettrackname(x), "V1//V2");
                                Miscutils.Savev1tag(mytrack);
                                Miscutils.Savev2tag(mytrack);
                            }

                            // Miscutils.Updaterecord(retagwin.gettrackname(x), retagwin.Album, retagwin.Artist, retagwin.Genre, tn[1], tnum.ToString(), retagwin.Year);
                        }
                    }

                    foreach (ListViewItem item in filename)
                    {
                        ReloadlistviewV1(item);
                        //
                    }
                }
            }
        }

        private void musicListStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection filename = this.musicListStore.SelectedItems;
            string temp = "";
            cleartextbox();
            pictureBox.Image = null;
            LABimage.Text = "";
            try
            {
                foreach (ListViewItem item in filename)
                {
                    if (item.SubItems.Count > 1)
                        temp += item.SubItems[1].Text + "\\" + item.SubItems[0].Text;
                }
                if (File.Exists(temp))
                {
                    if (ID3v2Tag.DoesTagExist(temp)) { poptextboxV2(temp); }
                    else if (ID3v1Tag.DoesTagExist(temp)) { poptextboxV1(temp); }
                }
            }//end of try
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void Onaddtolistview(Track mytrack)
        {

            if (this.musicListStore.InvokeRequired)
            {
                OnaddtolistviewDelegate d = new OnaddtolistviewDelegate(Onaddtolistview);
                this.Invoke(d, new object[] { mytrack });
            }
            else
            {

                ListViewItem lvi;
                string[] aHeaders = new string[9];


                aHeaders[0] = Path.GetFileName(mytrack.Filename);
                aHeaders[1] = Path.GetDirectoryName(mytrack.Filename);
                aHeaders[2] = mytrack.Tagtype;
                aHeaders[3] = mytrack.Title;
                aHeaders[4] = mytrack.Artist;
                aHeaders[5] = mytrack.Album;
                aHeaders[6] = mytrack.Trackno;
                aHeaders[7] = mytrack.Year;
                aHeaders[8] = mytrack.Genre;
                lvi = new ListViewItem(aHeaders);



                musicListStore.Items.Add(lvi);

            }

        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var trackxml = new XMLutils(appPath + "\\trackxml.xml");
            poptreeview(trackxml.GetAllRecords());
        }

        private void openfolder(object sender, DoWorkEventArgs e)
        {
            var scandirectory = new ScanDir(myopenfilename);
            scandirectory.OnListFiles += Onaddtolistview;
            scandirectory.UpdateProgress += UpdateProgress;
            scandirectory.Run_Scan();
            var trackxml = new XMLutils(appPath + "\\trackxml.xml");
            trackxml.Addrecord(scandirectory.tracks);
            
            //poptreeview(scandirectory.tracks);
        
        }
        private void poptextboxV1(string fdir)
        {
            TXTfilename.Text = fdir;
            
            if (ID3v1Tag.DoesTagExist(fdir))
            {
                RDOver1.Checked = true;
                var id3v1 = new ID3v1Tag(fdir);
                CMBartist.Text = id3v1.Artist;
                CMBtitle.Text = id3v1.Title;
                CMBalbum.Text = id3v1.Album;
                CMBgenre.Text = GenreHelper.GenreByIndex[id3v1.GenreIndex];
                CMBtrack.Text = id3v1.TrackNumber.ToString();
                CMByear.Text = id3v1.Year;
                CMBcomment.Text = id3v1.Comment;
            }
        }

        private void poptextboxV2(string fdir)
        {
            TXTfilename.Text = fdir;
            pictureBox.Image = null;
            LABimage.Text = "";
            if (ID3v2Tag.DoesTagExist(fdir))
            {
                RDOver2.Checked = true;

                var id3v2 = new ID3v2Tag(fdir);
                CMBartist.Text = id3v2.Artist;
                CMBtitle.Text = id3v2.Title;
                CMBalbum.Text = id3v2.Album;
                CMBgenre.Text = id3v2.Genre;
                CMBtrack.Text = id3v2.TrackNumber;
                CMByear.Text = id3v2.Year;
                CMBcomment.Text = id3v2.CommentsList.ToString();
                if (id3v2.CommentsList.Count > 0)
                    CMBcomment.Text = id3v2.CommentsList[0].Value;
                if (id3v2.PictureList.Count > 0)
                {
                    pictureBox.Image = id3v2.PictureList[0].Picture;
                    LABimage.Text = id3v2.PictureList[0].Description.ToString() + "\r\n" +id3v2.PictureList[0].Picture.Size.ToString() + "\r\n" + id3v2.PictureList[0].PictureExtension.ToString();
                    
                }
            }
        }

        private void poptreeview(BindingList<Track> tlist)
        {
            musicListStore.Items.Clear();
            ListViewItem lvi;
            string[] aHeaders = new string[9];

            for (int i = 0; i <= tlist.Count - 1; i++)
            {
                aHeaders[0] = Path.GetFileName(tlist[i].Filename);
                aHeaders[1] = Path.GetDirectoryName(tlist[i].Filename);
                aHeaders[2] = tlist[i].Tagtype;
                aHeaders[3] = tlist[i].Title;
                aHeaders[4] = tlist[i].Artist;
                aHeaders[5] = tlist[i].Album;
                aHeaders[6] = tlist[i].Trackno;
                aHeaders[7] = tlist[i].Year;
                aHeaders[8] = tlist[i].Genre;
                lvi = new ListViewItem(aHeaders);
                musicListStore.Items.Add(lvi);
            }
        }

        private void RDOver1_Click(object sender, EventArgs e)
        {
            if (File.Exists(TXTfilename.Text))
            {
                cleartextbox();
                poptextboxV1(TXTfilename.Text);
                pictureBox.Image = null;
            }
        }

        private void RDOver2_Click(object sender, EventArgs e)
        {
            if (File.Exists(TXTfilename.Text))
            {
                cleartextbox();
                poptextboxV2(TXTfilename.Text);
            }
        }

        private void Reloadfilenames(string oldfname, string newfname)
        {
            ListView.SelectedListViewItemCollection filename = this.musicListStore.SelectedItems;

            foreach (ListViewItem item in filename)
            {
                if (Path.GetFileName(oldfname) == item.SubItems[0].Text)
                {
                    item.SubItems[0].Text = Path.GetFileName(newfname);
                }
            }
        }

        private void renameFileFromTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMrename renamewin = new FRMrename();
            ListView.SelectedListViewItemCollection filename = this.musicListStore.SelectedItems;
            var trackxml = new XMLutils(appPath + "\\trackxml.xml");

            foreach (ListViewItem item in filename)
            {
                renamewin.Addtrack(item.SubItems[1].Text, item.SubItems[0].Text);
            }
            if (renamewin.ShowDialog(this) == DialogResult.OK)
            {
                for (int x = 0; x <= renamewin.Gettrack_Count_Before() - 1; x++)
                {
                    if (x <= renamewin.Gettrack_Count_After() - 1)
                    {
                        if (File.Exists(renamewin.Getoldtrackname(x)) & !File.Exists(renamewin.Getnewtrackname(x)))
                        {
                            File.Move(renamewin.Getoldtrackname(x), renamewin.Getnewtrackname(x));
                            trackxml.Updatefilename(renamewin.Getoldtrackname(x), renamewin.Getnewtrackname(x));
                            //Miscutils.UpdateFname(renamewin.Getoldtrackname(x), renamewin.Getnewtrackname(x)); //update xml
                            Reloadfilenames(renamewin.Getoldtrackname(x), renamewin.Getnewtrackname(x));
                        }
                        else
                        {
                            MessageBox.Show("File Error " + renamewin.Getoldtrackname(x));
                        }
                    }
                }
            }
        }

        private void searchgnudb()
        {
            BindingList<gnudbitems> searchlist = new BindingList<gnudbitems>();
            searchlist = sitem.searchresults;
            ListViewItem lvi;
            string[] aHeaders = new string[3];
            LSVsearch.Items.Clear();
            for (int i = 0; i <= sitem.searchresults.Count - 1; i++)
            {
                aHeaders[0] = searchlist[i].id;
                aHeaders[1] = searchlist[i].Artist;
                aHeaders[2] = searchlist[i].Album;
                lvi = new ListViewItem(aHeaders);
                LSVsearch.Items.Add(lvi);
            }
        }

        private void tagFromFilenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tagfilewin = new FRMtagfile();
            ListView.SelectedListViewItemCollection filename = this.musicListStore.SelectedItems;

            foreach (ListViewItem item in filename)
            {
                tagfilewin.Addtrack(item.SubItems[1].Text + "\\" + item.SubItems[0].Text);
            }
            if (tagfilewin.ShowDialog(this) == DialogResult.OK)
            {
                for (int x = 0; x <= tagfilewin.Gettrack_Count() - 1; x++)
                {
                    var mytrack = new Track(tagfilewin.getartist(x), tagfilewin.gettitle(x), tagfilewin.getalbum(x), tagfilewin.getyear(x), tagfilewin.gettracknumber(x), tagfilewin.getgenre(x), tagfilewin.getfilename(x), "V1/V2");
                    Miscutils.Savev1tag(mytrack);
                    Miscutils.Savev2tag(mytrack);
                    // Miscutils.Updaterecord(tagfilewin.getfilename(x), tagfilewin.getalbum(x), tagfilewin.getartist(x), tagfilewin.getgenre(x), tagfilewin.gettitle(x), tagfilewin.gettracknumber(x), tagfilewin.getyear(x));
                }
            }
            foreach (ListViewItem item in filename)
            {
                ReloadlistviewV1(item);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            musicListStore.SelectedItems.Clear();
            if (treeView.SelectedNode.Level == 0)
            {
                for (int i = 0; i < musicListStore.Items.Count - 1; i++)
                {
                    if (musicListStore.Items[i].SubItems[4].Text == treeView.SelectedNode.Text)
                    {
                        musicListStore.Items[i].Selected = true;
                        musicListStore.Items[i].EnsureVisible();
                    }
                }
            }
            if (treeView.SelectedNode.Level == 1)
            {
                for (int i = 0; i < musicListStore.Items.Count - 1; i++)
                {
                    if (musicListStore.Items[i].SubItems[1].Text == treeView.SelectedNode.ToolTipText)
                    {
                        musicListStore.Items[i].Selected = true;
                        musicListStore.Items[i].EnsureVisible();
                    }
                }
            }
            if (treeView.SelectedNode.Level == 2)
            {
                for (int i = 0; i < musicListStore.Items.Count - 1; i++)
                {
                    if (musicListStore.Items[i].SubItems[1].Text + "\\" + musicListStore.Items[i].SubItems[0].Text == treeView.SelectedNode.ToolTipText)
                    {
                        musicListStore.Items[i].Selected = true;
                        musicListStore.Items[i].EnsureVisible();
                    }
                }
            }

            musicListStore.HideSelection = false;
        }

        private void treeView_Enter(object sender, EventArgs e)
        {
            musicListStore.Focus();
        }

        private void UpdateProgress(Int32 progressValue)
        {
            if (this.statusStrip1.InvokeRequired)
            {
                UpdateProgressDelegate d = new UpdateProgressDelegate(UpdateProgress);
                this.Invoke(d, new object[] { progressValue });
            }
            else
            {
                this.toolStripProgressBar.Value = progressValue;
            }
        }

        private void BTNloadimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    pictureBox.Load(openFileDialog.FileName);
                }
            }
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMImage addimage = new FRMImage();
            
            ListView.SelectedListViewItemCollection filename = this.musicListStore.SelectedItems;
            var trackxml = new XMLutils(appPath + "\\trackxml.xml");
            addimage.Artist = filename[0].SubItems[4].Text;
            addimage.Album = filename[0].SubItems[5].Text;

            if (addimage.ShowDialog(this) == DialogResult.OK)
            {

                foreach (ListViewItem item in filename)
                {
                    string fname = item.SubItems[1].Text + "\\" + item.SubItems[0].Text;
                    var id3v2 = new ID3v2Tag(fname);
                    var mytrack = new Track();
                    mytrack.Filename = fname;
                    mytrack.Artist = id3v2.Artist;
                    mytrack.Title = id3v2.Title;
                    mytrack.Album = id3v2.Album;
                    mytrack.Genre = id3v2.Genre;
                    mytrack.Trackno = id3v2.TrackNumber.ToString();
                    mytrack.Year = id3v2.Year;
                    if (addimage.Getimage() != null)
                    {
                        mytrack.coverimage = addimage.Getimage();

                    }
                    Miscutils.Savev2tag(mytrack);
                    //ReloadlistviewV2(fname);

                }

            }
        }

        private void BTNsearchimage_Click(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles(appPath, "*.jpg");
            foreach (string filePath in filePaths)
                File.Delete(filePath);
            FRMimagesearch searchimage = new FRMimagesearch();
            searchimage.Artist = CMBartist.Text;
            searchimage.Album = CMBalbum.Text;
            if (searchimage.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox.Image = (Bitmap) searchimage.Getimage();

            }
           
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string[] filePaths = Directory.GetFiles(appPath, "*.jpg");
            foreach (string filePath in filePaths)
                File.Delete(filePath);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}