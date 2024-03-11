using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    public class Categorie_Types
    {
        private string lettreCatégorie;
        private string noType;
        private string libelle;
        public Categorie_Types(string categorie, string noType, string libelle) 
        {
           this.lettreCatégorie = categorie;
           this.noType = noType;
           this.libelle = libelle;
        }

        public override string ToString()
        {
            return lettreCatégorie + noType + " " + libelle;
        }
    }
}
