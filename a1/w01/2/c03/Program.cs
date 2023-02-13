Console.WriteLine("What is the person's name?");
var name = Console.ReadLine();

for (var i = 0; i < 4; i++)
{
    Console.WriteLine(i == 2 ? $"Happy birthday dear {name}!" : "Happy birthday to you!");
}