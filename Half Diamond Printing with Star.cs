using System;

class DiamondPattern
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the maximum number of *: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < (n - i); j++)
                Console.Write(" ");
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            for (int k = 1; k < i; k++)
                Console.Write("*");
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}
