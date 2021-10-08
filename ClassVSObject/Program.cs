using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVSObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Belgin";

            Person person1 = person;
            person.Name = "Türkay";

            Console.WriteLine(person.Name);  // çıktı Türkay olur. person1 için new'lemediğimizden stack de referans ataması  değişti.
            Console.ReadLine(); 



        }
    }
}
