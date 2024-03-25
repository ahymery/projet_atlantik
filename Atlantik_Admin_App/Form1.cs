using Atlantik_Admin_App.utilitaires;
using Atlantik_Admin_App.utilitaires.Afficher;
using Atlantik_Admin_App.utilitaires.Modifier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_Admin_App
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            lblAtlantik.Parent = logoAtlantik;
            lblAtlantik.BackColor = Color.Transparent;
        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            FormAjouterSecteur secteur = new FormAjouterSecteur();
            secteur.ShowDialog();
        }

        private void btnAjouterPort_Click(object sender, EventArgs e)
        {
            FormAjouterPort port = new FormAjouterPort();
            port.ShowDialog();
        }

        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {
            FormAjouterLiaison liaison = new FormAjouterLiaison();
            liaison.ShowDialog();
        }

        private void btnAjouterTarifs_Click(object sender, EventArgs e)
        {
            FormAjouterTarifs tarifs = new FormAjouterTarifs();
            tarifs.ShowDialog();
        }

        private void btnAjouterBateau_Click(object sender, EventArgs e)
        {
            FormAjoutBateau bateau = new FormAjoutBateau();
            bateau.ShowDialog();
        }

        private void btnAfficherDetails_Click(object sender, EventArgs e)
        {
            FormAfficherReservations reservations = new FormAfficherReservations();
            reservations.ShowDialog();
        }

        private void btnModifierBateau_Click(object sender, EventArgs e)
        {
            FormModifierBateau modifier = new FormModifierBateau();
            modifier.ShowDialog();
        }

        private void btnAjouterTraversee_Click(object sender, EventArgs e)
        {
            FormAjouterTraversee traversee = new FormAjouterTraversee();
            traversee.ShowDialog();
        }

        private void btnParametres_Click(object sender, EventArgs e)
        {
            FormModifierParametres modifier = new FormModifierParametres();
            modifier.ShowDialog();
        }

        private void btnAPropos_Click(object sender, EventArgs e)
        {
            A_Propos a_Propos = new A_Propos();
            a_Propos.ShowDialog();
        }

        private void btnAfficherTraversee_Click(object sender, EventArgs e)
        {
            FormAfficherTraversee traversee = new FormAfficherTraversee();
            traversee.ShowDialog();
        }
    }
}
