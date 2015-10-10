using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Net;

namespace Ntag
{
    internal class Gnudbsearch
    {
        private const string CMD_TERMINATOR = ".";
        private const string CMD_URL = "http://www.gnudb.org/search/";
        private string pageno = null;
        private string searchitem = null;
        private BindingList<gnudbitems> searchlist;

        public Gnudbsearch(string searchstring)
        {
            this.searchitem = searchstring;
            searchgnudb(this.searchitem);
        }

        public String page
        {
            get
            {
                return pageno;
            }
            set
            {
                pageno = value;
                searchlist.Clear();
                searchgnudb(this.searchitem.Replace(" ", "+") + "?page=" + pageno);
            }
        }

        public BindingList<gnudbitems> searchresults
        {
            get
            {
                return searchlist;
            }
        }

        public BindingList<Track> getgnutracks(string asin)
        {
            string cat = asin.Substring(0, 2);
            asin = asin.Substring(2);
            string genre = null;
            string year = null;
            string track = null;
            int ntrack = 0;
            BindingList<Track> trackList = new BindingList<Track>();
            string url = "http://www.gnudb.org/gnudb/";
            StringCollection ste = new StringCollection();
            switch (cat)
            {
                case "bl":
                    url = url + "blues/" + asin;
                    break;

                case "cl":
                    url = url + "classical/" + asin;
                    break;

                case "co":
                    url = url + "country/" + asin;
                    break;

                case "data":
                    url = url + "data/" + asin;
                    break;

                case "fo":
                    url = url + "folk/" + asin;
                    break;

                case "ja":
                    url = url + "jazz/" + asin;
                    break;

                case "mi":
                    url = url + "misc/" + asin;
                    break;

                case "ne":
                    url = url + "newage/" + asin;
                    break;

                case "re":
                    url = url + "reggae/" + asin;
                    break;

                case "ro":
                    url = url + "rock/" + asin;
                    break;

                case "so":
                    url = url + "soundtrack/" + asin;
                    break;

                default:
                    url = url + asin;
                    break;
            } // end switch
            ste = Call(url);
            foreach (String line in ste)
            {
                if (line.IndexOf("DYEAR=") != -1)
                {
                    year = line.Substring(6);
                }
                if (line.IndexOf("DGENRE=") != -1)
                {
                    genre = line.Substring(7);
                }
                if (line.IndexOf("TTITLE") != -1)
                {
                    ntrack = Convert.ToInt16(line.Substring(6, (line.IndexOf("=") - 6))) + 1;
                    track = line.Substring(line.IndexOf("=") + 1);
                    track = stripchar(track);
                    trackList.Add(new Track(string.Empty, track, "", year, ntrack.ToString(), genre, "", ""));
                }
            }
            return (trackList);
        }

        public void searchgnudb(string searchstring)
        {
            StringCollection ste = new StringCollection();
            searchlist = new BindingList<gnudbitems>();
            string[] aHeaders = new string[3];
            ste = Call(CMD_URL + searchstring);
            foreach (String line in ste)
            {
                if (line.IndexOf("<h2>Search Results,") != -1)
                {
                    pageno = line.Substring(line.IndexOf(",") + 1, (line.LastIndexOf("a") - line.IndexOf(",")) - 1).Trim();
                }

                if (line.IndexOf("http://www.gnudb.org/cd") != -1)
                {
                    try
                    {
                        int lst = line.LastIndexOf("http://www.gnudb.org/cd") + 24;
                        int lstb = line.LastIndexOf("</b") - lst;
                        string temp = line.Substring(lst, lstb);
                        aHeaders[0] = temp.Substring(0, temp.IndexOf("\""));
                        lstb = temp.IndexOf(" / ") - (temp.IndexOf("b>") + 2);
                        aHeaders[1] = temp.Substring(temp.IndexOf("b>") + 2, lstb);
                        aHeaders[2] = temp.Substring(temp.IndexOf(" / ") + 2);
                        searchlist.Add(new gnudbitems(aHeaders[0], aHeaders[1], aHeaders[2]));
                    }
                    catch (Exception em)
                    {
                        Console.Write("Error" + "---" + em.Message);
                    }
                }
            }
        }

        private StringCollection Call(string url)
        {
            StreamReader reader = null;
            HttpWebResponse response = null;
            StringCollection coll = new StringCollection();

            try
            {
                ////create our HttpWebRequest which we use to call the freedb server
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.ContentType = "text/plain";
                //// we are using th POST method of calling the http server. We could have also used the GET method
                req.Method = "POST";

                response = (HttpWebResponse)req.GetResponse();
                ////put the results into a StreamReader
                reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8);
                //// add each line to the StringCollection until we get the terminator
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith(CMD_TERMINATOR))
                    {
                        break;
                    }
                    else
                    {
                        coll.Add(line);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (response != null)
                    response.Close();
                if (reader != null)
                    reader.Close();
            }

            return coll;
        }

        private string stripchar(string fname)
        {
            char newchar = '-';
            char[] sep = new char[] { '\\', '/', ':', '?', '"', '*', '<', '>', '#', '&', '|' };
            foreach (char ss in sep)
            {
                if (fname.IndexOf(ss) > -1)
                {
                    fname = fname.Replace(ss, newchar);
                }
            }
            return (fname);
        }
    }// end of class
}