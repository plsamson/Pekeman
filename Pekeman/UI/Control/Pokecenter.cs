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
    public partial class Pokecenter : UserControl
    {
        PekemanInfo activePekeman; 

        public Pokecenter()
        {
            InitializeComponent();
            
        }

        public void  InitializeNurse()
        {
            activePekeman = LoadPekeman.GetActivePekeman();
            lblWelcome.Font = CustomFont.big;
            lblPekemanHealth.Font = CustomFont.standard;
            btnConfirm.Font = CustomFont.standard;
            imgSelectedPekeman.Image = LoadPekeman.GetActivePekeman().photoFront;
            btnConfirm.Text = "Soigner " + activePekeman.name;
            lblPekemanHealth.Text = activePekeman.currentHitpoints.ToString() +
                            "/" + activePekeman.maxHitpoints.ToString();

            SizeF labelSize = lblPekemanHealth.CreateGraphics().MeasureString(lblPekemanHealth.Text, lblPekemanHealth.Font);
            
            lblPekemanHealth.Location = new Point(imgSelectedPekeman.Location.X+(imgSelectedPekeman.Width-Convert.ToInt32(labelSize.Width))/2, 317);
            Visible = true;
        }

        private void ClosePekecentre()
        {
            Form formPekeman = FormPekeman.ActiveForm;
            WorldMap worldMap = formPekeman.Controls.Find("worldMap", false).FirstOrDefault() as WorldMap;
            worldMap.ExitShop(23*32,9*32);
            worldMap.Enabled = true;
            Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            activePekeman.currentHitpoints = activePekeman.maxHitpoints;
            ClosePekecentre();
        }

        private void btnClosePekecentre_Click(object sender, EventArgs e)
        {
            ClosePekecentre();
        } 
    }
}
