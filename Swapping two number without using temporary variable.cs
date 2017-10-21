using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[10000];
            bool cnt = false;
            string[] tokens;

            int n;
            Console.WriteLine("Enter how meany number you want to enter: ");
            n = int.Parse(Console.ReadLine());

            tokens = Console.ReadLine().Split();

            for (int i = 0; i < n; ++i)
            {
                ar[i] = int.Parse(tokens[i]);
            }

            for (int i = 0; i < n; ++i)
            {
                if (is_prime(ar[i]) == true)
                {
                    Console.Write(ar[i] + "");
                    cnt = true;
                }
            }
            if (cnt == false)
            {
                Console.WriteLine("There is no prime number in the input.");
            }
            Console.ReadKey();
        }


        public static bool is_prime(int num)
        {
            if (num == 1) return false;
            int temp = num / 2;
            for (int i = 2; i <= temp; ++i)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

    }




