using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MStoPP
{
    public partial class Form : System.Windows.Forms.Form
    {
        string[] lines;
        string path;
        string[] copyright = new string[3];

        public Form()
        {
            InitializeComponent();
        }

        private void impTxtBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                path = fileDialog.FileName;
                impTextBox.Text = path;

                this.lines = File.ReadAllLines(path);

            }
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            string chunk = "";
            bool copySet = false;
            ArrayList newLines = new ArrayList();
            copySet = false;
            try
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine("Got Line: " + lines[i]);

                    //skip the things I know we don't need.
                    if ((lines[i].Contains("Cue:") && lines[i].Contains("Page:")))
                        continue;

                    getChunk(i);
                    i++; //skip -----



                    //if ((lines[i].Contains("Cue:") && lines[i].Contains("Page:")) ||
                    //    lines[i].Contains("-----"))
                    //    continue;


                        //if (copySet)
                        //{
                        //    if( lines[i+1] == copyright[0] &&
                        //        lines[i+2] == copyright[1] &&
                        //        lines[i+3] == copyright[2])
                        //    {
                        //        i += 4;
                        //        newLines.Add("\n");
                        //        continue;
                        //    }
                        //}

                        //if(lines[i] == "" && lines[i + 1] != "")
                        //{
                        //    if (!copySet)
                        //    {
                        //        copyright[0] = lines[i + 1];
                        //        copyright[1] = lines[i + 2];
                        //        copyright[2] = lines[i + 3];
                        //        i += 3;

                        //        Console.WriteLine("Copyright: \n" +
                        //            copyright[0] + "\n" +
                        //            copyright[1] + "\n" +
                        //            copyright[2] + "\n");

                        //        copySet = true;
                        //        continue;
                        //    }
                        //}   

                        newLines.Add(lines[i]+"\n");
                    Console.WriteLine("ADDED LINE: " + lines[i] + "\n");
                }

                writeToFile((string[])newLines.ToArray(typeof(string)));
    
                dynStatusLabel.Text = "Done";
                
            }
            catch (IndexOutOfRangeException)
            {
                //do nothing, just end cuz we reached the end of the file. 
                dynStatusLabel.Text = "Done";
            }
            finally
            {
                writeToFile((string[])newLines.ToArray(typeof(string)));

            }


        }

        private string getChunk(int start)
        {
            StringBuilder retStr = new StringBuilder();
            retStr.Clear();
            for(int i = start; i < lines.Length; i++)
            {
                if (lines[i] == "-----")
                {
                    break;
                }
                if(lines[i] == "" && !copyrightLoaded()) //check for copyright
                {
                    loadCopyright(i);
                }

                retStr.Append(lines[i]);
            }
            
            return retStr.ToString();
        }

        private bool checkCopyright(int start)
        {
            if(copyright[0] == lines[start] &&
                copyright[1] == lines[start+1] &&
                copyright[2] == lines[start + 2])
                return true;
            
            return false;
        }

        private void loadCopyright(int start)
        {
            if((copyright[0] != "" &&
                copyright[1] != "" &&
                copyright[2] != "") &&
                (passCriteria(lines[start]) &&
                 passCriteria(lines[start+1]) &&
                 passCriteria(lines[start+2])))
            {
                copyright[0] = lines[start];
                copyright[1] = lines[start+1];
                copyright[2] = lines[start+2];
            }
        }

        private bool copyrightLoaded()
        {
            if(copyright[0] != "" &&
                copyright[1] != "" &&
                copyright[2] != "")
                return true;

            return false;
        }

        private bool passCriteria(string line)
        {
            if(!(line == "-----") && !(line.Contains("Cue:") && line.Contains("Page:")))
                return true;

            return false;
        }

        private string convertArrToStr(string[] strArr)
        {
            StringBuilder outStr = new StringBuilder();

            foreach (string str in strArr)
                outStr.Append(str);
            
            return outStr.ToString();
        }

        private void writeToFile(string[] newLines)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            save.InitialDirectory = path+"_PP.txt";
            
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, convertArrToStr(newLines));
            }
        }

        private void impTextBox_TextChanged(object sender, EventArgs e)
        {
            if (impTextBox.Text.Length > 0)
            {
                expBtn.Enabled = true;
            }
            else
            {
                expBtn.Enabled = false;
            } 
        }
    }
}
