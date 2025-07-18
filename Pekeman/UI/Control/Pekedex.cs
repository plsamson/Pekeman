using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace Pekeman
{
    public partial class Pekedex : UserControl
    {
        public List<PekemanInfo> listCaughtPekeman;
        public List<PekemanInfo> listPekeman;
        PekemanInfo pekemanActif;

        public Pekedex()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            listPekeman = LoadPekeman.GetPekemanList();
            listCaughtPekeman = LoadPekeman.GetListCaughtPekeman();
        }

        public void OpenPekedex()
        {
            pekemanActif = LoadPekeman.GetActivePekeman();
            listCaughtPekeman = LoadPekeman.GetListCaughtPekeman(); //peut mettre liste complete ici pr tester
            Visible = true;
            if (listCaughtPekeman.Count > 0)
            {
                UpdateList();
            }
            DisplayPokemon(0);
        }

        private void UpdateList()
        {
            lstPekemanAttrape.Items.Clear();
            for (int i = 0; i < listCaughtPekeman.Count; i++)
            {
                lstPekemanAttrape.Items.Add(listCaughtPekeman[i].name);
            }
        }

        private void DisplayPokemon(int i)
        {
            if (LoadMap.trainerName != "")
            {
                lblListeAttrape.Text = "Pekemans de " + LoadMap.trainerName + " :";
            }
            btnMyPekeman.Text = "Mon compagnon: " + pekemanActif.name;
            lblWeight.Text = "Poids: "+listCaughtPekeman[i].weight;
            lblType.Text = "Type: "+listCaughtPekeman[i].type;
            lblName.Text = "Nom: "+listCaughtPekeman[i].name;
            lblHitpoints.Text = "Vie: "+listCaughtPekeman[i].currentHitpoints.ToString()+
                                "/"+ listCaughtPekeman[i].maxHitpoints.ToString();
            lblHeight.Text = "Hauteur: "+listCaughtPekeman[i].height;
            lblGeneration.Text = "Pekeman de generation "+listCaughtPekeman[i].generation;
            lblCompteur.Text = listCaughtPekeman.Count+"/"+listPekeman.Count +"  attrapés";
            lblAtk.Text = "Attaque: "+listCaughtPekeman[i].attackName;
            imgPekeman.Image = listCaughtPekeman[i].photoFront;
            switch (listCaughtPekeman[i].sex)
            {
                case PekemanInfo.pekemanSex.M:
                    imgSex.Image = Properties.Resources.M;
                    break;
                case PekemanInfo.pekemanSex.F:
                    imgSex.Image = Properties.Resources.F;
                    break;
                case PekemanInfo.pekemanSex.MF:
                    imgSex.Image = Properties.Resources.MF;
                    break;
            }
            lblListeAttrape.Font = CustomFont.standard;
            lblWeight.Font = CustomFont.standard;
            lblType.Font = CustomFont.standard;
            lblName.Font = CustomFont.standard;
            lblHitpoints.Font = CustomFont.standard;
            lblHeight.Font = CustomFont.standard;
            lblGeneration.Font = CustomFont.standard;
            lblCompteur.Font = CustomFont.small;
            lblAtk.Font = CustomFont.standard;
            lblAtk.Font = CustomFont.standard;
            btnMyPekeman.Font = CustomFont.standard;
        }

        private void BtnClosePekedex_Click(object sender, EventArgs e)
        {
            Form formPekeman = FormPekeman.ActiveForm;
            WorldMap worldMap = formPekeman.Controls.Find("worldMap", false).FirstOrDefault() as WorldMap;
            worldMap.Enabled = true;
            Visible = false;
        }

        private void LstPekemanAttrape_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedPekeman = (string) lstPekemanAttrape.SelectedItem;
            int selectedPekemanIndex = lstPekemanAttrape.FindStringExact(selectedPekeman);
            DisplayPokemon(selectedPekemanIndex);
        }

        private void LstPekemanAttrape_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush greyBrush = Brushes.LightGray;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Red);
            e.DrawBackground();
            e.Graphics.DrawString(lstPekemanAttrape.Items[e.Index].ToString(), 
                                  CustomFont.standard,
                                  greyBrush,
                                  e.Bounds,
                                  StringFormat.GenericDefault);
        }

        private void BtnMyPekeman_Click(object sender, EventArgs e)
        {
            DisplayPokemon(0);
        }
    }
}
