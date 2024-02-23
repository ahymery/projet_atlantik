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

namespace Atlantik_Admin_App.utilitaires
{
    public partial class FormAjouterSecteur : Form
    {  
        public FormAjouterSecteur()
        {
            InitializeComponent();
            MySqlConnection bdd;

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
    }
}
