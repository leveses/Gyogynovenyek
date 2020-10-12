using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyogynovenyek
{
    class Noveny
    {
        public string Nev { get; private set; }
        
        public string Resz { get; private set; }
        
        public int Kezd { get; private set; }
        
        public int Veg { get; private set; }
        
        public int Idotartam { get; private set; }
        

        public Noveny(string n)
        {
            string[] sor = n.Split(';');
            Nev = sor[0];
            Resz = sor[1];
            Kezd = int.Parse(sor[2]);
            Veg = int.Parse(sor[3]);
            if (Veg > Kezd)
            {
                Idotartam = Veg - Kezd + 1;
            }
            else
            {
                Idotartam = 12 - Kezd + Veg + 1;
            }
            
        }
    }
}
