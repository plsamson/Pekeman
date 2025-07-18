using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pekeman
{
    public partial class Character : UserControl
    {
        private Point posCharacter = new Point(3 * 32, 4 * 32);
        private int animationState = 0;

        public Character()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void WalkLeft()
        {
            if (animationState == 0)
            {
                animationState = 1;
                tmrLeft1.Start();
            }
        }

        public void WalkRight()
        {
            if (animationState == 0)
            {
                animationState = 1;
                tmrRight1.Start();
            }
        }

        public void WalkUp()
        {
            if (animationState == 0)
            {
                animationState = 1;
                tmrTop1.Start();
            }
        }

        public void WalkDown()
        {
            if (animationState == 0)
            {
                animationState = 1;
                tmrBottom1.Start();
            }
        }

        public void MoveToTile(Point destinationTile)
        {
            Location = destinationTile;
            BackgroundImage = Properties.Resources.bas1;
            Refresh();
        }

        private void TmrLeft1_Tick(object sender, EventArgs e)
        {
            tmrLeft1.Stop();
            posCharacter.X -= 8;
            BackgroundImage = Properties.Resources.gauche1;
            Location = posCharacter;
            tmrLeft2.Start();
            Refresh();
        }

        private void TmrLeft2_Tick(object sender, EventArgs e)
        {
            tmrLeft2.Stop();
            posCharacter.X -= 8;
            BackgroundImage = Properties.Resources.gauche2;
            Location = posCharacter;
            Refresh();
            if (animationState == 1)
            {
                animationState = 2;
                tmrLeft1.Start();
            }
            else if (animationState == 2)
            {
                animationState = 0;
            }
        }

        private void TmrRight1_Tick(object sender, EventArgs e)
        {
            tmrRight1.Stop();
            posCharacter.X += 8;
            Location = posCharacter;
            BackgroundImage = Properties.Resources.droite1;
            tmrRight2.Start();
            Refresh();
        }

        private void TmrRight2_Tick(object sender, EventArgs e)
        {
            tmrRight2.Stop();
            posCharacter.X += 8;
            Location = posCharacter;
            BackgroundImage = Properties.Resources.droite2;
            Refresh();
            if (animationState == 1)
            {
                animationState = 2;
                tmrRight1.Start();
            }
            else if (animationState == 2)
            {
                animationState = 0;
            }
        }

        private void TmrTop1_Tick(object sender, EventArgs e)
        {
            tmrTop1.Stop();
            posCharacter.Y -= 5;
            Location = posCharacter;
            BackgroundImage = Properties.Resources.haut1;
            tmrTop2.Start();
            Refresh();
        }

        private void TmrTop2_Tick(object sender, EventArgs e)
        {
            tmrTop2.Stop();
            posCharacter.Y -= 5;//changer diviser par 6 + additionner les timer pour qui se fasse un derriere l'autre (milisecondes) 150?
            Location = posCharacter;
            BackgroundImage = Properties.Resources.haut2;
            tmrTop3.Start();
            Refresh();
        }

        private void TmrTop3_Tick(object sender, EventArgs e)
        {
            tmrTop3.Stop();
            posCharacter.Y -= 6;
            Location = posCharacter;
            BackgroundImage = Properties.Resources.haut3;
            Refresh();
            if (animationState == 1)
            {
                animationState = 2;
                tmrTop1.Start();
            }
            else if (animationState == 2)
            {
                animationState = 0;
            }
        }

        private void TmrBottom1_Tick(object sender, EventArgs e)
        {
            tmrBottom1.Stop();
            posCharacter.Y += 5;
            Location = posCharacter;
            BackgroundImage = Properties.Resources.bas1;
            Refresh();
            tmrBottom2.Start();
        }

        private void TmrBottom2_Tick(object sender, EventArgs e)
        {
            tmrBottom2.Stop();
            posCharacter.Y += 5;
            Location = posCharacter;
            BackgroundImage = Properties.Resources.bas2;
            Refresh();
            tmrBottom3.Start();
        }

        private void TmrBottom3_Tick(object sender, EventArgs e)
        {
            tmrBottom3.Stop();
            posCharacter.Y += 6;
            Location = posCharacter;
            BackgroundImage = Properties.Resources.bas3;
            Refresh();
            if (animationState == 1)
            {
                animationState = 2;
                tmrBottom1.Start();
            }
            else if (animationState == 2)
            {
                animationState = 0;
            }
        }
    }
}
