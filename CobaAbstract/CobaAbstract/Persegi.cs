using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaAbstract
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

        // method
        public override double hitungKeliling()
        {
            return 4 * Sisi;
        }

        public override double hitungLuas()
        {
            return Sisi * Sisi;
        }
    }
}
