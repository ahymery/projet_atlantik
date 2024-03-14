using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjouterTarifs : Form
    {
        MySqlConnection oConnexion;

        public FormAjouterTarifs()
        {
            InitializeComponent();
        }


        private void FormAjouterTarifs_Load(object sender, EventArgs e)
        {
            // Connexion a la BDD

            oConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");

            // Try-Catch pour la listBox
            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM secteur";
                var cmd = new MySqlCommand(requete, oConnexion);
                cmd.CommandText = requete;

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbxSecteurs.Items.Add(new Secteur(int.Parse(reader["NOSECTEUR"].ToString()), reader["NOM"].ToString()));
                }
                oConnexion.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }

            // try catch pour combo-box




            // Affichage dynamique des Labels et des textbox

            int i;
            try
            {
                oConnexion.Open();

                // Instanciations des objets label et textbox

                Label lbl;
                TextBox tbx;

                // Requête permettant de retrouver les lettre ainsi que les libelles des types/catégories

                string requete = "SELECT * FROM type;";

                // Création de la commande 

                var cmd = new MySqlCommand(requete, oConnexion);

                cmd.CommandText = requete;

                MySqlDataReader reader = cmd.ExecuteReader(); // Cela permet de pouvoir lire dans la base de données

                // Boucle permettant l'affichage des données

                for (i = 1; i <= 8; i++)
                {
                    reader.Read();

                    // Ajout des labels dans le GroupBox
                    lbl = new Label();
                    lbl.Text = reader["LETTRECATEGORIE"].ToString() + reader["NOTYPE"].ToString() + " - " + reader["LIBELLE"].ToString();
                    lbl.Location = new Point(15, i * 36);
                    gbxTarifs.Controls.Add(lbl);

                    // Ajout des TextBox dans le GroupBox
                    tbx = new TextBox();
                    tbx.Tag = reader["LETTRECATEGORIE"].ToString() + ";" + reader["NOTYPE"].ToString();
                    tbx.Location = new Point(120, i * 36);
                    gbxTarifs.Controls.Add(tbx);
                }
                oConnexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            // TRY-CATCH du combo-box des liaison

            try
            {
                oConnexion.Open();

                string requete = "SELECT *, " +
                "FROM liaison l " +
                "INNER JOIN port AS p_dep ON l.NOPORT_DEPART = p_dep.NOPORT " +
                "INNER JOIN port AS p_arr ON l.NOPORT_ARRIVEE = p_arr.NOPORT " +
                "INNER JOIN secteur AS s ON l.NOSECTEUR = s.NOSECTEUR " +
                "WHERE s.NOSECTEUR = @NOSECTEUR;";

                var cmd = new MySqlCommand(requete, oConnexion);
                
                cmd.CommandText = requete;
                
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    cmbLiaisons.Items.Add(new Liaison(reade"]);
                }
            }
            catch(MySqlException ex) 
            { 
                MessageBox.Show("Erreur : " +  ex.Message);
            }
        }

        private void btnAjouterTarifs_Click(object sender, EventArgs e)
        {

        }
    }

}
