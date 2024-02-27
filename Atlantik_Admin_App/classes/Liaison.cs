using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class Liaison
    {
        private string nomSecteurDepart;
        private string nomSecteurArrivee;
        private int idLiaison;

        public Liaison(int idLiaison, string nomSecteurDepart, string nomSecteurArrivee)
        {
            this.nomSecteurDepart = nomSecteurDepart;
            this.nomSecteurArrivee = nomSecteurArrivee;
            this.idLiaison = idLiaison;
        }

        public int GetId()
        {
            return idLiaison;
        }

        public override string ToString()
        {
            return nomSecteurDepart + " - " + nomSecteurArrivee;
        }
    }
}
