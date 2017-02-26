using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaInterface
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
        public double hitungKeliling()
        {
            return 2 * (Panjang + Lebar);
        }

        public double hitungLuas()
        {
            return Panjang * Lebar;
        }
    }
}
