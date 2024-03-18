using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class Periodes
    {
        private int noPeriode;
        private string dateDebut;
        private string dateFin;

        public Periodes(int noPeriode, string dateDebut, string dateFin)
        {
            this.noPeriode = noPeriode;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }

        public int getNoPeriode() { return noPeriode; }
        public string getDateDebut() { return dateDebut; }
        public string getDateFin() { return dateFin; }

        public override string ToString()
        {
            return dateDebut + " au " + dateFin;
        }
    }
}
