using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérek2020
{
    class Dolgozó
    {
        public string Név { get; set; }
        public string Nem { get; set; }
        public string Részleg { get; set; }
        public int BelépésÉve { get; set; }
        public int Bér { get; set; }

        public Dolgozó(string sor)
        {
            string[] s = sor.Split(';');
            Név = s[0];
            Nem = s[1];
            Részleg = s[2];
            BelépésÉve = int.Parse(s[3]);
            Bér = int.Parse(s[4]);
        }
    }
}
