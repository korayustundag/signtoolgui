using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace signtoolGUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            comboBoxTimestampProviders.SelectedIndex = 0;
            txtTimestampProviderURL.Text = "http://timestamp.sectigo.com";
        }

        private void comboBoxTimestampProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxTimestampProviders.SelectedIndex;
            if (index != 2)
            {
                txtTimestampProviderURL.ReadOnly = true;
                if (index == 0)
                {
                    txtTimestampProviderURL.Text = "http://timestamp.sectigo.com";
                }
                else
                {
                    txtTimestampProviderURL.Text = "http://timestamp.digicert.com";
                }
            }
            else
            {
                txtTimestampProviderURL.Clear();
                txtTimestampProviderURL.ReadOnly = false;
            }
        }

        private void btnPfxBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Please select certificate...";
                ofd.Filter = "Certificate File(*.pfx)|*.pfx";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCertificatePath.Text = ofd.FileName;
                }
            }
        }

        private void btnExeBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Please select executable file...";
                ofd.Filter = "Executable File(*.exe)|*.exe";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtExecutableFilePath.Text = ofd.FileName;
                }
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCertificatePath.Text))
            {
                MessageBox.Show("Please select a certificate for signing.", "SignTool GUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtCertificatePassword.Text))
            {
                MessageBox.Show("Please enter your certificate's password.", "SignTool GUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtExecutableFilePath.Text))
            {
                MessageBox.Show("Please select the file to sign.", "SignTool GUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtTimestampProviderURL.Text))
            {
                MessageBox.Show("Please enter the URL of the timestamp provider.", "SignTool GUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Utilities.SignTool.SignWithCert(txtExecutableFilePath.Text, txtCertificatePath.Text, txtCertificatePassword.Text, txtTimestampProviderURL.Text);
                MessageBox.Show("The file has been signed successfully.", "SignTool GUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SignTool GUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkGithubHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://github.com/korayustundag/signtoolgui");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SignTool GUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FrmLicense license = new FrmLicense())
            {
                license.ShowDialog();
            }
        }
    }
}