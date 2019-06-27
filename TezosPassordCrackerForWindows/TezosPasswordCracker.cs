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
using System.Threading;
using System.Runtime.InteropServices;

namespace TezosPassordCrackerForWindows
{
    public partial class TezosPasswordCracker : Form
    {

        private const string JTRExecutableDirectory = @"johntheripper\run\";
        private const string JTRMaskDocument = @"johntheripper\doc\MASK.txt";
        private const string JTRExecutableName = @"john.exe";
        private const string JTRExecutableFull = JTRExecutableDirectory + JTRExecutableName;
        private const int NumberOfSecondsBetweenUpdates = 10;
        private const string DefaultSessionName = "TezosXTZRecovery";
        private const string DefaultMaskName = DefaultSessionName + "Mask";
        private const string DefaultMaskFile = JTRExecutableDirectory + DefaultMaskName + ".txt";
        private const string DefaultBestGuessName = DefaultSessionName + "BestGuess";
        private const string DefaultBestGuessFile = JTRExecutableDirectory + DefaultBestGuessName + ".txt";


        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        const uint WM_KEYDOWN = 0x0100;
        //const uint WM_KEYUP = 0x0101;

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);






        public TezosPasswordCracker()
        {
            InitializeComponent();

        }

        private void ButtonGenerateHashesFile_Click(object sender, EventArgs e)
        {
            EnterEmailAndSeed z = new EnterEmailAndSeed();
            if (z.ShowDialog() == DialogResult.Yes)
            {
                SetRichTextBoxText("\n" + "New Hashfile Created. Backup all current session files", Color.Blue);

                //If we are running. Stop.
                SendStopMessageToJohnTheRipper();

                //backup all Sessions
                BackupSessionFiles(DefaultSessionName);
                BackupSessionFiles(DefaultMaskName);

                DetectSolvedPassword();
            }
            CheckForHashFile();
        }

