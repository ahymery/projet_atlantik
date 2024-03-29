using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
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

                string requete = "SELECT * FROM contenir WHERE NOBATEAU = @NOBATEAU";

                var cmd = new MySqlCommand(requete, oConnexion);

                cmd.Parameters.AddWithValue("@NOBATEAU", ((Bateaux)cmbNomBateau.SelectedItem).getNoBateau());

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    foreach (TextBox tbx in gbxCapacitésMax.Controls.OfType<TextBox>())
                    {
                        if (tbx.Tag.ToString() == reader["LETTRECATEGORIE"].ToString())
                        {
                            tbx.Text = reader["CAPACITEMAX"].ToString();
                        }
                    }
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (oConnexion is object & oConnexion.State == ConnectionState.Open)
                {
                    oConnexion.Close();
                }
            }
        }



        private void btnModifierBateau_Click(object sender, EventArgs e)
        {
            try
            {
                oConnexion.Open();
                foreach (TextBox tbx in gbxCapacitésMax.Controls.OfType<TextBox>())
                {
                    string requete = "UPDATE contenir SET CAPACITEMAX = @CAPACITEMAX WHERE NOBATEAU = @NOBATEAU AND LETTRECATEGORIE = @LETTRECATEGORIE;";
                    var cmd = new MySqlCommand(requete, oConnexion);
                    cmd.Parameters.AddWithValue("@CAPACITEMAX", tbx.Text.ToString());
                    cmd.Parameters.AddWithValue("@NOBATEAU", ((Bateaux)cmbNomBateau.SelectedItem).getNoBateau());
                    cmd.Parameters.AddWithValue("@LETTRECATEGORIE", tbx.Tag.ToString());

                    if (Regex.Match(tbx.Text, "^[0-9]+$").Success)
                    {
                        MessageBox.Show("Modification réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Modification échoué !", "Échec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        break;
                    }
                       
                }
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
    }
}
