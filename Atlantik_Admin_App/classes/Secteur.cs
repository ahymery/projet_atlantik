using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class Secteur
    {
        private string nomSecteur;
        private int idSecteur;

        public Secteur(int idSecteur, string nomSecteur)
        {
            this.idSecteur = idSecteur;
            this.nomSecteur = nomSecteur;
        }

        public int GetId()
        {
            return idSecteur;
        }

        public override string ToString()
        {
            return "Id : " + idSecteur.ToString() + "Nom : " + nomSecteur;
        }
    }
}
