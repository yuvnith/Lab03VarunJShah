using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03VarunJShah
{
    public class InvalidPersonNameException : Exception
    {        
        public InvalidPersonNameException()
        {
            Console.WriteLine("invalid name");
        }
        public InvalidPersonNameException(string errorMessage)
        {
            Console.WriteLine(errorMessage+" is an invalid name");
        }
    }
}
