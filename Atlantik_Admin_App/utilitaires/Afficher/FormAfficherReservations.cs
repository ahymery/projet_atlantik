using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAfficherReservations : Form
    {
        MySqlConnection oConnexion;
        MySqlDataReader reader = null;
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

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbClients.Items.Add(new Client(reader["NOM"].ToString(), reader["PRENOM"].ToString()));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                oConnexion.Close();
            }
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Affichage des quantités réservées dans le group box réservation 
            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM enregistrer WHERE NOTYPE = @NOTYPE;";
                var cmd = new MySqlCommand(requete, oConnexion);
                reader = cmd.ExecuteReader();
                foreach (Label lbl in gbxReservation.Controls.OfType<Label>())
                {
                    string categorie = lbl.Tag.ToString();
                    string[] tag;
                    tag = categorie.Split(';');
                    cmd.Parameters.AddWithValue("@NOTYPE", tag[1].ToString());
                    while (reader.Read())
                    {
                        lbl.Text = reader["QUANTITERESERVEE"].ToString();
                    }
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                oConnexion.Close();
            }

            // Affichage du montant totale

            try
            {
                oConnexion.Open();
                string requete = "SELECT MONTANTTOTAL FROM reservation WHERE NOCLIENT = @NOCLIENT;";
                var cmd = new MySqlCommand(requete, oConnexion);
                reader = cmd.ExecuteReader();

            }
        }
    }
}
