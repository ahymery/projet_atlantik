using Atlantik_Admin_App.classes;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Atlantik_Admin_App.utilitaires.Afficher
{
    public partial class FormAfficherTraversee : Form
    {
        public FormAfficherTraversee()
        {
            InitializeComponent();
        }

        MySqlConnection oConnexion = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader reader;
        private void FormAfficherTraversee_Load(object sender, EventArgs e)
        {
            // Ajout des items dans la combo box secteurs

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

            // Ajout des colonnes dans la listview

            lvTraversee.View = View.Details;
            lvTraversee.GridLines = true;
            lvTraversee.FullRowSelect = true;

            lvTraversee.Columns.Add("N° ", 50);
            lvTraversee.Columns.Add("Heure", 50);
            lvTraversee.Columns.Add("Bateau", 80);
            lvTraversee.Columns.Add("A Passager", 80);
            lvTraversee.Columns.Add("B Véh.inf.2m", 80);
            lvTraversee.Columns.Add("C Véh.sup.2m", 100);
        }

        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
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

                cmd.Parameters.AddWithValue("@NOSECTEUR", ((Secteur)lbxSecteurs.SelectedItem).GetId());

                reader = cmd.ExecuteReader();

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

        private void btnAfficherTraversee_Click(object sender, EventArgs e)
        {
            try
            {
                oConnexion.Open();
                string requete = "SELECT * " +
                                 "FROM traversee t " +
                                 "INNER JOIN bateau b ON (t.NOBATEAU = b.NOBATEAU) " +
                                 "INNER JOIN liaison l ON (l.NOLIAISON = t.NOLIAISON) " +
                                 "INNER JOIN secteur s ON (s.NOSECTEUR = l.NOSECTEUR); ";


                var cmd = new MySqlCommand(requete, oConnexion);
                //cmd.Parameters.AddWithValue("@NOSECTEUR", ((Secteur)lbxSecteurs.SelectedItem).GetId());
                //cmd.Parameters.AddWithValue("@NOLIAISON", ((Liaison)cmbLiaisons.SelectedItem).GetId());
                reader = cmd.ExecuteReader();

                string date = reader["DATEHEUREDEPART"].ToString();
                string[] heure = date.Split(' ');

                var tabItem = new string[6];
                ListViewItem unItem;
                lvTraversee.Items.Clear();


                while (reader.Read())
                {
                    tabItem[0] = reader["NOTRAVERSEE"].ToString();
                    tabItem[1] = heure[1].ToString();
                    tabItem[2] = reader["NOM"].ToString();
                    lvTraversee.Items.Add(new ListViewItem(tabItem));
                }
            }
            catch (MySqlException error) 
            {
                MessageBox.Show("Erreur : " + error.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { oConnexion.Close(); }
        }
    }
}
