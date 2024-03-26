using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using Mysqlx;
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
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oConnexion.Close();
                reader.Close();
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
                foreach (Label lblAffichage in gbxReservation.Controls.OfType<Label>()) 
                { 
                    string categorie = lblAffichage.Tag.ToString();
                    string[] tag;
                    tag = categorie.Split(';');
                    cmd.Parameters.AddWithValue("@NOTYPE", tag[1].ToString());
                    break;
                }

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblAffichageAdulte.Text = reader["QUANTITERESERVEE"].ToString();
                    lblAffichageJunior.Text = reader["QUANTITERESERVEE"].ToString();
                    lblAffichageEnfant.Text = reader["QUANTITERESERVEE"].ToString();
                    lblAffichageVoiture.Text = reader["QUANTITERESERVEE"].ToString();
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oConnexion.Close();
            }

            // Affichage du montant totale

            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM reservation;";
                var cmd = new MySqlCommand(requete, oConnexion);
                cmd.Parameters.AddWithValue("@NOCLIENT", ((Client)cmbClients.SelectedItem).getIdClient());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblAffichageMontant.Text = reader["MONTANTTOTAL"].ToString() + " euros";
                }

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oConnexion.Close();
            }

            // Affichage des informations des réservations 

            try
            {
                oConnexion.Open();
                string requete = "SELECT *, " +
                    "p_dep.NOM AS NomPortDepart, " +
                    "p_arr.NOM AS NomPortArrivee " +
                    "FROM enregistrer enr " +
                    "INNER JOIN reservation r ON (enr.NORESERVATION = r.NORESERVATION) " +
                    "INNER JOIN traversee t ON (r.NOTRAVERSEE = t.NOTRAVERSEE) " +
                    "INNER JOIN liaison l ON (l.NOLIAISON = t.NOLIAISON) " +
                    "INNER JOIN port p_dep ON (l.NOPORT_DEPART = p_dep.NOPORT) " +
                    "INNER JOIN port p_arr ON (l.NOPORT_ARRIVEE = p_arr.NOPORT);";

                var cmd = new MySqlCommand(requete, oConnexion);
                cmd.Parameters.AddWithValue("@NOCLIENT", ((Client)cmbClients.SelectedItem).getIdClient());
                reader = cmd.ExecuteReader();
                reader.Read();
                lvReservations.Items.Clear();
                Liaison l = new Liaison(int.Parse(reader["NOLIAISON"].ToString()), reader["NomPortDepart"].ToString(), reader["NomPortArrivee"].ToString());
                var tabItem = new string[4];
                ListViewItem uneReservation;
                tabItem[0] = reader["NORESERVATION"].ToString();
                tabItem[1] = l.ToString();
                tabItem[2] = reader["NOTRAVERSEE"].ToString();
                tabItem[3] = reader["DATEHEUREDEPART"].ToString();
                lvReservations.Items.Add(new ListViewItem(tabItem));

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oConnexion.Close();
            }
        }
    }
}
