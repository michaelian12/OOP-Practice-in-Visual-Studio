using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaObject
{
    class Bilangan
    {
        // atribute
        private Object a, b, c;

        // getter setter
        public object A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public object B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        public object C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        // method
        public void tukarData()
        {
            c = a;
            a = b;
            b = c;
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
        }
    }
}
