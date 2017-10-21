using System;



public abstract class Employee
{
    public abstract void getEmp();
    public abstract void setEmp1();
}



public class ContratualEmp : Employee
{

    public override void getEmp()
    {
        Console.WriteLine("This show getEmp method");
    }

    public override void setEmp1()
    {
        Console.WriteLine("This show getEmp1 method");
    }

    public void showContratualEmp()
    {
        Console.WriteLine("This show cont method");
    }

}


class Program
{
    static void Main(string[] args)
    {
        ContratualEmp obj = new ContratualEmp();
        obj.showContratualEmp();
        obj.getEmp();
        obj.setEmp1();
        Console.ReadKey();
    }
}

