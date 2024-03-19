using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjoutBateau : Form
    {
        MySqlConnection oConnexion;
        MySqlDataReader reader;
        public FormAjoutBateau()
        {
            InitializeComponent();
            oConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                oConnexion.Open();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }
            finally { oConnexion.Close(); }
        }

        private void FormAjoutBateau_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            foreach (TextBox bateau in gbxCapaMax.Controls.OfType<TextBox>())
            {
                try
                {
                    oConnexion.Open();

                    // Récupération du numéro de bateau afin de l'ajouter dans la table contenir

                    string nobateau = "SELECT NOBATEAU FROM bateau GROUP BY NOBATEAU DESC;";

                    var cmd_nobateau = new MySqlCommand(nobateau, oConnexion);

                    reader = cmd_nobateau.ExecuteReader();

                    // 1ere requete permettant l'insertion des capacités maximales saisis dans les textbox

                    string insert_contenir = "INSERT INTO contenir(LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES (@LETTRECATEGORIE, NOBATEAU, CAPACIEMAX);";

                    var cmd_contenir = new MySqlCommand(insert_contenir, oConnexion);

                    // Récupération des tags des textbox
                    string categorie = bateau.Tag.ToString();
                    // instanciation des paramètres
                    cmd_contenir.Parameters.AddWithValue("@LETTRECATEGORIE", categorie);

                    cmd_contenir.Parameters.AddWithValue("@NOBATEAU", int.Parse(reader["NOBATEAU"].ToString()) + 1);

                    cmd_contenir.Parameters.AddWithValue("@CAPACITEMAX", int.Parse(bateau.Text.ToString()));

                    cmd_contenir.ExecuteNonQuery();


                    // 2ème requete d'insertion permettant l'ajout du nom du bateau dans la table bateau

                    string insert_nombateau = "INSERT INTO bateau(NOM) VALUES (@NOMBATEAU);";

                    var cmd_nombateau = new MySqlCommand(insert_nombateau, oConnexion);

                    cmd_nombateau.Parameters.AddWithValue("@NOMBATEAU", tbxNomBateau.Text.ToString());

                    cmd_nombateau.ExecuteNonQuery();
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
        }
    }
}
