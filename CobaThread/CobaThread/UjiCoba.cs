using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CobaThread
{
    class UjiCoba
    {
        // atribute

        // method
        public static void methodSatu()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("Method Satu: {0}", i);
                Thread.Sleep(10);
            }
        }


        public static void methodDua()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("Method Dua: {0}", i);
                Thread.Sleep(10);
            }
        }
    }
}
