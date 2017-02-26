using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CobaThread
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize thread
            Thread th1 = new Thread(new ThreadStart(UjiCoba.methodSatu));
            Thread th2 = new Thread(new ThreadStart(UjiCoba.methodDua));

            // Set priority
            th1.Priority = ThreadPriority.Highest;
            th2.Priority = ThreadPriority.Lowest;

            // Run thread
            th1.Start();
            th2.Start();

            Console.ReadKey();
        }
    }
}
