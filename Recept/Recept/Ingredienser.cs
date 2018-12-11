using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recept
{
    class Ingredienser
    {
        int mått;
        string vara;
        string måttenhet;

        public int Mått// Få fram exempel mått?
        {
            get { return Mått; }
        }

        public string Vara
        {
            get { return Vara; }
        }
        
        public string Måttenhet
        {
            get { return Måttenhet; }
        }

        public Ingredienser(int m, string v, string ma) //Gör en konstruktor
        {
            m = mått;
            v = vara;
            ma = måttenhet;
        }
    }
}
