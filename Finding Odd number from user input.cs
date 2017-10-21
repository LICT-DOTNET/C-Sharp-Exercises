using System;

    class Program
    {
        static void Main()
        {
            int i = 0;
            
            int[] arr = new int[5];

            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

           
            Console.WriteLine("List of odd  numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
