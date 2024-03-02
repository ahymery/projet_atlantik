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
            string requete = "INSERT INTO bateau(NOM) VALUES (@NOMBATEAU);" +
                "INSERT INTO contenir(LETTRECATEGORIE, CAPACITEMAX) VALUES ('A', @CATEGORIEA);" +
                "INSERT INTO contenir(LETTRECATEGORIE, CAPACITEMAX) VALUES ('B', @CATEGORIEB);" +
            "INSERT INTO contenir(LETTRECATEGORIE, CAPACITEMAX) VALUES ('C', @CATEGORIEC);";

            var cmd = new MySqlCommand(requete, oConnexion);
            cmd.Parameters.AddWithValue("@NOMBATEAU", tbxNomBateau.Text);
            cmd.Parameters.AddWithValue("@CATEGORIEA", int.Parse(tbxCategorieA.Text));
            cmd.Parameters.AddWithValue("@CATEGORIEB", int.Parse(tbxCategorieB.Text));
            cmd.Parameters.AddWithValue("@CATEGORIEC", int.Parse(tbxCategorieC.Text));
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
