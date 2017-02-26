using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaAbstract
{
    abstract class BangunDatar
    {
        // atribute

        // method
        public abstract double hitungKeliling();
        public abstract double hitungLuas();

        public void siapaNamamu()
        {
            Console.WriteLine("Bangun Datar");
        }
    }
}
