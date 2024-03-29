using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjouterPort : Form
    {
        MySqlConnection oConnexion;
        public FormAjouterPort()
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
        }

        private void FormAjouterPort_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouterUnPort_Click(object sender, EventArgs e)
        {
            string requete;
            requete = "INSERT INTO port(NOM) VALUES (@NOMPORT)";
            var cmd = new MySqlCommand(requete, oConnexion);
            if (Regex.Match(tbxAjouterPort.Text, "^[a-zA-Zéèêëçàâôù ûïî]*$").Success)
            {
                cmd.Parameters.AddWithValue("@NOMPORT", tbxAjouterPort.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Ajout échoué !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAjouterPort.Text = " ";
                Close();
            }
        }
    }
}

