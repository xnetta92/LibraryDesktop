using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDesktopConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statistics statistics = new Statistics();
            Console.WriteLine("1. feladat: "  );
            statistics.longestBook();
            Console.WriteLine("***** Program vége *****");

            Console.ReadLine();
        }
    }
}
