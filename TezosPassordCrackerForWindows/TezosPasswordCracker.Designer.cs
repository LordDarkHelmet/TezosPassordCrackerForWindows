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
            this.pictureBoxRecovery = new System.Windows.Forms.PictureBox();
            this.linkLabelTelegram = new System.Windows.Forms.LinkLabel();
            this.groupBoxResources = new System.Windows.Forms.GroupBox();
            this.labelBitcoinDonationAddress = new System.Windows.Forms.Label();
            this.textBoxEmailSupport = new System.Windows.Forms.TextBox();
            this.labelDonationTezosAddress = new System.Windows.Forms.Label();
            this.linkLabelDonationBTC = new System.Windows.Forms.LinkLabel();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.linkLabelDonationTezos = new System.Windows.Forms.LinkLabel();
            this.labelDonations = new System.Windows.Forms.Label();
            this.textBoxDeveloperInfo = new System.Windows.Forms.TextBox();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecovery)).BeginInit();
            this.groupBoxResources.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerateHashesFile
            // 
            this.buttonGenerateHashesFile.Location = new System.Drawing.Point(9, 80);
            this.buttonGenerateHashesFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateHashesFile.Name = "buttonGenerateHashesFile";
            this.buttonGenerateHashesFile.Size = new System.Drawing.Size(98, 41);
            this.buttonGenerateHashesFile.TabIndex = 0;
            this.buttonGenerateHashesFile.Text = "Generate";
            this.buttonGenerateHashesFile.UseVisualStyleBackColor = true;
            this.buttonGenerateHashesFile.Click += new System.EventHandler(this.ButtonGenerateHashesFile_Click);
            // 
            // labelStep2
            // 
            this.labelStep2.AutoSize = true;
            this.labelStep2.Location = new System.Drawing.Point(7, 131);
            this.labelStep2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStep2.Name = "labelStep2";
            this.labelStep2.Size = new System.Drawing.Size(329, 13);
            this.labelStep2.TabIndex = 2;
            this.labelStep2.Text = "Step 2: Masks are a effective when  you might know  your password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(9, 18);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(776, 35);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(7, 2);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(234, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "When a Password is found, we will show it here!";
            // 
            // richTextBoxJTROutput
            // 
            this.richTextBoxJTROutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxJTROutput.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxJTROutput.Location = new System.Drawing.Point(9, 369);
            this.richTextBoxJTROutput.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxJTROutput.Name = "richTextBoxJTROutput";
            this.richTextBoxJTROutput.Size = new System.Drawing.Size(776, 266);
            this.richTextBoxJTROutput.TabIndex = 7;
            this.richTextBoxJTROutput.Text = "";
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Location = new System.Drawing.Point(688, 340);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(95, 24);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Universal Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "John The Ripper Output: This is a view of the password breaking process. ";
            // 
            // labelStep3
            // 
            this.labelStep3.AutoSize = true;
            this.labelStep3.Location = new System.Drawing.Point(7, 201);
            this.labelStep3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStep3.Name = "labelStep3";
            this.labelStep3.Size = new System.Drawing.Size(300, 13);
            this.labelStep3.TabIndex = 10;
            this.labelStep3.Text = "Step 3: Reserved for future capability. Contact us for requests ";
            // 
            // labelStep4
            // 
            this.labelStep4.AutoSize = true;
            this.labelStep4.Location = new System.Drawing.Point(7, 275);
            this.labelStep4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStep4.Name = "labelStep4";
            this.labelStep4.Size = new System.Drawing.Size(292, 13);
            this.labelStep4.TabIndex = 11;
            this.labelStep4.Text = "Step 4: Brute Force is a last resort. Use rules and masks first!";
            // 
            // labelStep1
            // 
            this.labelStep1.AutoSize = true;
            this.labelStep1.Location = new System.Drawing.Point(7, 63);
            this.labelStep1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStep1.Name = "labelStep1";
            this.labelStep1.Size = new System.Drawing.Size(38, 13);
            this.labelStep1.TabIndex = 12;
            this.labelStep1.Text = "Step 1";
            // 
            // buttonBruteForce
            // 
            this.buttonBruteForce.Location = new System.Drawing.Point(9, 291);
            this.buttonBruteForce.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBruteForce.Name = "buttonBruteForce";
            this.buttonBruteForce.Size = new System.Drawing.Size(98, 41);
            this.buttonBruteForce.TabIndex = 13;
            this.buttonBruteForce.Text = "Start Brute Force";
            this.buttonBruteForce.UseVisualStyleBackColor = true;
            this.buttonBruteForce.Click += new System.EventHandler(this.ButtonBruteForce_Click);
            // 
            // buttonBestGuess
            // 
            this.buttonBestGuess.Location = new System.Drawing.Point(9, 217);
            this.buttonBestGuess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBestGuess.Name = "buttonBestGuess";
            this.buttonBestGuess.Size = new System.Drawing.Size(98, 41);
            this.buttonBestGuess.TabIndex = 14;
            this.buttonBestGuess.Text = "Start Best Guess";
            this.buttonBestGuess.UseVisualStyleBackColor = true;
            this.buttonBestGuess.Click += new System.EventHandler(this.ButtonBestGuess_Click);
            // 
            // buttonMask
            // 
            this.buttonMask.Location = new System.Drawing.Point(9, 147);
            this.buttonMask.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMask.Name = "buttonMask";
            this.buttonMask.Size = new System.Drawing.Size(98, 41);
            this.buttonMask.TabIndex = 15;
            this.buttonMask.Text = "Start Mask";
            this.buttonMask.UseVisualStyleBackColor = true;
            this.buttonMask.Click += new System.EventHandler(this.ButtonMask_Click);
            // 
            // buttonBestGuessEdit
            // 
            this.buttonBestGuessEdit.Location = new System.Drawing.Point(111, 217);
            this.buttonBestGuessEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBestGuessEdit.Name = "buttonBestGuessEdit";
            this.buttonBestGuessEdit.Size = new System.Drawing.Size(56, 41);
            this.buttonBestGuessEdit.TabIndex = 16;
            this.buttonBestGuessEdit.Text = "Edit";
            this.buttonBestGuessEdit.UseVisualStyleBackColor = true;
            this.buttonBestGuessEdit.Visible = false;
            // 
            // buttonMaskEdit
            // 
            this.buttonMaskEdit.Location = new System.Drawing.Point(111, 147);
            this.buttonMaskEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMaskEdit.Name = "buttonMaskEdit";
            this.buttonMaskEdit.Size = new System.Drawing.Size(56, 41);
            this.buttonMaskEdit.TabIndex = 17;
            this.buttonMaskEdit.Text = "Edit";
            this.buttonMaskEdit.UseVisualStyleBackColor = true;
            this.buttonMaskEdit.Visible = false;
            this.buttonMaskEdit.Click += new System.EventHandler(this.ButtonMaskEdit_Click);
            // 
            // pictureBoxRecovery
            // 
            this.pictureBoxRecovery.Image = global::TezosPassordCrackerForWindows.Properties.Resources.TezosRecoveryPicture;
            this.pictureBoxRecovery.InitialImage = global::TezosPassordCrackerForWindows.Properties.Resources.TezosRecoveryPicture;
            this.pictureBoxRecovery.Location = new System.Drawing.Point(4, 13);
            this.pictureBoxRecovery.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRecovery.Name = "pictureBoxRecovery";
            this.pictureBoxRecovery.Size = new System.Drawing.Size(150, 162);
            this.pictureBoxRecovery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRecovery.TabIndex = 19;
            this.pictureBoxRecovery.TabStop = false;
            this.pictureBoxRecovery.Click += new System.EventHandler(this.PictureBoxRecovery_Click);
            // 
            // linkLabelTelegram
            // 
            this.linkLabelTelegram.AutoSize = true;
            this.linkLabelTelegram.Location = new System.Drawing.Point(302, 67);
            this.linkLabelTelegram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelTelegram.Name = "linkLabelTelegram";
            this.linkLabelTelegram.Size = new System.Drawing.Size(123, 13);
            this.linkLabelTelegram.TabIndex = 20;
            this.linkLabelTelegram.TabStop = true;
            this.linkLabelTelegram.Text = "Telegram Support Group";
            this.linkLabelTelegram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelTelegram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelTelegram_LinkClicked);
            // 
            // groupBoxResources
            // 
            this.groupBoxResources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResources.Controls.Add(this.labelBitcoinDonationAddress);
            this.groupBoxResources.Controls.Add(this.textBoxEmailSupport);
            this.groupBoxResources.Controls.Add(this.labelDonationTezosAddress);
            this.groupBoxResources.Controls.Add(this.linkLabelTelegram);
            this.groupBoxResources.Controls.Add(this.linkLabelDonationBTC);
            this.groupBoxResources.Controls.Add(this.linkLabelEmail);
            this.groupBoxResources.Controls.Add(this.linkLabelDonationTezos);
            this.groupBoxResources.Controls.Add(this.pictureBoxRecovery);
            this.groupBoxResources.Controls.Add(this.labelDonations);
            this.groupBoxResources.Controls.Add(this.textBoxDeveloperInfo);
            this.groupBoxResources.Controls.Add(this.linkLabelGitHub);
            this.groupBoxResources.Controls.Add(this.textBoxAbout);
            this.groupBoxResources.Location = new System.Drawing.Point(352, 56);
            this.groupBoxResources.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResources.Name = "groupBoxResources";
            this.groupBoxResources.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResources.Size = new System.Drawing.Size(431, 276);
            this.groupBoxResources.TabIndex = 21;
            this.groupBoxResources.TabStop = false;
            this.groupBoxResources.Text = "Additional Resources";
            // 
            // labelBitcoinDonationAddress
            // 
            this.labelBitcoinDonationAddress.AutoSize = true;
            this.labelBitcoinDonationAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitcoinDonationAddress.Location = new System.Drawing.Point(29, 232);
            this.labelBitcoinDonationAddress.Name = "labelBitcoinDonationAddress";
            this.labelBitcoinDonationAddress.Size = new System.Drawing.Size(51, 15);
            this.labelBitcoinDonationAddress.TabIndex = 35;
            this.labelBitcoinDonationAddress.Text = "Bitcoin";
            // 
            // textBoxEmailSupport
            // 
            this.textBoxEmailSupport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmailSupport.Enabled = false;
            this.textBoxEmailSupport.Location = new System.Drawing.Point(159, 145);
            this.textBoxEmailSupport.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmailSupport.Multiline = true;
            this.textBoxEmailSupport.Name = "textBoxEmailSupport";
            this.textBoxEmailSupport.ReadOnly = true;
            this.textBoxEmailSupport.Size = new System.Drawing.Size(247, 14);
            this.textBoxEmailSupport.TabIndex = 25;
            this.textBoxEmailSupport.Text = "You can send an email to us.";
            // 
            // labelDonationTezosAddress
            // 
            this.labelDonationTezosAddress.AutoSize = true;
            this.labelDonationTezosAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonationTezosAddress.Location = new System.Drawing.Point(29, 206);
            this.labelDonationTezosAddress.Name = "labelDonationTezosAddress";
            this.labelDonationTezosAddress.Size = new System.Drawing.Size(45, 15);
            this.labelDonationTezosAddress.TabIndex = 34;
            this.labelDonationTezosAddress.Text = "Tezos";
            // 
            // linkLabelDonationBTC
            // 
            this.linkLabelDonationBTC.AutoSize = true;
            this.linkLabelDonationBTC.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDonationBTC.Location = new System.Drawing.Point(80, 231);
            this.linkLabelDonationBTC.Name = "linkLabelDonationBTC";
            this.linkLabelDonationBTC.Size = new System.Drawing.Size(280, 16);
            this.linkLabelDonationBTC.TabIndex = 33;
            this.linkLabelDonationBTC.TabStop = true;
            this.linkLabelDonationBTC.Text = "33DxcicBuN7wvqByLfmHH9FC9AvuEa3cGh";
            this.linkLabelDonationBTC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelDonationBTC_LinkClicked);
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.Location = new System.Drawing.Point(302, 162);
            this.linkLabelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(127, 13);
            this.linkLabelEmail.TabIndex = 24;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "TezosHelp@outlook.com";
            this.linkLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelEmail_LinkClicked);
            // 
            // linkLabelDonationTezos
            // 
            this.linkLabelDonationTezos.AutoSize = true;
            this.linkLabelDonationTezos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDonationTezos.Location = new System.Drawing.Point(80, 204);
            this.linkLabelDonationTezos.Name = "linkLabelDonationTezos";
            this.linkLabelDonationTezos.Size = new System.Drawing.Size(296, 16);
            this.linkLabelDonationTezos.TabIndex = 32;
            this.linkLabelDonationTezos.TabStop = true;
            this.linkLabelDonationTezos.Text = "tz1WYZrE1Lhd5cgh4vzUhJB1UBNGEdekbskQ";
            this.linkLabelDonationTezos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelDonationTezos_LinkClicked);
            // 
            // labelDonations
            // 
            this.labelDonations.AutoSize = true;
            this.labelDonations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonations.Location = new System.Drawing.Point(8, 186);
            this.labelDonations.Name = "labelDonations";
            this.labelDonations.Size = new System.Drawing.Size(166, 15);
            this.labelDonations.TabIndex = 31;
            this.labelDonations.Text = "Donations are welcome: ";
            // 
            // textBoxDeveloperInfo
            // 
            this.textBoxDeveloperInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDeveloperInfo.Enabled = false;
            this.textBoxDeveloperInfo.Location = new System.Drawing.Point(159, 100);
            this.textBoxDeveloperInfo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDeveloperInfo.Multiline = true;
            this.textBoxDeveloperInfo.Name = "textBoxDeveloperInfo";
            this.textBoxDeveloperInfo.ReadOnly = true;
            this.textBoxDeveloperInfo.Size = new System.Drawing.Size(247, 17);
            this.textBoxDeveloperInfo.TabIndex = 23;
            this.textBoxDeveloperInfo.Text = "You can contact the development team on  GitHub:";
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.Location = new System.Drawing.Point(302, 119);
            this.linkLabelGitHub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(126, 13);
            this.linkLabelGitHub.TabIndex = 22;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "GitHub (LordDarkHelmet)";
            this.linkLabelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGitHub_LinkClicked);
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout.Enabled = false;
            this.textBoxAbout.Location = new System.Drawing.Point(159, 17);
            this.textBoxAbout.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.ReadOnly = true;
            this.textBoxAbout.Size = new System.Drawing.Size(268, 47);
            this.textBoxAbout.TabIndex = 21;
            this.textBoxAbout.Text = "This program was made by the Tezos XTZ Recovery group. It is here to make crackin" +
    "g your password a little bit easier for Windows 10. If you need help, please joi" +
    "n out group.";
            // 
            // TezosPasswordCracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 644);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TezosPasswordCracker";
            this.Text = "Tezos XTZ Recovery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TezosPasswordCracker_FormClosing);
            this.Load += new System.EventHandler(this.TezosPasswordCracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecovery)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxRecovery;
        private System.Windows.Forms.LinkLabel linkLabelTelegram;
        private System.Windows.Forms.GroupBox groupBoxResources;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
        private System.Windows.Forms.TextBox textBoxDeveloperInfo;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.TextBox textBoxEmailSupport;
        private System.Windows.Forms.Label labelBitcoinDonationAddress;
        private System.Windows.Forms.Label labelDonationTezosAddress;
        private System.Windows.Forms.LinkLabel linkLabelDonationBTC;
        private System.Windows.Forms.LinkLabel linkLabelDonationTezos;
        private System.Windows.Forms.Label labelDonations;
    }
}

