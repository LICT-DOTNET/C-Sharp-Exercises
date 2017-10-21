using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ar = new int[3, 3];
            string[] tokens;

            for (int i = 0; i < 3; ++i)
            {
                tokens = Console.ReadLine().Split();
                ar[i, 0] = int.Parse(tokens[0]);
                ar[i, 1] = int.Parse(tokens[1]);
                ar[i, 2] = int.Parse(tokens[2]);
            }
            Console.WriteLine(ar[0, 0]);
            Console.WriteLine("  " + ar[1, 1]);
            Console.WriteLine("    " + ar[2, 2]);
            Console.ReadKey();
        }
    }
}



