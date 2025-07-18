namespace Pekeman
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picBackgroundMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(141, 263);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnPlay.Size = new System.Drawing.Size(200, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "JOUER";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.UseCompatibleTextRendering = true;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Transparent;
            this.btnRules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRules.BackgroundImage")));
            this.btnRules.FlatAppearance.BorderSize = 0;
            this.btnRules.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Location = new System.Drawing.Point(141, 345);
            this.btnRules.Margin = new System.Windows.Forms.Padding(0);
            this.btnRules.Name = "btnRules";
            this.btnRules.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnRules.Size = new System.Drawing.Size(200, 40);
            this.btnRules.TabIndex = 1;
            this.btnRules.Text = "OPTIONS";
            this.btnRules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRules.UseCompatibleTextRendering = true;
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(141, 424);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnQuit.Size = new System.Drawing.Size(200, 40);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "QUITTER";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuit.UseCompatibleTextRendering = true;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Pekeman.Properties.Resources.pekemanLogo;
            this.picLogo.Location = new System.Drawing.Point(61, 78);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(356, 127);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = global::Pekeman.Properties.Resources.menu1;
            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Controls.Add(this.btnQuit);
            this.pnlMenu.Controls.Add(this.btnRules);
            this.pnlMenu.Controls.Add(this.btnPlay);
            this.pnlMenu.Controls.Add(this.picBackgroundMenu);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(484, 590);
            this.pnlMenu.TabIndex = 4;
            // 
            // picBackgroundMenu
            // 
            this.picBackgroundMenu.Image = ((System.Drawing.Image)(resources.GetObject("picBackgroundMenu.Image")));
            this.picBackgroundMenu.Location = new System.Drawing.Point(0, 0);
            this.picBackgroundMenu.Name = "picBackgroundMenu";
            this.picBackgroundMenu.Size = new System.Drawing.Size(484, 590);
            this.picBackgroundMenu.TabIndex = 0;
            this.picBackgroundMenu.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 590);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picBackgroundMenu;
    }
}