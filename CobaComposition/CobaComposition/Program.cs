using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Baju bj = new Baju(); // kancing object automatically created
            bj.setKancing("Bulat", "Besar");
            bj.Warna = "Hitam";
        }
    }
}
