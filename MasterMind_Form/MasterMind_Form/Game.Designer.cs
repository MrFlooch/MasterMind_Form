namespace MasterMind_Form
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.backgroundImagePnl = new System.Windows.Forms.Panel();
            this.foregroundImagePnl = new System.Windows.Forms.Panel();
            this.menuBtnPnl = new System.Windows.Forms.TableLayoutPanel();
            this.validBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.gridPnl = new System.Windows.Forms.Panel();
            this.hintPnl = new System.Windows.Forms.Panel();
            this.colorPnl = new System.Windows.Forms.Panel();
            this.codePnl = new System.Windows.Forms.Panel();
            this.colorBtnPnl = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundImagePnl.SuspendLayout();
            this.foregroundImagePnl.SuspendLayout();
            this.menuBtnPnl.SuspendLayout();
            this.gridPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundImagePnl
            // 
            this.backgroundImagePnl.BackColor = System.Drawing.Color.Gray;
            this.backgroundImagePnl.BackgroundImage = global::MasterMind_Form.Properties.Resources.transparent;
            this.backgroundImagePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundImagePnl.Controls.Add(this.foregroundImagePnl);
            this.backgroundImagePnl.Location = new System.Drawing.Point(12, 12);
            this.backgroundImagePnl.Name = "backgroundImagePnl";
            this.backgroundImagePnl.Size = new System.Drawing.Size(460, 735);
            this.backgroundImagePnl.TabIndex = 15;
            // 
            // foregroundImagePnl
            // 
            this.foregroundImagePnl.BackColor = System.Drawing.Color.Gray;
            this.foregroundImagePnl.BackgroundImage = global::MasterMind_Form.Properties.Resources.transparent;
            this.foregroundImagePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foregroundImagePnl.Controls.Add(this.menuBtnPnl);
            this.foregroundImagePnl.Controls.Add(this.gridPnl);
            this.foregroundImagePnl.Controls.Add(this.colorBtnPnl);
            this.foregroundImagePnl.Location = new System.Drawing.Point(0, 0);
            this.foregroundImagePnl.Name = "foregroundImagePnl";
            this.foregroundImagePnl.Size = new System.Drawing.Size(460, 735);
            this.foregroundImagePnl.TabIndex = 6;
            // 
            // menuBtnPnl
            // 
            this.menuBtnPnl.BackColor = System.Drawing.Color.Transparent;
            this.menuBtnPnl.ColumnCount = 2;
            this.menuBtnPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuBtnPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuBtnPnl.Controls.Add(this.validBtn, 0, 0);
            this.menuBtnPnl.Controls.Add(this.undoBtn, 0, 1);
            this.menuBtnPnl.Controls.Add(this.resetBtn, 1, 0);
            this.menuBtnPnl.Controls.Add(this.menuBtn, 1, 1);
            this.menuBtnPnl.Location = new System.Drawing.Point(245, 635);
            this.menuBtnPnl.Name = "menuBtnPnl";
            this.menuBtnPnl.RowCount = 2;
            this.menuBtnPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuBtnPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuBtnPnl.Size = new System.Drawing.Size(200, 80);
            this.menuBtnPnl.TabIndex = 13;
            // 
            // validBtn
            // 
            this.validBtn.BackColor = System.Drawing.Color.Transparent;
            this.validBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("validBtn.BackgroundImage")));
            this.validBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validBtn.FlatAppearance.BorderSize = 3;
            this.validBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validBtn.ForeColor = System.Drawing.Color.White;
            this.validBtn.Location = new System.Drawing.Point(3, 3);
            this.validBtn.Name = "validBtn";
            this.validBtn.Size = new System.Drawing.Size(90, 34);
            this.validBtn.TabIndex = 2;
            this.validBtn.Text = "OK";
            this.validBtn.UseVisualStyleBackColor = false;
            this.validBtn.Click += new System.EventHandler(this.ValidBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.BackColor = System.Drawing.Color.Transparent;
            this.undoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("undoBtn.BackgroundImage")));
            this.undoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoBtn.FlatAppearance.BorderSize = 3;
            this.undoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoBtn.ForeColor = System.Drawing.Color.White;
            this.undoBtn.Location = new System.Drawing.Point(3, 43);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(90, 34);
            this.undoBtn.TabIndex = 2;
            this.undoBtn.Text = "Annuler";
            this.undoBtn.UseVisualStyleBackColor = false;
            this.undoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FlatAppearance.BorderSize = 3;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(103, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(90, 34);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Réinit.";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuBtn.BackgroundImage")));
            this.menuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.FlatAppearance.BorderSize = 3;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Location = new System.Drawing.Point(103, 43);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(90, 34);
            this.menuBtn.TabIndex = 2;
            this.menuBtn.Text = "Quitter";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // gridPnl
            // 
            this.gridPnl.BackColor = System.Drawing.Color.Transparent;
            this.gridPnl.BackgroundImage = global::MasterMind_Form.Properties.Resources.transparent;
            this.gridPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gridPnl.Controls.Add(this.hintPnl);
            this.gridPnl.Controls.Add(this.colorPnl);
            this.gridPnl.Controls.Add(this.codePnl);
            this.gridPnl.Location = new System.Drawing.Point(23, 16);
            this.gridPnl.Name = "gridPnl";
            this.gridPnl.Size = new System.Drawing.Size(350, 670);
            this.gridPnl.TabIndex = 14;
            // 
            // hintPnl
            // 
            this.hintPnl.BackColor = System.Drawing.Color.Transparent;
            this.hintPnl.Location = new System.Drawing.Point(231, 20);
            this.hintPnl.Name = "hintPnl";
            this.hintPnl.Size = new System.Drawing.Size(125, 580);
            this.hintPnl.TabIndex = 11;
            // 
            // colorPnl
            // 
            this.colorPnl.BackColor = System.Drawing.Color.Transparent;
            this.colorPnl.Location = new System.Drawing.Point(18, 13);
            this.colorPnl.Name = "colorPnl";
            this.colorPnl.Size = new System.Drawing.Size(200, 580);
            this.colorPnl.TabIndex = 10;
            // 
            // codePnl
            // 
            this.codePnl.BackColor = System.Drawing.Color.Transparent;
            this.codePnl.Location = new System.Drawing.Point(18, 617);
            this.codePnl.Name = "codePnl";
            this.codePnl.Size = new System.Drawing.Size(640, 50);
            this.codePnl.TabIndex = 12;
            // 
            // colorBtnPnl
            // 
            this.colorBtnPnl.BackColor = System.Drawing.Color.Transparent;
            this.colorBtnPnl.ColumnCount = 1;
            this.colorBtnPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.colorBtnPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.colorBtnPnl.Location = new System.Drawing.Point(380, 25);
            this.colorBtnPnl.Name = "colorBtnPnl";
            this.colorBtnPnl.RowCount = 7;
            this.colorBtnPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorBtnPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorBtnPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorBtnPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorBtnPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorBtnPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorBtnPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.colorBtnPnl.Size = new System.Drawing.Size(69, 422);
            this.colorBtnPnl.TabIndex = 0;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 761);
            this.Controls.Add(this.backgroundImagePnl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "MasterMind - Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.backgroundImagePnl.ResumeLayout(false);
            this.foregroundImagePnl.ResumeLayout(false);
            this.menuBtnPnl.ResumeLayout(false);
            this.gridPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel colorBtnPnl;
        private System.Windows.Forms.Button validBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Panel foregroundImagePnl;
        private System.Windows.Forms.Panel hintPnl;
        private System.Windows.Forms.Panel colorPnl;
        private System.Windows.Forms.Panel codePnl;
        private System.Windows.Forms.TableLayoutPanel menuBtnPnl;
        private System.Windows.Forms.Panel gridPnl;
        private System.Windows.Forms.Panel backgroundImagePnl;
    }
}

