namespace MasterMind_Form
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.forgroundPnl = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.FrenchBx = new System.Windows.Forms.RadioButton();
            this.EnglishBx = new System.Windows.Forms.RadioButton();
            this.ItalianBx = new System.Windows.Forms.RadioButton();
            this.GermanBx = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.normalBackgroundBtn = new System.Windows.Forms.Button();
            this.woodBackgroundBtn = new System.Windows.Forms.Button();
            this.ironBackgroundBtn = new System.Windows.Forms.Button();
            this.woolBackgroundBtn = new System.Windows.Forms.Button();
            this.neonBackgroundBtn = new System.Windows.Forms.Button();
            this.optionTitle = new System.Windows.Forms.Label();
            this.optionText = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optionCheckBox = new System.Windows.Forms.CheckBox();
            this.colorLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundPnl = new System.Windows.Forms.Panel();
            this.forgroundPnl.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.backgroundPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // forgroundPnl
            // 
            this.forgroundPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forgroundPnl.BackColor = System.Drawing.Color.Gray;
            this.forgroundPnl.BackgroundImage = global::MasterMind_Form.Properties.Resources.transparent;
            this.forgroundPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forgroundPnl.ColumnCount = 3;
            this.forgroundPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.forgroundPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.forgroundPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.forgroundPnl.Controls.Add(this.flowLayoutPanel2, 1, 5);
            this.forgroundPnl.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.forgroundPnl.Controls.Add(this.optionTitle, 1, 1);
            this.forgroundPnl.Controls.Add(this.optionText, 1, 4);
            this.forgroundPnl.Controls.Add(this.menuBtn, 1, 6);
            this.forgroundPnl.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.forgroundPnl.Location = new System.Drawing.Point(0, 0);
            this.forgroundPnl.Name = "forgroundPnl";
            this.forgroundPnl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.forgroundPnl.RowCount = 8;
            this.forgroundPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.forgroundPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.forgroundPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.83099F));
            this.forgroundPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.95305F));
            this.forgroundPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.5F));
            this.forgroundPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.5F));
            this.forgroundPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.forgroundPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.forgroundPnl.Size = new System.Drawing.Size(776, 426);
            this.forgroundPnl.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.Controls.Add(this.FrenchBx);
            this.flowLayoutPanel2.Controls.Add(this.EnglishBx);
            this.flowLayoutPanel2.Controls.Add(this.ItalianBx);
            this.flowLayoutPanel2.Controls.Add(this.GermanBx);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(41, 310);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(692, 38);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // FrenchBx
            // 
            this.FrenchBx.AutoSize = true;
            this.FrenchBx.BackColor = System.Drawing.Color.Transparent;
            this.FrenchBx.Checked = true;
            this.FrenchBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrenchBx.Location = new System.Drawing.Point(3, 3);
            this.FrenchBx.Name = "FrenchBx";
            this.FrenchBx.Size = new System.Drawing.Size(100, 28);
            this.FrenchBx.TabIndex = 5;
            this.FrenchBx.TabStop = true;
            this.FrenchBx.Text = "Français";
            this.FrenchBx.UseVisualStyleBackColor = false;
            this.FrenchBx.CheckedChanged += new System.EventHandler(this.LanguagesBx_CheckedChanged);
            // 
            // EnglishBx
            // 
            this.EnglishBx.AutoSize = true;
            this.EnglishBx.BackColor = System.Drawing.Color.Transparent;
            this.EnglishBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishBx.Location = new System.Drawing.Point(109, 3);
            this.EnglishBx.Name = "EnglishBx";
            this.EnglishBx.Size = new System.Drawing.Size(91, 28);
            this.EnglishBx.TabIndex = 6;
            this.EnglishBx.Text = "English";
            this.EnglishBx.UseVisualStyleBackColor = false;
            this.EnglishBx.CheckedChanged += new System.EventHandler(this.LanguagesBx_CheckedChanged);
            // 
            // ItalianBx
            // 
            this.ItalianBx.AutoSize = true;
            this.ItalianBx.BackColor = System.Drawing.Color.Transparent;
            this.ItalianBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItalianBx.Location = new System.Drawing.Point(206, 3);
            this.ItalianBx.Name = "ItalianBx";
            this.ItalianBx.Size = new System.Drawing.Size(86, 28);
            this.ItalianBx.TabIndex = 7;
            this.ItalianBx.Text = "Italiano";
            this.ItalianBx.UseVisualStyleBackColor = false;
            this.ItalianBx.CheckedChanged += new System.EventHandler(this.LanguagesBx_CheckedChanged);
            // 
            // GermanBx
            // 
            this.GermanBx.AutoSize = true;
            this.GermanBx.BackColor = System.Drawing.Color.Transparent;
            this.GermanBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GermanBx.Location = new System.Drawing.Point(298, 3);
            this.GermanBx.Name = "GermanBx";
            this.GermanBx.Size = new System.Drawing.Size(97, 28);
            this.GermanBx.TabIndex = 8;
            this.GermanBx.Text = "Deutsch";
            this.GermanBx.UseVisualStyleBackColor = false;
            this.GermanBx.CheckedChanged += new System.EventHandler(this.LanguagesBx_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.normalBackgroundBtn);
            this.flowLayoutPanel1.Controls.Add(this.woodBackgroundBtn);
            this.flowLayoutPanel1.Controls.Add(this.ironBackgroundBtn);
            this.flowLayoutPanel1.Controls.Add(this.woolBackgroundBtn);
            this.flowLayoutPanel1.Controls.Add(this.neonBackgroundBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(692, 83);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // normalBackgroundBtn
            // 
            this.normalBackgroundBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.normalBackgroundBtn.BackColor = System.Drawing.Color.Gray;
            this.normalBackgroundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.normalBackgroundBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.normalBackgroundBtn.FlatAppearance.BorderSize = 3;
            this.normalBackgroundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalBackgroundBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalBackgroundBtn.ForeColor = System.Drawing.Color.White;
            this.normalBackgroundBtn.Location = new System.Drawing.Point(3, 3);
            this.normalBackgroundBtn.Name = "normalBackgroundBtn";
            this.normalBackgroundBtn.Size = new System.Drawing.Size(132, 75);
            this.normalBackgroundBtn.TabIndex = 7;
            this.normalBackgroundBtn.Text = "Classique";
            this.normalBackgroundBtn.UseVisualStyleBackColor = false;
            this.normalBackgroundBtn.Click += new System.EventHandler(this.BackgroundBtn_Click);
            // 
            // woodBackgroundBtn
            // 
            this.woodBackgroundBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.woodBackgroundBtn.BackgroundImage = global::MasterMind_Form.Properties.Resources.woodBtn;
            this.woodBackgroundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.woodBackgroundBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.woodBackgroundBtn.FlatAppearance.BorderSize = 3;
            this.woodBackgroundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.woodBackgroundBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woodBackgroundBtn.ForeColor = System.Drawing.Color.Black;
            this.woodBackgroundBtn.Location = new System.Drawing.Point(141, 3);
            this.woodBackgroundBtn.Name = "woodBackgroundBtn";
            this.woodBackgroundBtn.Size = new System.Drawing.Size(132, 75);
            this.woodBackgroundBtn.TabIndex = 7;
            this.woodBackgroundBtn.Text = "Bois";
            this.woodBackgroundBtn.UseVisualStyleBackColor = true;
            this.woodBackgroundBtn.Click += new System.EventHandler(this.WoodBackgroundBtn_Click);
            // 
            // ironBackgroundBtn
            // 
            this.ironBackgroundBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ironBackgroundBtn.BackgroundImage = global::MasterMind_Form.Properties.Resources.ironBtn;
            this.ironBackgroundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ironBackgroundBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ironBackgroundBtn.FlatAppearance.BorderSize = 3;
            this.ironBackgroundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ironBackgroundBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ironBackgroundBtn.ForeColor = System.Drawing.Color.White;
            this.ironBackgroundBtn.Location = new System.Drawing.Point(279, 3);
            this.ironBackgroundBtn.Name = "ironBackgroundBtn";
            this.ironBackgroundBtn.Size = new System.Drawing.Size(132, 75);
            this.ironBackgroundBtn.TabIndex = 7;
            this.ironBackgroundBtn.Text = "Fer";
            this.ironBackgroundBtn.UseVisualStyleBackColor = true;
            this.ironBackgroundBtn.Click += new System.EventHandler(this.IronBackgroundBtn_Click);
            // 
            // woolBackgroundBtn
            // 
            this.woolBackgroundBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.woolBackgroundBtn.BackgroundImage = global::MasterMind_Form.Properties.Resources.woolBtn;
            this.woolBackgroundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.woolBackgroundBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.woolBackgroundBtn.FlatAppearance.BorderSize = 3;
            this.woolBackgroundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.woolBackgroundBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woolBackgroundBtn.ForeColor = System.Drawing.Color.White;
            this.woolBackgroundBtn.Location = new System.Drawing.Point(417, 3);
            this.woolBackgroundBtn.Name = "woolBackgroundBtn";
            this.woolBackgroundBtn.Size = new System.Drawing.Size(132, 75);
            this.woolBackgroundBtn.TabIndex = 7;
            this.woolBackgroundBtn.Text = "Poker";
            this.woolBackgroundBtn.UseVisualStyleBackColor = true;
            this.woolBackgroundBtn.Click += new System.EventHandler(this.WoolBackgroundBtn_Click);
            // 
            // neonBackgroundBtn
            // 
            this.neonBackgroundBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.neonBackgroundBtn.BackColor = System.Drawing.Color.Black;
            this.neonBackgroundBtn.BackgroundImage = global::MasterMind_Form.Properties.Resources.neon;
            this.neonBackgroundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.neonBackgroundBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.neonBackgroundBtn.FlatAppearance.BorderSize = 3;
            this.neonBackgroundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neonBackgroundBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neonBackgroundBtn.ForeColor = System.Drawing.Color.White;
            this.neonBackgroundBtn.Location = new System.Drawing.Point(555, 3);
            this.neonBackgroundBtn.Name = "neonBackgroundBtn";
            this.neonBackgroundBtn.Size = new System.Drawing.Size(132, 75);
            this.neonBackgroundBtn.TabIndex = 7;
            this.neonBackgroundBtn.Text = "Neon";
            this.neonBackgroundBtn.UseVisualStyleBackColor = false;
            this.neonBackgroundBtn.Click += new System.EventHandler(this.NeonBackgroundBtn_Click);
            // 
            // optionTitle
            // 
            this.optionTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionTitle.AutoSize = true;
            this.optionTitle.BackColor = System.Drawing.Color.Transparent;
            this.optionTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionTitle.Location = new System.Drawing.Point(327, 29);
            this.optionTitle.Name = "optionTitle";
            this.optionTitle.Size = new System.Drawing.Size(119, 48);
            this.optionTitle.TabIndex = 4;
            this.optionTitle.Text = "Options";
            // 
            // optionText
            // 
            this.optionText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.optionText.AutoSize = true;
            this.optionText.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionText.Location = new System.Drawing.Point(41, 267);
            this.optionText.Name = "optionText";
            this.optionText.Size = new System.Drawing.Size(85, 35);
            this.optionText.TabIndex = 5;
            this.optionText.Text = "Langue";
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.menuBtn.AutoSize = true;
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.FlatAppearance.BorderSize = 3;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Location = new System.Drawing.Point(624, 357);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(109, 39);
            this.menuBtn.TabIndex = 2;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.42196F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.57803F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorLayoutPnl, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 181);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 79);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.optionCheckBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 73);
            this.panel1.TabIndex = 1;
            // 
            // optionCheckBox
            // 
            this.optionCheckBox.AutoSize = true;
            this.optionCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optionCheckBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCheckBox.Location = new System.Drawing.Point(0, 17);
            this.optionCheckBox.Name = "optionCheckBox";
            this.optionCheckBox.Size = new System.Drawing.Size(142, 39);
            this.optionCheckBox.TabIndex = 1;
            this.optionCheckBox.Text = "Daltonisme";
            this.optionCheckBox.UseVisualStyleBackColor = true;
            this.optionCheckBox.CheckedChanged += new System.EventHandler(this.optionCheckBox_CheckedChanged);
            // 
            // colorLayoutPnl
            // 
            this.colorLayoutPnl.ColumnCount = 7;
            this.colorLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorLayoutPnl.Location = new System.Drawing.Point(171, 3);
            this.colorLayoutPnl.Name = "colorLayoutPnl";
            this.colorLayoutPnl.RowCount = 1;
            this.colorLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.colorLayoutPnl.Size = new System.Drawing.Size(517, 73);
            this.colorLayoutPnl.TabIndex = 4;
            // 
            // backgroundPnl
            // 
            this.backgroundPnl.BackColor = System.Drawing.Color.Gray;
            this.backgroundPnl.Controls.Add(this.forgroundPnl);
            this.backgroundPnl.Location = new System.Drawing.Point(12, 12);
            this.backgroundPnl.Name = "backgroundPnl";
            this.backgroundPnl.Size = new System.Drawing.Size(776, 426);
            this.backgroundPnl.TabIndex = 4;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backgroundPnl);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Options";
            this.Text = "MasterMind - Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.forgroundPnl.ResumeLayout(false);
            this.forgroundPnl.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.backgroundPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel forgroundPnl;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Label optionTitle;
        private System.Windows.Forms.Label optionText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button woodBackgroundBtn;
        private System.Windows.Forms.Button ironBackgroundBtn;
        private System.Windows.Forms.Button woolBackgroundBtn;
        private System.Windows.Forms.Button neonBackgroundBtn;
        private System.Windows.Forms.Button normalBackgroundBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel colorLayoutPnl;
        private System.Windows.Forms.RadioButton FrenchBx;
        private System.Windows.Forms.RadioButton EnglishBx;
        private System.Windows.Forms.RadioButton ItalianBx;
        private System.Windows.Forms.RadioButton GermanBx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox optionCheckBox;
        private System.Windows.Forms.Panel backgroundPnl;
    }
}