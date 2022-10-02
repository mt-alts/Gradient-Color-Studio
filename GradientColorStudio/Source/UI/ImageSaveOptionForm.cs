using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GradientColorStudio
{
    public partial class ImageSaveOptionForm : Form
    {
        public ImageSaveOptionForm()
        {
            InitializeComponent();
        }

        public List<Color> Colors { get; set; }
        public EGradientStyle GradientStyle { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Colors == null)
            {
                return;
            }
            try
            {
                ColorBlender colorBlender = new ColorBlender(Colors);
                if (!String.IsNullOrEmpty(txtBxWidth.Text.Trim()) && !String.IsNullOrEmpty(txtBxHeight.Text.Trim()))
                {
                    colorBlender.BitmapSize = new Size(int.Parse(txtBxWidth.Text.ToString()), int.Parse(txtBxHeight.Text.ToString()));
                }
                else
                {
                    MessageBox.Show("Text input cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                colorBlender.GradientStyle = GradientStyle;
                Bitmap bmp = colorBlender.BlendBitmap();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(saveFileDialog1.FileName);
                    MessageBox.Show(saveFileDialog1.FileName + " saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBxWidth_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char item in txtBxWidth.Text)
            {
                if (!(char.IsDigit(item) || char.IsControl(item) || char.IsSeparator(item)))
                {
                    errorProvider1.SetError(txtBxWidth, "Text input allow only numeric input");
                }
            }
        }

        private void txtBxHeight_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (char item in txtBxHeight.Text)
            {
                if (!(char.IsDigit(item) || char.IsControl(item) || char.IsSeparator(item)))
                {
                    errorProvider1.SetError(txtBxHeight, "Text input allow only numeric input");
                }
            }
        }
    }
}
