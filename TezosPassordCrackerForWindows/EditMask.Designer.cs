namespace TezosPassordCrackerForWindows
{
    partial class EditMask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMask));
            this.textBoxMask = new System.Windows.Forms.TextBox();
            this.labelMaskTitle = new System.Windows.Forms.Label();
            this.labelMaskExample = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMaskPrecursor = new System.Windows.Forms.Label();
            this.richTextBoxJTRMaskDoc = new System.Windows.Forms.RichTextBox();
            this.labelMaskDocument = new System.Windows.Forms.Label();
            this.labelWordListLabel = new System.Windows.Forms.Label();
            this.labelWordListDescription = new System.Windows.Forms.Label();
            this.textBoxWordListFile = new System.Windows.Forms.TextBox();
            this.buttonAddWordList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMask
            // 
            this.textBoxMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMask.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMask.Location = new System.Drawing.Point(72, 547);
            this.textBoxMask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMask.Name = "textBoxMask";
            this.textBoxMask.Size = new System.Drawing.Size(752, 26);
            this.textBoxMask.TabIndex = 0;
            // 
            // labelMaskTitle
            // 
            this.labelMaskTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaskTitle.AutoSize = true;
            this.labelMaskTitle.Location = new System.Drawing.Point(8, 531);
            this.labelMaskTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaskTitle.Name = "labelMaskTitle";
            this.labelMaskTitle.Size = new System.Drawing.Size(159, 13);
            this.labelMaskTitle.TabIndex = 1;
            this.labelMaskTitle.Text = "Enter your mask here.  Example:";
            // 
            // labelMaskExample
            // 
            this.labelMaskExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaskExample.AutoSize = true;
            this.labelMaskExample.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaskExample.Location = new System.Drawing.Point(195, 532);
            this.labelMaskExample.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaskExample.Name = "labelMaskExample";
            this.labelMaskExample.Size = new System.Drawing.Size(196, 14);
            this.labelMaskExample.TabIndex = 2;
            this.labelMaskExample.Text = "?s[Ff][Ll1][l1]uffy?d?d?d?d";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(740, 602);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 31);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(652, 602);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 31);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelMaskPrecursor
            // 
            this.labelMaskPrecursor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaskPrecursor.AutoSize = true;
            this.labelMaskPrecursor.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaskPrecursor.Location = new System.Drawing.Point(6, 550);
            this.labelMaskPrecursor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaskPrecursor.Name = "labelMaskPrecursor";
            this.labelMaskPrecursor.Size = new System.Drawing.Size(68, 18);
            this.labelMaskPrecursor.TabIndex = 5;
            this.labelMaskPrecursor.Text = "-mask=";
            // 
            // richTextBoxJTRMaskDoc
            // 
            this.richTextBoxJTRMaskDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxJTRMaskDoc.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxJTRMaskDoc.Location = new System.Drawing.Point(8, 37);
            this.richTextBoxJTRMaskDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxJTRMaskDoc.Name = "richTextBoxJTRMaskDoc";
            this.richTextBoxJTRMaskDoc.Size = new System.Drawing.Size(816, 484);
            this.richTextBoxJTRMaskDoc.TabIndex = 6;
            this.richTextBoxJTRMaskDoc.Text = "";
            // 
            // labelMaskDocument
            // 
            this.labelMaskDocument.AutoSize = true;
            this.labelMaskDocument.Location = new System.Drawing.Point(7, 20);
            this.labelMaskDocument.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaskDocument.Name = "labelMaskDocument";
            this.labelMaskDocument.Size = new System.Drawing.Size(684, 13);
            this.labelMaskDocument.TabIndex = 7;
            this.labelMaskDocument.Text = "If you know part of your passord, masks are the way to go. For example I think my" +
    " password is someting like some symbol, Fluffy, then some year";
            // 
            // labelWordListLabel
            // 
            this.labelWordListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWordListLabel.AutoSize = true;
            this.labelWordListLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordListLabel.Location = new System.Drawing.Point(12, 611);
            this.labelWordListLabel.Name = "labelWordListLabel";
            this.labelWordListLabel.Size = new System.Drawing.Size(84, 14);
            this.labelWordListLabel.TabIndex = 8;
            this.labelWordListLabel.Text = "--wordlist=";
            // 
            // labelWordListDescription
            // 
            this.labelWordListDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWordListDescription.AutoSize = true;
            this.labelWordListDescription.Location = new System.Drawing.Point(12, 587);
            this.labelWordListDescription.Name = "labelWordListDescription";
            this.labelWordListDescription.Size = new System.Drawing.Size(559, 13);
            this.labelWordListDescription.TabIndex = 9;
            this.labelWordListDescription.Text = "A word list is a list of words that might be your password. You can add this list" +
    " to enable the ?w and ?W mask options.";
            // 
            // textBoxWordListFile
            // 
            this.textBoxWordListFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxWordListFile.Location = new System.Drawing.Point(102, 608);
            this.textBoxWordListFile.Name = "textBoxWordListFile";
            this.textBoxWordListFile.Size = new System.Drawing.Size(469, 20);
            this.textBoxWordListFile.TabIndex = 10;
            // 
            // buttonAddWordList
            // 
            this.buttonAddWordList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddWordList.Location = new System.Drawing.Point(572, 606);
            this.buttonAddWordList.Name = "buttonAddWordList";
            this.buttonAddWordList.Size = new System.Drawing.Size(26, 23);
            this.buttonAddWordList.TabIndex = 11;
            this.buttonAddWordList.Text = "...";
            this.buttonAddWordList.UseVisualStyleBackColor = true;
            this.buttonAddWordList.Click += new System.EventHandler(this.ButtonAddWordList_Click);
            // 
            // EditMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 643);
            this.Controls.Add(this.buttonAddWordList);
            this.Controls.Add(this.textBoxWordListFile);
            this.Controls.Add(this.labelWordListDescription);
            this.Controls.Add(this.labelWordListLabel);
            this.Controls.Add(this.textBoxMask);
            this.Controls.Add(this.labelMaskDocument);
            this.Controls.Add(this.richTextBoxJTRMaskDoc);
            this.Controls.Add(this.labelMaskPrecursor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelMaskExample);
            this.Controls.Add(this.labelMaskTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditMask";
            this.Text = "EditMask";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditMask_FormClosing);
            this.Load += new System.EventHandler(this.EditMask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMask;
        private System.Windows.Forms.Label labelMaskTitle;
        private System.Windows.Forms.Label labelMaskExample;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMaskPrecursor;
        private System.Windows.Forms.RichTextBox richTextBoxJTRMaskDoc;
        private System.Windows.Forms.Label labelMaskDocument;
        private System.Windows.Forms.Label labelWordListLabel;
        private System.Windows.Forms.Label labelWordListDescription;
        private System.Windows.Forms.TextBox textBoxWordListFile;
        private System.Windows.Forms.Button buttonAddWordList;
    }
}