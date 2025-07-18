namespace Pekeman
{
    partial class Combat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Combat));
            this.pnlCombat = new System.Windows.Forms.Panel();
            this.pnlPlayerInfo = new System.Windows.Forms.Panel();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerHitpoints = new System.Windows.Forms.Label();
            this.pgbHealthBarPlayer = new System.Windows.Forms.ProgressBar();
            this.picPlayerSex = new System.Windows.Forms.PictureBox();
            this.pnlEnemyInfo = new System.Windows.Forms.Panel();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblEnemyHitpoints = new System.Windows.Forms.Label();
            this.pgbHealthBarEnemy = new System.Windows.Forms.ProgressBar();
            this.picEnemySex = new System.Windows.Forms.PictureBox();
            this.picEnemyPekeman = new System.Windows.Forms.PictureBox();
            this.picPlayerPekeman = new System.Windows.Forms.PictureBox();
            this.picBackgroundCombat = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnCatch = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.pnlActionCombat = new System.Windows.Forms.Panel();
            this.pnlBtnAction = new System.Windows.Forms.Panel();
            this.lblAction = new System.Windows.Forms.Label();
            this.tmrAttackEnemy = new System.Windows.Forms.Timer(this.components);
            this.tmrAttackPlayer = new System.Windows.Forms.Timer(this.components);
            this.tmrFaint = new System.Windows.Forms.Timer(this.components);
            this.tmrCaught = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCombat.SuspendLayout();
            this.pnlPlayerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerSex)).BeginInit();
            this.pnlEnemyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemySex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPekeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerPekeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundCombat)).BeginInit();
            this.pnlActionCombat.SuspendLayout();
            this.pnlBtnAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCombat
            // 
            this.pnlCombat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCombat.BackgroundImage")));
            this.pnlCombat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCombat.Controls.Add(this.pnlPlayerInfo);
            this.pnlCombat.Controls.Add(this.pnlEnemyInfo);
            this.pnlCombat.Controls.Add(this.picEnemyPekeman);
            this.pnlCombat.Controls.Add(this.picPlayerPekeman);
            this.pnlCombat.Controls.Add(this.picBackgroundCombat);
            this.pnlCombat.Location = new System.Drawing.Point(0, -120);
            this.pnlCombat.Name = "pnlCombat";
            this.pnlCombat.Size = new System.Drawing.Size(1024, 512);
            this.pnlCombat.TabIndex = 8;
            // 
            // pnlPlayerInfo
            // 
            this.pnlPlayerInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayerInfo.BackgroundImage = global::Pekeman.Properties.Resources.combatBackgroundPlayer;
            this.pnlPlayerInfo.Controls.Add(this.lblPlayerName);
            this.pnlPlayerInfo.Controls.Add(this.lblPlayerHitpoints);
            this.pnlPlayerInfo.Controls.Add(this.pgbHealthBarPlayer);
            this.pnlPlayerInfo.Controls.Add(this.picPlayerSex);
            this.pnlPlayerInfo.Location = new System.Drawing.Point(39, 145);
            this.pnlPlayerInfo.Name = "pnlPlayerInfo";
            this.pnlPlayerInfo.Size = new System.Drawing.Size(300, 90);
            this.pnlPlayerInfo.TabIndex = 16;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlayerName.Location = new System.Drawing.Point(173, 15);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(78, 17);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "lblPlayerName";
            this.lblPlayerName.UseCompatibleTextRendering = true;
            // 
            // lblPlayerHitpoints
            // 
            this.lblPlayerHitpoints.AutoSize = true;
            this.lblPlayerHitpoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerHitpoints.Location = new System.Drawing.Point(184, 57);
            this.lblPlayerHitpoints.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblPlayerHitpoints.Name = "lblPlayerHitpoints";
            this.lblPlayerHitpoints.Size = new System.Drawing.Size(92, 17);
            this.lblPlayerHitpoints.TabIndex = 1;
            this.lblPlayerHitpoints.Text = "lblPlayerHitpoints";
            this.lblPlayerHitpoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlayerHitpoints.UseCompatibleTextRendering = true;
            // 
            // pgbHealthBarPlayer
            // 
            this.pgbHealthBarPlayer.ForeColor = System.Drawing.Color.Transparent;
            this.pgbHealthBarPlayer.Location = new System.Drawing.Point(53, 40);
            this.pgbHealthBarPlayer.MarqueeAnimationSpeed = 0;
            this.pgbHealthBarPlayer.Name = "pgbHealthBarPlayer";
            this.pgbHealthBarPlayer.Size = new System.Drawing.Size(221, 10);
            this.pgbHealthBarPlayer.TabIndex = 13;
            // 
            // picPlayerSex
            // 
            this.picPlayerSex.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerSex.Location = new System.Drawing.Point(237, 14);
            this.picPlayerSex.Name = "picPlayerSex";
            this.picPlayerSex.Size = new System.Drawing.Size(42, 16);
            this.picPlayerSex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerSex.TabIndex = 6;
            this.picPlayerSex.TabStop = false;
            // 
            // pnlEnemyInfo
            // 
            this.pnlEnemyInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlEnemyInfo.BackgroundImage = global::Pekeman.Properties.Resources.combatBackgroundEnemy;
            this.pnlEnemyInfo.Controls.Add(this.lblEnemyName);
            this.pnlEnemyInfo.Controls.Add(this.lblEnemyHitpoints);
            this.pnlEnemyInfo.Controls.Add(this.pgbHealthBarEnemy);
            this.pnlEnemyInfo.Controls.Add(this.picEnemySex);
            this.pnlEnemyInfo.Location = new System.Drawing.Point(684, 145);
            this.pnlEnemyInfo.Name = "pnlEnemyInfo";
            this.pnlEnemyInfo.Size = new System.Drawing.Size(300, 90);
            this.pnlEnemyInfo.TabIndex = 14;
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEnemyName.Location = new System.Drawing.Point(52, 17);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(81, 17);
            this.lblEnemyName.TabIndex = 0;
            this.lblEnemyName.Text = "lblEnemyName";
            this.lblEnemyName.UseCompatibleTextRendering = true;
            // 
            // lblEnemyHitpoints
            // 
            this.lblEnemyHitpoints.AutoSize = true;
            this.lblEnemyHitpoints.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyHitpoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEnemyHitpoints.Location = new System.Drawing.Point(33, 57);
            this.lblEnemyHitpoints.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblEnemyHitpoints.Name = "lblEnemyHitpoints";
            this.lblEnemyHitpoints.Size = new System.Drawing.Size(95, 17);
            this.lblEnemyHitpoints.TabIndex = 1;
            this.lblEnemyHitpoints.Text = "lblEnemyHitpoints";
            this.lblEnemyHitpoints.UseCompatibleTextRendering = true;
            // 
            // pgbHealthBarEnemy
            // 
            this.pgbHealthBarEnemy.ForeColor = System.Drawing.Color.Transparent;
            this.pgbHealthBarEnemy.Location = new System.Drawing.Point(31, 40);
            this.pgbHealthBarEnemy.MarqueeAnimationSpeed = 0;
            this.pgbHealthBarEnemy.Name = "pgbHealthBarEnemy";
            this.pgbHealthBarEnemy.Size = new System.Drawing.Size(221, 10);
            this.pgbHealthBarEnemy.TabIndex = 13;
            // 
            // picEnemySex
            // 
            this.picEnemySex.BackColor = System.Drawing.Color.Transparent;
            this.picEnemySex.Location = new System.Drawing.Point(21, 15);
            this.picEnemySex.Name = "picEnemySex";
            this.picEnemySex.Size = new System.Drawing.Size(42, 16);
            this.picEnemySex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnemySex.TabIndex = 6;
            this.picEnemySex.TabStop = false;
            // 
            // picEnemyPekeman
            // 
            this.picEnemyPekeman.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPekeman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picEnemyPekeman.Location = new System.Drawing.Point(697, 393);
            this.picEnemyPekeman.Name = "picEnemyPekeman";
            this.picEnemyPekeman.Size = new System.Drawing.Size(80, 90);
            this.picEnemyPekeman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnemyPekeman.TabIndex = 5;
            this.picEnemyPekeman.TabStop = false;
            // 
            // picPlayerPekeman
            // 
            this.picPlayerPekeman.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerPekeman.Location = new System.Drawing.Point(233, 393);
            this.picPlayerPekeman.Name = "picPlayerPekeman";
            this.picPlayerPekeman.Size = new System.Drawing.Size(80, 90);
            this.picPlayerPekeman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerPekeman.TabIndex = 4;
            this.picPlayerPekeman.TabStop = false;
            // 
            // picBackgroundCombat
            // 
            this.picBackgroundCombat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBackgroundCombat.BackgroundImage")));
            this.picBackgroundCombat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackgroundCombat.Image = ((System.Drawing.Image)(resources.GetObject("picBackgroundCombat.Image")));
            this.picBackgroundCombat.Location = new System.Drawing.Point(0, 0);
            this.picBackgroundCombat.Name = "picBackgroundCombat";
            this.picBackgroundCombat.Size = new System.Drawing.Size(1024, 512);
            this.picBackgroundCombat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackgroundCombat.TabIndex = 8;
            this.picBackgroundCombat.TabStop = false;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Transparent;
            this.btnRun.BackgroundImage = global::Pekeman.Properties.Resources.btnRun;
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRun.Location = new System.Drawing.Point(246, 13);
            this.btnRun.Margin = new System.Windows.Forms.Padding(0);
            this.btnRun.Name = "btnRun";
            this.btnRun.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.btnRun.Size = new System.Drawing.Size(101, 85);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "btnRun";
            this.btnRun.UseCompatibleTextRendering = true;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRun_MouseClick);
            // 
            // btnCatch
            // 
            this.btnCatch.BackColor = System.Drawing.Color.Transparent;
            this.btnCatch.BackgroundImage = global::Pekeman.Properties.Resources.btnCatch;
            this.btnCatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCatch.FlatAppearance.BorderSize = 0;
            this.btnCatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCatch.Location = new System.Drawing.Point(127, 13);
            this.btnCatch.Margin = new System.Windows.Forms.Padding(0);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.btnCatch.Size = new System.Drawing.Size(101, 85);
            this.btnCatch.TabIndex = 1;
            this.btnCatch.Text = "btnCatch";
            this.btnCatch.UseCompatibleTextRendering = true;
            this.btnCatch.UseVisualStyleBackColor = false;
            this.btnCatch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnCatch_MouseClick);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Transparent;
            this.btnAttack.BackgroundImage = global::Pekeman.Properties.Resources.btnAtk;
            this.btnAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAttack.FlatAppearance.BorderSize = 0;
            this.btnAttack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAttack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAttack.Location = new System.Drawing.Point(9, 13);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.btnAttack.Size = new System.Drawing.Size(101, 85);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "btnAttack";
            this.btnAttack.UseCompatibleTextRendering = true;
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAttack_MouseClick);
            // 
            // pnlActionCombat
            // 
            this.pnlActionCombat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.pnlActionCombat.BackgroundImage = global::Pekeman.Properties.Resources.combatActionBackground;
            this.pnlActionCombat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlActionCombat.Controls.Add(this.pnlBtnAction);
            this.pnlActionCombat.Controls.Add(this.lblAction);
            this.pnlActionCombat.Location = new System.Drawing.Point(0, 392);
            this.pnlActionCombat.Name = "pnlActionCombat";
            this.pnlActionCombat.Size = new System.Drawing.Size(1024, 120);
            this.pnlActionCombat.TabIndex = 9;
            this.pnlActionCombat.TabStop = true;
            // 
            // pnlBtnAction
            // 
            this.pnlBtnAction.BackColor = System.Drawing.Color.Transparent;
            this.pnlBtnAction.Controls.Add(this.btnAttack);
            this.pnlBtnAction.Controls.Add(this.btnCatch);
            this.pnlBtnAction.Controls.Add(this.btnRun);
            this.pnlBtnAction.Location = new System.Drawing.Point(470, 5);
            this.pnlBtnAction.Name = "pnlBtnAction";
            this.pnlBtnAction.Size = new System.Drawing.Size(359, 111);
            this.pnlBtnAction.TabIndex = 17;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.BackColor = System.Drawing.Color.Transparent;
            this.lblAction.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAction.Location = new System.Drawing.Point(226, 32);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(47, 17);
            this.lblAction.TabIndex = 8;
            this.lblAction.Text = "lblAction";
            this.lblAction.UseCompatibleTextRendering = true;
            // 
            // tmrAttackEnemy
            // 
            this.tmrAttackEnemy.Interval = 2100;
            this.tmrAttackEnemy.Tick += new System.EventHandler(this.TmrAttackEnemy_Tick);
            // 
            // tmrAttackPlayer
            // 
            this.tmrAttackPlayer.Interval = 2700;
            this.tmrAttackPlayer.Tick += new System.EventHandler(this.TmrAttackPlayer_Tick);
            // 
            // tmrFaint
            // 
            this.tmrFaint.Interval = 2200;
            this.tmrFaint.Tick += new System.EventHandler(this.TmrFaint_Tick);
            // 
            // tmrCaught
            // 
            this.tmrCaught.Interval = 2000;
            this.tmrCaught.Tick += new System.EventHandler(this.TmrCaught_Tick);
            // 
            // Combat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCombat);
            this.Controls.Add(this.pnlActionCombat);
            this.DoubleBuffered = true;
            this.Name = "Combat";
            this.Size = new System.Drawing.Size(1024, 512);
            this.pnlCombat.ResumeLayout(false);
            this.pnlPlayerInfo.ResumeLayout(false);
            this.pnlPlayerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerSex)).EndInit();
            this.pnlEnemyInfo.ResumeLayout(false);
            this.pnlEnemyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemySex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPekeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerPekeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundCombat)).EndInit();
            this.pnlActionCombat.ResumeLayout(false);
            this.pnlActionCombat.PerformLayout();
            this.pnlBtnAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCombat;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.PictureBox picEnemySex;
        private System.Windows.Forms.PictureBox picEnemyPekeman;
        private System.Windows.Forms.PictureBox picPlayerPekeman;
        private System.Windows.Forms.Button btnCatch;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblEnemyHitpoints;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.PictureBox picBackgroundCombat;
        private System.Windows.Forms.ProgressBar pgbHealthBarEnemy;
        private System.Windows.Forms.Panel pnlEnemyInfo;
        private System.Windows.Forms.Panel pnlPlayerInfo;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerHitpoints;
        private System.Windows.Forms.ProgressBar pgbHealthBarPlayer;
        private System.Windows.Forms.PictureBox picPlayerSex;
        private System.Windows.Forms.Panel pnlActionCombat;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Timer tmrAttackEnemy;
        private System.Windows.Forms.Panel pnlBtnAction;
        private System.Windows.Forms.Timer tmrAttackPlayer;
        private System.Windows.Forms.Timer tmrFaint;
        private System.Windows.Forms.Timer tmrCaught;
        private System.Windows.Forms.Timer timer1;
    }
}
