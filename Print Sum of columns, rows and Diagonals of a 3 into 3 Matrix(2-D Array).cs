using System;

public class Test
{
    public static void Main()
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
        int temp;
        for (int i = 0; i < 3; ++i)
        {
            temp = ar[i, 0] + ar[i, 1] + ar[i, 2];
            Console.WriteLine("Sum of row {0}: {1}", i + 1, temp);
        }

        for (int i = 0; i < 3; ++i)
        {
            temp = ar[0, i] + ar[1, i] + ar[2, i];
            Console.WriteLine("Sum of Column {0}: {1}", i + 1, temp);
        }

        temp = ar[0, 0] + ar[1, 1] + ar[2, 2];
        Console.WriteLine("Sum of Diagonal : {0}", temp);

        temp = ar[0, 2] + ar[1, 1] + ar[2, 0];
        Console.WriteLine("Sum of Diagonal : {0}", temp);
        Console.ReadKey();


    }
}