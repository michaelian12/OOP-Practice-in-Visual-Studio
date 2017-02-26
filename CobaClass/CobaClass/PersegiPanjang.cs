using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaClass
{
    class PersegiPanjang
    {
        //atribute
        protected double panjang;
        protected double lebar;

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

        //method
        public PersegiPanjang()
        {
            panjang = 0;
            lebar = 0;
            Console.WriteLine("Objek persegi panjang sudah dibuat");
        }

        public double hitungLuas()
        {
            return panjang*lebar;
        }

        public double hitungKeliling()
        {
            return (2 * panjang) + (2*lebar);
        }

        public void siapaNamamu()
        {
            Console.WriteLine("Persegi panjang");
        }
    }
}
