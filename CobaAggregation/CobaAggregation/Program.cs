using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Penerbit terbit = new Penerbit("Erlangga","Surabaya");
            Buku buku = new Buku();
            buku.setPenerbit(terbit);
            buku.Pengarang = "Michael Agustian";

            Console.WriteLine(buku.pbt.Pop().Nama);
            Console.ReadKey();

        }
    }
}
