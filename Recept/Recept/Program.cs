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
        static List<Receptclass> receptLista;
        List<List>(string) SaveRecept;

        static void Main(string[] args)
        {
            receptLista = new List<Receptclass>();

            receptLista.Add(new Receptclass("joel", new List<string>(), new List<Ingredienser>()));

            SkrivaRecept();
        }

        public static string LäsaRecept()
        {
            foreach(Receptclass i in receptLista) { }


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


        public static Receptclass SkrivaRecept()//med static så kan jag använda metoden
        {
            int mått;
            string vara;
            string måttenhet;
            string beskrivning;

            List<string> Beskrivningar = new List<string>();

            string namn;

            List<Ingredienser> Ingredienslista = new List<Ingredienser>();

            while(true){
                Console.WriteLine("Skriv receptnamnet");
                namn = Console.ReadLine();

                Console.WriteLine("Skriv in antal mått");
                mått = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in måttenhet");
                måttenhet = Console.ReadLine();
                Console.WriteLine("Vill du skriva mer?");

                string stopMått;

                stopMått = Console.ReadLine();

                if (stopMått == "no")
                {
                    break;
                }
            }

            while (true)//Skapar en loop, om man är nöjd med sitt mått så fortsätter inte loopen
            {
                Console.WriteLine("vill du ändra måttenhet?");

                string stoppme;

                stoppme = Console.ReadLine();
                if(stoppme == "Nej")
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
