using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaLibrary
{
    public class Persegi
    {
        // attributes
        private double sisi;

        // Getter Setter
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
        public Persegi(double sisi)
        {
            this.sisi = sisi;
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
