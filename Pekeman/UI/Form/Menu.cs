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
    public partial class Menu : Form
    {
        public Menu()
        {
            DoubleBuffered = true;
            InitializeComponent();
            btnPlay.Font = CustomFont.standard;
            btnRules.Font = CustomFont.standard;
            btnQuit.Font = CustomFont.standard;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form game = new FormPekeman(this);
            Hide();
            game.Show();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
