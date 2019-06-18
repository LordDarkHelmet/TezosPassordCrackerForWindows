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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            bypassQuestion = true;
            save = true;
            this.Close();
        }


        private void EditMask_FormClosing(object sender, FormClosingEventArgs e)
        {
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

            textBoxMask.Text = File.ReadAllText(MaskFile);

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

            try
            {
                File.WriteAllText(MaskFile, textBoxMask.Text, Encoding.UTF8);
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
    }
}
