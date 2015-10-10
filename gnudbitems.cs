using System;

namespace Ntag
{
    internal class gnudbitems
    {
        #region <<< Private Fields >>>

        private String m_id;
        private String m_Artist;
        private String m_Album;

        #endregion <<< Private Fields >>>

        #region <<< Constructor >>>

        public gnudbitems(String id, String artist, String album)
        {
            m_id = id;
            m_Artist = artist;
            m_Album = album;
        }

        #endregion <<< Constructor >>>

        #region <<< Public Properties >>>

        public String id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public String Artist
        {
            get { return m_Artist; }
            set { m_Artist = value; }
        }

        public String Album
        {
            get { return m_Album; }
            set { m_Album = value; }
        }

        #endregion <<< Public Properties >>>
    }
}