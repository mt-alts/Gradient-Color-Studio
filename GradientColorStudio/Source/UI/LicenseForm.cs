using System;
using System.Windows.Forms;

namespace GradientColorStudio
{
    public partial class LicenseForm : Form
    {
        private bool agreement = false;

        public LicenseForm()
        {
            InitializeComponent();
        }

        private void LicenseForm_Load(object sender, EventArgs e)
        {
            rtbLicenseText.Text = global::GradientColorStudio.Properties.Resources.license;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = checkBox1.Checked;
        }

        public void LicenseView(bool agreement)
        {
            this.agreement = agreement;
            if (agreement)
            {
                rtbLicenseText.Dock = DockStyle.Fill;
                rtbLicenseText.BringToFront();
                Text = "License";
                ShowDialog();
            }
            else
            {
                this.ShowDialog();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            agreement = true;
            Configuration configuration = new Configuration();
            try
            {
                if (configuration.Write("license", "agreement", "true"))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LicenseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!agreement)
            {
                Application.Exit();
            }
        }
    }
}
