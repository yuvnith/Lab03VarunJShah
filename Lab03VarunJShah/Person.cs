using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03VarunJShah
{
    public class Person
    {
        public Person()
        {
            apartment = new Apartment();
        }
        public string name;
        public Apartment apartment ;
        public void ShowData()
        {
            Console.WriteLine(name);
            Console.WriteLine(apartment.area);
            Console.WriteLine(apartment.door.color);
        }
    }
}
