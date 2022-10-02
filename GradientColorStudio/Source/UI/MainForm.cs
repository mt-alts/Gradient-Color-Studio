using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GradientColorStudio
{
    public partial class MainForm : Form
    {
        private readonly PreviousColors previousColors = new PreviousColors();
        private int previousCount;
        private readonly List<Color> customColorList = new List<Color>();
        private readonly List<Color> outputColorList = new List<Color>();
        private EGradientStyle gradientStyle = EGradientStyle.MIXED;
        private ColorBlender colorBlender;

        public MainForm()
        {
            InitializeComponent();
            lbRendererType.DrawItem += new DrawItemEventHandler(lbRendererTYpe_DrawItem);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Statics.COLOR_RENDERER_SIZE = pbRenderer.Size;
            cbColorModel.SelectedIndex = (int)EColorModel.RGB;
            lbRendererType.SelectedIndex = (int)ERendererType.SQUARE;
            cbGradientStyle.SelectedIndex = (int)EGradientStyle.MIXED;

            if (!previousColors.LoadList())
            {
                btnBack.BackColor = Color.Gray;
                btnBack.Enabled = false;
            }
            else
            {
                previousCount = previousColors.RowCount();
            }

            About();
            ToolTip ttp = new ToolTip();
            ttp.AutoPopDelay = 5000;
            ttp.InitialDelay = 1000;
            ttp.ReshowDelay = 500;
            ttp.ShowAlways = true;
            ttp.SetToolTip(btnLbCustomColorsAddItem, "Custom color list add item");
            ttp.SetToolTip(btnLbCustomColorsRemoveItem, "Custom color list remove item");
            ttp.SetToolTip(btnLbCustomColorsEditItem, "Custom color list edit item");
            ttp.SetToolTip(btnLbCustomColorsMoveUpItem, "Custom color list move up item");
            ttp.SetToolTip(btnLbCustomColorsMoveDownItem, "Custom color list move down item");
            ttp.SetToolTip(btnLbCustomColorsRemoveAllItem, "Custom color list clear");
            ttp.SetToolTip(chckBxCustomColors, "Enable or disable custom color mode");
            ttp.SetToolTip(rbRgb, "Custom color type - RGB");
            ttp.SetToolTip(rbHtml, "Custom color type - HTML");
            ttp.SetToolTip(btnGenerate, "Generate gradient color");
            ttp.SetToolTip(btnBack, "Back");
            ttp.SetToolTip(pbRenderer, "Double click save as");

            bool licenseAgreement = CheckLicenseAgreement();

            if (!licenseAgreement)
            {
                LicenseForm licenseForm = new LicenseForm();
                licenseForm.LicenseView(licenseAgreement);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           previousColors.SaveList();
        }

        private bool CheckLicenseAgreement()
        {
            if (System.IO.File.Exists(Statics.configurationFile))
            {
                try
                {
                    Configuration configuration = new Configuration();
                    return configuration.Read("license", "agreement").Equals("true");
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    System.IO.File.Create(Statics.configurationFile).Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

        private void chckBxCustomColors_CheckedChanged(object sender, EventArgs e)
        {
            lbCustomColors.Enabled = chckBxCustomColors.Checked;
            pnlLbCustomColorsButtons.Enabled = chckBxCustomColors.Checked;
            numUpDownColorCount.Enabled = !chckBxCustomColors.Checked;
            pnlRgbHtml.Enabled = chckBxCustomColors.Checked;
            pnlRgbHtml.BackColor = chckBxCustomColors.Checked ? pnlRgbHtml.BackColor = Color.FromArgb(55, 55, 55) : pnlRgbHtml.BackColor = Color.Gray;
        }

        private void lbColorsUpdate()
        {
            int outputColorListCount = outputColorList.Count;
            lbColors.Items.Clear();

            if (cbColorModel.SelectedIndex == (int)EColorModel.RGB)
            {
                for (int i = 0; i < outputColorListCount; i++)
                {
                    lbColors.Items.Add("R:" + outputColorList[i].R + ", G:" + outputColorList[i].G + ", B:" + outputColorList[i].B);
                }
            }
            else
            {
                for (int i = 0; i < outputColorListCount; i++)
                {
                    lbColors.Items.Add(ColorTranslator.ToHtml(outputColorList[i]));
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            outputColorList.Clear();

            if ((cbGradientStyle.SelectedIndex == (int)EGradientStyle.MIXED))
            {
                gradientStyle = EGradientStyle.MIXED;
            }
            else
            {
                gradientStyle = EGradientStyle.LINEAR;

                if (chckBxCustomColors.Checked && customColorList.Count < 2)
                {
                    MessageBox.Show("You must choose at least two colors!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!chckBxCustomColors.Checked && numUpDownColorCount.Value < 2)
                {
                    MessageBox.Show("You must choose at least two colors!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (chckBxCustomColors.Checked)
            {
                List<Color> colors = new List<Color>();

                for (int i = 0; i < lbCustomColors.Items.Count; i++)
                {
                    colors.Add(customColorList[i]);
                }

                colorBlender = new ColorBlender(colors);
                colorBlender.GradientStyle = gradientStyle;
                pbRenderer.Image = colorBlender.BlendBitmap();
                lbColors.Items.Clear();

                for (int i = 0; i < colors.Count; i++)
                {
                    outputColorList.Add(colors[i]);
                    lbColors.Items.Add(colors[i].ToString());
                }

                previousColors.AddColor(colors.ToArray());
            }
            else
            {
                List<Color> colors = new RandomColorGenerator(Decimal.ToInt32(numUpDownColorCount.Value));
                colorBlender = new ColorBlender(colors);
                colorBlender.GradientStyle = gradientStyle;
                pbRenderer.Image = colorBlender.BlendBitmap();
                lbColors.Items.Clear();

                for (int i = 0; i < colors.Count; i++)
                {
                    outputColorList.Add(colors[i]);
                    lbColors.Items.Add(colors[i].ToString());
                }

                previousColors.AddColor(colors.ToArray());
            }

            if (!btnBack.Enabled)
            {
                btnBack.Enabled = true;
                btnBack.BackColor = Color.FromArgb(55,55,55);
            }

            previousCount = previousColors.RowCount() - 1;
            lbColorsUpdate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            outputColorList.Clear();

            if (previousCount > 0)
            {
                previousCount -= 1;
            }
            else
            {
                previousCount = previousColors.RowCount() - 1;
            }

            List<Color> colors = new List<Color>(previousColors.GetRow(previousCount));
            colorBlender = new ColorBlender(colors);
            colorBlender.GradientStyle = gradientStyle;
            pbRenderer.Image = colorBlender.BlendBitmap();
            lbColors.Items.Clear();

            for (int i = 0; i < colors.Count; i++)
            {
                lbColors.Items.Add(colors[i].ToString());
                outputColorList.Add(colors[i]);
            }

            lbColorsUpdate();
        }

        private void cbColorModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbColorsUpdate();
        }

        private void btnLbCustomColorsAddItem_Click(object sender, EventArgs e)
        {
            if (customColorList.Count < numUpDownColorCount.Maximum)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    String colorCode = "";

                    if (rbRgb.Checked)
                    {
                        colorCode = "R:" + colorDialog.Color.R + ", G:" + colorDialog.Color.G + ", B:" + colorDialog.Color.B;
                    }
                    else
                    {
                        colorCode = ColorTranslator.ToHtml(colorDialog.Color);
                    }

                    lbCustomColors.Items.Add(colorCode);
                    customColorList.Add(colorDialog.Color);
                }
            }
            else
            {
                MessageBox.Show("Currently, no more than four colors are supported :(", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLbCustomColorsRemoveItem_Click(object sender, EventArgs e)
        {
            if (lbCustomColors.SelectedIndex > -1)
            {
                customColorList.RemoveAt(lbCustomColors.SelectedIndex);
                lbCustomColors.Items.RemoveAt(lbCustomColors.SelectedIndex);
            }
        }

        private void btnLbCustomColorsEditItem_Click(object sender, EventArgs e)
        {
            if (lbCustomColors.SelectedIndex > -1)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    string colorCode = "";

                    if (rbRgb.Checked)
                    {
                        colorCode = "R:" + colorDialog.Color.R + ", G:" + colorDialog.Color.G + ", B:" + colorDialog.Color.B;
                    }
                    else
                    {
                        colorCode = ColorTranslator.ToHtml(colorDialog.Color);
                    }

                    lbCustomColors.Items[lbCustomColors.SelectedIndex] = colorCode;
                    customColorList[lbCustomColors.SelectedIndex] = colorDialog.Color;
                    lbColorsUpdate();
                }
            }
        }

        private void btnLbCustomColorsMoveUpItem_Click(object sender, EventArgs e)
        {
            if (lbCustomColors.SelectedIndex > -1)
            {
                int selectedIndex = lbCustomColors.SelectedIndex;
                var item = lbCustomColors.Items[selectedIndex];
                Color colorItem = customColorList[selectedIndex];
                int newIndex = lbCustomColors.SelectedIndex - 1;

                if (lbCustomColors.SelectedIndex == 0)
                {
                    newIndex = lbCustomColors.Items.Count - 1;
                }

                lbCustomColors.Items.RemoveAt(selectedIndex);
                lbCustomColors.Items.Insert(newIndex, item);
                customColorList.RemoveAt(selectedIndex);
                customColorList.Insert(newIndex, colorItem);
                lbCustomColors.SelectedIndex = newIndex;
            }
        }

        private void btnLbCustomColorsMoveDownItem_Click(object sender, EventArgs e)
        {
            if (lbCustomColors.SelectedIndex > -1)
            {
                int selectedIndex = lbCustomColors.SelectedIndex;
                var item = lbCustomColors.Items[lbCustomColors.SelectedIndex];
                Color colorItem = customColorList[selectedIndex];
                int newIndex = lbCustomColors.SelectedIndex + 1;

                if (lbCustomColors.SelectedIndex == lbCustomColors.Items.Count - 1)
                {
                    newIndex = 0;
                }

                lbCustomColors.Items.RemoveAt(lbCustomColors.SelectedIndex);
                lbCustomColors.Items.Insert(newIndex, item);
                customColorList.RemoveAt(selectedIndex);
                customColorList.Insert(newIndex, colorItem);
                lbCustomColors.SelectedIndex = newIndex;
            }
        }

        private void btnLbCustomColorsRemoveAllItem_Click(object sender, EventArgs e)
        {
            lbCustomColors.Items.Clear();
            customColorList.Clear();
        }

        private void cbGradientStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colorBlender != null)
            {

                if (cbGradientStyle.SelectedIndex == (int)EGradientStyle.MIXED)
                {
                    if (outputColorList.Count <= 0)
                    {
                        return;
                    }

                    List<Color> colors = outputColorList;

                    if (colors.Count > 4)
                    {
                        colors = outputColorList.GetRange(0, 4);
                    }

                    gradientStyle = (EGradientStyle)cbGradientStyle.SelectedIndex;
                    colorBlender = new ColorBlender(colors);
                    colorBlender.GradientStyle = gradientStyle;
                    pbRenderer.Image = colorBlender.BlendBitmap();
                }
                else
                {
                    if (outputColorList.Count <= 1)
                    {
                        return;
                    }

                    numUpDownColorCount.Maximum = outputColorList.Count;
                    numUpDownColorCount.Value = numUpDownColorCount.Maximum;
                    gradientStyle = (EGradientStyle)cbGradientStyle.SelectedIndex;
                    colorBlender.GradientStyle = gradientStyle;
                    pbRenderer.Image = colorBlender.BlendBitmap();
                }
            }

            switch (cbGradientStyle.SelectedIndex)
            {
                case (int)EGradientStyle.LINEAR:
                    numUpDownColorCount.Maximum = 200;
                    break;
                case (int)EGradientStyle.MIXED:
                    numUpDownColorCount.Maximum = 4;
                    break;
            }
        }

        private void lbRendererType_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (GraphicsPath gp = new GraphicsPath())
            {
                Rectangle rectangle = new Rectangle(0, 0, pbRenderer.Width, pbRenderer.Height);

                switch (lbRendererType.SelectedIndex)
                {
                    case (int)ERendererType.ELLIPSE:
                        gp.AddEllipse(rectangle);
                        break;
                    case (int)ERendererType.SQUARE:
                        gp.AddRectangle(rectangle);
                        break;
                    case (int)ERendererType.TRIANGLE:
                        gp.AddPolygon(new Point[] {
                             new Point(pbRenderer.Width / 2, 0),
                             new Point(pbRenderer.Width, pbRenderer.Height),
                             new Point(0, pbRenderer.Height)});
                        break;
                    case (int)ERendererType.HEXAGON:
                        gp.AddPolygon(new Point[] {
                                new Point(pbRenderer.Width / 4, 0),
                                new Point(0, pbRenderer.Height / 4),
                                new Point(0, pbRenderer.Height - (pbRenderer.Height / 4)),
                                new Point(pbRenderer.Width / 4, pbRenderer.Height),
                                new Point(pbRenderer.Width - (pbRenderer.Width / 4), pbRenderer.Height),
                                new Point(pbRenderer.Width, pbRenderer.Height - (pbRenderer.Height / 4)),
                                new Point(pbRenderer.Width, pbRenderer.Height / 4),
                                new Point(pbRenderer.Width - (pbRenderer.Width / 4), 0)
                            });
                        break;
                }

                pbRenderer.Region = new Region(gp);
            }
        }

        private void lbRendererTYpe_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;

            if (e.Index > -1)
            {
                object item = list.Items[e.Index];

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e = new DrawItemEventArgs(e.Graphics,
                                              e.Font,
                                              e.Bounds,
                                              e.Index,
                                              e.State ^ DrawItemState.Selected,
                                              e.ForeColor,
                                              Color.DarkGray);
                }

                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }

        private void lbCustomColors_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;

            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                Color c = ColorTranslator2.Invertion(customColorList[e.Index]);
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.None,
                                          customColorList[e.Index],
                                          customColorList[e.Index]);
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(c);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + 5, e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }

        private void lbColors_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;

            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                Color c = ColorTranslator2.Invertion(outputColorList[e.Index]);
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.None,
                                          outputColorList[e.Index],
                                          outputColorList[e.Index]);
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(c);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + 5, e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }

        private void rbRgb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRgb.Checked)
            {
                lbCustomColors.Items.Clear();
                int customColorListCount = customColorList.Count;

                for (int i = 0; i < customColorListCount; i++)
                {
                    lbCustomColors.Items.Add("R:" + customColorList[i].R + ", G:" + customColorList[i].G + ", B:" + customColorList[i].B);
                }
            }
            else
            {
                lbCustomColors.Items.Clear();
                int customColorListCount = customColorList.Count;

                for (int i = 0; i < customColorListCount; i++)
                {
                    lbCustomColors.Items.Add(ColorTranslator.ToHtml(customColorList[i]));
                }
            }
        }

        private void pbRenderer_DoubleClick(object sender, EventArgs e)
        {
            if (pbRenderer.Image == null)
            {
                return;
            }

            ImageSaveOptionForm isof = new ImageSaveOptionForm();
            isof.Colors = outputColorList;
            isof.GradientStyle = gradientStyle;
            isof.StartPosition = FormStartPosition.CenterParent;
            isof.ShowDialog();
        }

        private void lbColors_DoubleClick(object sender, EventArgs e)
        {
            int index = lbColors.SelectedIndex;
            if (index > -1)
            {
                string text = "";

                if (cbColorModel.SelectedIndex == (int)EColorModel.RGB)
                {
                    text = outputColorList[index].R + "," + outputColorList[index].G + "," + outputColorList[index].B;
                }
                else
                {
                    text = lbColors.Items[index].ToString();
                }

                Clipboard.SetText(text);
                AlertMessage.Show(this, "Copied " + text, 1500);
            }
        }

        private void lbCustomColors_DoubleClick(object sender, EventArgs e)
        {
            int index = lbCustomColors.SelectedIndex;
            if (index > -1)
            {
                string text = "";

                if (rbRgb.Checked)
                {
                    text = customColorList[index].R + "," + customColorList[index].G + "," + customColorList[index].B;
                }
                else
                {
                    text = lbCustomColors.Items[index].ToString();
                }

                Clipboard.SetText(text);
                AlertMessage.Show(this, "Copied " + text, 1500);
            }
        }

        private void goLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseForm licenseForm = new LicenseForm();
            licenseForm.LicenseView(true);
        }

        private void goWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mt-alts/Gradient-Color-Studio");
        }

        private void About()
        {
            List<Color> pnlAboutColors = new List<Color>();
            pnlAboutColors.Add(Color.FromArgb(101, 18, 245));
            pnlAboutColors.Add(Color.FromArgb(118, 103, 229));
            pnlAboutColors.Add(Color.FromArgb(240, 166, 181));
            pnlAboutColors.Add(Color.FromArgb(9, 226, 164));
            ColorBlender cb = new ColorBlender(pnlAboutColors);
            cb.BitmapSize = pnlAbout.Size;
            cb.GradientStyle = EGradientStyle.MIXED;
            pnlAbout.BackgroundImage = cb.BlendBitmap();
        }
    }
}
