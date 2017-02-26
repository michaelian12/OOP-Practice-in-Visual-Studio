using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaGeneric
{
    class GenericClass <E>
    {
        // atribute
        private E a, b, c;

        // getter setter
        public E A
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

        public E B
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

        public E C
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
