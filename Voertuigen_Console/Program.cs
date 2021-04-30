using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voertuigen_Business;

namespace Voertuigen_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Fiets _velo = new Fiets();
            Auto _wagen = new Auto();
            //Voertuig _kar = new Voertuig();

            Console.WriteLine("geef uw merk in van uw auto");
            string merk = Console.ReadLine();

            _wagen.Merk = merk;

            _velo.Bagagedrager = true;
            //_kar.Merk = "Appel";
            
            _wagen.Nummerplaat = "1ABC007";

            Console.WriteLine(_velo.getDetails());
            Console.WriteLine(_wagen.getDetails());
            //Console.WriteLine(_kar.getDetails());

            Console.ReadKey();
        }
    }
}
