using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class Liaison
    {
        private string nomPortDepart;
        private string nomPortArrivee;
        private int idSecteur;

        public Liaison(int idSecteur, string nomPortDepart, string nomPortArrivee)
        {
            this.nomPortDepart = nomPortDepart;
            this.nomPortArrivee = nomPortArrivee;
            this.idSecteur = idSecteur;
        }

        public int GetId() { return idSecteur; }
        public string GetNomPortDepart() { return nomPortDepart; }
        public string GetNomPortArrivee() { return  nomPortArrivee; }
        public override string ToString()
        {
            return nomPortDepart + " - " + nomPortArrivee;
        }
    }
}
