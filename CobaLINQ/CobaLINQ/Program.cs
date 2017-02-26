using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> nama = new LinkedList<string>();
            nama.AddFirst("Ani");
            nama.AddFirst("Budi");
            nama.AddFirst("Aqila");
            nama.AddFirst("Wijaya");

            // LINQ
            var query = from n in nama
                        where n.StartsWith("A")
                        orderby n descending
                        select n;

            foreach (var q in query)
            {
                Console.WriteLine($"nama: "+ q);
            }

            Console.ReadKey();
        }
    }
}
