using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjouterPort : Form
    {
        MySqlConnection bdd;
        public FormAjouterPort()
        {
            InitializeComponent();

            bdd = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                bdd.Open();
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
            var cmd = new MySqlCommand(requete, bdd);
            cmd.Parameters.AddWithValue("@NOMPORT", tbxAjouterPort.Text);
            int nb = cmd.ExecuteNonQuery();
            MessageBox.Show("Ajout réussi.");
            Close();
        }
    }
}
