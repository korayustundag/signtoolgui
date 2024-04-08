namespace signtoolGUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBoxCertificate = new System.Windows.Forms.GroupBox();
            this.txtCertificatePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPfxBrowse = new System.Windows.Forms.Button();
            this.txtCertificatePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxExe = new System.Windows.Forms.GroupBox();
            this.btnExeBrowse = new System.Windows.Forms.Button();
            this.txtExecutableFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTimestamp = new System.Windows.Forms.GroupBox();
            this.txtTimestampProviderURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTimestampProviders = new System.Windows.Forms.ComboBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.linkGithubHomePage = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLicense = new System.Windows.Forms.LinkLabel();
            this.groupBoxCertificate.SuspendLayout();
            this.groupBoxExe.SuspendLayout();
            this.groupBoxTimestamp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCertificate
            // 
            this.groupBoxCertificate.Controls.Add(this.txtCertificatePassword);
            this.groupBoxCertificate.Controls.Add(this.label2);
            this.groupBoxCertificate.Controls.Add(this.btnPfxBrowse);
            this.groupBoxCertificate.Controls.Add(this.txtCertificatePath);
            this.groupBoxCertificate.Controls.Add(this.label1);
            this.groupBoxCertificate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCertificate.Name = "groupBoxCertificate";
            this.groupBoxCertificate.Size = new System.Drawing.Size(306, 119);
            this.groupBoxCertificate.TabIndex = 0;
            this.groupBoxCertificate.TabStop = false;
            this.groupBoxCertificate.Text = "Certificate (pfx)";
            // 
            // txtCertificatePassword
            // 
            this.txtCertificatePassword.Location = new System.Drawing.Point(6, 92);
            this.txtCertificatePassword.Name = "txtCertificatePassword";
            this.txtCertificatePassword.Size = new System.Drawing.Size(213, 20);
            this.txtCertificatePassword.TabIndex = 4;
            this.txtCertificatePassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btnPfxBrowse
            // 
            this.btnPfxBrowse.Location = new System.Drawing.Point(225, 41);
            this.btnPfxBrowse.Name = "btnPfxBrowse";
            this.btnPfxBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPfxBrowse.TabIndex = 2;
            this.btnPfxBrowse.Text = "Browse...";
            this.btnPfxBrowse.UseVisualStyleBackColor = true;
            this.btnPfxBrowse.Click += new System.EventHandler(this.btnPfxBrowse_Click);
            // 
            // txtCertificatePath
            // 
            this.txtCertificatePath.Location = new System.Drawing.Point(6, 43);
            this.txtCertificatePath.Name = "txtCertificatePath";
            this.txtCertificatePath.ReadOnly = true;
            this.txtCertificatePath.Size = new System.Drawing.Size(213, 20);
            this.txtCertificatePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // groupBoxExe
            // 
            this.groupBoxExe.Controls.Add(this.btnExeBrowse);
            this.groupBoxExe.Controls.Add(this.txtExecutableFilePath);
            this.groupBoxExe.Controls.Add(this.label3);
            this.groupBoxExe.Location = new System.Drawing.Point(12, 137);
            this.groupBoxExe.Name = "groupBoxExe";
            this.groupBoxExe.Size = new System.Drawing.Size(306, 100);
            this.groupBoxExe.TabIndex = 1;
            this.groupBoxExe.TabStop = false;
            this.groupBoxExe.Text = "Executable File (exe)";
            // 
            // btnExeBrowse
            // 
            this.btnExeBrowse.Location = new System.Drawing.Point(225, 46);
            this.btnExeBrowse.Name = "btnExeBrowse";
            this.btnExeBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnExeBrowse.TabIndex = 5;
            this.btnExeBrowse.Text = "Browse...";
            this.btnExeBrowse.UseVisualStyleBackColor = true;
            this.btnExeBrowse.Click += new System.EventHandler(this.btnExeBrowse_Click);
            // 
            // txtExecutableFilePath
            // 
            this.txtExecutableFilePath.Location = new System.Drawing.Point(6, 48);
            this.txtExecutableFilePath.Name = "txtExecutableFilePath";
            this.txtExecutableFilePath.ReadOnly = true;
            this.txtExecutableFilePath.Size = new System.Drawing.Size(213, 20);
            this.txtExecutableFilePath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Path:";
            // 
            // groupBoxTimestamp
            // 
            this.groupBoxTimestamp.Controls.Add(this.txtTimestampProviderURL);
            this.groupBoxTimestamp.Controls.Add(this.label5);
            this.groupBoxTimestamp.Controls.Add(this.label4);
            this.groupBoxTimestamp.Controls.Add(this.comboBoxTimestampProviders);
            this.groupBoxTimestamp.Location = new System.Drawing.Point(324, 12);
            this.groupBoxTimestamp.Name = "groupBoxTimestamp";
            this.groupBoxTimestamp.Size = new System.Drawing.Size(203, 225);
            this.groupBoxTimestamp.TabIndex = 2;
            this.groupBoxTimestamp.TabStop = false;
            this.groupBoxTimestamp.Text = "Timestamp";
            // 
            // txtTimestampProviderURL
            // 
            this.txtTimestampProviderURL.Location = new System.Drawing.Point(6, 92);
            this.txtTimestampProviderURL.Name = "txtTimestampProviderURL";
            this.txtTimestampProviderURL.ReadOnly = true;
            this.txtTimestampProviderURL.Size = new System.Drawing.Size(191, 20);
            this.txtTimestampProviderURL.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Provider URL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Provider:";
            // 
            // comboBoxTimestampProviders
            // 
            this.comboBoxTimestampProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimestampProviders.FormattingEnabled = true;
            this.comboBoxTimestampProviders.Items.AddRange(new object[] {
            "Sectigo(Comodo)",
            "DigiCert",
            "Custom Provider"});
            this.comboBoxTimestampProviders.Location = new System.Drawing.Point(6, 43);
            this.comboBoxTimestampProviders.Name = "comboBoxTimestampProviders";
            this.comboBoxTimestampProviders.Size = new System.Drawing.Size(191, 21);
            this.comboBoxTimestampProviders.TabIndex = 0;
            this.comboBoxTimestampProviders.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimestampProviders_SelectedIndexChanged);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(452, 247);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 23);
            this.btnSign.TabIndex = 3;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // linkGithubHomePage
            // 
            this.linkGithubHomePage.AutoSize = true;
            this.linkGithubHomePage.Location = new System.Drawing.Point(12, 260);
            this.linkGithubHomePage.Margin = new System.Windows.Forms.Padding(0);
            this.linkGithubHomePage.Name = "linkGithubHomePage";
            this.linkGithubHomePage.Size = new System.Drawing.Size(38, 13);
            this.linkGithubHomePage.TabIndex = 4;
            this.linkGithubHomePage.TabStop = true;
            this.linkGithubHomePage.Text = "Github";
            this.linkGithubHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithubHomePage_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "-";
            // 
            // linkLicense
            // 
            this.linkLicense.AutoSize = true;
            this.linkLicense.Location = new System.Drawing.Point(60, 260);
            this.linkLicense.Margin = new System.Windows.Forms.Padding(0);
            this.linkLicense.Name = "linkLicense";
            this.linkLicense.Size = new System.Drawing.Size(44, 13);
            this.linkLicense.TabIndex = 6;
            this.linkLicense.TabStop = true;
            this.linkLicense.Text = "License";
            this.linkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLicense_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(539, 282);
            this.Controls.Add(this.linkLicense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkGithubHomePage);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.groupBoxTimestamp);
            this.Controls.Add(this.groupBoxExe);
            this.Controls.Add(this.groupBoxCertificate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignTool (GUI) [Pre-Alpha]";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBoxCertificate.ResumeLayout(false);
            this.groupBoxCertificate.PerformLayout();
            this.groupBoxExe.ResumeLayout(false);
            this.groupBoxExe.PerformLayout();
            this.groupBoxTimestamp.ResumeLayout(false);
            this.groupBoxTimestamp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCertificate;
        private System.Windows.Forms.TextBox txtCertificatePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPfxBrowse;
        private System.Windows.Forms.TextBox txtCertificatePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxExe;
        private System.Windows.Forms.Button btnExeBrowse;
        private System.Windows.Forms.TextBox txtExecutableFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxTimestamp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTimestampProviders;
        private System.Windows.Forms.TextBox txtTimestampProviderURL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.LinkLabel linkGithubHomePage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLicense;
    }
}