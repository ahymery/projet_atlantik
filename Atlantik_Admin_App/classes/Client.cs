using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class Client
    {
        private int idClient;
        private string nomClient;
        private string prenomClient;

        public Client(string nomClient, string prenomClient) 
        {
            this.nomClient = nomClient;
            this.prenomClient = prenomClient;
        }

        public int getIdClient() 
        {
            return idClient; 
        } 
        
        public override string ToString() 
        { 
            return nomClient + ", " + prenomClient;
        }
    }
}
