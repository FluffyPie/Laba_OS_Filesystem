using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_OS_Filesystem
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        
      
        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            string Text;
            int Counter = 0;
            string[] ArrayLine = null;
            string ResultedText = "";
            string FirstLine;
            string[] ArrayCluster = null;
            string[] Alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "W", "X", "Z", "V", "Y" };
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = OpenFileDialog.FileName;
                try
                {
                    using (var Stream = new StreamReader(FileName, Encoding.UTF8))
                    {
                        Text = Stream.ReadToEnd();
                        UnsortedTextbox.Text = "Your Filesystem:" + Environment.NewLine + Text + Environment.NewLine + "Your Files:" + Environment.NewLine;

                        FirstLine = File.ReadLines(FileName).Skip(0).First(); 
                        string[] ElemsOfFirstLine = FirstLine.Split(' ');

                        string SecondLine = File.ReadLines(FileName).Skip(1).First(); 
                        ArrayCluster = new string[(SecondLine.Length + 1) / 2];
                        ArrayCluster = SecondLine.Split(' ');
                        string[] ArrayClusterCopy = SecondLine.Split(' ');

                        Counter = ElemsOfFirstLine.Length / 2 + 1; 
                        ArrayLine = new string[Counter];
                        int i = 0;
                        for (int j = 0; j != ArrayLine.Length; j++)
                        {
                            if (i < ElemsOfFirstLine.Length)
                            {
                                ArrayLine[j] = ElemsOfFirstLine[i] + " " + ElemsOfFirstLine[i + 1];
                                int StarterValue = Convert.ToInt32(ElemsOfFirstLine[i + 1]);
                                string NextValue = ArrayCluster[StarterValue];
                                while (NextValue != "eof" && NextValue != "bad" && NextValue != "0")
                                {
                                    ArrayLine[j] += " " + NextValue;
                                    StarterValue = Convert.ToInt32(ArrayCluster[StarterValue]);
                                    NextValue = ArrayCluster[StarterValue];
                                }
                                if (NextValue == "eof")
                                {
                                    ArrayLine[j] += " eof";
                                }
                                if (NextValue == "bad")
                                {
                                    ArrayLine[j] += " bad";
                                }
                                i += 2;
                                UnsortedTextbox.Text += ArrayLine[j] + Environment.NewLine;
                            }
                        }
        
                        for (int j = 0; j != ElemsOfFirstLine.Length; j += 2)
                        {
                            int FirstValue = Convert.ToInt32(ElemsOfFirstLine[j + 1]);
                            string NextValue = ArrayClusterCopy[FirstValue]; 
                            while (NextValue != "eof" && NextValue != "bad" && NextValue != "0")
                            {
                                int IndexOfCopyArray = FirstValue;
                                FirstValue = Convert.ToInt32(NextValue);
                                NextValue = ArrayClusterCopy[FirstValue];
                                ArrayClusterCopy[IndexOfCopyArray] = "0";
                            }
                            if (NextValue == "eof")
                            {
                                ArrayClusterCopy[FirstValue] = "0";
                            }
                            if (NextValue == "bad")
                            {
                                ArrayClusterCopy[FirstValue] = "0";
                            }
                        }

                        string OtherLine = ""; 
                        for (int j = 0; j != ArrayClusterCopy.Length; j++)
                        {
                            if (ArrayClusterCopy[j] != "0")
                            {
                                if (OtherLine == "")
                                {
                                    OtherLine = Convert.ToString(j);
                                    int FirstValue = j;
                                    string NextValue = ArrayClusterCopy[FirstValue];
                                    while (NextValue != "eof" && NextValue != "bad" && NextValue != "0")
                                    {
                                        int f = FirstValue;
                                        OtherLine += " " + NextValue;
                                        FirstValue = Convert.ToInt32(ArrayClusterCopy[FirstValue]);
                                        NextValue = ArrayClusterCopy[FirstValue];
                                        ArrayClusterCopy[f] = "0";
                                    }
                                    if (NextValue == "eof")
                                    {
                                        OtherLine += " eof";
                                        ArrayClusterCopy[FirstValue] = "0";
                                    }
                                    if (NextValue == "bad")
                                    {
                                        OtherLine += " bad";
                                        ArrayClusterCopy[FirstValue] = "0";
                                    }
                                }
                                else
                                {
                                    int indexOfSubstring = OtherLine.IndexOf(ArrayClusterCopy[j]); 
                                    OtherLine = OtherLine.Insert(indexOfSubstring, ArrayClusterCopy[j] + " ");
                                }
                            }
                        }
                        ArrayLine[ArrayLine.Length - 1] = OtherLine;
                        UnsortedTextbox.Text += ArrayLine[ArrayLine.Length - 1] + Environment.NewLine;
                    }
                    int[] ArrayofEmptyClusters = new int[32];
                    for (int j = 0; j != ArrayofEmptyClusters.Length; j++)
                    {
                        ArrayofEmptyClusters[j] = 0;
                    }

                    bool FirstSign = false;
                    bool Overlay = false;

                    for (int i = 0; i != ArrayLine.Length; i++)
                    {
                        if (ArrayLine[i] != null && ArrayLine[i] != "")
                        {
                            string Line = ArrayLine[i];
                            string[] ElemOfFiles = Line.Split(' ');
                            SortedTextbox.Text += Line;
                            bool Yes = false;
                            for (int j = 0; j != ElemOfFiles.Length; j++)
                            {
                                if (Yes == false)
                                {
                                    if (ElemOfFiles[0] == Alphabet[i])
                                    {
                                        ResultedText += ElemOfFiles[0];
                                    }
                                    else
                                    {
                                        ResultedText += Alphabet[i];
                                        FirstLine += " " + Alphabet[i] + " " + ElemOfFiles[0];
                                        SortedTextbox.Text += Environment.NewLine + "File was lost in your filesystem. It was added under name '" + Alphabet[i] + "'" + Environment.NewLine;
                                        FirstSign = true;
                                    }
                                    Yes = true;
                                }
                                //////////
                                if (ElemOfFiles[j] != Alphabet[i] && ElemOfFiles[j] != "eof" && ElemOfFiles[j] != "bad")
                                {
                                    int k = Convert.ToInt32(ElemOfFiles[j]);
                                    if (ArrayofEmptyClusters[k] == 0)
                                    {
                                        ArrayofEmptyClusters[k] = k;
                                        ResultedText += " " + ElemOfFiles[j];
                                    }
                                    else
                                    {
                                        Overlay = true;
                                        SortedTextbox.Text += Environment.NewLine + "Crossing of adresses " + ElemOfFiles[j] + ". Duplicate elements will be rewritten to empty cells" + Environment.NewLine;
                                        bool Record = false;
                                        for (int a = 0; a != ArrayofEmptyClusters.Length; a++)
                                        {
                                            if (Record == false)
                                            {
                                                if (ArrayofEmptyClusters[a] == 0)
                                                {
                                                    Record = true;
                                                    ArrayofEmptyClusters[a] = k;
                                                    ResultedText += " " + a;
                                                    ArrayCluster[Convert.ToInt32(ElemOfFiles[j - 1])] = Convert.ToString(a);
                                                    ArrayCluster[a] = "eof";
                                                    ElemOfFiles[j] = Convert.ToString(a);
                                                }
                                            }
                                        }
                                        Record = false;
                                    }
                                }
                                else
                                {
                                    if (ElemOfFiles[j] == "eof") 
                                    {
                                        if (FirstSign == false && Overlay == false)
                                        {
                                            SortedTextbox.Text += Environment.NewLine + "No errors found" + Environment.NewLine;
                                        }
                                        ResultedText += " " + "eof" + Environment.NewLine;
                                    }
                                    if (ElemOfFiles[j] == "bad") 
                                    {
                                        SortedTextbox.Text += Environment.NewLine + "Found a badblock. Deleting this file" + Environment.NewLine;
                                        ResultedText += " " + "eof" + Environment.NewLine;
                                        ArrayCluster[Convert.ToInt32(ElemOfFiles[j - 1])] = "eof";
                                    }
                                }
                                if (j == ElemOfFiles.Length - 1)
                                {
                                    if (ElemOfFiles[j] != "eof" && ElemOfFiles[j] != "bad") 
                                    {
                                        SortedTextbox.Text += Environment.NewLine + "The end of the file was omitted. This error will be corrected by writing 'Eof' to the last cell." + Environment.NewLine;
                                        ResultedText += " " + "eof" + Environment.NewLine;
                                        ArrayCluster[Convert.ToInt32(ElemOfFiles[j])] = "eof";
                                    }
                                }
                            }
                        }
                    }
                   
                    SortedTextbox.Text += Environment.NewLine + "Fixed filesystem:" + Environment.NewLine + ResultedText + Environment.NewLine;
                        

                }
                catch
                {
                    MessageBox.Show("Bad data from file");
                }

            }
            else
            {
                MessageBox.Show("Unable to read file");
            }
        }

        private void MouseEnterYourFile(object sender, EventArgs e)
        {
            UnsortedTextbox.ScrollBars = ScrollBars.Vertical;
        }

        private void MouseLeaveYourFile(object sender, EventArgs e)
        {
            UnsortedTextbox.ScrollBars = ScrollBars.None;
        }

        private void MouseEnterSortedFile(object sender, EventArgs e)
        {
            SortedTextbox.ScrollBars = ScrollBars.Vertical;
        }

        private void MouseLeaveSortedFile(object sender, EventArgs e)
        {
            SortedTextbox.ScrollBars = ScrollBars.None;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
