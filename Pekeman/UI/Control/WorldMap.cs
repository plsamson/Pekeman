using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pekeman
{
    /// <summary>
    /// Environnement de jeu contenant les tuiles
    /// </summary>
    public partial class WorldMap : UserControl
    {
        public int[,] tiles { get; set; }
        public int[,] tileType { get; set; }
        private enum eventTile { herb = 2, gym = 3, poke = 4 };

        public WorldMap()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            tiles = LoadMap.LoadTiles();
            tileType = LoadMap.LoadCollision(tiles);
            
        }

        /// <summary>
        /// Override de la fonction onPaint en fonction des cases
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Point coordTuile;
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    coordTuile = new Point(j * TilesetImageGenerator.IMAGE_WIDTH,
                                           i * TilesetImageGenerator.IMAGE_HEIGHT);
                    pe.Graphics.DrawImage(TilesetImageGenerator.GetTile(tiles[i, j]), coordTuile);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (pekedex.Visible == false)
            {
                Point location = GetPlayerCoords();
                try
                {
                    switch (keyData)
                    {
                        case Keys.Up:
                            WalkRequest(location.X - 1, location.Y, 'U');
                            break;
                        case Keys.Down:
                            WalkRequest(location.X + 1, location.Y, 'D');
                            break;
                        case Keys.Right:
                            WalkRequest(location.X, location.Y + 1, 'R');
                            break;
                        case Keys.Left:
                            WalkRequest(location.X, location.Y - 1, 'L');
                            break;
                        default:
                            break;
                    }
                }
                catch (IndexOutOfRangeException) { } //deplacement hors de la carte, ne pas effectuer
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void WalkRequest(int x, int y, char direction)
        {
            if (tileType[x, y] != 0)
            {
                switch (direction)
                {
                    case 'U':
                        playerCharacter.WalkUp();
                        break;
                    case 'D':
                        playerCharacter.WalkDown();
                        break;
                    case 'R':
                        playerCharacter.WalkRight();
                        break;
                    case 'L':
                        playerCharacter.WalkLeft();
                        break;
                }
            }
            switch (tileType[x, y])
            {
                case (int)eventTile.herb:
                    Form formPekeman = FormPekeman.ActiveForm;
                    Combat combat = formPekeman.Controls.Find("combat", false).FirstOrDefault() as Combat;
                    Enabled = false;
                    combat.StartCombat();
                    Enabled = true;
                    

                    break;
                case (int)eventTile.gym:
                    //gym
                    break;
                case (int)eventTile.poke:
                    pokecenter.InitializeNurse();
                    break;
                default:
                    break;
            }
        }

        public Point GetPlayerCoords()
        {
            Point playerCoords = new Point(playerCharacter.Location.Y / 32,
                                           playerCharacter.Location.X / 32);
            return playerCoords;
        }

        public void ExitShop(int x, int y)
        {
            Point shopCoords = new Point(x, y);
            playerCharacter.MoveToTile(shopCoords);
        }

        public void VerifyWin()
        {
            if (pekedex.listCaughtPekeman.Count == pekedex.listPekeman.Count)
            {
                    victory.BringToFront();
                    victory.Visible = true;
            }

        }

        public void GameWon()
        {
            
        }

        private void btnPekedex_Click(object sender, EventArgs e)
        {
            pekedex.OpenPekedex();
        }

        
    }
}

