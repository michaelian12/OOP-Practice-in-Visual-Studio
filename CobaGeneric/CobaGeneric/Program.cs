using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // atribute
            GenericClass<Int32> bilangan = new GenericClass<Int32>();
            bilangan.A = 10;
            bilangan.B = 11;
            bilangan.tukarData();

            GenericClass<String> nama = new GenericClass<String>();
            nama.A = "Andi";
            nama.B = "Budi";
            nama.tukarData();

            Console.ReadKey();
        }
    }
}
