using System;
public class Program
{
    public string Name { get; set; } = string.Empty;    
    public string Description { get; set; } = string.Empty;

    public void Main(string[] args)
    {
        checkAge(8);
        AddTwoNumber(12, 50);

    }

    public void checkAge(int age)
    {
        if (age < 18)
        {
            Console.WriteLine("Access denied - You must be at least 18 years old.");
        }
        else
        {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }

    public void AddTwoNumber(int i, int j)
    {
        var result = i + j; 
        Console.WriteLine(result);
    }

}