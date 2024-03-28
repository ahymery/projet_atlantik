using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class traversee
    {
        private int noTraversee;
        private string heure;
        private int capaciteMax;

        public traversee(int noTraversee) 
        { 
            this.noTraversee = noTraversee;
        }

        public int GetNoTraversee()
        {
            return noTraversee;
        }

        public string GetHeure()
        {
            return heure;
        }

        public int GetCapaciteMax()
        {
            return capaciteMax;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
