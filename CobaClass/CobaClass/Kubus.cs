using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaClass
{
    class Kubus:Persegi // extends
    {
        public Kubus() // constructor
        {
            Console.WriteLine("Objek kubus sudah dibuat");
        }
        public double hitungLuasPermukaan()
        {
            return 6 * hitungLuas();
        }

        public double hitungVolume()
        {
            return Sisi * Sisi * Sisi;
        }
    }
}
