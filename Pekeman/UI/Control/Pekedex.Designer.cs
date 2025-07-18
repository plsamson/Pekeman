using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Pekeman
{
    partial class Pekedex
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
            this.imgPekedex = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lstPekemanAttrape = new System.Windows.Forms.ListBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.imgPekeman = new System.Windows.Forms.PictureBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGeneration = new System.Windows.Forms.Label();
            this.lblCompteur = new System.Windows.Forms.Label();
            this.lblHitpoints = new System.Windows.Forms.Label();
            this.lblAtk = new System.Windows.Forms.Label();
            this.btnMyPekeman = new System.Windows.Forms.Button();
            this.lblListeAttrape = new System.Windows.Forms.Label();
            this.imgSex = new System.Windows.Forms.PictureBox();
            this.pnlPekedex = new System.Windows.Forms.Panel();
            this.btnClosePekedex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPekedex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPekeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSex)).BeginInit();
            this.pnlPekedex.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPekedex
            // 
            this.imgPekedex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imgPekedex.BackgroundImage = global::Pekeman.Properties.Resources.pekedex;
            this.imgPekedex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgPekedex.Location = new System.Drawing.Point(0, 0);
            this.imgPekedex.Name = "imgPekedex";
            this.imgPekedex.Size = new System.Drawing.Size(1024, 512);
            this.imgPekedex.TabIndex = 3;
            this.imgPekedex.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblType.Location = new System.Drawing.Point(186, 336);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(41, 17);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "lblType";
            this.lblType.UseCompatibleTextRendering = true;
            // 
            // lstPekemanAttrape
            // 
            this.lstPekemanAttrape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lstPekemanAttrape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPekemanAttrape.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPekemanAttrape.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lstPekemanAttrape.FormattingEnabled = true;
            this.lstPekemanAttrape.ItemHeight = 20;
            this.lstPekemanAttrape.Location = new System.Drawing.Point(560, 188);
            this.lstPekemanAttrape.Name = "lstPekemanAttrape";
            this.lstPekemanAttrape.Size = new System.Drawing.Size(269, 180);
            this.lstPekemanAttrape.TabIndex = 0;
            this.lstPekemanAttrape.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LstPekemanAttrape_DrawItem);
            this.lstPekemanAttrape.SelectedIndexChanged += new System.EventHandler(this.LstPekemanAttrape_SelectedIndexChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeight.Location = new System.Drawing.Point(352, 186);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(48, 17);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "lblHeight";
            this.lblHeight.UseCompatibleTextRendering = true;
            // 
            // imgPekeman
            // 
            this.imgPekeman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.imgPekeman.Location = new System.Drawing.Point(175, 177);
            this.imgPekeman.Name = "imgPekeman";
            this.imgPekeman.Size = new System.Drawing.Size(146, 133);
            this.imgPekeman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgPekeman.TabIndex = 6;
            this.imgPekeman.TabStop = false;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWeight.Location = new System.Drawing.Point(352, 236);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(51, 17);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "lblWeight";
            this.lblWeight.UseCompatibleTextRendering = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(186, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "lblName";
            this.lblName.UseCompatibleTextRendering = true;
            // 
            // lblGeneration
            // 
            this.lblGeneration.AutoSize = true;
            this.lblGeneration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblGeneration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGeneration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGeneration.Location = new System.Drawing.Point(186, 433);
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(72, 17);
            this.lblGeneration.TabIndex = 5;
            this.lblGeneration.Text = "lblGeneration";
            this.lblGeneration.UseCompatibleTextRendering = true;
            // 
            // lblCompteur
            // 
            this.lblCompteur.AutoSize = true;
            this.lblCompteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblCompteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCompteur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCompteur.Location = new System.Drawing.Point(558, 84);
            this.lblCompteur.Name = "lblCompteur";
            this.lblCompteur.Size = new System.Drawing.Size(65, 17);
            this.lblCompteur.TabIndex = 7;
            this.lblCompteur.Text = "lblCompteur";
            this.lblCompteur.UseCompatibleTextRendering = true;
            // 
            // lblHitpoints
            // 
            this.lblHitpoints.AutoSize = true;
            this.lblHitpoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblHitpoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHitpoints.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHitpoints.Location = new System.Drawing.Point(352, 286);
            this.lblHitpoints.Name = "lblHitpoints";
            this.lblHitpoints.Size = new System.Drawing.Size(60, 17);
            this.lblHitpoints.TabIndex = 8;
            this.lblHitpoints.Text = "lblHitpoints";
            this.lblHitpoints.UseCompatibleTextRendering = true;
            // 
            // lblAtk
            // 
            this.lblAtk.AutoSize = true;
            this.lblAtk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblAtk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAtk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAtk.Location = new System.Drawing.Point(186, 387);
            this.lblAtk.Name = "lblAtk";
            this.lblAtk.Size = new System.Drawing.Size(32, 17);
            this.lblAtk.TabIndex = 9;
            this.lblAtk.Text = "lblAtk";
            this.lblAtk.UseCompatibleTextRendering = true;
            // 
            // btnMyPekeman
            // 
            this.btnMyPekeman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMyPekeman.FlatAppearance.BorderSize = 0;
            this.btnMyPekeman.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMyPekeman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMyPekeman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPekeman.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMyPekeman.Location = new System.Drawing.Point(548, 424);
            this.btnMyPekeman.Margin = new System.Windows.Forms.Padding(0);
            this.btnMyPekeman.Name = "btnMyPekeman";
            this.btnMyPekeman.Size = new System.Drawing.Size(294, 30);
            this.btnMyPekeman.TabIndex = 1;
            this.btnMyPekeman.Text = "btnMyPekeman";
            this.btnMyPekeman.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMyPekeman.UseCompatibleTextRendering = true;
            this.btnMyPekeman.UseVisualStyleBackColor = false;
            this.btnMyPekeman.Click += new System.EventHandler(this.BtnMyPekeman_Click);
            // 
            // lblListeAttrape
            // 
            this.lblListeAttrape.AutoSize = true;
            this.lblListeAttrape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblListeAttrape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblListeAttrape.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListeAttrape.Location = new System.Drawing.Point(558, 135);
            this.lblListeAttrape.Name = "lblListeAttrape";
            this.lblListeAttrape.Size = new System.Drawing.Size(85, 17);
            this.lblListeAttrape.TabIndex = 11;
            this.lblListeAttrape.Text = "Mes Pekemans:";
            this.lblListeAttrape.UseCompatibleTextRendering = true;
            // 
            // imgSex
            // 
            this.imgSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.imgSex.Location = new System.Drawing.Point(404, 73);
            this.imgSex.Name = "imgSex";
            this.imgSex.Size = new System.Drawing.Size(84, 33);
            this.imgSex.TabIndex = 12;
            this.imgSex.TabStop = false;
            // 
            // pnlPekedex
            // 
            this.pnlPekedex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlPekedex.Controls.Add(this.lstPekemanAttrape);
            this.pnlPekedex.Controls.Add(this.imgSex);
            this.pnlPekedex.Controls.Add(this.lblAtk);
            this.pnlPekedex.Controls.Add(this.lblHitpoints);
            this.pnlPekedex.Controls.Add(this.btnClosePekedex);
            this.pnlPekedex.Controls.Add(this.lblListeAttrape);
            this.pnlPekedex.Controls.Add(this.btnMyPekeman);
            this.pnlPekedex.Controls.Add(this.lblCompteur);
            this.pnlPekedex.Controls.Add(this.lblGeneration);
            this.pnlPekedex.Controls.Add(this.lblName);
            this.pnlPekedex.Controls.Add(this.lblWeight);
            this.pnlPekedex.Controls.Add(this.imgPekeman);
            this.pnlPekedex.Controls.Add(this.lblHeight);
            this.pnlPekedex.Controls.Add(this.lblType);
            this.pnlPekedex.Controls.Add(this.imgPekedex);
            this.pnlPekedex.Location = new System.Drawing.Point(0, 0);
            this.pnlPekedex.Name = "pnlPekedex";
            this.pnlPekedex.Size = new System.Drawing.Size(1024, 512);
            this.pnlPekedex.TabIndex = 7;
            // 
            // btnClosePekedex
            // 
            this.btnClosePekedex.BackColor = System.Drawing.Color.Black;
            this.btnClosePekedex.BackgroundImage = global::Pekeman.Properties.Resources.btnClose;
            this.btnClosePekedex.FlatAppearance.BorderSize = 0;
            this.btnClosePekedex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePekedex.Location = new System.Drawing.Point(946, 14);
            this.btnClosePekedex.Margin = new System.Windows.Forms.Padding(2);
            this.btnClosePekedex.Name = "btnClosePekedex";
            this.btnClosePekedex.Size = new System.Drawing.Size(50, 50);
            this.btnClosePekedex.TabIndex = 2;
            this.btnClosePekedex.UseVisualStyleBackColor = false;
            this.btnClosePekedex.Click += new System.EventHandler(this.BtnClosePekedex_Click);
            // 
            // Pekedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlPekedex);
            this.Name = "Pekedex";
            this.Size = new System.Drawing.Size(1024, 512);
            ((System.ComponentModel.ISupportInitialize)(this.imgPekedex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPekeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSex)).EndInit();
            this.pnlPekedex.ResumeLayout(false);
            this.pnlPekedex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgPekedex;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ListBox lstPekemanAttrape;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.PictureBox imgPekeman;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGeneration;
        private System.Windows.Forms.Label lblCompteur;
        private System.Windows.Forms.Label lblHitpoints;
        private System.Windows.Forms.Label lblAtk;
        private System.Windows.Forms.Button btnMyPekeman;
        private System.Windows.Forms.Label lblListeAttrape;
        private System.Windows.Forms.PictureBox imgSex;
        private System.Windows.Forms.Panel pnlPekedex;
        private System.Windows.Forms.Button btnClosePekedex;
    }
}
