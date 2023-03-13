public static class PersonalInformation
{
    public static void PrintName(string s)
    {
        Console.WriteLine(s);
    }

    public static void PrintName(string s1, string s2)
    {
        Console.WriteLine($"{s1} {s2}");
    }

    public static void PrintName(char c, string s)
    {
        Console.WriteLine($"{c}. {s}");
    }

    public static int IncreaseSalary(int i) => i + 100;

    public static double IncreaseSalary(int i, double d) => i + i * d;
}