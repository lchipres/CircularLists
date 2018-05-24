using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLists
{
    class Base
    {
        public string name;
        public Int32 minutes;
        public Base next;
        

        public Base()
        {

        }

        public Base(Base b)
        {
            name = b.name;
            next = null;
        }

        public Base(string name,Int32 minutes)
        {
            this.name = name;
            this.minutes = minutes;
        }

        public override string ToString()
        {
            return "Nombre: "+name+" Minutos: "+minutes;
        }
    }
}
