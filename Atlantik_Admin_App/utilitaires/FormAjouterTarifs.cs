using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjouterTarifs : Form
    {
        MySqlConnection oConnexion;
        public FormAjouterTarifs()
        {
            InitializeComponent();

        }

        private void FormAjouterTarifs_Load(object sender, EventArgs e)
        {
            oConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            // Try-Catch pour la listBox
            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM secteur";
                var cmd = new MySqlCommand(requete, oConnexion);
                cmd.CommandText = requete;

                MySqlDataReader readDB = cmd.ExecuteReader();
                while (readDB.Read())
                {
                    lbxSecteurs.Items.Add(new Secteur(int.Parse(readDB["NOSECTEUR"].ToString()), readDB["NOM"].ToString()));
                }
                oConnexion.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }

            // try catch pour combo-box

            try
            {
                oConnexion.Open();
                string requete = "SELECT *, p_dep.NOM AS NomPortDepart, p_arr.NOM AS NomPortArrivee, s.NOM AS NomSecteur FROM liaison l INNER JOIN port p_dep ON l.NOPORT_DEPART = p_dep.NOPORT INNER JOIN port p_arr ON l.NOPORT_ARRIVEE = p_arr.NOPORT INNER JOIN secteur s ON l.NOSECTEUR = s.NOSECTEUR WHERE s.NOSECTEUR = @NOSECTEUR;";
                

                var cmd = new MySqlCommand(requete, oConnexion);
                cmd.CommandText = requete;
                MySqlDataReader readDB = cmd.ExecuteReader();
                cmd.Parameters.AddWithValue("@NOSECTEUR", lbxSecteurs.SelectedItem);
                while (readDB.Read())
                {
                    cmbLiaisons.Items.Add(new Liaison(int.Parse(readDB["NOSECTEUR"].ToString()), readDB["NomPortDepart"].ToString(), readDB["NomPortArrivee"].ToString()));
                }
            } 
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }

              

            // textbox

            TextBox tbx;
            int i;
            for (i = 1; i <= 5; i++)
            {
                tbx = new TextBox();
                tbx.Location = new Point(130, i * 50);
                gbxTarifs.Controls.Add(tbx);
            }
        }
    }

}
