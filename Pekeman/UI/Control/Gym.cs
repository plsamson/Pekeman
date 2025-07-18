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
    public partial class Gym : UserControl
    {
        List<PekemanInfo> listPekeman;

        public Gym()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            listPekeman = LoadPekeman.LoadFromFile();
            InitializeUI();

        }

        private void InitializeUI()
        {
            lblChoice.Font = CustomFont.big;
            lblWelcome.Font = CustomFont.big;
            btnConfirm.Font = CustomFont.standard;
            txtPlayerName.Font = CustomFont.standard;

            for (int i = 0; i < listPekeman.Count; i++)
            {
                lstPekeman.Items.Add(listPekeman[i].name);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lstPekeman.SelectedItem != null)
            {
                String selectedPekeman = (string)lstPekeman.SelectedItem;
                int selectedPekemanIndex = lstPekeman.FindStringExact(selectedPekeman);
                LoadPekeman.SetActivePekeman(selectedPekemanIndex);
                LoadPekeman.CaughtPekeman(listPekeman[selectedPekemanIndex]);
                LoadMap.trainerName = txtPlayerName.Text;
                Form formPekeman = FormPekeman.ActiveForm;
                WorldMap worldMap = formPekeman.Controls.Find("worldMap", false).FirstOrDefault() as WorldMap;
                worldMap.ExitShop(3 * 32, 4 * 32);
                this.Enabled = false;
                this.Visible = false;
            }       
        }

        private void LstPekeman_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedPekeman = (string)lstPekeman.SelectedItem;
            int selectedPekemanIndex = lstPekeman.FindStringExact(selectedPekeman);
            imgSelectedPekeman.Image = listPekeman[selectedPekemanIndex].photoFront;
        }

        private void LstPekeman_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush greyBrush = Brushes.Black;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.LightGray);
            e.DrawBackground();
            e.Graphics.DrawString(lstPekeman.Items[e.Index].ToString(),
                                  CustomFont.standard,
                                  greyBrush,
                                  e.Bounds,
                                  StringFormat.GenericDefault);
        }
    }
}
