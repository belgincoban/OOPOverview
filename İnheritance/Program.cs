using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Asci asci = new Asci();
            asci.Pisir(new PirasaYemek());
            asci.Pisir(new KofteYemek());

            Baklava baklava = new Baklava();
            baklava.SunumYap();

            Console.ReadLine();
        }
    }
}
