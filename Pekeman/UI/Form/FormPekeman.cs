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
    public partial class FormPekeman : Form
    {
        private Form menu;

        public FormPekeman(Form mainForm)
        {
            menu = mainForm; 
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void FormPekeman_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Le progrès ne sera pas sauvegardé.\n\nVoulez-vous vraiment quitter?";
            const string titre = "Quitter";

            var reponse = MessageBox.Show(message, titre,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation);
            switch (reponse)
            {
                case DialogResult.Yes:
                    e.Cancel = false;
                    menu.Close();
                    //menu.Show();
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
