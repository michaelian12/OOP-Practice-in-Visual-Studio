using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaComposition
{
    class Baju
    {
        // atribut
        private LinkedList<Kancing> kancing; // Assosiative law
        private string warna;

        public string Warna
        {
            get
            {
                return warna;
            }

            set
            {
                warna = value;
            }
        }

        // method
        public void setKancing(string bentuk, string ukuran)
        {
            Kancing kcg = new Kancing("bulat", "besar");
            kancing = new LinkedList<Kancing>(); // composition

            kancing.AddFirst(kcg);
        }


    }
}
