using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjouterSecteur : Form
    {
        private MySqlConnection bdd;

        public FormAjouterSecteur()
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

        private void AjouterSecteur_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAjouterUnSecteur_Click(object sender, EventArgs e)
        {
            string requete;
            requete = "INSERT INTO secteur(NOM) VALUES (@NOMSECTEUR)";
            var cmd = new MySqlCommand(requete, bdd);
            if (Regex.Match(tbxSecteur.Text, "^[a-zA-Zéèêëçàâôù ûïî]*$").Success)
            {
                cmd.Parameters.AddWithValue("@NOMSECTEUR", tbxSecteur.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout effectué avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ajout échoué !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxSecteur.Text = " ";
            }
            Close();
        }

        private void tbxSecteur_Validating(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");

            var resultatTest = objetRegEx.Match(tbxSecteur.Text);
            if (!resultatTest.Success)
            {
                tbxSecteur.BackColor = Color.Tomato;
            }
            else
            {
                tbxSecteur.BackColor = Color.LightGreen;
            }
        }
    }
}
