using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Ekmek
    {
        public string Tur { get; set; }
        public int Adet { get; set; }

        public Ekmek():this(1,"Beyaz ekmek")
        {
        }
        public Ekmek(int adet):this(adet,"beyaz ekmek")
        {
        }

        public Ekmek(string tur):this(1, tur)
        {
        }
        public Ekmek(int adet, string tur)
        {
            Adet = adet;
            Tur = tur;
        }
    }
}
