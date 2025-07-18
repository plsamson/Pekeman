namespace Pekeman
{
    partial class Pokecenter
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgSelectedPekeman = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClosePekecentre = new System.Windows.Forms.Button();
            this.lblPekemanHealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelectedPekeman)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSelectedPekeman
            // 
            this.imgSelectedPekeman.BackColor = System.Drawing.Color.Transparent;
            this.imgSelectedPekeman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgSelectedPekeman.Location = new System.Drawing.Point(395, 208);
            this.imgSelectedPekeman.Name = "imgSelectedPekeman";
            this.imgSelectedPekeman.Size = new System.Drawing.Size(117, 111);
            this.imgSelectedPekeman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgSelectedPekeman.TabIndex = 19;
            this.imgSelectedPekeman.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(314, 97);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblWelcome.Size = new System.Drawing.Size(173, 73);
            this.lblWelcome.TabIndex = 18;
            this.lblWelcome.Text = "Bienvenue au Centre Pekeman!\n\nJe peux soigner votre\n\nPekeman si vous le désirez.";
            this.lblWelcome.UseCompatibleTextRendering = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(342, 348);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(222, 30);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirm.UseCompatibleTextRendering = true;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClosePekecentre
            // 
            this.btnClosePekecentre.BackColor = System.Drawing.Color.Black;
            this.btnClosePekecentre.BackgroundImage = global::Pekeman.Properties.Resources.btnClose;
            this.btnClosePekecentre.FlatAppearance.BorderSize = 0;
            this.btnClosePekecentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePekecentre.Location = new System.Drawing.Point(946, 14);
            this.btnClosePekecentre.Margin = new System.Windows.Forms.Padding(2);
            this.btnClosePekecentre.Name = "btnClosePekecentre";
            this.btnClosePekecentre.Size = new System.Drawing.Size(50, 50);
            this.btnClosePekecentre.TabIndex = 20;
            this.btnClosePekecentre.UseVisualStyleBackColor = false;
            this.btnClosePekecentre.Click += new System.EventHandler(this.btnClosePekecentre_Click);
            // 
            // lblPekemanHealth
            // 
            this.lblPekemanHealth.AutoSize = true;
            this.lblPekemanHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblPekemanHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPekemanHealth.ForeColor = System.Drawing.Color.Black;
            this.lblPekemanHealth.Location = new System.Drawing.Point(403, 317);
            this.lblPekemanHealth.Margin = new System.Windows.Forms.Padding(3);
            this.lblPekemanHealth.Name = "lblPekemanHealth";
            this.lblPekemanHealth.Padding = new System.Windows.Forms.Padding(3);
            this.lblPekemanHealth.Size = new System.Drawing.Size(102, 23);
            this.lblPekemanHealth.TabIndex = 21;
            this.lblPekemanHealth.Text = "lblPekemanHealth";
            this.lblPekemanHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPekemanHealth.UseCompatibleTextRendering = true;
            // 
            // Pokecenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Pekeman.Properties.Resources.healer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lblPekemanHealth);
            this.Controls.Add(this.btnClosePekecentre);
            this.Controls.Add(this.imgSelectedPekeman);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnConfirm);
            this.Name = "Pokecenter";
            this.Size = new System.Drawing.Size(1025, 512);
            ((System.ComponentModel.ISupportInitialize)(this.imgSelectedPekeman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSelectedPekeman;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClosePekecentre;
        private System.Windows.Forms.Label lblPekemanHealth;
    }
}
