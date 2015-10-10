using System;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ntag
{
    class Buildargs
    {
        StringBuilder ingstring = new StringBuilder();
        StringBuilder outgstring = new StringBuilder();
        StringBuilder effectgstring = new StringBuilder();
        StringBuilder fronteffect = new StringBuilder();
        string outfname = string.Empty;

        public Buildargs()
        {
        }

        public void addfname(string fname)
        {
            ingstring.Append(fname.Trim() + " ");

        }

        public void addoutfname(string fname)
        {
            outgstring.Append("\"" + fname.Trim() + "\"" + " ");
        }


        public void addoutfname(string fname, string newdirectory, string newextion)
        {
            string newfname = newdirectory + "\\" + Path.GetFileName(fname);
            newfname = Path.ChangeExtension(newfname, newextion);
            outgstring.Append("\"" + newfname.Trim() + "\"" + " ");
            outfname = newfname.Trim();
        }

        public void addoutfname_gmic(string fname, string newdirectory, string newextion)
        {
            string newfname = newdirectory + "\\" + Path.GetFileName(fname);
            newfname = Path.ChangeExtension(newfname, newextion);
            outgstring.Append("-o " + "\"" + newfname.Trim() + "\"" + " ");
            outfname = newfname.Trim();
        }

        public void addeffect(string effectname)
        {
            if (effectname != null)
                effectgstring.Append(effectname.Trim() + " ");
        }

        public void addfronteffect(string effectname)
        {
            if (effectname != null)
                fronteffect.Append(effectname.Trim() + " ");
        }

        public string getarg()
        {
            return (fronteffect.ToString() + " " + ingstring.ToString() + "  " + effectgstring.ToString() + " " + outgstring.ToString());
        }

        public string Getoutfname()
        {
            return (outfname);
        }



        public string Callcoverart(string filename)
        {
            string myarg = null;
            myarg = fronteffect.ToString() + " " + ingstring.ToString() + "  " + effectgstring.ToString() + " " + outgstring.ToString();

            Clipboard.SetText(myarg);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = myarg,
                FileName = filename,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            };

            using (Process exeProcess = Process.Start(startInfo))
            {
                string IMResponse = exeProcess.StandardOutput.ReadToEnd();
                exeProcess.WaitForExit();
                exeProcess.Close();
                exeProcess.Dispose();
                return !String.IsNullOrEmpty(IMResponse) ? IMResponse : "True";
            }
        }
    }
}
