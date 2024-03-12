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
                string requete = "SELECT *, " +
                "p_dep.NOM AS NomPortDepart, " +
                "p_arr.NOM AS NomPortArrivee, " +
                "s.NOM AS NomSecteur " +
                "FROM liaison l " +
                "INNER JOIN port p_dep ON l.NOPORT_DEPART = p_dep.NOPORT " +
                "INNER JOIN port p_arr ON l.NOPORT_ARRIVEE = p_arr.NOPORT " +
                "INNER JOIN secteur s ON l.NOSECTEUR = s.NOSECTEUR " +
                "WHERE s.NOSECTEUR = @NOSECTEUR;";

                var cmd = new MySqlCommand(requete, oConnexion);
                cmd.CommandText = requete;
                var noSecteur = (Secteur)lbxSecteurs.SelectedItem;

                MySqlDataReader readDB = cmd.ExecuteReader();
                cmd.Parameters.AddWithValue("@NOSECTEUR", noSecteur.GetId());
                while (readDB.Read())
                {
                    cmbLiaisons.Items.Add(new Liaison(int.Parse(readDB["@NOSECTEUR"].ToString()), readDB["NomPortDepart"].ToString(), readDB["NomPortArrivee"].ToString()));
                }
                oConnexion.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }

            // textbox & labels

            int i;
            try
            {
                Label lbl;
                TextBox tbx;

                string categorie = "SELECT * FROM type;";

                var cmd = new MySqlCommand(categorie, oConnexion);

                cmd.CommandText = categorie;

                MySqlDataReader reader = cmd.ExecuteReader();

                for(i = 1; i <= 8; i = i + 1)
                {
                    reader.Read();
                    lbl = new Label();
                    lbl.Text = reader["LETTRECATEGORIE"].ToString() + reader["NOTYPE"].ToString() + " - " + reader["LIBELLE"].ToString();
                    lbl.Location = new Point(15, i * 36);
                    gbxTarifs.Controls.Add(lbl);

                    tbx = new TextBox();
                    tbx.Tag = reader["LETTRECATEGORIE"].ToString() + ";" + reader["NOTYPE"].ToString();
                    tbx.Location = new Point(120, i * 36);
                    gbxTarifs.Controls.Add(tbx);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAjouterTarifs_Click(object sender, EventArgs e)
        {
            
        }
    }

}
