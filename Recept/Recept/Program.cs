using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Recept
{
    class Program
    {
        static List<Receptclass> Steve;

        static void Main(string[] args)
        {
            Steve = new List<Receptclass>();

            Steve.Add(new Receptclass("joel", new List<string>(), new List<Ingredienser>()));
        }

        public string LäsaRecept()
        {
            foreach(Receptclass i in Steve) { }

            return "";
        }


        public string SkrivaRecept()
        {
            int mått;
            string vara;
            string måttenhet;
            string beskrivning;

            List<string> Beskrivningar = new List<string>();

            string namn;

            List<Ingredienser> Ingredienslista = new List<Ingredienser>();

            Console.WriteLine("Skriv receptnamnet");
            namn = Console.ReadLine();
            Console.WriteLine("Skriv in mått");
            mått = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in mått");
            måttenhet = Console.ReadLine();

            return "";
        }
    }

}
