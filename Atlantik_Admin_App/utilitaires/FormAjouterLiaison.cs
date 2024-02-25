using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Web;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjouterLiaison : Form
    {
        MySqlConnection oConnexion;
        public FormAjouterLiaison()
        {
            InitializeComponent();
        }

        private void FormAjouterLiaison_Load(object sender, EventArgs e)
        {
            oConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            // Try-Catch pour la listBox
            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM secteur";
                var cmd = new MySqlCommand(requete, oConnexion);
                cmd.CommandText = requete;

                MySqlDataReader readDB = cmd.ExecuteReader();
                while (readDB.Read())
                {
                    lbxSecteur.Items.Add(new Secteur(int.Parse(readDB["NOSECTEUR"].ToString()), readDB["NOM"].ToString()));
                }
                oConnexion.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }
            // Fin du premier try-catch

            // Try-Catch pour les comboBox

            try
            {
                oConnexion.Open();
                string rCmb = "SELECT * FROM port";
                var cmd = new MySqlCommand(rCmb, oConnexion);
                cmd.CommandText = rCmb;

                MySqlDataReader readDB = cmd.ExecuteReader();
                while (readDB.Read())
                {
                    cmbDepart.Items.Add(new Port(int.Parse(readDB["NOPORT"].ToString()), readDB["NOM"].ToString()));
                    cmbArrivee.Items.Add(new Port(int.Parse(readDB["NOPORT"].ToString()), readDB["NOM"].ToString()));
                }
            } 
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }
        }

        private void btnAjoutLiaison_Click(object sender, EventArgs e)
        {
            try
            {
                string requete = "INSERT INTO liaison(NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE) VALUES (@NOPORT_DEPART, @NOSECTEUR, @NOPORT_ARRIVEE, @DISTANCE)";
                var cmd = new MySqlCommand(requete, oConnexion);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmd.Parameters.AddWithValue("@NOPORT_DEPART", ;
                    cmd.Parameters.AddWithValue("@NOSECTEUR", );
                    cmd.Parameters.AddWithValue("@NOPORT_ARRIVEE", );
                    cmd.Parameters.AddWithValue("@DISTANCE", );
                    MessageBox.Show("Ajout réussi.");
                    Close();
                }

            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }
        }
    }
}
