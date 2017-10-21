using System;

class ExceptionDemo
{

    public static void Main()
    {
        int[] table = new int[5] { 6, 7, 8, 11, 12 };
        int idx = 5;

        M(table, idx);
    }

    public static void M(int[] table, int idx)
    {
        try
        {
            Console.WriteLine("Accessing element {0}: {1}",
                               idx, table[idx]);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("A null reference exception");
            throw;     
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Divide by zero");
            throw;                   
        }

    }
}