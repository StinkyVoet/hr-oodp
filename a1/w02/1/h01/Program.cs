class Program
{
    public static void Main()
    {
        PrintIsLeapYear(1000);
    }

    public static bool IsDivisibleBy(int num1, int num2) => num1 % num2 == 0;
    public static bool IsLeapYear(int year)
    {
        if (IsDivisibleBy(year, 4) && !IsDivisibleBy(year, 100)) return true;
        return IsDivisibleBy(year, 400);
    }
    public static void PrintIsLeapYear(int year)
    {
        var leapYearString = IsLeapYear(year) ? "": "not ";
        Console.WriteLine($"{year} is {leapYearString}a leap year");
    }
}