using System;

public class Company
{

    String name;
    String type;
    int estrength;

    public Company(String name, String type,
                  int estrength)
    {
        this.name = name;
        this.type = type;
        this.estrength = estrength;
    }

    public String getName()
    {
        return name;
    }

    public String gettype()
    {
        return type;
    }

    public int getestrength()
    {
        return estrength;
   
    }

    public String toString()
    {
        return ("Hi my name is " + this.getName()
                + ".\nMy type, estrength  are " + this.gettype()
                + ", " + getestrength());
    }

    public static void Main(String[] args)
    {

        Company Phyelements = new Company("Phyelements", "Software", 20);
        Console.WriteLine(Phyelements.toString());
    }
}