using IdSharp.Tagging.ID3v1;
using IdSharp.Tagging.ID3v2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Ntag
{
    internal class XMLutils
    {
        private string myPath = string.Empty;

        public XMLutils(string fname)
        {
            this.myPath = fname;
            if (File.Exists(myPath))
            {
                //File.Delete(myPath);
                //createxmltile("Root");
            }
            else
                createxmltile("Root");
        }

        private void createxmltile(string root)
        {
            if (!File.Exists(this.myPath))
            {
                var textWriter = new XmlTextWriter(this.myPath, null);
                textWriter.Formatting = Formatting.Indented;
                textWriter.WriteStartDocument();
                textWriter.WriteStartElement(root);

                textWriter.WriteEndElement();
                textWriter.WriteEndDocument();
                textWriter.Flush();
                textWriter.Close();
            }
        }

        public void Updaterecord(string filename)
        {
            string tagstring = "";
            if (ID3v2Tag.DoesTagExist(filename))
            {
                tagstring = "/V2";
                if (ID3v1Tag.DoesTagExist(filename))
                {
                    tagstring = "V1" + tagstring;
                }
                var id3 = new ID3v2Tag(filename);
                var mytrack = new Track(id3.Artist, id3.Title, id3.Album, id3.Year, id3.TrackNumber, id3.Genre, filename, tagstring);
                ModifyRecord(mytrack);
            }
            if (ID3v1Tag.DoesTagExist(filename) && tagstring == "")
            {
                tagstring = "V1";
                var id3 = new ID3v1Tag(filename);
                var mytrack = new Track(id3.Artist, id3.Title, id3.Album, id3.Year, id3.TrackNumber.ToString(), GenreHelper.GenreByIndex[id3.GenreIndex], filename, tagstring);
                ModifyRecord(mytrack);
            }
            if (tagstring == "No Tag")
            {
                var mytrack = new Track("", "", "", "", "", "", filename, "No Tag");
                ModifyRecord(mytrack);
            }
        }

        public void Addrecord(BindingList<Track> tlist)
        {
            if (!File.Exists(this.myPath))
                createxmltile("Root");
            var doc = new XmlDocument();

            doc.Load(this.myPath);
            XmlNode newXMLNode = doc.SelectSingleNode("Root");

            for (int i = 0; i <= tlist.Count - 1; i++)
            {
                XmlElement newElem = doc.CreateElement("Record");
                newElem.SetAttribute("ID", Stripescape(tlist[i].Filename));

                XmlElement firstnewElem = doc.CreateElement("Tagtype");
                firstnewElem.InnerText = tlist[i].Tagtype;
                newElem.AppendChild(firstnewElem);

                XmlElement firstelement = doc.CreateElement("Title");
                firstelement.InnerText = Stripescape(tlist[i].Title);
                newElem.AppendChild(firstelement);

                XmlElement secondelement = doc.CreateElement("Artist");
                secondelement.InnerText = Stripescape(tlist[i].Artist);
                newElem.AppendChild(secondelement);

                XmlElement thirdelement = doc.CreateElement("Album");
                thirdelement.InnerText = Stripescape(tlist[i].Album);
                newElem.AppendChild(thirdelement);

                XmlElement fourthelement = doc.CreateElement("Trackno");
                fourthelement.InnerText = tlist[i].Trackno;
                newElem.AppendChild(fourthelement);

                XmlElement fifthelement = doc.CreateElement("Year");
                fifthelement.InnerText = tlist[i].Year;
                newElem.AppendChild(fifthelement);

                XmlElement sixthhelement = doc.CreateElement("Genre");
                sixthhelement.InnerText = tlist[i].Genre;
                newElem.AppendChild(sixthhelement);

                doc.DocumentElement.InsertAfter(newElem, doc.DocumentElement.LastChild);
            }
            doc.Save(this.myPath);
        }

        public void Addrecord(Track mytrack)
        {
            if (!File.Exists(this.myPath))
                createxmltile("Root");
            var doc = new XmlDocument();

            doc.Load(this.myPath);
            XmlNode newXMLNode = doc.SelectSingleNode("Root");

            XmlElement newElem = doc.CreateElement("Record");
            newElem.SetAttribute("ID", Stripescape(mytrack.Filename));

            XmlElement firstnewElem = doc.CreateElement("Tagtype");
            firstnewElem.InnerText = mytrack.Tagtype;
            newElem.AppendChild(firstnewElem);

            XmlElement firstelement = doc.CreateElement("Title");
            firstelement.InnerText = Stripescape(mytrack.Title);
            newElem.AppendChild(firstelement);

            XmlElement secondelement = doc.CreateElement("Artist");
            secondelement.InnerText = Stripescape(mytrack.Artist);
            newElem.AppendChild(secondelement);

            XmlElement thirdelement = doc.CreateElement("Album");
            thirdelement.InnerText = Stripescape(mytrack.Album);
            newElem.AppendChild(thirdelement);

            XmlElement fourthelement = doc.CreateElement("Trackno");
            fourthelement.InnerText = mytrack.Trackno;
            newElem.AppendChild(fourthelement);

            XmlElement fifthelement = doc.CreateElement("Year");
            fifthelement.InnerText = mytrack.Year;
            newElem.AppendChild(fifthelement);

            XmlElement sixthhelement = doc.CreateElement("Genre");
            sixthhelement.InnerText = mytrack.Genre;
            newElem.AppendChild(sixthhelement);

            doc.DocumentElement.InsertAfter(newElem, doc.DocumentElement.LastChild);

            doc.Save(this.myPath);
        }

        public void ModifyRecord(Track mytrack)
        {
            try
            {
                var doc = new XmlDocument();
                doc.Load(this.myPath);
                string myid = Stripescape(mytrack.Filename);
                XmlNode nodes = doc.SelectSingleNode("//Root/Record[@ID=" + "'" + myid + "'" + "]");
                if (nodes == null)
                {
                    Addrecord(mytrack);
                    return;
                }

                doc.SelectSingleNode("//Root/Record[@ID=" + "'" + myid + "'" + "]/Tagtype").InnerText = mytrack.Tagtype;
                doc.SelectSingleNode("//Root/Record[@ID=" + "'" + myid + "'" + "]/Title").InnerText = Stripescape(mytrack.Title);
                doc.SelectSingleNode("//Root/Record[@ID=" + "'" + myid + "'" + "]/Artist").InnerText = Stripescape(mytrack.Artist);
                doc.SelectSingleNode("//Root/Record[@ID=" + "'" + myid + "'" + "]/Album").InnerText = Stripescape(mytrack.Album);
                doc.SelectSingleNode("//Root/Record[@ID=" + "'" + myid + "'" + "]/Trackno").InnerText = mytrack.Trackno;
                doc.SelectSingleNode("//Root/Record[@ID=" + "'" + myid + "'" + "]/Year").InnerText = mytrack.Year;
                doc.SelectSingleNode("//Root/Record[@ID=" + "'" + myid + "'" + "]/Genre").InnerText = mytrack.Genre;

                doc.Save(this.myPath);
                doc = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<string> Getcatagorys(string catagory)
        {
            List<string> cats = new List<string>();
            if (!File.Exists(this.myPath))
                return null;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(this.myPath);
                XmlNodeList nodes = doc.GetElementsByTagName(catagory);
                foreach (XmlNode node in nodes)
                {
                    if (cats.Contains(node.InnerText.ToString()) == false)
                    {
                        cats.Add(node.InnerText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in parsing the xml file Getcatagorys " + ex.Message);
            }
            return cats;
        }

        public List<string> Getalbums(string artist)
        {
            List<string> cats = new List<string>();
            if (!File.Exists(this.myPath))
                return null;
            try
            {
                XDocument doc = XDocument.Load(this.myPath);
                var result = (from m in doc.Root.Elements("Record") where ((string)m.Element("Artist").Value == artist) select m).Elements("Album").Distinct();
                foreach (string item in result)
                {
                    if (cats.Contains(item) == false)
                    {
                        cats.Add(Restorescape(item));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in parsing the xml file Getalbums " + ex.Message);
            }

            return cats;
        }

        public BindingList<Track> Gettracks(string album, string artist)
        {
            BindingList<Track> trackList = new BindingList<Track>();
            if (!File.Exists(this.myPath))
                return null;
            try
            {
                XDocument doc = XDocument.Load(this.myPath);
                var records = from book in doc.Root.Elements("Record") where ((string)book.Element("Album").Value.ToUpper() == album.ToUpper() & (string)book.Element("Artist").Value.ToUpper() == artist.ToUpper()) select book;

                foreach (var myrecord in records)
                {
                    trackList.Add(new Track("", Restorescape(myrecord.Element("Title").Value), "", "", "", "", Restorescape(myrecord.Attribute("ID").Value), ""));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in parsing the xml file Gettracks " + ex.Message);
            }

            return trackList;
        }

        private string Stripescape(string xmlstring)
        {
            string tempxml = xmlstring;
            if (tempxml == null) { return ""; }
            if (tempxml.Contains("'"))
            {
                tempxml = xmlstring.Replace("'", "&apos;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");//.Replace("&", "&amp;");
                //  return tempxml;
            }
            return tempxml;
        }

        private string Restorescape(string xmlstring)
        {
            if (xmlstring == null) { return ""; }
            string tempxml = xmlstring.Replace("&apos;", "'").Replace("&lt;", "<").Replace("&gt;", ">").Replace("&quot;", "\"");//.Replace("&amp;", "&");
            return tempxml;
        }

        public BindingList<Track> GetAllRecords()
        {
            BindingList<Track> trackList = new BindingList<Track>();
            if (!File.Exists(this.myPath))
                return null;
            try
            {
                XElement xelement = XElement.Load(this.myPath);
                IEnumerable<XElement> records = xelement.Elements();
                foreach (var myrecord in records)
                {
                    trackList.Add(new Track(Restorescape(myrecord.Element("Artist").Value), Restorescape(myrecord.Element("Title").Value), Restorescape(myrecord.Element("Album").Value),
                        myrecord.Element("Year").Value, myrecord.Element("Trackno").Value, myrecord.Element("Genre").Value,
                       Restorescape(myrecord.Attribute("ID").Value), myrecord.Element("Tagtype").Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in parsing the xml file GetAllRecords " + ex.Message);
            }

            return trackList;
        }

        public BindingList<Track> SeachRecords(string searchstring, string catagory)
        {
            BindingList<Track> trackList = new BindingList<Track>();
            if (!File.Exists(this.myPath))
                return null;
            try
            {
                XDocument doc = XDocument.Load(this.myPath);
                var records = from book in doc.Root.Elements("Record") where (string)book.Element(catagory).Value.ToUpper() == searchstring.ToUpper() select book;
                foreach (var myrecord in records)
                {
                    trackList.Add(new Track(Restorescape(myrecord.Element("Artist").Value), Restorescape(myrecord.Element("Title").Value), Restorescape(myrecord.Element("Album").Value),
                        myrecord.Element("Year").Value, myrecord.Element("Trackno").Value, myrecord.Element("Genre").Value,
                       Restorescape(myrecord.Attribute("ID").Value), myrecord.Element("Tagtype").Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in parsing the xml file GetAllRecords " + ex.Message);
            }

            return trackList;
        }

        public BindingList<Track> SeachRecordsall(string searchstring)
        {
            BindingList<Track> trackList = new BindingList<Track>();
            if (!File.Exists(this.myPath))
                return null;
            try
            {
                XDocument doc = XDocument.Load(this.myPath);
                var records = from book in doc.Root.Elements("Record") where 
                                  book.Element("Artist").Value.ToUpper().Contains(searchstring.ToUpper()) ||
                                  book.Element("Title").Value.ToUpper().Contains(searchstring.ToUpper()) ||
				                  book.Element("Album").Value.ToUpper().Contains(searchstring.ToUpper()) ||
				                  book.Element("Year").Value.ToUpper().Contains(searchstring.ToUpper()) ||
				                  book.Element("Genre").Value.ToUpper().Contains(searchstring.ToUpper()) 
				select book;
                foreach (var myrecord in records)
                {
                    trackList.Add(new Track(Restorescape(myrecord.Element("Artist").Value), Restorescape(myrecord.Element("Title").Value), Restorescape(myrecord.Element("Album").Value),
                        myrecord.Element("Year").Value, myrecord.Element("Trackno").Value, myrecord.Element("Genre").Value,
                       Restorescape(myrecord.Attribute("ID").Value), myrecord.Element("Tagtype").Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in parsing the xml file GetAllRecords " + ex.Message);
            }

            return trackList;
        }

        public void Updatefilename(string oldfile, string newfile)
        {
            try
            {
                XDocument doc = XDocument.Load(this.myPath);
                var fname = (from nf in doc.Root.Elements("Record") where (string)nf.Attribute("ID").Value == Stripescape(oldfile) select nf).First();
                fname.Attribute("ID").Value = Stripescape(newfile);
                doc.Save(this.myPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in parsing the xml file Updatefilename " + ex.Message);
            }
        }
    }
}