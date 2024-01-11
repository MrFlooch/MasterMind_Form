namespace MasterMind_Form
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.foregroundImagePnl = new System.Windows.Forms.Panel();
            this.quitBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.optionBtn = new System.Windows.Forms.Button();
            this.titleCard = new System.Windows.Forms.Label();
            this.backgroundImagePnl = new System.Windows.Forms.Panel();
            this.foregroundImagePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // foregroundImagePnl
            // 
            this.foregroundImagePnl.BackColor = System.Drawing.Color.Gray;
            this.foregroundImagePnl.BackgroundImage = global::MasterMind_Form.Properties.Resources.transparent;
            this.foregroundImagePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foregroundImagePnl.Controls.Add(this.quitBtn);
            this.foregroundImagePnl.Controls.Add(this.playBtn);
            this.foregroundImagePnl.Controls.Add(this.rulesBtn);
            this.foregroundImagePnl.Controls.Add(this.optionBtn);
            this.foregroundImagePnl.Controls.Add(this.titleCard);
            this.foregroundImagePnl.Location = new System.Drawing.Point(12, 12);
            this.foregroundImagePnl.Name = "foregroundImagePnl";
            this.foregroundImagePnl.Size = new System.Drawing.Size(760, 437);
            this.foregroundImagePnl.TabIndex = 4;
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quitBtn.AutoSize = true;
            this.quitBtn.BackColor = System.Drawing.Color.Transparent;
            this.quitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quitBtn.BackgroundImage")));
            this.quitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitBtn.FlatAppearance.BorderSize = 3;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.Color.White;
            this.quitBtn.Location = new System.Drawing.Point(382, 293);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(298, 65);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Quitter";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playBtn.AutoSize = true;
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.FlatAppearance.BorderSize = 3;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(80, 131);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(600, 75);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Jouer";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rulesBtn.AutoSize = true;
            this.rulesBtn.BackColor = System.Drawing.Color.Transparent;
            this.rulesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rulesBtn.BackgroundImage")));
            this.rulesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rulesBtn.FlatAppearance.BorderSize = 3;
            this.rulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rulesBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesBtn.ForeColor = System.Drawing.Color.White;
            this.rulesBtn.Location = new System.Drawing.Point(80, 212);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(600, 75);
            this.rulesBtn.TabIndex = 0;
            this.rulesBtn.Text = "Règles";
            this.rulesBtn.UseVisualStyleBackColor = false;
            this.rulesBtn.Click += new System.EventHandler(this.RulesBtn_Click);
            // 
            // optionBtn
            // 
            this.optionBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionBtn.AutoSize = true;
            this.optionBtn.BackColor = System.Drawing.Color.Transparent;
            this.optionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("optionBtn.BackgroundImage")));
            this.optionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionBtn.FlatAppearance.BorderSize = 3;
            this.optionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionBtn.ForeColor = System.Drawing.Color.White;
            this.optionBtn.Location = new System.Drawing.Point(80, 293);
            this.optionBtn.Name = "optionBtn";
            this.optionBtn.Size = new System.Drawing.Size(296, 65);
            this.optionBtn.TabIndex = 1;
            this.optionBtn.Text = "Options";
            this.optionBtn.UseVisualStyleBackColor = false;
            this.optionBtn.Click += new System.EventHandler(this.OptionBtn_Click);
            // 
            // titleCard
            // 
            this.titleCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleCard.AutoSize = true;
            this.titleCard.BackColor = System.Drawing.Color.Transparent;
            this.titleCard.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleCard.Location = new System.Drawing.Point(193, 54);
            this.titleCard.Name = "titleCard";
            this.titleCard.Size = new System.Drawing.Size(372, 48);
            this.titleCard.TabIndex = 2;
            this.titleCard.Text = "Bienvenue sur MasterMind";
            this.titleCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backgroundImagePnl
            // 
            this.backgroundImagePnl.BackColor = System.Drawing.Color.Gray;
            this.backgroundImagePnl.BackgroundImage = global::MasterMind_Form.Properties.Resources.transparent;
            this.backgroundImagePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundImagePnl.Location = new System.Drawing.Point(12, 12);
            this.backgroundImagePnl.Name = "backgroundImagePnl";
            this.backgroundImagePnl.Size = new System.Drawing.Size(760, 437);
            this.backgroundImagePnl.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.foregroundImagePnl);
            this.Controls.Add(this.backgroundImagePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "MasterMind - Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.Menu_VisibleChanged);
            this.foregroundImagePnl.ResumeLayout(false);
            this.foregroundImagePnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rulesBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button optionBtn;
        private System.Windows.Forms.Label titleCard;
        private System.Windows.Forms.Panel foregroundImagePnl;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Panel backgroundImagePnl;
    }
}

