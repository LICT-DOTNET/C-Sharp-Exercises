using System;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter The Char:");
        char ch = Convert.ToChar(Console.ReadLine().ToLower());
        switch (ch)
        {
            case 'a':
                Console.WriteLine("IT IS A VOWEL");
                break;

            case 'e':
                Console.WriteLine("IT IS A VOWEL");
                break;

            case 'i':
                Console.WriteLine("IT IS A VOWEL");
                break;

            case 'o':
                Console.WriteLine("IT IS A VOWEL");
                break;

            case 'u':
                Console.WriteLine("IT IS A VOWEL");
                break;

            default:
                Console.WriteLine("It is not Vowel");
                break;

        }

        Console.ReadKey();
    }
}

