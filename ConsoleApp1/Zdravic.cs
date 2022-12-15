using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Zdravic
    {

        public string text;

        public string Pozdrav(string jmeno)
        {
            return String.Format("{0} dfas {1}", text, jmeno);
        }
        

        
    }
}
