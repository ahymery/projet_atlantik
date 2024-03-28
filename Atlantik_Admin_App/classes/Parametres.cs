using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Atlantik_Admin_App.classes
{
    internal class Parametres
    {
        private string site;
        private string idSite;
        private string rangSite;
        private string cleHMAC;

        public Parametres(string site, string idSite, string rangSite, string cleHMAC)
        {
            this.site = site;
            this.idSite = idSite;
            this.rangSite = rangSite;
            this.cleHMAC = cleHMAC;
        }  

        public string GetSite() {  return site; }
        public string GetIdSite() {  return idSite; }
        public string GetRangSite() {  return rangSite; }
        public string GetCleHMAC() {  return cleHMAC; }
       
    }
}
