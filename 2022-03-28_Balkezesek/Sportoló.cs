using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_28_Balkezesek
{
    class Sportoló
    {
        public string név { get; set; }
        public string első { get; set; }
        public string utolsó { get; set; }
        public int súly { get; set; }
        public int magasság { get; set; }


        public Sportoló(string sor )
        {
            string[] t = sor.Split(';');
            név = t[0];
            első = t[1];
            utolsó = t[2];
            súly = int.Parse(t[3]);
            magasság = int.Parse(t[4]);
        }
    }
}
