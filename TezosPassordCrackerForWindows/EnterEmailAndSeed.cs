using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace TezosPassordCrackerForWindows
{
    public partial class EnterEmailAndSeed : Form
    {
        public EnterEmailAndSeed()
        {
            InitializeComponent();
        }

        private readonly static string myPythonAppWorkingDirectory = @"johntheripper\run\";
        private readonly static string myPythonAppFile = "tezos2john.py";
        private readonly static string myPythonApp = myPythonAppWorkingDirectory + myPythonAppFile;
        public static string myHashesFile = "DoNotShareTezosSeedEmailAndAddress";
        public static string myHashesFileFull = myPythonAppWorkingDirectory + myHashesFile;

        public static bool DoesHashesFileExist
        {
            get
            {
                return File.Exists(myHashesFileFull);
            }
        }

        private bool GenerateJTR_TezosHashFile(string[] words, string email, string PublicKey)
        {
            //I do all error checking before calling this function 

            if (!File.Exists(myPythonApp))
            {
                //This is not known
                MessageBox.Show("Could Not locate tezos2john.py file.\n\nThe John The Ripper Files Should have been included! Please contact the dev.", "tezos2john.py not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            

            if (words.Length != 15)
            {
                MessageBox.Show("Need exactly 15 seed words", "Seed Word Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }

            int NumberOfWordsNotInBIP39 = 0;
            string IssueText = ""; 
            string[] BIP39Words = System.IO.File.ReadAllLines("BIP39EnglishWordList.txt");
            foreach (string word in words)
            {
                if (!BIP39Words.Contains(word))
                {
                    IssueText += "Seed word \"" + word + "\" does not exist in the BIP39 word list. Check your spelling. " + "\n\n";
                    NumberOfWordsNotInBIP39++;
                }
            }

            if (NumberOfWordsNotInBIP39 > 0)
            {
                MessageBox.Show("Detected bad Seed words:\n\n" + IssueText, "Seed Word Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string args = "\"";
            for (int i = 0; i < words.Length-1; i++)
            {
                args += words[i] + " "; 
            }
            args += words[words.Length - 1] + "\" \"" + email + "\" \"" + PublicKey + "\""; //  | out-file " + myHashesFile + " - encoding utf8";

            //MessageBox.Show(args);

            Process prcPythonCheck = new Process();
            prcPythonCheck.StartInfo.UseShellExecute = false;
            prcPythonCheck.StartInfo.RedirectStandardOutput = true;
            prcPythonCheck.StartInfo.RedirectStandardError = true;
            prcPythonCheck.StartInfo.CreateNoWindow = true;
            prcPythonCheck.StartInfo.FileName = "python";
            prcPythonCheck.StartInfo.Arguments = myPythonAppFile + " " + args;
            prcPythonCheck.StartInfo.ErrorDialog = true;
            prcPythonCheck.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
            prcPythonCheck.StartInfo.WorkingDirectory = myPythonAppWorkingDirectory;
            prcPythonCheck.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8;

            try
            {
                prcPythonCheck.Start();
                string result = prcPythonCheck.StandardOutput.ReadToEnd();
                string errorString = prcPythonCheck.StandardError.ReadToEnd();

                prcPythonCheck.WaitForExit();
                
                if (prcPythonCheck.ExitCode != 0)
                {
                    MessageBox.Show("Error Code " + prcPythonCheck.ExitCode + " Retruned\n\n" + errorString, "Error in Python Script", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                
                if (File.Exists(myHashesFileFull))
                {
                    if(MessageBox.Show("Do you want to overwrite your existing Tezos seed, email, and address settings?", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    {
                        return false;
                    }
                }

                try
                {
                    File.WriteAllText(myHashesFileFull, result, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return ReadMyTezosHashesConfig();

            }
            catch (System.ComponentModel.Win32Exception)
            {
                //This is not known
                MessageBox.Show("Python Not Insalled, or not included in PATH. \n\nThis needs to be fixed before we can continue.", "Python Installed?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //This is not known
                MessageBox.Show("Something with Python is not working.\n\nThis needs to be fixed before we can continue.\n\n" + ex.Message, "Python Issue?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            return false;
        }

        private bool ReadMyTezosHashesConfig()
        {

            if (!File.Exists(myHashesFileFull))
            {
                //This is not known
                Console.WriteLine("Could not locate: " + myHashesFileFull);
                return false;
            }


            //dummy:$tezos$1*2048*update next industry maze one carbon pottery chunk skull strong garden noble canyon crop gain*TezosHelp@outlook.com*tz1eF6A2Wo4UeoCS32bAX167J8BWeg5c9ZLX*a19fcc13b6dd0fb6eec6f498d9cb2bfffc8c4a9e6d6f\r\n

            string[] results = File.ReadAllText(myHashesFileFull).Split('*');

            if (results.Length != 6)
            {
                MessageBox.Show("Number of sections in \""+myHashesFile+"\" should be 6, we detected " + results.Length, "Bad Format in File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            textBoxSeed.Text = results[2];
            textBoxEmail.Text = results[3];
            textBoxPublicKey.Text = results[4];

            return true;
 
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            

            bool ShouldICancel = false;

            string[] words = textBoxSeed.Text.Replace(System.Environment.NewLine, " ").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string IssueText = "";

            if (words.Length != 15)
            {
                IssueText += "There must be 15 seed words. Please check your PDF and copy the values exactly." + "\n\n";
                ShouldICancel = true;
            }

            string[] BIP39Words = System.IO.File.ReadAllLines("BIP39EnglishWordList.txt");
            foreach (string word in words)
            {
                if (!BIP39Words.Contains(word))
                {
                    IssueText += "Seed word \"" + word + "\" does not exist in the BIP39 word list. Check your spelling. " + "\n\n";
                    ShouldICancel = true;
                }
            }

            textBoxEmail.Text = textBoxEmail.Text.Trim(new char[] { ' ' });
            textBoxPublicKey.Text = textBoxPublicKey.Text.Trim(new char[] { ' ' });

            if (textBoxEmail.Text == "")
            {
                IssueText += "Your Email address is empty. Please copy the email address you used exactly." + "\n\n";
                ShouldICancel = true;
            }

            if (textBoxPublicKey.Text == "")
            {
                IssueText += "Your Tezos Public Address is empty. Please copy the address exactly." + "\n\n";
                ShouldICancel = true;
            }

            if (ShouldICancel)
            {
                MessageBox.Show(IssueText, "Issues", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GenerateJTR_TezosHashFile(words, textBoxEmail.Text, textBoxPublicKey.Text);
            }

        }

        private void EnterEmailAndSeed_Load(object sender, EventArgs e)
        {
            Process prcPythonCheck = new Process();
            prcPythonCheck.StartInfo.UseShellExecute = false;
            prcPythonCheck.StartInfo.RedirectStandardOutput = true;
            prcPythonCheck.StartInfo.CreateNoWindow = true;
            prcPythonCheck.StartInfo.FileName = "python";
            prcPythonCheck.StartInfo.Arguments = "--version";

            try
            {
                prcPythonCheck.Start();
                string result = prcPythonCheck.StandardOutput.ReadToEnd();
                prcPythonCheck.WaitForExit();

                // TODO: Get version and display it
                Console.WriteLine("Python Version: " + result);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                //This is not known
                MessageBox.Show("Python Not Insalled, or not included in PATH. \n\nThis needs to be fixed before we can continue.", "Python Installed?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                //This is not known
                MessageBox.Show("Something with Python is not working.\n\nThis needs to be fixed before we can continue.\n\n" + ex.Message, "Python Issue?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            
            if (!File.Exists(myPythonApp))
            {
                //This is not known
                MessageBox.Show("Could Not locate tezos2john.py file.\n\nThe John The Ripper Files Should have been included! Please contact the dev.", "tezos2john.py not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ReadMyTezosHashesConfig();
            
        }
    }
}
