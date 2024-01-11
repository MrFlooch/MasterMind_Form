namespace MasterMind_Form
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.label1 = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.Button();
            this.ruleTitle = new System.Windows.Forms.Label();
            this.textLbl = new System.Windows.Forms.Label();
            this.foregroundImagePnl = new System.Windows.Forms.Panel();
            this.textPnl = new System.Windows.Forms.Panel();
            this.backgroundImagePnl = new System.Windows.Forms.Panel();
            this.foregroundImagePnl.SuspendLayout();
            this.textPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
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
            this.menuBtn.Location = new System.Drawing.Point(628, 408);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(109, 39);
            this.menuBtn.TabIndex = 2;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // ruleTitle
            // 
            this.ruleTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ruleTitle.AutoSize = true;
            this.ruleTitle.BackColor = System.Drawing.Color.Transparent;
            this.ruleTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleTitle.ForeColor = System.Drawing.Color.White;
            this.ruleTitle.Location = new System.Drawing.Point(336, 20);
            this.ruleTitle.Name = "ruleTitle";
            this.ruleTitle.Size = new System.Drawing.Size(108, 48);
            this.ruleTitle.TabIndex = 4;
            this.ruleTitle.Text = "Règles";
            // 
            // textLbl
            // 
            this.textLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLbl.AutoSize = true;
            this.textLbl.BackColor = System.Drawing.Color.Transparent;
            this.textLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLbl.ForeColor = System.Drawing.Color.White;
            this.textLbl.Location = new System.Drawing.Point(13, 13);
            this.textLbl.MaximumSize = new System.Drawing.Size(1690, 1276);
            this.textLbl.MinimumSize = new System.Drawing.Size(690, 276);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(690, 276);
            this.textLbl.TabIndex = 3;
            this.textLbl.Text = resources.GetString("textLbl.Text");
            // 
            // foregroundImagePnl
            // 
            this.foregroundImagePnl.BackColor = System.Drawing.Color.Gray;
            this.foregroundImagePnl.Controls.Add(this.textPnl);
            this.foregroundImagePnl.Controls.Add(this.menuBtn);
            this.foregroundImagePnl.Controls.Add(this.ruleTitle);
            this.foregroundImagePnl.ForeColor = System.Drawing.Color.Gray;
            this.foregroundImagePnl.Location = new System.Drawing.Point(11, 12);
            this.foregroundImagePnl.Name = "foregroundImagePnl";
            this.foregroundImagePnl.Size = new System.Drawing.Size(776, 458);
            this.foregroundImagePnl.TabIndex = 3;
            // 
            // textPnl
            // 
            this.textPnl.BackColor = System.Drawing.Color.Gray;
            this.textPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textPnl.Controls.Add(this.textLbl);
            this.textPnl.ForeColor = System.Drawing.Color.Gray;
            this.textPnl.Location = new System.Drawing.Point(32, 94);
            this.textPnl.Name = "textPnl";
            this.textPnl.Size = new System.Drawing.Size(705, 304);
            this.textPnl.TabIndex = 4;
            // 
            // backgroundImagePnl
            // 
            this.backgroundImagePnl.BackColor = System.Drawing.Color.Gray;
            this.backgroundImagePnl.ForeColor = System.Drawing.Color.Transparent;
            this.backgroundImagePnl.Location = new System.Drawing.Point(11, 12);
            this.backgroundImagePnl.Name = "backgroundImagePnl";
            this.backgroundImagePnl.Size = new System.Drawing.Size(776, 458);
            this.backgroundImagePnl.TabIndex = 5;
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.foregroundImagePnl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backgroundImagePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rules";
            this.Text = "MasterMind - Rules";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Rules_Load);
            this.foregroundImagePnl.ResumeLayout(false);
            this.foregroundImagePnl.PerformLayout();
            this.textPnl.ResumeLayout(false);
            this.textPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Label textLbl;
        private System.Windows.Forms.Label ruleTitle;
        private System.Windows.Forms.Panel foregroundImagePnl;
        private System.Windows.Forms.Panel textPnl;
        private System.Windows.Forms.Panel backgroundImagePnl;
    }
}