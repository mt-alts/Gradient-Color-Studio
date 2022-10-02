
namespace GradientColorStudio
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chckBxCustomColors = new System.Windows.Forms.CheckBox();
            this.lbCustomColors = new System.Windows.Forms.ListBox();
            this.lbColors = new System.Windows.Forms.ListBox();
            this.cbColorModel = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbGradientStyle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDownColorCount = new System.Windows.Forms.NumericUpDown();
            this.pnlLbCustomColorsButtons = new System.Windows.Forms.Panel();
            this.btnLbCustomColorsRemoveAllItem = new System.Windows.Forms.Button();
            this.btnLbCustomColorsMoveDownItem = new System.Windows.Forms.Button();
            this.btnLbCustomColorsEditItem = new System.Windows.Forms.Button();
            this.btnLbCustomColorsMoveUpItem = new System.Windows.Forms.Button();
            this.btnLbCustomColorsRemoveItem = new System.Windows.Forms.Button();
            this.btnLbCustomColorsAddItem = new System.Windows.Forms.Button();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.goWebsite = new System.Windows.Forms.LinkLabel();
            this.pbAppIco = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.goLicense = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlRgbHtml = new System.Windows.Forms.Panel();
            this.rbHtml = new System.Windows.Forms.RadioButton();
            this.rbRgb = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbRendererType = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pbRenderer = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownColorCount)).BeginInit();
            this.pnlLbCustomColorsButtons.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIco)).BeginInit();
            this.panel6.SuspendLayout();
            this.pnlRgbHtml.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRenderer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.Location = new System.Drawing.Point(104, 255);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(236, 65);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chckBxCustomColors
            // 
            this.chckBxCustomColors.AutoSize = true;
            this.chckBxCustomColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.chckBxCustomColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckBxCustomColors.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckBxCustomColors.ForeColor = System.Drawing.SystemColors.Control;
            this.chckBxCustomColors.Location = new System.Drawing.Point(0, -1);
            this.chckBxCustomColors.Name = "chckBxCustomColors";
            this.chckBxCustomColors.Size = new System.Drawing.Size(150, 28);
            this.chckBxCustomColors.TabIndex = 2;
            this.chckBxCustomColors.Text = "Custom Colors";
            this.chckBxCustomColors.UseVisualStyleBackColor = false;
            this.chckBxCustomColors.CheckedChanged += new System.EventHandler(this.chckBxCustomColors_CheckedChanged);
            // 
            // lbCustomColors
            // 
            this.lbCustomColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lbCustomColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCustomColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbCustomColors.Enabled = false;
            this.lbCustomColors.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCustomColors.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCustomColors.FormattingEnabled = true;
            this.lbCustomColors.ItemHeight = 24;
            this.lbCustomColors.Location = new System.Drawing.Point(12, 359);
            this.lbCustomColors.Name = "lbCustomColors";
            this.lbCustomColors.Size = new System.Drawing.Size(285, 288);
            this.lbCustomColors.TabIndex = 3;
            this.lbCustomColors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbCustomColors_DrawItem);
            this.lbCustomColors.DoubleClick += new System.EventHandler(this.lbCustomColors_DoubleClick);
            // 
            // lbColors
            // 
            this.lbColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lbColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbColors.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbColors.ForeColor = System.Drawing.SystemColors.Control;
            this.lbColors.FormattingEnabled = true;
            this.lbColors.ItemHeight = 24;
            this.lbColors.Location = new System.Drawing.Point(346, 51);
            this.lbColors.Name = "lbColors";
            this.lbColors.Size = new System.Drawing.Size(326, 192);
            this.lbColors.TabIndex = 4;
            this.lbColors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbColors_DrawItem);
            this.lbColors.DoubleClick += new System.EventHandler(this.lbColors_DoubleClick);
            // 
            // cbColorModel
            // 
            this.cbColorModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cbColorModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbColorModel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cbColorModel.ForeColor = System.Drawing.SystemColors.Control;
            this.cbColorModel.FormattingEnabled = true;
            this.cbColorModel.Items.AddRange(new object[] {
            "RGB",
            "HTML"});
            this.cbColorModel.Location = new System.Drawing.Point(346, 13);
            this.cbColorModel.Name = "cbColorModel";
            this.cbColorModel.Size = new System.Drawing.Size(326, 32);
            this.cbColorModel.TabIndex = 5;
            this.cbColorModel.SelectedIndexChanged += new System.EventHandler(this.cbColorModel_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(12, 255);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 65);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(346, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 65);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.cbGradientStyle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numUpDownColorCount);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 63);
            this.panel2.TabIndex = 0;
            // 
            // cbGradientStyle
            // 
            this.cbGradientStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cbGradientStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGradientStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGradientStyle.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGradientStyle.ForeColor = System.Drawing.SystemColors.Control;
            this.cbGradientStyle.FormattingEnabled = true;
            this.cbGradientStyle.Items.AddRange(new object[] {
            "Linear",
            "Mixed"});
            this.cbGradientStyle.Location = new System.Drawing.Point(204, 19);
            this.cbGradientStyle.Name = "cbGradientStyle";
            this.cbGradientStyle.Size = new System.Drawing.Size(111, 23);
            this.cbGradientStyle.TabIndex = 3;
            this.cbGradientStyle.SelectedIndexChanged += new System.EventHandler(this.cbGradientStyle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(135, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gradient\r\nStyle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color\r\nCount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numUpDownColorCount
            // 
            this.numUpDownColorCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.numUpDownColorCount.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numUpDownColorCount.ForeColor = System.Drawing.SystemColors.Control;
            this.numUpDownColorCount.Location = new System.Drawing.Point(54, 10);
            this.numUpDownColorCount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDownColorCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownColorCount.Name = "numUpDownColorCount";
            this.numUpDownColorCount.Size = new System.Drawing.Size(71, 40);
            this.numUpDownColorCount.TabIndex = 0;
            this.numUpDownColorCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // pnlLbCustomColorsButtons
            // 
            this.pnlLbCustomColorsButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlLbCustomColorsButtons.Controls.Add(this.btnLbCustomColorsRemoveAllItem);
            this.pnlLbCustomColorsButtons.Controls.Add(this.btnLbCustomColorsMoveDownItem);
            this.pnlLbCustomColorsButtons.Controls.Add(this.btnLbCustomColorsEditItem);
            this.pnlLbCustomColorsButtons.Controls.Add(this.btnLbCustomColorsMoveUpItem);
            this.pnlLbCustomColorsButtons.Controls.Add(this.btnLbCustomColorsRemoveItem);
            this.pnlLbCustomColorsButtons.Controls.Add(this.btnLbCustomColorsAddItem);
            this.pnlLbCustomColorsButtons.Enabled = false;
            this.pnlLbCustomColorsButtons.Location = new System.Drawing.Point(302, 359);
            this.pnlLbCustomColorsButtons.Name = "pnlLbCustomColorsButtons";
            this.pnlLbCustomColorsButtons.Size = new System.Drawing.Size(38, 290);
            this.pnlLbCustomColorsButtons.TabIndex = 8;
            // 
            // btnLbCustomColorsRemoveAllItem
            // 
            this.btnLbCustomColorsRemoveAllItem.FlatAppearance.BorderSize = 0;
            this.btnLbCustomColorsRemoveAllItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLbCustomColorsRemoveAllItem.Image = ((System.Drawing.Image)(resources.GetObject("btnLbCustomColorsRemoveAllItem.Image")));
            this.btnLbCustomColorsRemoveAllItem.Location = new System.Drawing.Point(1, 213);
            this.btnLbCustomColorsRemoveAllItem.Name = "btnLbCustomColorsRemoveAllItem";
            this.btnLbCustomColorsRemoveAllItem.Size = new System.Drawing.Size(36, 36);
            this.btnLbCustomColorsRemoveAllItem.TabIndex = 1;
            this.btnLbCustomColorsRemoveAllItem.UseVisualStyleBackColor = true;
            this.btnLbCustomColorsRemoveAllItem.Click += new System.EventHandler(this.btnLbCustomColorsRemoveAllItem_Click);
            // 
            // btnLbCustomColorsMoveDownItem
            // 
            this.btnLbCustomColorsMoveDownItem.FlatAppearance.BorderSize = 0;
            this.btnLbCustomColorsMoveDownItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLbCustomColorsMoveDownItem.Image = global::GradientColorStudio.Properties.Resources.down;
            this.btnLbCustomColorsMoveDownItem.Location = new System.Drawing.Point(1, 171);
            this.btnLbCustomColorsMoveDownItem.Name = "btnLbCustomColorsMoveDownItem";
            this.btnLbCustomColorsMoveDownItem.Size = new System.Drawing.Size(36, 36);
            this.btnLbCustomColorsMoveDownItem.TabIndex = 1;
            this.btnLbCustomColorsMoveDownItem.UseVisualStyleBackColor = true;
            this.btnLbCustomColorsMoveDownItem.Click += new System.EventHandler(this.btnLbCustomColorsMoveDownItem_Click);
            // 
            // btnLbCustomColorsEditItem
            // 
            this.btnLbCustomColorsEditItem.FlatAppearance.BorderSize = 0;
            this.btnLbCustomColorsEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLbCustomColorsEditItem.Image = global::GradientColorStudio.Properties.Resources.edit;
            this.btnLbCustomColorsEditItem.Location = new System.Drawing.Point(1, 87);
            this.btnLbCustomColorsEditItem.Name = "btnLbCustomColorsEditItem";
            this.btnLbCustomColorsEditItem.Size = new System.Drawing.Size(36, 36);
            this.btnLbCustomColorsEditItem.TabIndex = 1;
            this.btnLbCustomColorsEditItem.UseVisualStyleBackColor = true;
            this.btnLbCustomColorsEditItem.Click += new System.EventHandler(this.btnLbCustomColorsEditItem_Click);
            // 
            // btnLbCustomColorsMoveUpItem
            // 
            this.btnLbCustomColorsMoveUpItem.FlatAppearance.BorderSize = 0;
            this.btnLbCustomColorsMoveUpItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLbCustomColorsMoveUpItem.Image = global::GradientColorStudio.Properties.Resources.up;
            this.btnLbCustomColorsMoveUpItem.Location = new System.Drawing.Point(1, 129);
            this.btnLbCustomColorsMoveUpItem.Name = "btnLbCustomColorsMoveUpItem";
            this.btnLbCustomColorsMoveUpItem.Size = new System.Drawing.Size(36, 36);
            this.btnLbCustomColorsMoveUpItem.TabIndex = 1;
            this.btnLbCustomColorsMoveUpItem.UseVisualStyleBackColor = true;
            this.btnLbCustomColorsMoveUpItem.Click += new System.EventHandler(this.btnLbCustomColorsMoveUpItem_Click);
            // 
            // btnLbCustomColorsRemoveItem
            // 
            this.btnLbCustomColorsRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnLbCustomColorsRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLbCustomColorsRemoveItem.Image = global::GradientColorStudio.Properties.Resources.subtract;
            this.btnLbCustomColorsRemoveItem.Location = new System.Drawing.Point(1, 45);
            this.btnLbCustomColorsRemoveItem.Name = "btnLbCustomColorsRemoveItem";
            this.btnLbCustomColorsRemoveItem.Size = new System.Drawing.Size(36, 36);
            this.btnLbCustomColorsRemoveItem.TabIndex = 0;
            this.btnLbCustomColorsRemoveItem.UseVisualStyleBackColor = true;
            this.btnLbCustomColorsRemoveItem.Click += new System.EventHandler(this.btnLbCustomColorsRemoveItem_Click);
            // 
            // btnLbCustomColorsAddItem
            // 
            this.btnLbCustomColorsAddItem.FlatAppearance.BorderSize = 0;
            this.btnLbCustomColorsAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLbCustomColorsAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnLbCustomColorsAddItem.Image")));
            this.btnLbCustomColorsAddItem.Location = new System.Drawing.Point(1, 3);
            this.btnLbCustomColorsAddItem.Name = "btnLbCustomColorsAddItem";
            this.btnLbCustomColorsAddItem.Size = new System.Drawing.Size(36, 36);
            this.btnLbCustomColorsAddItem.TabIndex = 0;
            this.btnLbCustomColorsAddItem.UseVisualStyleBackColor = true;
            this.btnLbCustomColorsAddItem.Click += new System.EventHandler(this.btnLbCustomColorsAddItem_Click);
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnlAbout.Controls.Add(this.panel3);
            this.pnlAbout.Location = new System.Drawing.Point(347, 326);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(327, 324);
            this.pnlAbout.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.goWebsite);
            this.panel3.Controls.Add(this.pbAppIco);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.goLicense);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(49, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 163);
            this.panel3.TabIndex = 0;
            // 
            // goWebsite
            // 
            this.goWebsite.AutoSize = true;
            this.goWebsite.BackColor = System.Drawing.Color.Transparent;
            this.goWebsite.LinkColor = System.Drawing.SystemColors.Control;
            this.goWebsite.Location = new System.Drawing.Point(106, 117);
            this.goWebsite.Name = "goWebsite";
            this.goWebsite.Size = new System.Drawing.Size(89, 17);
            this.goWebsite.TabIndex = 2;
            this.goWebsite.TabStop = true;
            this.goWebsite.Text = "Visit Website";
            this.goWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goWebsite_LinkClicked);
            // 
            // pbAppIco
            // 
            this.pbAppIco.BackColor = System.Drawing.Color.Transparent;
            this.pbAppIco.Image = global::GradientColorStudio.Properties.Resources.front_icon;
            this.pbAppIco.Location = new System.Drawing.Point(77, 0);
            this.pbAppIco.Name = "pbAppIco";
            this.pbAppIco.Size = new System.Drawing.Size(76, 70);
            this.pbAppIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAppIco.TabIndex = 0;
            this.pbAppIco.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gradient Color Studio";
            // 
            // goLicense
            // 
            this.goLicense.AutoSize = true;
            this.goLicense.BackColor = System.Drawing.Color.Transparent;
            this.goLicense.LinkColor = System.Drawing.SystemColors.Control;
            this.goLicense.Location = new System.Drawing.Point(43, 116);
            this.goLicense.Name = "goLicense";
            this.goLicense.Size = new System.Drawing.Size(57, 17);
            this.goLicense.TabIndex = 2;
            this.goLicense.TabStop = true;
            this.goLicense.Text = "License";
            this.goLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goLicense_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Version: 1.0";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel6.Controls.Add(this.pnlRgbHtml);
            this.panel6.Controls.Add(this.chckBxCustomColors);
            this.panel6.Location = new System.Drawing.Point(11, 326);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(329, 27);
            this.panel6.TabIndex = 12;
            // 
            // pnlRgbHtml
            // 
            this.pnlRgbHtml.BackColor = System.Drawing.Color.Gray;
            this.pnlRgbHtml.Controls.Add(this.rbHtml);
            this.pnlRgbHtml.Controls.Add(this.rbRgb);
            this.pnlRgbHtml.Enabled = false;
            this.pnlRgbHtml.Location = new System.Drawing.Point(158, -1);
            this.pnlRgbHtml.Name = "pnlRgbHtml";
            this.pnlRgbHtml.Size = new System.Drawing.Size(170, 31);
            this.pnlRgbHtml.TabIndex = 3;
            // 
            // rbHtml
            // 
            this.rbHtml.AutoSize = true;
            this.rbHtml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbHtml.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbHtml.ForeColor = System.Drawing.SystemColors.Control;
            this.rbHtml.Location = new System.Drawing.Point(85, 0);
            this.rbHtml.Name = "rbHtml";
            this.rbHtml.Size = new System.Drawing.Size(78, 28);
            this.rbHtml.TabIndex = 3;
            this.rbHtml.Text = "HTML";
            this.rbHtml.UseVisualStyleBackColor = true;
            // 
            // rbRgb
            // 
            this.rbRgb.AutoSize = true;
            this.rbRgb.Checked = true;
            this.rbRgb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRgb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbRgb.ForeColor = System.Drawing.SystemColors.Control;
            this.rbRgb.Location = new System.Drawing.Point(14, 0);
            this.rbRgb.Name = "rbRgb";
            this.rbRgb.Size = new System.Drawing.Size(65, 28);
            this.rbRgb.TabIndex = 3;
            this.rbRgb.TabStop = true;
            this.rbRgb.Text = "RGB";
            this.rbRgb.UseVisualStyleBackColor = true;
            this.rbRgb.CheckedChanged += new System.EventHandler(this.rbRgb_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel7.Location = new System.Drawing.Point(347, 239);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(325, 10);
            this.panel7.TabIndex = 13;
            // 
            // lbRendererType
            // 
            this.lbRendererType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lbRendererType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRendererType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbRendererType.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbRendererType.ForeColor = System.Drawing.SystemColors.Control;
            this.lbRendererType.FormattingEnabled = true;
            this.lbRendererType.ItemHeight = 20;
            this.lbRendererType.Items.AddRange(new object[] {
            "Ellipse",
            "Square",
            "Triangle",
            "Hexagon"});
            this.lbRendererType.Location = new System.Drawing.Point(0, 73);
            this.lbRendererType.Name = "lbRendererType";
            this.lbRendererType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbRendererType.Size = new System.Drawing.Size(86, 117);
            this.lbRendererType.TabIndex = 14;
            this.lbRendererType.SelectedIndexChanged += new System.EventHandler(this.lbRendererType_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.lbRendererType);
            this.panel4.Location = new System.Drawing.Point(12, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 236);
            this.panel4.TabIndex = 9;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // pbRenderer
            // 
            this.pbRenderer.Location = new System.Drawing.Point(104, 13);
            this.pbRenderer.Name = "pbRenderer";
            this.pbRenderer.Size = new System.Drawing.Size(236, 236);
            this.pbRenderer.TabIndex = 0;
            this.pbRenderer.TabStop = false;
            this.pbRenderer.DoubleClick += new System.EventHandler(this.pbRenderer_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(685, 659);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lbColors);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlLbCustomColorsButtons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbColorModel);
            this.Controls.Add(this.lbCustomColors);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pbRenderer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gradient Color Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownColorCount)).EndInit();
            this.pnlLbCustomColorsButtons.ResumeLayout(false);
            this.pnlAbout.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppIco)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlRgbHtml.ResumeLayout(false);
            this.pnlRgbHtml.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRenderer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRenderer;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chckBxCustomColors;
        private System.Windows.Forms.ListBox lbCustomColors;
        private System.Windows.Forms.ListBox lbColors;
        private System.Windows.Forms.ComboBox cbColorModel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlLbCustomColorsButtons;
        private System.Windows.Forms.NumericUpDown numUpDownColorCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGradientStyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLbCustomColorsAddItem;
        private System.Windows.Forms.Button btnLbCustomColorsRemoveItem;
        private System.Windows.Forms.Button btnLbCustomColorsMoveUpItem;
        private System.Windows.Forms.Button btnLbCustomColorsMoveDownItem;
        private System.Windows.Forms.Button btnLbCustomColorsRemoveAllItem;
        private System.Windows.Forms.Panel pnlRgbHtml;
        private System.Windows.Forms.RadioButton rbHtml;
        private System.Windows.Forms.RadioButton rbRgb;
        private System.Windows.Forms.ListBox lbRendererType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnLbCustomColorsEditItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel goLicense;
        private System.Windows.Forms.LinkLabel goWebsite;
        private System.Windows.Forms.PictureBox pbAppIco;
        private System.Windows.Forms.Panel panel3;
    }
}

