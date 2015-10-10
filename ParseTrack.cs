using System;
using System.IO;

namespace Ntag
{
    internal class ParseTrack
    {
        private string trackno;
        private string title;
        private string artist;

        public ParseTrack(string fname, string template)
        {
            string newfname = Path.GetFileNameWithoutExtension(fname);
            string[] temp = template.Split(new Char[] { '%' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i <= temp.Length - 1; i++)
            {
                if (temp[i] == "TRACKNUMBER")
                {
                    if (i < temp.Length - 1)
                    {
                        string aaa = temp[i + 1].Trim();
                        if (aaa == "")
                        {
                            aaa = " ";
                        }
                        int end = newfname.IndexOf(aaa);
                        if (end > 0)
                        {
                            trackno = newfname.Substring(0, end);
                            string[] sfname = newfname.Split(new string[] { temp[i + 1] }, StringSplitOptions.RemoveEmptyEntries);
                            if (sfname.Length > 1)
                            {
                                newfname = "";
                                sfname[0] = "";
                                foreach (string part in sfname)
                                {
                                    newfname = newfname + part;
                                }
                            }
                        }
                    }
                    else
                    {
                        trackno = newfname;
                    }
                }// end of TRACKNUMBER

                if (temp[i] == "TITLE")
                {
                    if (i < temp.Length - 1)
                    {
                        string aaa = temp[i + 1].Trim();
                        if (aaa == "")
                        {
                            aaa = " ";
                        }
                        if (newfname.StartsWith(aaa))
                        {
                            newfname = newfname.Substring(1);
                        }
                        int end = newfname.IndexOf(aaa);
                        if (end > 0)
                        {
                            title = newfname.Substring(0, end);
                            string[] sfname = newfname.Split(new string[] { temp[i + 1] }, StringSplitOptions.RemoveEmptyEntries);
                            if (sfname.Length > 1)
                            {
                                newfname = "";
                                sfname[0] = "";
                                foreach (string part in sfname)
                                {
                                    newfname = newfname + part;
                                }
                            }
                        }
                    }
                    else
                    {
                        title = newfname;
                    }
                }//end of title
                if (temp[i] == "ARTIST")
                {
                    if (i < temp.Length - 1)
                    {
                        string aaa = temp[i + 1].Trim();
                        if (aaa == "")
                        {
                            aaa = " ";
                        }
                        int end = newfname.IndexOf(aaa);
                        if (end > 0)
                        {
                            artist = newfname.Substring(0, end);
                            string[] sfname = newfname.Split(new string[] { temp[i + 1] }, StringSplitOptions.RemoveEmptyEntries);
                            if (sfname.Length > 1)
                            {
                                newfname = "";
                                sfname[0] = "";
                                foreach (string part in sfname)
                                {
                                    newfname = newfname + part;
                                }
                            }
                        }
                    }
                    else
                    {
                        artist = newfname;
                    }
                }//end of artist
            }
        }

        public String GetTrackNumber
        {
            get { return trackno; }
        }

        public String GetTitle
        {
            get { return title; }
        }

        public String GetArtist
        {
            get { return artist; }
        }
    }
}