using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    public class Yemek
    {
        public int Sure { get; set; }
        public void Pisir()
        {

        }


        public virtual void SunumYap()
        {
            Console.WriteLine($"{this.GetType().Name} yanında pilav");
        }
    }

    public enum PismeBicimi
    {
        Az, Orta, Cok
    }

    public class EtYemek : Yemek
    {
        public PismeBicimi PismeBicimi { get; set; }


    }
    public class SebzeYemek : Yemek
    {
        public bool ZeytinyagliMi { get; set; }

    }

    public class KofteYemek: EtYemek 
    {

    }

    public class PirasaYemek:Yemek
    {

    }

    public class Tatli : Yemek
    {

    }

    public class Baklava : Tatli
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{this.GetType().Name} yanında dondurma");
        }
    }
}
