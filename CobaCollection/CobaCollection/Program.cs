using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CobaCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // dynamic array
            ArrayList bil = new ArrayList();
            bil.Add(10);
            bil.Add(11);
            bil.Add(9);
            bil.Sort();

            foreach (Int32 x in bil)
            {
                Console.WriteLine(x);
            }

            // linked list
            LinkedList<String> nama = new LinkedList<String>();
            nama.AddFirst("Andi");
            nama.AddFirst("Budi");
            nama.AddLast("Bayu");
            nama.RemoveLast();

            foreach (String x in nama)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(nama.First.Value);

            LinkedList<Mahasiswa> mhs = new LinkedList<Mahasiswa>();
            Mahasiswa m = new Mahasiswa();
            m.Nim = "10113050";
            m.Nama = "Michael";

            mhs.AddFirst(m);

            // stack
            Stack<Double> pecahan = new Stack<Double>();
            pecahan.Push(10.4);
            pecahan.Push(12.3);
            Console.WriteLine(pecahan.Pop());
            Console.WriteLine(pecahan.Peek());

            // queue
            Queue<String> benda = new Queue<String>();
            benda.Enqueue("Spidol");
            benda.Enqueue("Laptop");
            Console.WriteLine(benda.Dequeue());

            Console.ReadKey();
        }
    }
}
