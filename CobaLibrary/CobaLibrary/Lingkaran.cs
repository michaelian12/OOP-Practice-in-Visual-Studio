using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaLibrary
{
    class Lingkaran
    {
        // attributes
        private double jari;

        // Getter Setter
        public double Jari
        {
            get
            {
                return jari;
            }

            set
            {
                jari = value;
            }
        }

        // methods
        public Lingkaran(double jari)
        {
            this.jari = jari;
        }

        public double hitungKeliling()
        {
            return 2 * 3.14 * jari;
        }

        public double hitungLuas()
        {
            return 3.14 * jari * jari;
        }
    }
}
