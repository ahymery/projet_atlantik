using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjouterTarifs : Form
    {
        private MySqlConnection oConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        public FormAjouterTarifs()
        {
            InitializeComponent();
        }

        private void FormAjouterTarifs_Load(object sender, EventArgs e)
        {

            // Try-Catch pour la listBox

            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM secteur";
                var cmd = new MySqlCommand(requete, oConnexion);
                cmd.CommandText = requete;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lbxSecteurs.Items.Add(new Secteur(int.Parse(reader["NOSECTEUR"].ToString()), reader["NOM"].ToString()));
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }
            finally { oConnexion.Close(); }


            // Affichage dynamique des Labels et des textbox

            int i;
            try
            {

                oConnexion.Open();

                // Instanciations des objets label et textbox

                Label lbl;

                TextBox tbx;

                // Requête permettant de retrouver les lettre ainsi que les libelles des types/catégories

                string requete = "SELECT * FROM type;";

                // Création de la commande 

                var cmd = new MySqlCommand(requete, oConnexion);

                cmd.CommandText = requete;

                MySqlDataReader reader = cmd.ExecuteReader(); // Cela permet de pouvoir lire dans la base de données

                // Boucle permettant l'affichage des données

                for (i = 1; i <= 8; i++)
                {
                    reader.Read();

                    // Ajout des labels dans le GroupBox

                    lbl = new Label();
                    lbl.Text = reader["LETTRECATEGORIE"].ToString() + reader["NOTYPE"].ToString() + " - " + reader["LIBELLE"].ToString();
                    lbl.Location = new Point(15, i * 36);
                    gbxTarifs.Controls.Add(lbl);

                    // Ajout des TextBox dans le GroupBox

                    tbx = new TextBox();
                    tbx.Tag = reader["LETTRECATEGORIE"].ToString() + ";" + reader["NOTYPE"].ToString();
                    tbx.Location = new Point(120, i * 36);
                    gbxTarifs.Controls.Add(tbx);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { oConnexion.Close(); }

            // ComboBox des Periodes

            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM periode";
                var cmd = new MySqlCommand(requete, oConnexion);
                cmd.CommandText = requete;
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbPeriodes.Items.Add(new Periodes(int.Parse(reader["NOPERIODE"].ToString()), reader["DATEDEBUT"].ToString(), reader["DATEFIN"].ToString()));
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


        private void btnAjouterTarifs_Click(object sender, EventArgs e)
        {
            foreach (TextBox tarifs in gbxTarifs.Controls.OfType<TextBox>())
            {
                try
                {
                    oConnexion.Open();
                    string requete = "INSERT INTO tarifer (NOPERIODE, LETTRECATEGORIE, NOTYPE, NOLIAISON, TARIF) VALUES (@NOPERIODE, @LETTRECATEGORIE, @NOTYPE, @NOLIAISON, @TARIF);";
                    var cmd = new MySqlCommand(requete, oConnexion);

                    // Split des tags des Textbox générées précédemment

                    string categorie = tarifs.Tag.ToString();
                    string[] tag;
                    tag = categorie.Split(';');

                    cmd.Parameters.AddWithValue("@NOPERIODE", int.Parse(((Periodes)cmbPeriodes.SelectedItem).getNoPeriode().ToString()));
                    cmd.Parameters.AddWithValue("@LETTRECATEGORIE", tag[0].ToString());
                    cmd.Parameters.AddWithValue("@NOTYPE", tag[1].ToString());
                    cmd.Parameters.AddWithValue("@NOLIAISON", ((Liaison)cmbLiaisons.SelectedItem).GetId());
                    cmd.Parameters.AddWithValue("@TARIF", Convert.ToDouble(tarifs.Text.ToString()));
                    int nb = cmd.ExecuteNonQuery();
                    if (nb > 0)
                    {
                        MessageBox.Show("Ajout réussi", "Réussite de l'ajout !", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TRY-CATCH du combo-box des liaison

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

                cmd.Parameters.AddWithValue("@NOSECTEUR", ((Secteur)lbxSecteurs.SelectedItem).GetId().ToString());

                MySqlDataReader reader = cmd.ExecuteReader();

                cmbLiaisons.Items.Clear();

                while (reader.Read())
                {
                    cmbLiaisons.Items.Add(new Liaison(int.Parse(reader["NOLIAISON"].ToString()), reader["NomPortDepart"].ToString(), reader["NomPortArrivee"].ToString()));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally { oConnexion.Close(); }
        }
    }

}