        private bool BackupSessionFiles(string sessionName)
        {
            try
            {
                string myTime = DateTime.Now.ToString("MMM'-'dd'-'yyyy_HHmmss");

                if (File.Exists(JTRExecutableDirectory + sessionName + ".rec"))
                {
                    SetRichTextBoxText("\n" + "Backing up previous session.", Color.Blue);
                    File.Move(JTRExecutableDirectory + sessionName + ".rec", JTRExecutableDirectory + sessionName + "Backup" + myTime + ".rec");
                    SetRichTextBoxText("\n" + "Backup complte: " + sessionName + "Backup" + myTime + ".rec", Color.Blue);
                }
                if (File.Exists(JTRExecutableDirectory + sessionName + ".log"))
                {
                    File.Move(JTRExecutableDirectory + sessionName + ".log", JTRExecutableDirectory + sessionName + "Backup" + myTime + ".log");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex.Message, "Session Backup Error ("+sessionName+")", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }


        private Thread threadJTR;


        private void ButtonBestGuess_Click(object sender, EventArgs e)
        {
            //LaunchThreadWithInfo(false, DefaultSessionName, "Best Guess", "");
            MessageBox.Show("This is for the next version. Write to me at TezosHelp@outlook.com if you would like to see it implemented.");
        }

        private void ButtonMask_Click(object sender, EventArgs e)
        {
            //if file not found
            if (File.Exists(DefaultMaskFile))
            {
                LaunchThreadWithInfo(false, DefaultMaskName, "Mask", " --mask=" + File.ReadAllText(DefaultMaskFile) + " ");
            }
            else
            {
                EditMaskFile();
            }
 
        }

        private void ButtonMaskEdit_Click(object sender, EventArgs e)
        {
            EditMaskFile();
        }

        private void EditMaskFile()
        {
            //Launch the form
            EditMask editMaskForm = new EditMask(DefaultMaskFile, JTRMaskDocument);
            if (DialogResult.Yes == editMaskForm.ShowDialog())
            {
                //We changed the mask file. 
                //Stop Current Progress
                SendStopMessageToJohnTheRipper();

                //backup current sessions
                BackupSessionFiles(DefaultMaskName);

                //Start
                if (File.Exists(DefaultMaskFile))
                {
                    SetRichTextBoxText("\n" + "Attempting to start a new session ... ", Color.Blue);
                    LaunchThreadWithInfo(true, DefaultMaskName, "Mask", " --mask=" +File.ReadAllText(DefaultMaskFile) + " ");
                }
            }
            else
            {
                SetRichTextBoxText("\n" + "Mask File Unchanged. No action Taken", Color.Blue);
            }

            CheckForMaskFile();
        }


        private void ButtonBruteForce_Click(object sender, EventArgs e)
        {
            LaunchThreadWithInfo(false, DefaultSessionName, "Brute Force", "");
        }


        private void LaunchThreadWithInfo(bool forceRestart, string sessionName, string SessionType, string attributes)
        {
            bool startNewThread = true;

            if (threadJTR == null) { threadJTR = new Thread(JTRThreadMethod); }

            if (prcPythonCheck != null)
            {
                if (!prcPythonCheck.HasExited)
                {
                    if (forceRestart)
                    {
                        //stop thread
                        ForceThreadClose();

                    }
                    else
                    {
                        if (DialogResult.Yes != MessageBox.Show(myCurrentSessionType + " session already running, Do you want to close and restart a " + SessionType + " session?", "Start a new session?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {

                            startNewThread = false;
                        }
                        else
                        {
                            ForceThreadClose();
                        }
                    }
                }
            }

            if (startNewThread)
            {
                threadJTR = new Thread(JTRThreadMethod);
                threadJTR.Start(SessionManagement(sessionName, attributes));
                myCurrentSessionType = SessionType;
            }
        }

        private string SessionManagement(string sessionName, string attributes, bool overwrite=false)
        {
            sessionName = sessionName.Replace(" ", "_");

            if (sessionName == "")
            {
                sessionName = DefaultSessionName;
            }

            string theCommandLineAttributeThatWeShouldUse;

            //Does the session exist?
            if (File.Exists(JTRExecutableDirectory + sessionName + ".rec"))
            {
                //If so do we want to continue or overwrite?
                if (overwrite)
                {
                    //overwrite
                    theCommandLineAttributeThatWeShouldUse = " --session=" + JTRExecutableDirectory + sessionName + " " + attributes + " " + EnterEmailAndSeed.myHashesFileFull;
                    SetRichTextBoxText("\n" + "Session " + sessionName + " already exists, we will overwite all progress and start.", Color.Blue);
                }
                else
                {
                    //continue
                    theCommandLineAttributeThatWeShouldUse = " --restore=" + JTRExecutableDirectory + sessionName + " ";
                    SetRichTextBoxText("\n" + "Session " + sessionName + " already exists, we will resume the existing session.", Color.Blue);
                }                
            }
            else
            {
                //This is a new session.
                theCommandLineAttributeThatWeShouldUse = " --session=" + JTRExecutableDirectory + sessionName + " " + attributes + " " + EnterEmailAndSeed.myHashesFileFull;
                SetRichTextBoxText("\n" + "Session " + sessionName + " does not yet exist, starting a new session.", Color.Blue);
            }
            
            return theCommandLineAttributeThatWeShouldUse;

        }

        private Process prcPythonCheck;
        private System.Timers.Timer myTimerKeyboardInputToJohn;
        private System.Timers.Timer myTimerCheckOnJohn;
        private String myCurrentSessionType = "";

        public void JTRThreadMethod(object attributes)
        {


            if (prcPythonCheck != null) prcPythonCheck.Dispose();
            prcPythonCheck = new Process();
            prcPythonCheck.StartInfo.UseShellExecute = false;
            prcPythonCheck.StartInfo.RedirectStandardOutput = true;
            prcPythonCheck.StartInfo.RedirectStandardError = true;
            //prcPythonCheck.StartInfo.RedirectStandardInput = true;
            prcPythonCheck.StartInfo.CreateNoWindow = false;
            prcPythonCheck.StartInfo.FileName = JTRExecutableFull;
            prcPythonCheck.StartInfo.Arguments = " " + attributes;
            prcPythonCheck.StartInfo.ErrorDialog = true;
            prcPythonCheck.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            prcPythonCheck.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
            //prcPythonCheck.StartInfo.WorkingDirectory = JTRExecutableDirectory;
            prcPythonCheck.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8;
            prcPythonCheck.OutputDataReceived += new DataReceivedEventHandler(JTROutputHandler);
            prcPythonCheck.ErrorDataReceived += new DataReceivedEventHandler(JTRErrorOutputHandler);
            prcPythonCheck.Exited += PrcPythonCheck_Exited;

            try
            {
                SetRichTextBoxText("\n\n" + "Command: " + prcPythonCheck.StartInfo.FileName + " " + prcPythonCheck.StartInfo.Arguments, Color.Purple);
                SetRichTextBoxText("\nStart: " + DateTime.Now.ToString(), Color.Purple);
                prcPythonCheck.Start();

                prcPythonCheck.BeginOutputReadLine();
                prcPythonCheck.BeginErrorReadLine();



                //This timer is neccesary becasue we do not get an exit event unless we check if it has exited. Not sure why. 
                myTimerCheckOnJohn = new System.Timers.Timer();
                myTimerCheckOnJohn.Elapsed += MyTimerCheckOnJohn_Elapsed;
                myTimerCheckOnJohn.Interval = 500;
                myTimerCheckOnJohn.Start();

                Thread.Sleep(250);
                SetRichTextBoxText("\n" + "Minimizing JTW Console Window, This app issues commands via a fake keyboard. Output is displayed in this message box.", Color.Blue);
                if (!prcPythonCheck.HasExited) ShowWindow(prcPythonCheck.MainWindowHandle, 11);

                Thread.Sleep(2 * 1000);
                if (!prcPythonCheck.HasExited) SetRichTextBoxText("\n" + "We will check progress every " + NumberOfSecondsBetweenUpdates + " Seconds", Color.Blue);
                myTimerKeyboardInputToJohn = new System.Timers.Timer();
                MyTimerKeyboardInputToJohn_Elapsed();
                myTimerKeyboardInputToJohn.Elapsed += MyTimerKeyboardInputToJohn_Elapsed;
                myTimerKeyboardInputToJohn.Interval = NumberOfSecondsBetweenUpdates * 1000;
                myTimerKeyboardInputToJohn.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
        }

        private void MyTimerCheckOnJohn_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                //We are only doing this check becuase if we don't check the exited event is not raised. Not sure why. 
                if (prcPythonCheck.HasExited)
                {
                    //Do this so the compiler does not elimiate the above check for efficiency. 
                    myTimerKeyboardInputToJohn.Stop();
                }
            }
            catch (Exception)
            {

            }
            
              
        }

        private void MyTimerKeyboardInputToJohn_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MyTimerKeyboardInputToJohn_Elapsed();
        }
        private void MyTimerKeyboardInputToJohn_Elapsed()
        {
            try
            {
                ShowWindow(prcPythonCheck.MainWindowHandle, 11); //Minimize Window. 2 = SW_MINIMIZE
            }
            catch (Exception)
            {

            }
             

            try
            {
                if (prcPythonCheck.HasExited)
                {
                    myTimerKeyboardInputToJohn.Stop();
                }
                else
                {
                    PostMessage(prcPythonCheck.MainWindowHandle, WM_KEYDOWN, (IntPtr)(Keys.A), IntPtr.Zero);
                }
            }
            catch (Exception ex)
            {
                SetRichTextBoxText("\nError (minor): Keyboard to John Timer Issue: " + ex.Message + "\n", Color.Red);
            }
        }

        public void PrcPythonCheck_Exited(object sender, EventArgs e)
        {
            if (myTimerKeyboardInputToJohn != null) myTimerKeyboardInputToJohn.Stop();
            if (myTimerCheckOnJohn != null) myTimerCheckOnJohn.Stop();
            SetRichTextBoxText("\nExit: " + prcPythonCheck.ExitTime.ToString() + " Exit Code:" + prcPythonCheck.ExitCode + "\n", Color.Purple);
            DetectSolvedPassword();
        }

        private void JTROutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (outLine.Data != null)
            {
                SetRichTextBoxText("\n" + outLine.Data.ToString(), Color.Black);
                if (outLine.Data.Contains("(dummy)"))
                {
                    string myPassword = outLine.Data.Substring(0, outLine.Data.Length - 7);
                    SetRichTextBoxText("\n" + "Password Found:" + myPassword, Color.Green);
                    SetTextBoxPassword(myPassword, Color.Green);

                }
            }
        }



