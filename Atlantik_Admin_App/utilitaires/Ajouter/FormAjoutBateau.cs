using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjoutBateau : Form
    {
        MySqlConnection oConnexion;
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

                    // 1ere requete d'ajout du nom du bateau dans la table bateau 

                    string requete = "INSERT INTO bateau(NOM) VALUES (@NOMBATEAU);";

                    var cmd_nombateau = new MySqlCommand(requete, oConnexion);

                    cmd_nombateau.Parameters.AddWithValue("@NOMBATEAU", tbxNomBateau.Text);

                    cmd_nombateau.ExecuteNonQuery();

                    // 2eme requete permettant l'insertion des capacités maximales saisis dans les textbox

                    string insert_contenir = "INSERT INTO contenir(LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES (@LETTRECATEGORIE,   , @CAPACITEMAX);";

                    var cmd_contenir = new MySqlCommand(insert_contenir, oConnexion);
                    

                    // Récupération des tags des textbox
                    
                    string categorie = bateau.Tag.ToString();

                    // instanciation des paramètres

                    cmd_contenir.Parameters.AddWithValue("@LETTRECATEGORIE", categorie);

                    cmd_contenir.Parameters.AddWithValue("@CAPACITEMAX", int.Parse(bateau.Text.ToString()));

                    cmd_contenir.ExecuteNonQuery();
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
