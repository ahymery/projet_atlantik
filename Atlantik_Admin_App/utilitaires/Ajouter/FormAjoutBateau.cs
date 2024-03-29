using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Text.RegularExpressions;
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

            try
            {

                oConnexion.Open();

                // 1ere requete d'ajout du nom du bateau dans la table bateau 

                string requete = "INSERT INTO bateau(NOM) VALUES (@NOMBATEAU);";

                var cmd_nombateau = new MySqlCommand(requete, oConnexion);

                cmd_nombateau.Parameters.AddWithValue("@NOMBATEAU", tbxNomBateau.Text);

                // Ajout du controle de saisie pour la textbox du nom bateau 

                if (Regex.Match(tbxNomBateau.Text, "^[a-zA-Zéèêëçàâôù ûïî]*$").Success)
                {
                    MessageBox.Show("Ajout du nom du bateau effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd_nombateau.ExecuteNonQuery();
                }
                else
                {
                    tbxNomBateau.Text = " ";
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

            // 2eme requete permettant l'insertion des capacités maximales saisis dans les textbox

            try
            {
                oConnexion.Open();
                foreach (TextBox bateau in gbxCapaMax.Controls.OfType<TextBox>())
                {
                    string insertion_capacite = "INSERT INTO contenir(LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES(@LETTRECATEGORIE, @NOBATEAU, @CAPACITEMAX);";

                    var cmd_capacite = new MySqlCommand(insertion_capacite, oConnexion);

                    string tag = bateau.Tag.ToString();

                    string[] tags;

                    tags = tag.Split(';');

                    cmd_capacite.Parameters.AddWithValue("@LETTRECATEGORIE", tags[0].ToString());

                    string last_id = "SELECT NOBATEAU FROM bateau GROUP BY NOBATEAU DESC;";

                    var cmd_nobateau = new MySqlCommand(last_id, oConnexion);

                    var nobateau = cmd_nobateau.ExecuteReader();

                    if (nobateau.Read())
                    {
                        cmd_capacite.Parameters.AddWithValue("@NOBATEAU", nobateau["NOBATEAU"].ToString());
                        cmd_capacite.Parameters.AddWithValue("@CAPACITEMAX", bateau.Text);
                    }
                    nobateau.Close();

                    // Ajout du controle de saisie pour l'ensembles des textbox d'ajout des capacité des bateaux

                    if (Regex.Match(bateau.Text, "^[0-9]*$").Success)
                    {
                        cmd_capacite.ExecuteNonQuery();
                        MessageBox.Show("Ajout des données de la table 'contenir' effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur de saisie !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bateau.Text = " ";
                        break;
                    }



                }
            }

            catch (MySqlException error)

            {
                MessageBox.Show("Erreur : " + error.Message);
            }

            finally

            {
                oConnexion.Close();
            }


        }

    }
}
