using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pekeman
{
    public partial class Combat : UserControl
    {
        private PekemanInfo playerPekeman;
        private PekemanInfo enemyPekeman;

        public Combat()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            InitializeUI();
        }

        public void StartCombat()
        {
            GeneratePekemans();
            UpdateUI();
            this.BringToFront();
            this.Enabled = true;
        }

        private void GeneratePekemans()
        {
            Random rnd = new Random();
            int rndPekeman = rnd.Next(0, LoadPekeman.GetListPekemanLength());
            enemyPekeman = LoadPekeman.GetPekemanListItem(rndPekeman);
            playerPekeman = LoadPekeman.GetActivePekeman();
        }

        private void InitializeUI()
        {
            lblPlayerName.Font = CustomFont.standard;
            lblPlayerHitpoints.Font = CustomFont.standard;
            lblEnemyName.Font = CustomFont.standard;
            lblEnemyHitpoints.Font = CustomFont.standard;
            lblAction.Font = CustomFont.standard;
            btnAttack.Font = CustomFont.standard;
            btnCatch.Font = CustomFont.standard;
            btnRun.Font = CustomFont.standard;
            btnAttack.Text = "Attaquer";
            btnCatch.Text = "Attrapper";
            btnRun.Text = "Fuir";
        }

        private void UpdateUI()
        {
            const int bottomScreen = 482;

            //Player
            lblPlayerName.Text = playerPekeman.name;
            SizeF labelSize = lblPlayerName.CreateGraphics().MeasureString(
                  lblPlayerName.Text, lblPlayerName.Font);
            lblPlayerName.Location = new Point(pnlPlayerInfo.Width - 52 - 
                                               Convert.ToInt32(labelSize.Width), 17);
            picPlayerPekeman.Image = playerPekeman.photoBack;
            picPlayerPekeman.Size = new Size(Convert.ToInt32(playerPekeman.photoBack.Size.Width*1.5),
                                             Convert.ToInt32(playerPekeman.photoBack.Size.Height*1.5));
            picPlayerPekeman.Location = new Point(304, Convert.ToInt32(bottomScreen -
                                                  playerPekeman.photoBack.Size.Height*1.5)); //changer x
            pgbHealthBarPlayer.Maximum = playerPekeman.maxHitpoints;
            switch (playerPekeman.sex)
            {
                case PekemanInfo.pekemanSex.M:
                    picPlayerSex.Image = Properties.Resources.M;
                    break;
                case PekemanInfo.pekemanSex.F:
                    picPlayerSex.Image = Properties.Resources.F;
                    break;
                case PekemanInfo.pekemanSex.MF:
                    picPlayerSex.Image = Properties.Resources.MF;
                    break;
            }
            //Enemy
            lblEnemyName.Text = enemyPekeman.name;
            picEnemyPekeman.Image = enemyPekeman.photoFront;
            picEnemyPekeman.Size = new Size(Convert.ToInt32(enemyPekeman.photoFront.Size.Width * 1.5),
                                            Convert.ToInt32(enemyPekeman.photoFront.Size.Height * 1.5));
            picEnemyPekeman.Location = new Point(615, Convert.ToInt32(bottomScreen - 
                                                 enemyPekeman.photoFront.Size.Height * 1.5)); //changer x
            pgbHealthBarEnemy.Maximum = enemyPekeman.maxHitpoints;
            switch (enemyPekeman.sex)
            {
                case PekemanInfo.pekemanSex.M:
                    picEnemySex.Image = Properties.Resources.M;
                    break;
                case PekemanInfo.pekemanSex.F:
                    picEnemySex.Image = Properties.Resources.F;
                    break;
                case PekemanInfo.pekemanSex.MF:
                    picEnemySex.Image = Properties.Resources.MF;
                    break;
            }
            UpdateHealth();
            lblAction.Text = "Un " + enemyPekeman.name + "\nsauvage apparaît!";
            pnlBtnAction.Enabled = true;

        }

        private void BtnRun_MouseClick(object sender, MouseEventArgs e)
        {
            QuitCombat();
        }

        private void BtnCatch_MouseClick(object sender, MouseEventArgs e)
        {
            bool caught = AttemptCapture();

            pnlBtnAction.Enabled = false;
            if (caught)
            {
                lblAction.Text = "Vous avez attrape\n" + enemyPekeman.name + "!";
                tmrCaught.Start();
            }
            else
            {
                EnemyAttack();
            }
        }

        private void BtnAttack_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBtnAction.Enabled = false;
            enemyPekeman.currentHitpoints -= 10; //do player atk
            if (enemyPekeman.currentHitpoints <= 0)
            {
                enemyPekeman.currentHitpoints = 0;
            }
            lblAction.Text = playerPekeman.name + " utilise\n" + playerPekeman.attackName;
            UpdateHealth();
            tmrAttackEnemy.Start();
        }

        private void UpdateHealth()
        {
            pgbHealthBarEnemy.Value = enemyPekeman.currentHitpoints;
            lblEnemyHitpoints.Text = Convert.ToString(enemyPekeman.currentHitpoints)
                                + "/" + Convert.ToString(enemyPekeman.maxHitpoints);

            pgbHealthBarPlayer.Value = playerPekeman.currentHitpoints;
            lblPlayerHitpoints.Text = Convert.ToString(playerPekeman.currentHitpoints)
                                + "/" + Convert.ToString(playerPekeman.maxHitpoints);

            SizeF labelSize = lblPlayerHitpoints.CreateGraphics().MeasureString(lblPlayerHitpoints.Text, lblPlayerHitpoints.Font);
            lblPlayerHitpoints.Location = new Point(pnlPlayerInfo.Width - 33 - Convert.ToInt32(labelSize.Width), 57);        
        }

        private void TmrAttackEnemy_Tick(object sender, EventArgs e)
        {
            tmrAttackEnemy.Stop();
            if (enemyPekeman.currentHitpoints == 0)
            {
                PokemonFainted();
            }
            else
            {
                EnemyAttack();
            }
        }

        private void PokemonFainted()
        {
            lblAction.Text = enemyPekeman.name + " s'est evanoui.";
            tmrFaint.Start();
        }

        private void EnemyAttack()
        {
            playerPekeman.currentHitpoints -= 5; //do enemy atk
            if (playerPekeman.currentHitpoints <= 0)
            {
                playerPekeman.currentHitpoints = 0;
            }
            UpdateHealth();
            lblAction.Text = enemyPekeman.name + " sauvage\nutilise " + enemyPekeman.attackName;
            tmrAttackPlayer.Start();
            tmrAttackEnemy.Stop();
        }

        private void TmrAttackPlayer_Tick(object sender, EventArgs e)
        {
            tmrAttackPlayer.Stop();
            if (playerPekeman.currentHitpoints == 0)
            {
                //GAME OVER
                QuitCombat();
            }
            else
            {
                NextTurn();
            }
        }

        private void NextTurn()
        {
            lblAction.Text = "Qu'est-ce que\n" + playerPekeman.name + " fera?";
            pnlBtnAction.Enabled = true;
        }

        private void TmrFaint_Tick(object sender, EventArgs e)
        {
            tmrFaint.Stop();
            QuitCombat();
        }

        private bool AttemptCapture()
        {
            bool captured = true;
            //implement attrapper pekeman
            return captured;
        }

        private void QuitCombat() //map doit gerer si vie du peke est a zero
        {
            
            Form formPekeman = FormPekeman.ActiveForm;
            WorldMap worldMap = formPekeman.Controls.Find("worldMap", false).FirstOrDefault() as WorldMap;
            this.Enabled = false;
            this.SendToBack();
            worldMap.VerifyWin();
        }

        private void TmrCaught_Tick(object sender, EventArgs e)
        {
            tmrCaught.Stop();
            enemyPekeman.currentHitpoints = enemyPekeman.maxHitpoints;
            LoadPekeman.CaughtPekeman(enemyPekeman);
            QuitCombat();
        }
    }
}
