using System;
using System.Linq;
using System.Collections.Generic;


public class Phyelements
{
    public static void Main()
    {
       
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "ranju", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Manju",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "sanju",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "viju" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "raaju" , Age = 15 }
            };

        var teenAgerStudent = from s in studentList
                              where s.Age > 12 && s.Age < 20
                              select s;
        Console.WriteLine("Teen age Students:");

        foreach (Student std in teenAgerStudent)
        {
            Console.WriteLine(std.StudentName);
        }
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}