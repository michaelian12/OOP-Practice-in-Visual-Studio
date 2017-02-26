
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaCollection
{
    class Mahasiswa
    {
        // atribute
        private string nim, nama;

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

        public string Nim
        {
            get
            {
                return nim;
            }

            set
            {
                nim = value;
            }
        }
    }
}
