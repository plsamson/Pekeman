namespace Pekeman
{
    partial class Gym
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
            this.lstPekeman = new System.Windows.Forms.ListBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblChoice = new System.Windows.Forms.Label();
            this.imgSelectedPekeman = new System.Windows.Forms.PictureBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSelectedPekeman)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPekeman
            // 
            this.lstPekeman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.lstPekeman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPekeman.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPekeman.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lstPekeman.FormattingEnabled = true;
            this.lstPekeman.ItemHeight = 20;
            this.lstPekeman.Location = new System.Drawing.Point(300, 234);
            this.lstPekeman.Name = "lstPekeman";
            this.lstPekeman.Size = new System.Drawing.Size(154, 100);
            this.lstPekeman.TabIndex = 1;
            this.lstPekeman.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LstPekeman_DrawItem);
            this.lstPekeman.SelectedIndexChanged += new System.EventHandler(this.LstPekeman_SelectedIndexChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(299, 86);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblWelcome.Size = new System.Drawing.Size(187, 48);
            this.lblWelcome.TabIndex = 14;
            this.lblWelcome.Text = "Bienvenue, dresseur de Pekeman!\n\nComment t\'appelle-tu?";
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
            this.btnConfirm.Location = new System.Drawing.Point(348, 358);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnConfirm.Size = new System.Drawing.Size(222, 30);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirm.UseCompatibleTextRendering = true;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChoice.ForeColor = System.Drawing.Color.Black;
            this.lblChoice.Location = new System.Drawing.Point(299, 201);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblChoice.Size = new System.Drawing.Size(163, 23);
            this.lblChoice.TabIndex = 15;
            this.lblChoice.Text = "Choisis ton Pekeman de base :";
            this.lblChoice.UseCompatibleTextRendering = true;
            // 
            // imgSelectedPekeman
            // 
            this.imgSelectedPekeman.BackColor = System.Drawing.Color.Transparent;
            this.imgSelectedPekeman.Location = new System.Drawing.Point(464, 219);
            this.imgSelectedPekeman.Name = "imgSelectedPekeman";
            this.imgSelectedPekeman.Size = new System.Drawing.Size(133, 123);
            this.imgSelectedPekeman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgSelectedPekeman.TabIndex = 16;
            this.imgSelectedPekeman.TabStop = false;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(302, 163);
            this.txtPlayerName.MaxLength = 14;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(216, 23);
            this.txtPlayerName.TabIndex = 0;
            // 
            // Gym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Pekeman.Properties.Resources.gym;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.imgSelectedPekeman);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.lstPekeman);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnConfirm);
            this.DoubleBuffered = true;
            this.Name = "Gym";
            this.Size = new System.Drawing.Size(1024, 512);
            ((System.ComponentModel.ISupportInitialize)(this.imgSelectedPekeman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPekeman;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.PictureBox imgSelectedPekeman;
        private System.Windows.Forms.TextBox txtPlayerName;
    }
}
