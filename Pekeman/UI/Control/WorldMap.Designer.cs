namespace Pekeman
{
    partial class WorldMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldMap));
            this.btnPekedex = new System.Windows.Forms.Button();
            this.gym = new Pekeman.Gym();
            this.pokecenter = new Pekeman.Pokecenter();
            this.pekedex = new Pekeman.Pekedex();
            this.dpad = new Pekeman.Dpad();
            this.playerCharacter = new Pekeman.Character();
            this.loss = new Pekeman.Loss();
            this.victory = new Pekeman.Victory();
            this.SuspendLayout();
            // 
            // btnPekedex
            // 
            this.btnPekedex.BackColor = System.Drawing.Color.Transparent;
            this.btnPekedex.BackgroundImage = global::Pekeman.Properties.Resources.btnPekedex;
            this.btnPekedex.FlatAppearance.BorderSize = 0;
            this.btnPekedex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPekedex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPekedex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPekedex.Location = new System.Drawing.Point(859, 441);
            this.btnPekedex.Name = "btnPekedex";
            this.btnPekedex.Size = new System.Drawing.Size(50, 50);
            this.btnPekedex.TabIndex = 2;
            this.btnPekedex.UseVisualStyleBackColor = false;
            this.btnPekedex.Click += new System.EventHandler(this.btnPekedex_Click);
            // 
            // gym
            // 
            this.gym.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gym.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gym.BackgroundImage")));
            this.gym.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gym.Location = new System.Drawing.Point(0, 0);
            this.gym.Name = "gym";
            this.gym.Size = new System.Drawing.Size(1024, 512);
            this.gym.TabIndex = 3;
            // 
            // pokecenter
            // 
            this.pokecenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pokecenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pokecenter.BackgroundImage")));
            this.pokecenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pokecenter.Location = new System.Drawing.Point(0, 0);
            this.pokecenter.Name = "pokecenter";
            this.pokecenter.Size = new System.Drawing.Size(1025, 512);
            this.pokecenter.TabIndex = 4;
            this.pokecenter.Visible = false;
            // 
            // pekedex
            // 
            this.pekedex.BackColor = System.Drawing.Color.Transparent;
            this.pekedex.Location = new System.Drawing.Point(0, 0);
            this.pekedex.Name = "pekedex";
            this.pekedex.Size = new System.Drawing.Size(1024, 512);
            this.pekedex.TabIndex = 1;
            this.pekedex.Visible = false;
            // 
            // dpad
            // 
            this.dpad.BackColor = System.Drawing.Color.Transparent;
            this.dpad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dpad.BackgroundImage")));
            this.dpad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dpad.Location = new System.Drawing.Point(922, 411);
            this.dpad.Name = "dpad";
            this.dpad.Size = new System.Drawing.Size(90, 90);
            this.dpad.TabIndex = 5;
            // 
            // playerCharacter
            // 
            this.playerCharacter.BackColor = System.Drawing.Color.Transparent;
            this.playerCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerCharacter.BackgroundImage")));
            this.playerCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerCharacter.Location = new System.Drawing.Point(96, 128);
            this.playerCharacter.Margin = new System.Windows.Forms.Padding(0);
            this.playerCharacter.Name = "playerCharacter";
            this.playerCharacter.Size = new System.Drawing.Size(32, 32);
            this.playerCharacter.TabIndex = 0;
            // 
            // loss
            // 
            this.loss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loss.Location = new System.Drawing.Point(0, 0);
            this.loss.Name = "loss";
            this.loss.Size = new System.Drawing.Size(1024, 512);
            this.loss.TabIndex = 6;
            this.loss.Visible = false;
            // 
            // victory
            // 
            this.victory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.victory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.victory.Location = new System.Drawing.Point(0, 0);
            this.victory.Name = "victory";
            this.victory.Size = new System.Drawing.Size(1024, 512);
            this.victory.TabIndex = 7;
            this.victory.Visible = false;
            // 
            // WorldMap
            // 
            this.Controls.Add(this.gym);
            this.Controls.Add(this.pokecenter);
            this.Controls.Add(this.pekedex);
            this.Controls.Add(this.victory);
            this.Controls.Add(this.loss);
            this.Controls.Add(this.dpad);
            this.Controls.Add(this.btnPekedex);
            this.Controls.Add(this.playerCharacter);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WorldMap";
            this.Size = new System.Drawing.Size(1024, 512);
            this.ResumeLayout(false);

        }

        #endregion

        private Character playerCharacter;
        private Pekedex pekedex;
        private System.Windows.Forms.Button btnPekedex;
        private Gym gym;
        private Pokecenter pokecenter;
        private Dpad dpad;
        private Loss loss;
        private Victory victory;
    }
}
