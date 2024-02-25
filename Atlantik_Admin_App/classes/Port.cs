using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class Port
    {
        private string nomPort;
        private int idPort;

        public Port(int idPort, string nomPort)
        {
            this.nomPort = nomPort;
            this.idPort = idPort;
        }

        public int GetId()
        {
            return idPort;
        }

        public override string ToString()
        {
            return nomPort;
        }
    }
}
