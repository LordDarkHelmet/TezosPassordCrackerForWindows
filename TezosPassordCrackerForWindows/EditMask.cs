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

namespace TezosPassordCrackerForWindows
{
    public partial class EditMask : Form
    {

        private const string WORDLIST_KEYWORD = " --wordlist=";

        private string MaskFile;
        private string JTRMaskDocument;

        public EditMask(string defaultMaskFile, string JTRMaskDoc)
        {
            MaskFile = defaultMaskFile;
            JTRMaskDocument = JTRMaskDoc;
            InitializeComponent();
            DialogResult = DialogResult.No;
        }

        bool bypassQuestion = false;
        bool save = false;
        bool justExit = false;

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            bypassQuestion = true;
            save = true;
            if (WriteMyTezosMaskFile())
            {
                justExit = true;
                this.Close();
            }
            else
            {
                save = false;
            }
        }


        private void EditMask_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (justExit)
            {
                return;
            }
            if (bypassQuestion)
            {
                if (save)
                {
                    WriteMyTezosMaskFile();
                }
            }
            else if (MessageBox.Show("Do you want to save?","Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WriteMyTezosMaskFile();
            }
        }

        private void EditMask_Load(object sender, EventArgs e)
        {
            ReadMyTezosMaskFile();

            try
            {
                richTextBoxJTRMaskDoc.Text = File.ReadAllText(JTRMaskDocument);
            }
            catch (Exception ex)
            {
                richTextBoxJTRMaskDoc.Text = "Error Loading Mask Document!\n\n" + ex.Message;
            }
            
        }

        private bool ReadMyTezosMaskFile()
        {
            if (!File.Exists(MaskFile))
            {
                //This is not known
                Console.WriteLine("Could not locate: " + MaskFile);
                return false;
            }

            string[] myDelimiter = new string[1];
            myDelimiter[0] = WORDLIST_KEYWORD;

            string[] myStuff = File.ReadAllText(MaskFile).Split(myDelimiter, StringSplitOptions.RemoveEmptyEntries);

            if (myStuff.Length >= 1)
            {
                textBoxMask.Text = myStuff[0];
            }

            if (myStuff.Length >= 2)
            {
                textBoxWordListFile.Text = myStuff[1];
            }

            return true;
        }

        private bool WriteMyTezosMaskFile()
        {
            if (File.Exists(MaskFile))
            {
                if (MessageBox.Show("Do you want to overwrite your existing mask file?\n\nThis will stop any current session, backup the session, then start a new one.", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                {
                    return false;
                }
            }

            if (textBoxMask.Text == "")
            {
                MessageBox.Show("Mask Cannot be blank. Please Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string myStuffToSave = textBoxMask.Text;

            //Now lets validate the word list
            textBoxWordListFile.Text = textBoxWordListFile.Text.Trim();

            if (textBoxWordListFile.Text != string.Empty)
            {
                //lets add the word list 

                //Does that file exist?
                if (!File.Exists(textBoxWordListFile.Text))
                {
                    MessageBox.Show("Word List File Does Not Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                myStuffToSave += WORDLIST_KEYWORD + textBoxWordListFile.Text;
            }

            try
            {
                File.WriteAllText(MaskFile, myStuffToSave, Encoding.UTF8);
                DialogResult = DialogResult.Yes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return ReadMyTezosMaskFile();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            bypassQuestion = true;
            save = false;
            Close();
        }

        private void ButtonAddWordList_Click(object sender, EventArgs e)
        {


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                try
                {
                    if (Directory.Exists(Path.GetDirectoryName(textBoxWordListFile.Text)))
                    {
                        openFileDialog.InitialDirectory = Path.GetDirectoryName(textBoxWordListFile.Text);
                    }
                }
                catch (Exception)
                {
                    
                }


                openFileDialog.Filter = "Wordlist (*.txt, *.lst)|*.txt;*.lst|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    textBoxWordListFile.Text = openFileDialog.FileName;

                }
            }
        }
    }
}
