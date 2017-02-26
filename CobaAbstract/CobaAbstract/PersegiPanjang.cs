using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaAbstract
{
    class PersegiPanjang : BangunDatar
    {
        // atribute
        private double panjang, lebar;

        // getter setter
        public double Lebar
        {
            get
            {
                return lebar;
            }

            set
            {
                lebar = value;
            }
        }

        public double Panjang
        {
            get
            {
                return panjang;
            }

            set
            {
                panjang = value;
            }
        }

        // method
        public override double hitungKeliling()
        {
            return 2 * (Panjang + Lebar);
        }

        public override double hitungLuas()
        {
            return Panjang * Lebar;
        }
    }
}
