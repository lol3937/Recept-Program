using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recept
{
    class Receptclass
    {
        string beskrivning;

        List<string> Beskrivningar = new List<string>();

        string namn;

        List<Ingredienser> Ingredienslista = new List<Ingredienser>();


        public Receptclass(string n, List<string> b, List<Ingredienser> i)
        {
            namn = n;
            Beskrivningar = b;
            Ingredienslista = i;
        }
    }
}
