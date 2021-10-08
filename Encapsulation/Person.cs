using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }  //kurallar yazılabilir.
        }

        public string Name { get; set; }
        public double Salaray { get; private set; }
        private double hourPrice;
        public double HourPrice { 
            get
            {
                return hourPrice;
            } 
            
            set
            {
                hourPrice = value;
                Salaray = hourPrice * 200;
            } }

        //public void SetAge()
        //{
        //    if (age>0)
        //    {
        //        this.age = age;
        //    }
        //    else
        //    {
         //       throw new ArgumentException("yaş 0 dan küçük olamaz.");
          //  }

        //}
    }
}