        private void JTRErrorOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (outLine.Data != null)
            {
                SetRichTextBoxText("\n" + outLine.Data.ToString(), Color.Red);

                if (outLine.Data.ToString().Contains("Crash recovery file is locked"))
                {
                    ForceThreadClose();
                    SetRichTextBoxText("\n" + "Locked File Detected. Use Task Manager to close John or restart your computer\n" + outLine.Data.ToString(), Color.Red);
                    SetRichTextBoxText("\n" + "Locked File Detected. Use Task Manager to close John or restart your computer\n" + outLine.Data.ToString(), Color.Purple);
                    SetRichTextBoxText("\n" + "Locked File Detected. Use Task Manager to close John or restart your computer\n" + outLine.Data.ToString(), Color.Blue);
                    MessageBox.Show("Locked File Detected. Use Task Manager to close John or restart your computer\n\n" + outLine.Data.ToString(), "Locked File Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private delegate void SetRichTextBoxTextInvoker(string text, Color myColor);
        private void SetRichTextBoxText(string text, Color myColor)
        {
            try
            {
                            
                if (richTextBoxJTROutput.InvokeRequired)
                {
                    richTextBoxJTROutput.Invoke(new SetRichTextBoxTextInvoker(SetRichTextBoxText), text, myColor);
                }
                else
                {
                    if (richTextBoxJTROutput.IsDisposed)
                    {
                        return;
                    }

                    richTextBoxJTROutput.Select(richTextBoxJTROutput.TextLength, 0);

                    richTextBoxJTROutput.SelectionColor = myColor;

                    richTextBoxJTROutput.AppendText(text);

                    richTextBoxJTROutput.SelectionStart = richTextBoxJTROutput.Text.Length;

                    richTextBoxJTROutput.ScrollToCaret();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private delegate void SetTextBoxPasswordInvoker(string text, Color myColor);
        private void SetTextBoxPassword(string text, Color myColor)
        {
            try
            {

                if (textBoxPassword.InvokeRequired)
                {
                    textBoxPassword.Invoke(new SetTextBoxPasswordInvoker(SetTextBoxPassword), text, myColor);
                }
                else
                {
                    if (textBoxPassword.IsDisposed)
                    {
                        return;
                    }

                    textBoxPassword.Select(textBoxPassword.TextLength, 0);

                    textBoxPassword.BackColor = myColor;

                    textBoxPassword.Text = text;

                    textBoxPassword.SelectionStart = textBoxPassword.Text.Length;

                    textBoxPassword.ScrollToCaret();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void TezosPasswordCracker_Load(object sender, EventArgs e)
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
                MessageBox.Show("Python Not Insalled, or not included in PATH. \n\nThis needs to be fixed before we can continue.\n\nYou need to download, and install python. \nhttps://www.python.org/downloads/release/python-373/\nRemember to check \"Add Python 3.7 to PATH\" when installing.", "Python Installed?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                //This is not known
                MessageBox.Show("Something with Python is not working.\n\nThis needs to be fixed before we can continue.\n\n" + ex.Message, "Python Issue?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


            if (!File.Exists(JTRExecutableFull))
            {
                //This is not known
                MessageBox.Show("Could Not locate " + JTRExecutableName + ".\n\nThe John The Ripper Files Should have been included! Please contact the dev.", JTRExecutableName + " not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            CheckForHashFile();
            CheckForMaskFile();
            CheckForBestGuessFile();
            DetectSolvedPassword();

            this.Name = "Tezos XTZ Recovery  -  Version " + Application.ProductVersion;
        }

        private void CheckForHashFile()
        {
            if (EnterEmailAndSeed.DoesHashesFileExist)
            {
                labelStep1.Text = "Step 1: Complete, Your Infomation has been loaded.";
                labelStep1.ForeColor = Color.Green;
                buttonGenerateHashesFile.Text = "Edit Information";
                buttonGenerateHashesFile.Font = new Font(buttonGenerateHashesFile.Font.Name, buttonGenerateHashesFile.Font.Size, FontStyle.Regular);
                buttonBestGuess.Enabled = buttonMask.Enabled = buttonBruteForce.Enabled = buttonMaskEdit.Enabled = buttonBestGuessEdit.Enabled = true;
            }
            else
            {
                labelStep1.Text = "Step 1: Incomplete, you need to fill out your information.";
                labelStep1.ForeColor = Color.Red;
                buttonGenerateHashesFile.Text = "Add Information";
                buttonGenerateHashesFile.Font = new Font(buttonGenerateHashesFile.Font.Name, buttonGenerateHashesFile.Font.Size, FontStyle.Bold);
                buttonBestGuess.Enabled = buttonMask.Enabled = buttonBruteForce.Enabled = buttonMaskEdit.Enabled = buttonBestGuessEdit.Enabled = false;
            }
        }

        private void CheckForMaskFile()
        {
            if (File.Exists(DefaultMaskFile))
            {
                buttonMaskEdit.Visible = true;
            }
            else
            {
                buttonMaskEdit.Visible = false;
            }
        }

        private void CheckForBestGuessFile()
        {
            if (File.Exists(DefaultBestGuessFile))
            {
                buttonBestGuessEdit.Visible = true;
            }
            else
            {
                buttonBestGuessEdit.Visible = false;
            }
        }

        private void TezosPasswordCracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            ForceThreadClose();
        }

        private void ForceThreadClose()
        {
            if (prcPythonCheck != null)
            {

                SendStopMessageToJohnTheRipper();
                for (int i = 0; i < 3000; i += 50)
                {
                    if (prcPythonCheck != null)
                    {
                        if (!prcPythonCheck.HasExited)
                        {
                            Thread.Sleep(50);
                        }
                        else
                        {
                            break;
                        }
                    }
                }


            }
            if (prcPythonCheck != null)
            {
                if (!prcPythonCheck.HasExited)
                {
                    SetRichTextBoxText("\n" + "Sending kill message to stop the process.", Color.Blue);
                    prcPythonCheck.Kill();
                }
            }


        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            SendStopMessageToJohnTheRipper();
        }

        public void SendStopMessageToJohnTheRipper()
        {
            if (prcPythonCheck != null)
            {
                if (!prcPythonCheck.HasExited)
                {
                    SetRichTextBoxText("\n" + "Sending \"q\" as the quit message.", Color.Blue);
                    PostMessage(prcPythonCheck.MainWindowHandle, WM_KEYDOWN, (IntPtr)(Keys.Q), IntPtr.Zero);
                }
                else
                {
                    SetRichTextBoxText("\n" + "We have already exited, stop not sent.", Color.Blue);
                }
            }
            else
            {
                SetRichTextBoxText("\n" + "Nothing to send a stop to.", Color.Blue);
            }
        }

        private void LinkLabelTelegram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://t.me/xtzrecovery");
        }

        private void PictureBoxRecovery_Click(object sender, EventArgs e)
        {
            About myAbout = new About();
            myAbout.ShowDialog();
        }

        private void LinkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/LordDarkHelmet/TezosPassordCrackerForWindows");
        }

        private void LinkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:TezosHelp@outlook.com");
        }

        private bool DetectSolvedPassword()
        {
            string passwordFoundFile = JTRExecutableDirectory + "john.pot";
            if (File.Exists(passwordFoundFile) && File.Exists(EnterEmailAndSeed.myHashesFileFull))
            {
                string[] results = File.ReadAllLines(passwordFoundFile);
                foreach (string result in results)
                {
                    try
                    {
                        if (File.ReadAllText(EnterEmailAndSeed.myHashesFileFull).Contains(result.Split(':')[0]))
                        {
                            if (result != string.Empty)
                            {
                                string myPassword = result.Split(':')[1];
                                SetTextBoxPassword(myPassword, Color.Green);
                                return true;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }

            }
            return false;
        }

        private void LinkLabelDonationTezos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Thank you for donating. 
            Clipboard.SetText(linkLabelDonationTezos.Text);

            if (DialogResult.Yes == MessageBox.Show("Thank you for your support! Our work is donation based. \nThe Tezos address " + linkLabelDonationTezos.Text + " has been copied to your clipboard.\n\nWould you like to see the donation address?", "Thank you!", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                Process.Start(@"https://tzscan.io/" + linkLabelDonationTezos.Text);
            }
        }

        private void LinkLabelDonationBTC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Thank you for donating. 
            Clipboard.SetText(linkLabelDonationBTC.Text);

            if (DialogResult.Yes == MessageBox.Show("Thank you for your support! Our work is donation based. \nThe Bitcoin address " + linkLabelDonationBTC.Text + " has been copied to your clipboard.\n\nWould you like to see the donation address?", "Thank you!", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                Process.Start(@"https://www.blockchain.com/btc/address/" + linkLabelDonationBTC.Text);
            }
        }
    }

}
