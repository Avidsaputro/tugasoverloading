using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contohoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            numbers number = new numbers();
            Console.WriteLine("Minimum1: {0}", number.findminimum(3,1));
            Console.WriteLine("Minimum2: {0}", number.findminimum(3, 8, 4));
            Console.WriteLine();
            Console.WriteLine("Minimum1: {0}", number.findmaximum(3, 1));
            Console.WriteLine("Minimum2: {0}", number.findmaximum(3, 8, 4));

            Console.ReadKey();
        }
    }
}
