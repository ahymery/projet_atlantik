using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAfficherReservations : Form
    {
        MySqlConnection oConnexion;
        public FormAfficherReservations()
        {
            InitializeComponent();
            oConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                oConnexion.Open();
            }
            catch(MySqlException e)  
            {
                MessageBox.Show("Erreur : " + e.Message);
            }
        }

        private void FormAfficherReservations_Load(object sender, EventArgs e)
        {
            lvReservations.View = View.Details;
            lvReservations.GridLines = true;
            lvReservations.FullRowSelect = true;

            lvReservations.Columns.Add("n° Réservation", 100);
            lvReservations.Columns.Add("Liaison", 50);
            lvReservations.Columns.Add("n° Traversée", 100);
            lvReservations.Columns.Add("Date départ", 100);

            string requete = "SELECT NOM, PRENOM FROM client " +
                "INNER JOIN reservation ON (client.NOCLIENT = reservation.NOCLIENT)" +
                "INNER JOIN traversee ON (reservation.NOTRAVERSEE = traversee.NOTRAVERSEE)" +
                "INNER JOIN liaison ON (traversee.NOLIAISON = liaison.NOLIAISON)" +
                "INNER JOIN enregistrer ON (client.NOCLIENT = enregistrer.NOTYPE);";
            var cmd = new MySqlCommand(requete, oConnexion);
            cmd.CommandText = requete;

            MySqlDataReader readDB = cmd.ExecuteReader();
            while (readDB.Read())
            {
                cmbClients.Items.Add(new Client(readDB["NOM"].ToString(), readDB["PRENOM"].ToString()));
                if (cmbClients.SelectedIndex > 0)
                {
                    lblAffichageAdulte.Text = readDB["enregistrer.QUANTITERESERVEE"].ToString();
                }
            }
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
