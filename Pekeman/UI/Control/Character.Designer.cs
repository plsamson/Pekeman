namespace Pekeman
{
    partial class Character
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
            this.tmrLeft1 = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft2 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight1 = new System.Windows.Forms.Timer(this.components);
            this.tmrRight2 = new System.Windows.Forms.Timer(this.components);
            this.tmrTop1 = new System.Windows.Forms.Timer(this.components);
            this.tmrTop2 = new System.Windows.Forms.Timer(this.components);
            this.tmrTop3 = new System.Windows.Forms.Timer(this.components);
            this.tmrBottom1 = new System.Windows.Forms.Timer(this.components);
            this.tmrBottom2 = new System.Windows.Forms.Timer(this.components);
            this.tmrBottom3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrLeft1
            // 
            this.tmrLeft1.Interval = 50;
            this.tmrLeft1.Tick += new System.EventHandler(this.TmrLeft1_Tick);
            // 
            // tmrLeft2
            // 
            this.tmrLeft2.Interval = 50;
            this.tmrLeft2.Tick += new System.EventHandler(this.TmrLeft2_Tick);
            // 
            // tmrRight1
            // 
            this.tmrRight1.Interval = 50;
            this.tmrRight1.Tick += new System.EventHandler(this.TmrRight1_Tick);
            // 
            // tmrRight2
            // 
            this.tmrRight2.Interval = 50;
            this.tmrRight2.Tick += new System.EventHandler(this.TmrRight2_Tick);
            // 
            // tmrTop1
            // 
            this.tmrTop1.Interval = 50;
            this.tmrTop1.Tick += new System.EventHandler(this.TmrTop1_Tick);
            // 
            // tmrTop2
            // 
            this.tmrTop2.Interval = 50;
            this.tmrTop2.Tick += new System.EventHandler(this.TmrTop2_Tick);
            // 
            // tmrTop3
            // 
            this.tmrTop3.Interval = 50;
            this.tmrTop3.Tick += new System.EventHandler(this.TmrTop3_Tick);
            // 
            // tmrBottom1
            // 
            this.tmrBottom1.Interval = 50;
            this.tmrBottom1.Tick += new System.EventHandler(this.TmrBottom1_Tick);
            // 
            // tmrBottom2
            // 
            this.tmrBottom2.Interval = 50;
            this.tmrBottom2.Tick += new System.EventHandler(this.TmrBottom2_Tick);
            // 
            // tmrBottom3
            // 
            this.tmrBottom3.Interval = 50;
            this.tmrBottom3.Tick += new System.EventHandler(this.TmrBottom3_Tick);
            // 
            // Character
            // 
            this.BackgroundImage = global::Pekeman.Properties.Resources.bas1;
            this.Name = "Character";
            this.Size = new System.Drawing.Size(32, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrLeft1;
        private System.Windows.Forms.Timer tmrLeft2;
        private System.Windows.Forms.Timer tmrRight1;
        private System.Windows.Forms.Timer tmrRight2;
        private System.Windows.Forms.Timer tmrTop1;
        private System.Windows.Forms.Timer tmrTop2;
        private System.Windows.Forms.Timer tmrTop3;
        private System.Windows.Forms.Timer tmrBottom1;
        private System.Windows.Forms.Timer tmrBottom2;
        private System.Windows.Forms.Timer tmrBottom3;
    }
}
