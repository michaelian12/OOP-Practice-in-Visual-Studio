using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaAggregation
{
    class Penerbit
    {
        //attribut
        string nama;
        string tempat;

        // getter setter
        public string Nama
        {
            get
            {
                return nama;
            }

            set
            {
                nama = value;
            }
        }

        public string Tempat
        {
            get
            {
                return tempat;
            }

            set
            {
                tempat = value;
            }
        }

        // method
        // parametered constructor
        public Penerbit(string nama, string tempat)
        {
            this.nama = nama;
            this.tempat = tempat;
        }
    }
}
