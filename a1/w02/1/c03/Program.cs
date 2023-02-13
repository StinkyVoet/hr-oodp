using System.ComponentModel;

public class Program
{
    public static void Main()
    {
        var firstName = Console.ReadLine() ?? "";
        var lastName = Console.ReadLine() ?? "";
        DisplayName(firstName, lastName);
    }

    public static string Name(string firstName, string lastName) => $"{firstName} {lastName}";
    public static void DisplayName(string firstName, string lastName) => Console.WriteLine(Name(firstName, lastName));
}