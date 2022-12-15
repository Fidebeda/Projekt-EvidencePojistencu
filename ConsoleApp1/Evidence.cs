using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Evidence
    {

        public List<Pojistenec> Pojistenci = new List<Pojistenec>();

        /// <summary>
        /// Metoda přidání pojištěnce do listu
        /// </summary>
        /// <param name="pojistenec"></param>
        public void PridejPojistence(Pojistenec pojistenec)
        {
            Pojistenci.Add(pojistenec); 
        }

        /// <summary>
        /// Metoda vyhledání pojištěnce v listu podle parametrů
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        public void Vyhledat(string jmeno, string prijmeni)
        {
            foreach (var item in Pojistenci)
            {
                if(item.Jmeno == jmeno && item.Prijmeni == prijmeni)
                {
                    Console.WriteLine(item);
                }
                
            }
        }

        /// <summary>
        /// Metoda na výpis pojištěnců
        /// </summary>
        public void Vypis()
        {
            foreach (var item in Pojistenci)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}
