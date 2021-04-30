using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen_Business
{
    abstract public class Voertuig
    {
        private int _aantalWielen;
        private bool _motor;
        private string _merk;

        public Voertuig()
        {
            _aantalWielen = 0;
            _merk = "";
            _motor = true;
        }

        public int AantalWielen
        {
            get { return _aantalWielen; }
            set { _aantalWielen = value; }
        }

        public bool Motor
        {
            get { return _motor;}
            set { _motor = value; }
        }

        public string Merk
        {
            get { return _merk; }
            set { _merk = value; }
        }

        public virtual string getDetails()
        {
            return "Uw voertuig van het merk " + _merk + " heeft " + _aantalWielen.ToString() + " wielen.";
        }
    }

    
}
