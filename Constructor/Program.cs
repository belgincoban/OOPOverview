using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekmek ekmek = new Ekmek();
            Ekmek e3 = new Ekmek();

            Ekmek ekmek1 = new Ekmek(3,"kepekli");


            Console.ReadLine();
        }
        
    }
}
