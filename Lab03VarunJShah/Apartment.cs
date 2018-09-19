using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03VarunJShah
{
    public class Apartment
    {
        public Apartment()
        {
            door = new Door();
        }
        public float area;
        public Door door;
        public virtual void ShowData()
        {

        }
    }
}
