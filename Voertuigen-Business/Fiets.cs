using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen_Business
{
    public class Fiets : Voertuig
    {
        private bool _bagagedrager;

        public Fiets()
        {
            _bagagedrager = false;
            AantalWielen = 2;
            Motor = false;
            Merk = "geen merk";
        }

        public bool Bagagedrager
        {
            get { return _bagagedrager; }
            set { _bagagedrager = value; }
        }

        public override string getDetails()
        {
            // return "Uw fiets van het merk " + Merk + "heeft " + AantalWielen.ToString() + " wielen!!!!!";
            if (_bagagedrager == true)
            {
                return base.getDetails() + " en heeft een bagagedrager";
            }
            else
            {
                return base.getDetails() + " en heeft geen bagagedrager";
            }
            
        }

    }
}
