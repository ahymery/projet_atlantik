using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class Periodes
    {
        private string dateDebut;
        private string dateFin;

        public Periodes(string dateDebut, string dateFin)
        {
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }

        public string getDateDebut() { return dateDebut; }
        public string getDateFin() { return dateFin; }

        public override string ToString()
        {
            return dateDebut + " au " + dateFin;
        }
    }
}
