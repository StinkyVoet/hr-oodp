Console.WriteLine("Enter an age:");
var age = int.Parse(Console.ReadLine() ?? "");
var ageGroup = age switch
{
    >= 0 and <= 12 => "a child",
    >= 13 and <= 19 => "a teenager",
    >= 20 and <= 150 => "an adult",
    _ => "invalid",
};
Console.WriteLine($"Age {age}: {ageGroup}");