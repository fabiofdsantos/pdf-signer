namespace pdfSignerWithCC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSignNow = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.lblCivilId = new System.Windows.Forms.Label();
            this.gbCitizenIdentityData = new System.Windows.Forms.GroupBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.gbFilesToSign = new System.Windows.Forms.GroupBox();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.lbFilesToSign = new System.Windows.Forms.ListBox();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.gbGeneralOptions = new System.Windows.Forms.GroupBox();
            this.cbSignWithTSA = new System.Windows.Forms.CheckBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.cbMultiSign = new System.Windows.Forms.CheckBox();
            this.lblAboutTitle = new System.Windows.Forms.Label();
            this.lblAboutContent = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.gbCitizenIdentityData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.gbFilesToSign.SuspendLayout();
            this.gbGeneralOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(771, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 20);
            this.lblStatus.Text = "lblStatus";
            // 
            // btnSignNow
            // 
            this.btnSignNow.Enabled = false;
            this.btnSignNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignNow.Location = new System.Drawing.Point(605, 65);
            this.btnSignNow.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignNow.Name = "btnSignNow";
            this.btnSignNow.Size = new System.Drawing.Size(133, 28);
            this.btnSignNow.TabIndex = 22;
            this.btnSignNow.Text = "Sign Now";
            this.btnSignNow.UseVisualStyleBackColor = true;
            this.btnSignNow.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(100, 119);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(459, 22);
            this.txtFullName.TabIndex = 20;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(100, 98);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(75, 17);
            this.lblFullName.TabIndex = 17;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Enabled = false;
            this.txtIdNumber.Location = new System.Drawing.Point(100, 57);
            this.txtIdNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(164, 22);
            this.txtIdNumber.TabIndex = 21;
            // 
            // lblCivilId
            // 
            this.lblCivilId.AutoSize = true;
            this.lblCivilId.Location = new System.Drawing.Point(100, 34);
            this.lblCivilId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCivilId.Name = "lblCivilId";
            this.lblCivilId.Size = new System.Drawing.Size(108, 17);
            this.lblCivilId.TabIndex = 18;
            this.lblCivilId.Text = "Civil ID Number:";
            // 
            // gbCitizenIdentityData
            // 
            this.gbCitizenIdentityData.Controls.Add(this.pbPhoto);
            this.gbCitizenIdentityData.Controls.Add(this.txtIdNumber);
            this.gbCitizenIdentityData.Controls.Add(this.lblCivilId);
            this.gbCitizenIdentityData.Controls.Add(this.txtFullName);
            this.gbCitizenIdentityData.Controls.Add(this.lblFullName);
            this.gbCitizenIdentityData.Location = new System.Drawing.Point(12, 12);
            this.gbCitizenIdentityData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCitizenIdentityData.Name = "gbCitizenIdentityData";
            this.gbCitizenIdentityData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCitizenIdentityData.Size = new System.Drawing.Size(568, 149);
            this.gbCitizenIdentityData.TabIndex = 25;
            this.gbCitizenIdentityData.TabStop = false;
            this.gbCitizenIdentityData.Text = "Citizen Identity Data";
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(7, 34);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(85, 105);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 14;
            this.pbPhoto.TabStop = false;
            // 
            // gbFilesToSign
            // 
            this.gbFilesToSign.Controls.Add(this.btnRemoveFile);
            this.gbFilesToSign.Controls.Add(this.lbFilesToSign);
            this.gbFilesToSign.Controls.Add(this.btnAddFiles);
            this.gbFilesToSign.Controls.Add(this.btnSignNow);
            this.gbFilesToSign.Location = new System.Drawing.Point(12, 311);
            this.gbFilesToSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilesToSign.Name = "gbFilesToSign";
            this.gbFilesToSign.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFilesToSign.Size = new System.Drawing.Size(747, 102);
            this.gbFilesToSign.TabIndex = 27;
            this.gbFilesToSign.TabStop = false;
            this.gbFilesToSign.Text = "Files to Sign (PDF)";
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Enabled = false;
            this.btnRemoveFile.Image = global::pdfSigner.Properties.Resources.delete;
            this.btnRemoveFile.Location = new System.Drawing.Point(675, 25);
            this.btnRemoveFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(64, 28);
            this.btnRemoveFile.TabIndex = 28;
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // lbFilesToSign
            // 
            this.lbFilesToSign.FormattingEnabled = true;
            this.lbFilesToSign.ItemHeight = 16;
            this.lbFilesToSign.Location = new System.Drawing.Point(7, 25);
            this.lbFilesToSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFilesToSign.Name = "lbFilesToSign";
            this.lbFilesToSign.ScrollAlwaysVisible = true;
            this.lbFilesToSign.Size = new System.Drawing.Size(592, 68);
            this.lbFilesToSign.TabIndex = 27;
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Image = global::pdfSigner.Properties.Resources.add;
            this.btnAddFiles.Location = new System.Drawing.Point(605, 25);
            this.btnAddFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(64, 28);
            this.btnAddFiles.TabIndex = 23;
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbGeneralOptions
            // 
            this.gbGeneralOptions.Controls.Add(this.cbSignWithTSA);
            this.gbGeneralOptions.Controls.Add(this.lblLocation);
            this.gbGeneralOptions.Controls.Add(this.txtLocation);
            this.gbGeneralOptions.Controls.Add(this.lblReason);
            this.gbGeneralOptions.Controls.Add(this.txtReason);
            this.gbGeneralOptions.Controls.Add(this.cbMultiSign);
            this.gbGeneralOptions.Location = new System.Drawing.Point(12, 178);
            this.gbGeneralOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGeneralOptions.Name = "gbGeneralOptions";
            this.gbGeneralOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGeneralOptions.Size = new System.Drawing.Size(747, 117);
            this.gbGeneralOptions.TabIndex = 28;
            this.gbGeneralOptions.TabStop = false;
            this.gbGeneralOptions.Text = "General Options";
            // 
            // cbSignWithTSA
            // 
            this.cbSignWithTSA.AutoSize = true;
            this.cbSignWithTSA.Checked = true;
            this.cbSignWithTSA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSignWithTSA.Location = new System.Drawing.Point(8, 25);
            this.cbSignWithTSA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSignWithTSA.Name = "cbSignWithTSA";
            this.cbSignWithTSA.Size = new System.Drawing.Size(167, 21);
            this.cbSignWithTSA.TabIndex = 5;
            this.cbSignWithTSA.Text = "Use timestamp server";
            this.cbSignWithTSA.UseVisualStyleBackColor = true;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(493, 87);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 17);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(565, 85);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(175, 22);
            this.txtLocation.TabIndex = 3;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(5, 87);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(61, 17);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Reason:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(72, 85);
            this.txtReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(385, 22);
            this.txtReason.TabIndex = 1;
            // 
            // cbMultiSign
            // 
            this.cbMultiSign.AutoSize = true;
            this.cbMultiSign.Location = new System.Drawing.Point(7, 55);
            this.cbMultiSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMultiSign.Name = "cbMultiSign";
            this.cbMultiSign.Size = new System.Drawing.Size(625, 21);
            this.cbMultiSign.TabIndex = 0;
            this.cbMultiSign.Text = "Enable multiple digital signatures (sign documents without invalidating the previ" +
    "ous signatures)";
            this.cbMultiSign.UseVisualStyleBackColor = true;
            // 
            // lblAboutTitle
            // 
            this.lblAboutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAboutTitle.Location = new System.Drawing.Point(586, 21);
            this.lblAboutTitle.Name = "lblAboutTitle";
            this.lblAboutTitle.Size = new System.Drawing.Size(173, 23);
            this.lblAboutTitle.TabIndex = 29;
            this.lblAboutTitle.Text = "PDF Signer 1.0";
            this.lblAboutTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAboutContent
            // 
            this.lblAboutContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutContent.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAboutContent.Location = new System.Drawing.Point(586, 58);
            this.lblAboutContent.Name = "lblAboutContent";
            this.lblAboutContent.Size = new System.Drawing.Size(173, 103);
            this.lblAboutContent.TabIndex = 30;
            this.lblAboutContent.Text = "Created by:\r\nFábio Santos (ffsantos92)\r\nEurico Sousa (ejm3)\r\n\r\nLicense: MIT";
            this.lblAboutContent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 453);
            this.Controls.Add(this.lblAboutContent);
            this.Controls.Add(this.lblAboutTitle);
            this.Controls.Add(this.gbGeneralOptions);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbCitizenIdentityData);
            this.Controls.Add(this.gbFilesToSign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Sign PDFs with the Portuguese Citizen Card";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbCitizenIdentityData.ResumeLayout(false);
            this.gbCitizenIdentityData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.gbFilesToSign.ResumeLayout(false);
            this.gbGeneralOptions.ResumeLayout(false);
            this.gbGeneralOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnSignNow;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblCivilId;
        private System.Windows.Forms.GroupBox gbCitizenIdentityData;
        private System.Windows.Forms.GroupBox gbFilesToSign;
        private System.Windows.Forms.GroupBox gbGeneralOptions;
        private System.Windows.Forms.ListBox lbFilesToSign;
        private System.Windows.Forms.CheckBox cbMultiSign;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.CheckBox cbSignWithTSA;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Label lblAboutTitle;
        private System.Windows.Forms.Label lblAboutContent;
    }
}