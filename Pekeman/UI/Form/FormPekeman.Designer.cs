namespace Pekeman
{
    partial class FormPekeman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPekeman));
            this.combat = new Pekeman.Combat();
            this.worldMap = new Pekeman.WorldMap();
            this.SuspendLayout();
            // 
            // combat
            // 
            this.combat.Enabled = false;
            this.combat.Location = new System.Drawing.Point(0, 0);
            this.combat.Margin = new System.Windows.Forms.Padding(0);
            this.combat.Name = "combat";
            this.combat.Size = new System.Drawing.Size(1024, 512);
            this.combat.TabIndex = 4;
            // 
            // worldMap
            // 
            this.worldMap.Location = new System.Drawing.Point(0, 0);
            this.worldMap.Margin = new System.Windows.Forms.Padding(0);
            this.worldMap.Name = "worldMap";
            this.worldMap.Size = new System.Drawing.Size(1024, 512);
            this.worldMap.TabIndex = 0;
            // 
            // FormPekeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 512);
            this.Controls.Add(this.worldMap);
            this.Controls.Add(this.combat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPekeman";
            this.Text = "Pekeman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPekeman_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private WorldMap worldMap;
        private Combat combat;
    }
}