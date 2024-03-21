using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
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
        }

        private void FormAfficherReservations_Load(object sender, EventArgs e)
        {
            try
            {
                oConnexion.Open();

                lvReservations.View = View.Details;
                lvReservations.GridLines = true;
                lvReservations.FullRowSelect = true;

                lvReservations.Columns.Add("n° Réservation", 100);
                lvReservations.Columns.Add("Liaison", 150);
                lvReservations.Columns.Add("n° Traversée", 100);
                lvReservations.Columns.Add("Date départ", 150);

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
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally { oConnexion.Close(); }
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM enregistrer;";
                var cmd = new MySqlCommand(requete, oConnexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblAffichageAdulte.Text = reader["QUANTITERESERVEE"].ToString();
                    lblAffichageJunior.Text = reader["QUANTITERESERVEE"].ToString();
                    lblAffichageEnfant.Text = reader["QUANTITERESERVEE"].ToString();
                    lblAffichageVoiture.Text = reader["QUANTITERESERVEE"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally { oConnexion.Close(); }
        }
    }
}
