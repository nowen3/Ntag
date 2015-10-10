using IdSharp.Tagging.ID3v1;
using IdSharp.Tagging.ID3v2;
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using IdSharp.Tagging.ID3v2.Frames;

namespace Ntag
{
    public static class Miscutils
    {
        private static string appPath = Path.GetDirectoryName(Application.ExecutablePath);

        public static Boolean Savev1tag(Track mytrack)
        {
            if (!File.Exists(mytrack.Filename))
            {
                MessageBox.Show("File Does not exist " + mytrack.Filename);
                return false;
            }
            try
            {
                var trackxml = new XMLutils(appPath + "\\trackxml.xml");
                removeID3v1(mytrack.Filename);
                var id3 = new ID3v1Tag(mytrack.Filename);
                if (!String.IsNullOrEmpty(mytrack.Filename) && File.Exists(mytrack.Filename))
                {
                    id3.Album = mytrack.Album;
                    id3.Artist = mytrack.Artist;
                    id3.Title = mytrack.Title;
                    if (mytrack.Trackno.Contains("/"))
                    {
                        id3.TrackNumber = Convert.ToInt16(mytrack.Trackno.Substring(0, mytrack.Trackno.IndexOf("/")));
                    }
                    else id3.TrackNumber = Convert.ToInt16(mytrack.Trackno);
                    id3.Year = mytrack.Year;
                    id3.GenreIndex = GenreHelper.GetGenreIndex(mytrack.Genre);
                    // id3.Comment = comment;
                    id3.Save(mytrack.Filename);
                    trackxml.ModifyRecord(mytrack);
                }
                if (ID3v1Tag.DoesTagExist(mytrack.Filename))
                {
                    trackxml.Updaterecord(mytrack.Filename);
                    return (true);
                }
                else return (false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static Boolean Savev2tag(Track mytrack)
        {
            if (!File.Exists(mytrack.Filename))
            {
                MessageBox.Show("File Does not exist " + mytrack.Filename);
                return false;
            }
            var trackxml = new XMLutils(appPath + "\\trackxml.xml");
            removeID3v2(mytrack.Filename);
            var id3 = new ID3v2Tag(mytrack.Filename);
            if (!String.IsNullOrEmpty(mytrack.Filename) && File.Exists(mytrack.Filename))
            {
                id3.Album = mytrack.Album;
                id3.Artist = mytrack.Artist;
                id3.Title = mytrack.Title;
                id3.TrackNumber = mytrack.Trackno;
                id3.Year = mytrack.Year;
                id3.Genre = mytrack.Genre;
                
                if (mytrack.coverimage !=null)
                {
                    id3.PictureList.Clear();
                    IAttachedPicture picture = id3.PictureList.AddNew();
                    
                    picture.PictureData = ConvertBitMapToByteArray(mytrack.coverimage);
                    picture.PictureType = PictureType.CoverFront;
                   
                }
                id3.Save(mytrack.Filename);
                trackxml.ModifyRecord(mytrack);
            }
            if (ID3v2Tag.DoesTagExist(mytrack.Filename))
            {
                trackxml.Updaterecord(mytrack.Filename);
                return (true);
            }
            else return (false);
        }

        public static byte[] ConvertBitMapToByteArray(Bitmap bitmap)
        {
            byte[] result = null;

            if (bitmap != null)
            {
                Bitmap im = new Bitmap((Image)bitmap);
                MemoryStream stream = new MemoryStream();
                im.Save(stream, bitmap.RawFormat);
                result = stream.ToArray();
            }

            return result;
        }

        public static Boolean removeID3v1(string fname)
        {
            Boolean success = false;
            var trackxml = new XMLutils(appPath + "\\trackxml.xml");
            if (!String.IsNullOrEmpty(fname) && File.Exists(fname))
            {
                success = ID3v1Tag.RemoveTag(fname);
            }
            if (success)
            {
                trackxml.Updaterecord(fname);
            }
            return (success);
        }

        public static Boolean removeID3v2(string fname)
        {
            Boolean success = false;
            var trackxml = new XMLutils(appPath + "\\trackxml.xml");
            if (!String.IsNullOrEmpty(fname) && File.Exists(fname))
            {
                var id3 = new ID3v2Tag(fname);
                if (id3.PictureList.Count > 0)
                {
                    id3.PictureList.Clear();
                }
                    success = ID3v2Tag.RemoveTag(fname);
            }
            if (success)
            {
                trackxml.Updaterecord(fname);
            }
            return (success);
        }

        public static Track Getv1tags(string fname)
        {
            Track mytrack = new Track("", "", "", "", "", "", "", "");

            if (File.Exists(fname))
            {
                var id3 = new ID3v1Tag(fname);
                mytrack.Album = id3.Album;
                mytrack.Artist = id3.Artist;
                mytrack.Title = id3.Title;
                mytrack.Trackno = id3.TrackNumber.ToString();
                mytrack.Year = id3.Year;
            }
            return mytrack;
        }

        public static Track Getv2tags(string fname)
        {
            var mytrack = new Track("", "", "", "", "", "", "", "");

            if (File.Exists(fname))
            {
                var id3 = new ID3v2Tag(fname);
                mytrack.Album = id3.Album;
                mytrack.Artist = id3.Artist;
                mytrack.Title = id3.Title;
                mytrack.Trackno = id3.TrackNumber.ToString();
                mytrack.Year = id3.Year;
            }
            return mytrack;
        }

        public static string stripchar(string fname)
        {
            //char newchar = '';
            char[] sep = new char[] { '/', ':', '?', '"', '*', '<', '>', '|' };
            foreach (char ss in sep)
            {
                if (fname.IndexOf(ss) > -1)
                    fname = fname.Replace(ss.ToString(), "");
            }
            return (fname);
        }

        public static string PaddedNumber(string Original)
        {
            if (Original.Length == 1)
            {
                return Original.PadLeft(2, '0');
            }
            else
                return Original;
        }

        public static void SetDoubleBuffering(System.Windows.Forms.Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(System.Windows.Forms.Control)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            controlProperty.SetValue(control, value, null);
        }
    }
}