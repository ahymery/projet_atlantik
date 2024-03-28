using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires.Modifier
{
    public partial class FormModifierParametres : Form
    {
        MySqlConnection oConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader reader = null;
        public FormModifierParametres()
        {
            InitializeComponent();
        }

        private void FormModifierParametres_Load(object sender, EventArgs e)
        {
            // Ajout du texte dans textbox
            try
            {
                string requete = "SELECT * FROM parametres";
                oConnexion.Open();
                var cmd = new MySqlCommand(requete, oConnexion);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tbxSite.Text = reader["SITE_PB"].ToString();
                    tbxRang.Text = reader["RANG_PB"].ToString();
                    tbxID.Text = reader["IDENTIFIANT_PB"].ToString();
                    tbxCle.Text = reader["CLEHMAC_PB"].ToString();
                    tbxMel.Text = reader["MELSITE"].ToString();
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.ToString());
            }
            finally { oConnexion.Close(); }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Modification des paramètres
            try
            {
                oConnexion.Open();
                foreach (TextBox tbx in gbxPayBox.Controls.OfType<TextBox>())
                {
                    string requete = "UPDATE `parametres` SET SITE_PB = @SITEPB,`RANG_PB` = @RANGPB,`IDENTIFIANT_PB` = @IDPB,`CLEHMAC_PB`=@CLEHMAC,`MELSITE`=@MELSITE;";
                    var cmd = new MySqlCommand(requete, oConnexion);
                    cmd.Parameters.AddWithValue("@SITEPB", tbxSite.Text.ToString());
                    cmd.Parameters.AddWithValue("@RANGPB", tbxRang.Text.ToString());
                    cmd.Parameters.AddWithValue("IDPB", tbxID.Text.ToString());
                    cmd.Parameters.AddWithValue("@CLEHMAC", tbxCle.Text.ToString());
                    cmd.Parameters.AddWithValue("@MELSITE", tbxMel.Text.ToString());
                    int nb = cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Modification réussie", "Réussite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oConnexion.Close();
                Close();
            }


        }

        private void cbxProduction_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                oConnexion.Open();
                string requete = "UPDATE parametres SET ENPRODUCTION = @ENPRODUCTION;";
                var cmd = new MySqlCommand(requete, oConnexion);
                if (cbxProduction.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@ENPRODUCTION", 1); 
                }
                 else if(cbxProduction.Checked == false) 
                {
                    cmd.Parameters.AddWithValue("@ENPRODUCTION", 0);
                }
                cmd.ExecuteNonQuery();  
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }
            finally { oConnexion.Close(); } 
        }
    }
}
