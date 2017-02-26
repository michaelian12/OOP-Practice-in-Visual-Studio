using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilangan bil = new Bilangan();

            bil.A = 10;
            bil.B = 11;
            bil.tukarData();
            
            bil.A = "Andi";
            bil.B = "Budi";
            bil.tukarData();

            Console.ReadKey();
        }
    }
}
