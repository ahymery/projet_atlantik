using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class Bateaux
    {
        private int noBateau;
        private string nomBateau;

        public Bateaux(int noBateau, string nomBateau) 
        { 
            this.noBateau = noBateau;
            this.nomBateau = nomBateau;
        }

        public int getNoBateau() { return noBateau; }

        public override string ToString() { return nomBateau; }
    }
}
