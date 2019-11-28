using System;
public class Employee
{
    int id;  
    String name;
    String work;
    String companyname;

    public static void Main(string[] args)
    {
        Employee e1 = new Employee();   
        e1.id = 77;
        e1.name = "Sanjay Gowda";
        e1.work = "Engineer";
        e1.companyname = "PhyElements";
        Console.WriteLine(e1.id);
        Console.WriteLine(e1.name);
        Console.WriteLine(e1.companyname);
        Console.WriteLine(e1.work);

    }
}