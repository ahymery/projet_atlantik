using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjouterTraversee : Form
    {
        MySqlConnection oConnexion;
        MySqlDataReader reader = null;
        public FormAjouterTraversee()
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
            finally { oConnexion.Close(); }
        }

        private void FormAjouterTraversee_Load(object sender, EventArgs e)
        {
            // Génération de la combo box des nom de bateau
            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM bateau";
                var cmd = new MySqlCommand(requete, oConnexion);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbBateau.Items.Add(new Bateaux(int.Parse(reader["NOBATEAU"].ToString()), reader["NOM"].ToString()));
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

            // Try-Catch pour la listBox Secteurs

            try
            {
                oConnexion.Open();
                string requete = "SELECT * FROM secteur";
                var cmd = new MySqlCommand(requete, oConnexion);
                cmd.CommandText = requete;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lbxSecteur.Items.Add(new Secteur(int.Parse(reader["NOSECTEUR"].ToString()), reader["NOM"].ToString()));
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Erreur : " + error.Message);
            }
            finally { oConnexion.Close(); }
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
                                 "INNER JOIN secteur s ON l.NOSECTEUR = s.NOSECTEUR;";

                var cmd = new MySqlCommand(requete, oConnexion);


                MySqlDataReader reader = cmd.ExecuteReader();

                cmbLiaison.Items.Clear();

                while (reader.Read())
                {
                    cmbLiaison.Items.Add(new Liaison(int.Parse(reader["NOLIAISON"].ToString()), reader["NomPortDepart"].ToString(), reader["NomPortArrivee"].ToString()));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally { oConnexion.Close(); }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                oConnexion.Open();
                string requete = "INSERT INTO traversee(NOLIAISON, NOBATEAU, DATEHEUREDEPART, DATEHEUREARRIVEE) " +
                                 "VALUES (@NOLIAISON, @NOBATEAU, @DATEHEUREDEPART, @DATEHEUREARRIVEE);";
                var cmd = new MySqlCommand(requete, oConnexion);
                reader = cmd.ExecuteReader();

                cmd.Parameters.AddWithValue("@NOLIAISON", ((Liaison)cmbLiaison.SelectedItem).GetId());
                cmd.Parameters.AddWithValue("@NOBATEAU", ((Bateaux)cmbBateau.SelectedItem).getNoBateau());
                cmd.Parameters.AddWithValue("@DATEHEUREDEPART", dateDepart.Value);
                cmd.Parameters.AddWithValue("@DATEHEUREARRIVEE", dateArrivee.Value);

                cmd.ExecuteNonQuery();
            } catch (MySqlException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally { oConnexion.Close(); } 
        }
    }
}
