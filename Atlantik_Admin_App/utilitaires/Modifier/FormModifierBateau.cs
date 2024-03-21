using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Linq;
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
            try
            {

            oConnexion.Open();
                string requete = "SELECT * FROM contenir c " +
                                 "INNER JOIN bateau b ON (b.NOBATEAU = c.NOBATEAU);";
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }
            finally { oConnexion.Close(); } 
        }


        private void btnModifierBateau_Click(object sender, EventArgs e)
        {
            string requete = "UPDATE contenir SET CAPACITEMAX = @CAPACITEMAX";


        }
    }
}
