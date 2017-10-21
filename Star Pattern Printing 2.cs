using System;
class pattern2
{
public static void Main(string[] args)
    {
        int i, j,k = 1;
 
        for (i = 1; i <= 4; i++)
        {
            for (j = 1; j <= i; j++)
                Console.Write("{0} ", k++);
            Console.Write("\n");
            
        }
        Console.ReadKey();
}
}