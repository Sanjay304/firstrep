using System;
using System.Collections.Generic;

public class ListCollection
{
    public static void Main(string[] args)
    {  
        var names = new List<string>() { "Rajesh", "Spoorthi", "Harsha", "Sanjay","Sathis","Guru","Sachin", };

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}