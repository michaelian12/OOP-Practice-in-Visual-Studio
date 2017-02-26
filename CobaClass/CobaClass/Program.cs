using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // call object
            Persegi psg = new Persegi();
            psg.Sisi = 10;
            Console.WriteLine("Luas persegi " + psg.hitungLuas());
            Console.WriteLine("Keliling persegi " + psg.hitungKeliling() + "\n");

            PersegiPanjang psgpjg = new PersegiPanjang();
            psgpjg.Panjang = 5;
            psgpjg.Lebar = 3;
            Console.WriteLine("Luas persegi panjang " + psgpjg.hitungLuas());
            Console.WriteLine("Keliling persegi panjang " + psgpjg.hitungKeliling() + "\n");

            // inheritance
            Kubus kbs = new Kubus();
            Console.Write("Masukkan sisi kubus: ");
            kbs.Sisi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Luas permukaan kubus: " + kbs.hitungLuasPermukaan());
            Console.WriteLine("Volume kubus: " + kbs.hitungVolume() + "\n");

            Balok blk = new Balok();
            Console.Write("Masukkan panjang balok: ");
            blk.Panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar balok: ");
            blk.Lebar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi balok: ");
            blk.Tinggi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Volume balok: " + blk.hitungVolume());
            Console.WriteLine("Luas permukaan balok: " + blk.hitungLuasPermukaan());

            Console.ReadKey();
        }
    }
}
