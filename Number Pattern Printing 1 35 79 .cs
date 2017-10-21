using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0, now = 1, cc = 0;
            Console.WriteLine("1");
            for (int i = 3; i < 56; i = i + 2)
            {
                if (first == 0)
                {
                    Console.Write("{0}{1}", i, i + 2);
                    i = i + 2;
                    first = 1;
                }
                else Console.Write(" {0}", i);
                ++cc;
                if (now == cc)
                {
                    now++;
                    cc = 0;
                    first = 0;
                    Console.WriteLine();
                }

            }
            Console.ReadKey();
        }
    }
}



