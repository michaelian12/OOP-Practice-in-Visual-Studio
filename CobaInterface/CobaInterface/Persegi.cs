using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaInterface
{
    class Persegi : BangunDatar
    {
        // atribute
        private double sisi;

        // getter setter
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

        //method
        public double hitungKeliling()
        {
            return 4 * Sisi;
        }

        public double hitungLuas()
        {
            return Sisi * Sisi;
        }
    }
}
