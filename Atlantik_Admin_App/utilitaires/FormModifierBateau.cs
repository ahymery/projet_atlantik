using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormModifierBateau : Form
    {
        private MySqlConnection oConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        private MySqlDataReader reader = null;

        public FormModifierBateau()
        {
            InitializeComponent();
        }

        private void FormModifierBateau_Load(object sender, EventArgs e)
        {
            // Try Catch pour lE COMBOBOX des bateaux

            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM bateau";
                var cmd = new MySqlCommand(requete, oConnexion);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbNomBateau.Items.Add(new Bateaux(int.Parse(reader["NOBATEAU"].ToString()), reader["NOM"].ToString()));
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

        private void cmbNomBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            oConnexion.Open();

            //  Faire en sorte que le text de la capacité Maximale affiche dans les textbox en cliquant sur un nom du bateau dans le ComboBox
            try
            {
                string requete = "SELECT * FROM contenir " +
                    "INNER JOIN bateau ON (bateau.NOBATEAU = contenir.NOBATEAU) " +
                    "INNER JOIN categorie ON (categorie.LETTRECATEGORIE = contenir.LETTRECATEGORIE) " +
                    "WHERE bateau.NOBATEAU = @NOBATEAU;";

                var cmd = new MySqlCommand(requete, oConnexion);

                cmd.Parameters.AddWithValue("@NOBATEAU", ((Bateaux)cmbNomBateau.SelectedItem).getNoBateau());

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {                                     
                        tbxCategorieA.Text = reader["CAPACITEMAX"].ToString();
                        tbxCategorieB.Text = reader["CAPACITEMAX"].ToString();
                        tbxCategorieC.Text = reader["CAPACITEMAX"].ToString();        
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }
            finally { oConnexion.Close(); }
        }
    }
}
