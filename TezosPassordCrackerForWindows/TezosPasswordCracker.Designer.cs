namespace TezosPassordCrackerForWindows
{
    partial class TezosPasswordCracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TezosPasswordCracker));
            this.buttonGenerateHashesFile = new System.Windows.Forms.Button();
            this.labelStep2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.richTextBoxJTROutput = new System.Windows.Forms.RichTextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStep3 = new System.Windows.Forms.Label();
            this.labelStep4 = new System.Windows.Forms.Label();
            this.labelStep1 = new System.Windows.Forms.Label();
            this.buttonBruteForce = new System.Windows.Forms.Button();
            this.buttonBestGuess = new System.Windows.Forms.Button();
            this.buttonMask = new System.Windows.Forms.Button();
            this.buttonBestGuessEdit = new System.Windows.Forms.Button();
            this.buttonMaskEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelTelegram = new System.Windows.Forms.LinkLabel();
            this.groupBoxResources = new System.Windows.Forms.GroupBox();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.textBoxDeveloperInfo = new System.Windows.Forms.TextBox();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.textBoxEmailSupport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResources.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerateHashesFile
            // 
            this.buttonGenerateHashesFile.Location = new System.Drawing.Point(12, 98);
            this.buttonGenerateHashesFile.Name = "buttonGenerateHashesFile";
            this.buttonGenerateHashesFile.Size = new System.Drawing.Size(130, 51);
            this.buttonGenerateHashesFile.TabIndex = 0;
            this.buttonGenerateHashesFile.Text = "Generate";
            this.buttonGenerateHashesFile.UseVisualStyleBackColor = true;
            this.buttonGenerateHashesFile.Click += new System.EventHandler(this.ButtonGenerateHashesFile_Click);
            // 
            // labelStep2
            // 
            this.labelStep2.AutoSize = true;
            this.labelStep2.Location = new System.Drawing.Point(9, 161);
            this.labelStep2.Name = "labelStep2";
            this.labelStep2.Size = new System.Drawing.Size(433, 17);
            this.labelStep2.TabIndex = 2;
            this.labelStep2.Text = "Step 2: Masks are a effective when  you might know  your password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(12, 22);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(1033, 41);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(9, 2);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(306, 17);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "When a Password is found, we will show it here!";
            // 
            // richTextBoxJTROutput
            // 
            this.richTextBoxJTROutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxJTROutput.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxJTROutput.Location = new System.Drawing.Point(12, 454);
            this.richTextBoxJTROutput.Name = "richTextBoxJTROutput";
            this.richTextBoxJTROutput.Size = new System.Drawing.Size(1033, 257);
            this.richTextBoxJTROutput.TabIndex = 7;
            this.richTextBoxJTROutput.Text = "";
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Location = new System.Drawing.Point(918, 418);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(127, 30);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Universal Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "John The Ripper Output: This is a view of the password breaking process. ";
            // 
            // labelStep3
            // 
            this.labelStep3.AutoSize = true;
            this.labelStep3.Location = new System.Drawing.Point(9, 247);
            this.labelStep3.Name = "labelStep3";
            this.labelStep3.Size = new System.Drawing.Size(402, 17);
            this.labelStep3.TabIndex = 10;
            this.labelStep3.Text = "Step 3: Reserved for future capability. Contact us for requests ";
            // 
            // labelStep4
            // 
            this.labelStep4.AutoSize = true;
            this.labelStep4.Location = new System.Drawing.Point(9, 338);
            this.labelStep4.Name = "labelStep4";
            this.labelStep4.Size = new System.Drawing.Size(1047, 17);
            this.labelStep4.TabIndex = 11;
            this.labelStep4.Text = "Step 4: Brute Force, this is the longest version and will take the most amount of" +
    " time. I recomend that you learn more about rules and masks if your password is " +
    "long. ";
            // 
            // labelStep1
            // 
            this.labelStep1.AutoSize = true;
            this.labelStep1.Location = new System.Drawing.Point(9, 78);
            this.labelStep1.Name = "labelStep1";
            this.labelStep1.Size = new System.Drawing.Size(49, 17);
            this.labelStep1.TabIndex = 12;
            this.labelStep1.Text = "Step 1";
            // 
            // buttonBruteForce
            // 
            this.buttonBruteForce.Location = new System.Drawing.Point(12, 358);
            this.buttonBruteForce.Name = "buttonBruteForce";
            this.buttonBruteForce.Size = new System.Drawing.Size(130, 51);
            this.buttonBruteForce.TabIndex = 13;
            this.buttonBruteForce.Text = "Start Brute Force";
            this.buttonBruteForce.UseVisualStyleBackColor = true;
            this.buttonBruteForce.Click += new System.EventHandler(this.ButtonBruteForce_Click);
            // 
            // buttonBestGuess
            // 
            this.buttonBestGuess.Location = new System.Drawing.Point(12, 267);
            this.buttonBestGuess.Name = "buttonBestGuess";
            this.buttonBestGuess.Size = new System.Drawing.Size(130, 51);
            this.buttonBestGuess.TabIndex = 14;
            this.buttonBestGuess.Text = "Start Best Guess";
            this.buttonBestGuess.UseVisualStyleBackColor = true;
            this.buttonBestGuess.Click += new System.EventHandler(this.ButtonBestGuess_Click);
            // 
            // buttonMask
            // 
            this.buttonMask.Location = new System.Drawing.Point(12, 181);
            this.buttonMask.Name = "buttonMask";
            this.buttonMask.Size = new System.Drawing.Size(130, 51);
            this.buttonMask.TabIndex = 15;
            this.buttonMask.Text = "Start Mask";
            this.buttonMask.UseVisualStyleBackColor = true;
            this.buttonMask.Click += new System.EventHandler(this.ButtonMask_Click);
            // 
            // buttonBestGuessEdit
            // 
            this.buttonBestGuessEdit.Location = new System.Drawing.Point(148, 267);
            this.buttonBestGuessEdit.Name = "buttonBestGuessEdit";
            this.buttonBestGuessEdit.Size = new System.Drawing.Size(75, 51);
            this.buttonBestGuessEdit.TabIndex = 16;
            this.buttonBestGuessEdit.Text = "Edit";
            this.buttonBestGuessEdit.UseVisualStyleBackColor = true;
            this.buttonBestGuessEdit.Visible = false;
            // 
            // buttonMaskEdit
            // 
            this.buttonMaskEdit.Location = new System.Drawing.Point(148, 181);
            this.buttonMaskEdit.Name = "buttonMaskEdit";
            this.buttonMaskEdit.Size = new System.Drawing.Size(75, 51);
            this.buttonMaskEdit.TabIndex = 17;
            this.buttonMaskEdit.Text = "Edit";
            this.buttonMaskEdit.UseVisualStyleBackColor = true;
            this.buttonMaskEdit.Visible = false;
            this.buttonMaskEdit.Click += new System.EventHandler(this.ButtonMaskEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // linkLabelTelegram
            // 
            this.linkLabelTelegram.AutoSize = true;
            this.linkLabelTelegram.Location = new System.Drawing.Point(403, 82);
            this.linkLabelTelegram.Name = "linkLabelTelegram";
            this.linkLabelTelegram.Size = new System.Drawing.Size(166, 17);
            this.linkLabelTelegram.TabIndex = 20;
            this.linkLabelTelegram.TabStop = true;
            this.linkLabelTelegram.Text = "Telegram Support Group";
            this.linkLabelTelegram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelTelegram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelTelegram_LinkClicked);
            // 
            // groupBoxResources
            // 
            this.groupBoxResources.Controls.Add(this.textBoxEmailSupport);
            this.groupBoxResources.Controls.Add(this.linkLabelTelegram);
            this.groupBoxResources.Controls.Add(this.linkLabelEmail);
            this.groupBoxResources.Controls.Add(this.pictureBox1);
            this.groupBoxResources.Controls.Add(this.textBoxDeveloperInfo);
            this.groupBoxResources.Controls.Add(this.linkLabelGitHub);
            this.groupBoxResources.Controls.Add(this.textBoxAbout);
            this.groupBoxResources.Location = new System.Drawing.Point(470, 68);
            this.groupBoxResources.Name = "groupBoxResources";
            this.groupBoxResources.Size = new System.Drawing.Size(575, 235);
            this.groupBoxResources.TabIndex = 21;
            this.groupBoxResources.TabStop = false;
            this.groupBoxResources.Text = "Additional Resources";
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout.Enabled = false;
            this.textBoxAbout.Location = new System.Drawing.Point(212, 21);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.ReadOnly = true;
            this.textBoxAbout.Size = new System.Drawing.Size(357, 58);
            this.textBoxAbout.TabIndex = 21;
            this.textBoxAbout.Text = "This program was made by the Tezos XTZ Recovery group. It is here to make crackin" +
    "g your password a little bit easier for Windows 10. If you need help, please joi" +
    "n out group.";
            // 
            // textBoxDeveloperInfo
            // 
            this.textBoxDeveloperInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDeveloperInfo.Enabled = false;
            this.textBoxDeveloperInfo.Location = new System.Drawing.Point(212, 123);
            this.textBoxDeveloperInfo.Multiline = true;
            this.textBoxDeveloperInfo.Name = "textBoxDeveloperInfo";
            this.textBoxDeveloperInfo.ReadOnly = true;
            this.textBoxDeveloperInfo.Size = new System.Drawing.Size(329, 21);
            this.textBoxDeveloperInfo.TabIndex = 23;
            this.textBoxDeveloperInfo.Text = "You can contact the development team on  GitHub:";
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(403, 147);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(169, 17);
            this.linkLabelGitHub.TabIndex = 22;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "GitHub (LordDarkHelmet)";
            this.linkLabelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGitHub_LinkClicked);
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.Location = new System.Drawing.Point(403, 199);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(166, 17);
            this.linkLabelEmail.TabIndex = 24;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "TezosHelp@outlook.com";
            this.linkLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelEmail_LinkClicked);
            // 
            // textBoxEmailSupport
            // 
            this.textBoxEmailSupport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmailSupport.Enabled = false;
            this.textBoxEmailSupport.Location = new System.Drawing.Point(212, 179);
            this.textBoxEmailSupport.Multiline = true;
            this.textBoxEmailSupport.Name = "textBoxEmailSupport";
            this.textBoxEmailSupport.ReadOnly = true;
            this.textBoxEmailSupport.Size = new System.Drawing.Size(329, 17);
            this.textBoxEmailSupport.TabIndex = 25;
            this.textBoxEmailSupport.Text = "You can send an email to us.";
            // 
            // TezosPasswordCracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 723);
            this.Controls.Add(this.groupBoxResources);
            this.Controls.Add(this.buttonMaskEdit);
            this.Controls.Add(this.buttonBestGuessEdit);
            this.Controls.Add(this.buttonMask);
            this.Controls.Add(this.buttonBestGuess);
            this.Controls.Add(this.buttonBruteForce);
            this.Controls.Add(this.labelStep1);
            this.Controls.Add(this.labelStep4);
            this.Controls.Add(this.labelStep3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.richTextBoxJTROutput);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelStep2);
            this.Controls.Add(this.buttonGenerateHashesFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TezosPasswordCracker";
            this.Text = "Tezos XTZ Recovery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TezosPasswordCracker_FormClosing);
            this.Load += new System.EventHandler(this.TezosPasswordCracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResources.ResumeLayout(false);
            this.groupBoxResources.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateHashesFile;
        private System.Windows.Forms.Label labelStep2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.RichTextBox richTextBoxJTROutput;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStep3;
        private System.Windows.Forms.Label labelStep4;
        private System.Windows.Forms.Label labelStep1;
        private System.Windows.Forms.Button buttonBruteForce;
        private System.Windows.Forms.Button buttonBestGuess;
        private System.Windows.Forms.Button buttonMask;
        private System.Windows.Forms.Button buttonBestGuessEdit;
        private System.Windows.Forms.Button buttonMaskEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelTelegram;
        private System.Windows.Forms.GroupBox groupBoxResources;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
        private System.Windows.Forms.TextBox textBoxDeveloperInfo;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.TextBox textBoxEmailSupport;
    }
}

