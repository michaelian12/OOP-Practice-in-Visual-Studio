using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaClass
{
    class Persegi
    {
        // atributes
        private double sisi;

        // encapsulate
        public double Sisi
        {
            get
            {
                return sisi;
            }

            set
            {
                sisi = value;
            }
        }
        
        // methods
        public Persegi() // constructor
        {
            sisi = 0;
            Console.WriteLine("Objek persegi sudah dibuat");
        }

        public double hitungKeliling()
        {
            return 4 * sisi;
        }

        public double hitungLuas()
        {
            return sisi * sisi;
        }
    }
}
