using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab03VarunJShah
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment mySmallApartment = new SmallApartment();
            mySmallApartment.area = 210;
            mySmallApartment.door.color = "red";
            Person myPerson = new Person();
            myPerson.name = "A4li";
            myPerson.apartment = mySmallApartment;
            try
            {
                ValidatePerson(myPerson);
                myPerson.ShowData();
            }
            catch(InvalidPersonNameException ex)
            {
                
            }
            Console.Read();
        }
        private static void ValidatePerson(Person p)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(p.name))
            {
                throw new InvalidPersonNameException(p.name);
            }
     
               
        }

    }
}
