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
        }

        private void FormAjoutBateau_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Ajout du nom du bateau dans la table bateau
            string requete = "INSERT INTO contenir(CAPACITEMAX) SELECT LETTRECATEGORIE LIKE '%A%';";
            var cmd = new MySqlCommand(requete, oConnexion);
            cmd.Parameters.AddWithValue("@NOMBATEAU", tbxNomBateau.Text);
            cmd.Parameters.AddWithValue("@CATEGORIEA", tbxCategorieA.Text);
            cmd.Parameters.AddWithValue("@CATEGORIEB", tbxCategorieB.Text);
            cmd.Parameters.AddWithValue("@CATEGORIEC", tbxCategorieC.Text);
            int nb = cmd.ExecuteNonQuery();
            if (nb > 0)
            {
                MessageBox.Show("Ajout réussi.");
            }
            else
            {
                MessageBox.Show("Aucune ligne n'a été affecté.");
            }
        }
    }
}
