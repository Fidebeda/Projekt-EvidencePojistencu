using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clovek
    {

        public string Jmeno { get; private set; }
        public int Unava { get; private  set; }

        public int Vek { get; private set; }


        public Clovek(string jmeno, int vek)
        {
            Jmeno = jmeno;
            Unava = 0;
            Vek = vek;
        }

        public void Beh(int vzdalenost)
        {

            Unava += vzdalenost;
            
            if(Unava > 20)
            {
                Console.WriteLine("nemůžu");
                Unava -= vzdalenost;
            }
            else
            {
                Unava = Unava;
            }
        }

        public void Spanek(int doba)
        {

            Unava -= 10 * doba;
            int newUnava;
            
            if(Unava < 0)
            {
                Console.WriteLine("nemůžu dál spát");
                newUnava = Unava;
                
                
                
                Unava = 0;


                Console.WriteLine("spal jsem jen" + (doba * 10) / -(newUnava) + " procent spánku");
            }
            else
            {
                Unava = Unava;
            }
            
        }

    }
}
