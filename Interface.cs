using System;
interface ICustomer1
{
    void print1();
}
interface ICustomer2
{
    void print2();
}
class Customer:ICustomer2, ICustomer1
{
    public void print1()
    {
        Console.WriteLine("I am a print1 method");
    }
     public void print2()
    {
        Console.WriteLine("I am a print2 method");
    }
}
class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.print1();
            obj.print2();
            Console.ReadKey();

        }
    }

