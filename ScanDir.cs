using System;
using System.ComponentModel;
using IdSharp.Tagging.ID3v1;
using IdSharp.Tagging.ID3v2;
using System.IO;

namespace Ntag
{
    public delegate void OnListfilesEvent(Track fname);
    public delegate void UpdateProgressEvent(int prog);

    class ScanDir
    {
        private string dir = string.Empty;

        private BindingList<Track> trackList = new BindingList<Track>();

        public ScanDir(string Dir)
        {
            dir = Dir;
        }

        public ScanDir()
        {

        }

        public event OnListfilesEvent OnListFiles;
        public event UpdateProgressEvent UpdateProgress;

        public string Dir
        {
            get { return dir; }
            set { dir = value; }
        }

        public BindingList<Track> tracks
        {
            get { return this.trackList; }
        }

        public void Run_Scan()
        {
            if (Directory.Exists(dir))
            {
                Runscan();
            }
        }
        private void Runscan()
        {
            Int32 totalFiles = 0;
            string tagstrV1 = null;
            string tagstrV2 = null;

            DirectoryInfo di = new DirectoryInfo(Dir);
            FileInfo[] fileList = di.GetFiles("*.mp3", SearchOption.AllDirectories);
            totalFiles = fileList.Length;

            for (Int32 i = 0; i < totalFiles; i++)
            {
                tagstrV1 = string.Empty;
                tagstrV2 = string.Empty;

               // Currentfile(fileList[i].FullName);
                if (ID3v1Tag.DoesTagExist(fileList[i].FullName))
                    tagstrV1 = "V1";
                if (ID3v2Tag.DoesTagExist(fileList[i].FullName))
                    tagstrV2 = "V2";

                if (tagstrV1 == "V1" & tagstrV2 == "")
                {
                    var id3 = new ID3v1Tag(fileList[i].FullName);
                    var mytrack = new Track(id3.Artist, id3.Title, id3.Album, id3.Year, id3.TrackNumber.ToString(), GenreHelper.GenreByIndex[id3.GenreIndex], fileList[i].FullName, tagstrV1 + "/" + tagstrV2);
                    if (OnListFiles != null) { OnListFiles(mytrack); }
                    trackList.Add(mytrack);
                }
                if (tagstrV2 == "V2")
                {
                    var id3 = new ID3v2Tag(fileList[i].FullName);
                    if (id3.Genre == null)
                    {
                        id3.Genre = "none";
                    }

                    try
                    {
                        var mytrack = new Track(id3.Artist, id3.Title, id3.Album, id3.Year, id3.TrackNumber, id3.Genre, fileList[i].FullName, tagstrV1 + "/" + tagstrV2);
                        if (OnListFiles != null) { OnListFiles(mytrack); }
                        trackList.Add(mytrack);
                    }
                    catch (Exception)
                    {
                       trackList.RemoveAt(trackList.Count - 1);
                       trackList.Add(new Track("", "", "", "", "", "", fileList[i].FullName, "Bad Tag"));
                    }
                }

                if (tagstrV2 == "" & tagstrV1 == "")
                {
                    var mytrack = new Track("", "", "", "", "", "", fileList[i].FullName, "No Tag");
                    if (OnListFiles != null) { OnListFiles(mytrack); }
                    trackList.Add(mytrack);
                }

                if ((i % 100) == 0)
                {
                    if (UpdateProgress != null) { UpdateProgress(i * 100 / totalFiles); }
                    
                }

                
                
            }
        }
    }
}
