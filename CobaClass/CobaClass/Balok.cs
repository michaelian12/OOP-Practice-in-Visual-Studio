using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaClass
{
    class Balok:PersegiPanjang //extends
    {
        //attribute
        private double tinggi;


        //method
        public Balok()
        {
            tinggi = 0;
            Console.WriteLine("Objek balok sudah dibuat");
        }

        public double Tinggi
        {
            get
            {
                return tinggi;
            }

            set
            {
                tinggi = value;
            }
        }

        public double hitungLuasPermukaan()
        {
            return (2 * hitungLuas())+(2*panjang*tinggi)+(2*lebar*tinggi);
        }

        public double hitungVolume()
        {
            return hitungLuas() * tinggi;
        }

        public void siapaNamamu()
        {
            Console.WriteLine("Balok");
        }
    }
}
