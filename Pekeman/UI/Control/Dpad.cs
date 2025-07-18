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
    public partial class Dpad : UserControl
    {
        WorldMap map;
        
        public Dpad()
        {
            InitializeComponent();
            map = (this.Parent as WorldMap);
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            map = (this.Parent as WorldMap);
            Point location = map.GetPlayerCoords();
            map.WalkRequest(location.X - 1, location.Y, 'U');
        }

        private void BtnDown_MouseClick(object sender, MouseEventArgs e)
        {
            map = (this.Parent as WorldMap);
            Point location = map.GetPlayerCoords();
            map.WalkRequest(location.X + 1, location.Y, 'D');
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            map = (this.Parent as WorldMap);
            Point location = map.GetPlayerCoords();
            map.WalkRequest(location.X, location.Y + 1, 'R');
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            map = (this.Parent as WorldMap);
            Point location = map.GetPlayerCoords();
            map.WalkRequest(location.X, location.Y - 1, 'L');
        }


    }
}
