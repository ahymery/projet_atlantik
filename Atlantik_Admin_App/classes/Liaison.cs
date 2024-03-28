using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class Liaison
    {
        private string NomPortDepart;
        private string NomPortArrivee;
        private int idLiaison;

        public Liaison(int idLiaison, string NomPortDepart, string NomPortArrivee)
        {
            this.NomPortDepart = NomPortDepart;
            this.NomPortArrivee = NomPortArrivee;
            this.idLiaison = idLiaison;
        }

        public int GetId() { return idLiaison; }
        public string GetNoPortDepart() { return NomPortDepart; }
        public string GetNoPortArrivee() { return  NomPortArrivee; }

        public override string ToString()
        {
            return idLiaison + " - " +  NomPortDepart + " - " + NomPortArrivee;
        }
    }
}
