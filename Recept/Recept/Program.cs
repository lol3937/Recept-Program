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


            //Skapar en readline
            StreamReader sr = new StreamReader("Recept.txt");
            List<string> receptRader = new List<string>();
            string rad = "";

            while ((rad = sr.ReadLine()) != null)
            {
                receptRader.Add(rad);
            }

            sr.Close();

            List<Receptclass> R = new List<Receptclass>();//läser in receptclass
            List<Ingredienser> I = new List<Ingredienser>();
            List<string> B = new List<string>();


            return "";

        }


        public Receptclass SkrivaRecept()
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

            string StopMått = "no";//När mått inte ska skrivas ut mera

            if (Console.ReadLine(StopMått) == "no")
            {
                
            }
            

            Console.WriteLine("Skriv in måttenhet");
            måttenhet = Console.ReadLine();

            while (true)//Skapar en loop, om man är nöjd med sitt mått så fortsätter inte loopen
            {
                Console.WriteLine("vill du ändra måttenhet?");
                if(Console.ReadLine() == "Nej")
                {
                    break;
                }
                
            }

            StreamWriter sw = new StreamWriter("Recept.txt", true);
            sw.WriteLine("f");
            sw.Close();

            Receptclass temp = new Receptclass(namn, Beskrivningar, Ingredienslista);
            return temp;


        }
    }

}
