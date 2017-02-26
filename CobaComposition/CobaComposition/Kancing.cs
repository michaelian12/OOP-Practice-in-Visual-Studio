using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaComposition
{
    class Kancing
    {
        // atribut
        private string bentuk;
        private string ukuran;

        // getter setter
        public string Bentuk
        {
            get
            {
                return bentuk;
            }

            set
            {
                bentuk = value;
            }
        }

        public string Ukuran
        {
            get
            {
                return ukuran;
            }

            set
            {
                ukuran = value;
            }
        }

        // method
        // parametered constructor
        public Kancing(string bentuk, string ukuran)
        {
            this.bentuk = bentuk;
            this.Ukuran = ukuran;
        }
    }
}
