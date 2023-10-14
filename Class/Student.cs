using System.Security.Cryptography.X509Certificates;

public class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public int Point;
    public bool IsGraduated;
    public Student(string name, string surname, string group, int point, bool isGraduated)
    {
        Name = name;
        Surname = surname;
        Group = group;
        Point = point;
        IsGraduated = isGraduated;
    }
    public void ShowFullName()
    {
        Console.WriteLine($"FullName = {Name} {Surname}");
    }
    public void ShowFullInfo()
    {
        Console.WriteLine($"Name = {Name} Surname = {Surname} Group = {Group} Point = {Point} IsGraduated = {IsGraduated}");

        if (IsGraduated == true)
        {
            Console.WriteLine("Telebe artiq mezun olub.");
        }
        else {
            Console.WriteLine("Telebe hele mezun olmayib.");
        }
    }

    public void SecondChance()
    {
        if (Point>80 && Point<100)
        {
            Console.WriteLine("2-ci sans imtahaninda istirak ucun haqq qazanmisiniz.");
        }
        else if(Point<80)
        {
            Console.WriteLine("2-ci sans imtahaninda istirak haqqini itirdiniz.");
        }
        else
        {
            Console.WriteLine("Siz ilk imtahanda maksimum netice gostermisiniz.");
        }
    }
}