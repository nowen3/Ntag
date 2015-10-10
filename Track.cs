using System;
using System.Drawing;

namespace Ntag
{
    public class Track
    {
        #region <<< Private Fields >>>

        private String m_Filename;
        private String m_Artist;
        private String m_Title;
        private String m_Album;
        private String m_Year;
        private String m_Genre;
        private String m_track;
        private string m_tag;
        private Bitmap m_coverimage;

        #endregion <<< Private Fields >>>

        #region <<< Constructor >>>

        public Track(String artist, String title, String album, String year, string trackno, String genre, String filename, string tagtype, Bitmap coverimage = null)
        {
            m_Artist = artist;
            m_Title = title;
            m_Album = album;
            m_Year = year;
            m_track = trackno;
            m_Genre = genre;
            m_Filename = filename;
            m_tag = tagtype;
            m_coverimage = (Bitmap) coverimage;
        }

        public Track()
        {
            //jhkkj
        }

        #endregion <<< Constructor >>>

        #region <<< Public Properties >>>

        public String Filename
        {
            get { return this.m_Filename; }
            set { this.m_Filename = value; }
        }

        public String Artist
        {
            get
            {
                return this.m_Artist;
            }
            set
            {
                this.m_Artist = value;
            }
        }

        public String Title
        {
            get
            {
                return this.m_Title;
            }
            set
            {
                this.m_Title = value;
            }
        }

        public String Album
        {
            get
            {
                return this.m_Album;
            }
            set
            {
                this.m_Album = value;
            }
        }

        public String Year
        {
            get
            {
                return this.m_Year;
            }
            set
            {
                this.m_Year = value;
            }
        }

        public String Trackno
        {
            get
            {
                return this.m_track;
            }
            set
            {
                this.m_track = value;
            }
        }

        public String Genre
        {
            get
            {
                return this.m_Genre;
            }
            set
            {
                this.m_Genre = value;
            }
        }

        public String Tagtype
        {
            get
            {
                return this.m_tag;
            }
            set
            {
                this.m_tag = value;
            }
        }

        public Bitmap coverimage
        {
            get
            {
                return this.m_coverimage;
            }
            set
            {
                this.m_coverimage = value;
            }
        }


    #endregion <<< Public Properties >>>
}
}