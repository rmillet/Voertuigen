using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen_Business
{
    public class Auto : Voertuig
    {
        private string _nummerplaat;

        public string Nummerplaat
        {   
            get { return _nummerplaat; }
            set { _nummerplaat = value; }
        }
        public Auto()
        {
            //alle fields (eig) krijgen een waarde
            _nummerplaat = "2AAA000";
            Merk = "****";
            Motor = true;
            AantalWielen = 4;
        }

        public override string getDetails()
        {
            return "Mijn auto heeft als merk " + Merk + " met nummerplaat " + Nummerplaat;
        }        

    }
}
