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
            cmd.Parameters.AddWithValue("@NOMPORT", tbxAjouterPort.Text);
            int nb = cmd.ExecuteNonQuery();
            if (nb > 0)
            {
                MessageBox.Show("Ajout réussi", "Réussite de l'ajout !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Aucune ligne n'a été affecté.");
            }
        }

        private void tbxAjouterPort_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");

            var resultatTest = objetRegEx.Match(tbxAjouterPort.Text);
            if (!resultatTest.Success)
            {
                tbxAjouterPort.BackColor = Color.Red;
            }
            else
            {
                tbxAjouterPort.BackColor = Color.Green;
            }
        }
    }
}

