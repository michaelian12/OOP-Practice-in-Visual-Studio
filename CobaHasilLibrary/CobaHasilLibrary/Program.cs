using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CobaLibrary;

namespace CobaHasilLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Persegi psg = new Persegi(10);
            Console.WriteLine(psg.hitungLuas());

            Console.ReadKey();
        }
    }
}
