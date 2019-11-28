using System;
using System.Collections.Generic;

public class Phyelements
{
    public static void Main()
    {
        IList<int> intList = new List<int>() { 10, 20, 30, 40 };


        Console.WriteLine(intList.Count);

        IList<Employee> EmployeeList = new List<Employee>() {
                new Employee(){ EmployeeID=2, EmployeeName="Rajesh"},
                new Employee(){ EmployeeID=4, EmployeeName="Spoorthi"},
                new Employee(){ EmployeeID=6, EmployeeName="Harsha"},
                new Employee(){ EmployeeID=8, EmployeeName="Sanjay"}
            };

        Console.WriteLine(EmployeeList.Count);

    }
}

public class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }

}