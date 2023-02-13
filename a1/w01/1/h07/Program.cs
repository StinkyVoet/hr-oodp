Console.WriteLine("For each direction, input Y/N if it is valid.");

bool north, east, south, west;

Console.WriteLine("North? Y/N");
north = Console.ReadLine().ToLower() == "y" ? true : false;
Console.WriteLine("East? Y/N");
east = Console.ReadLine().ToLower() == "y" ? true : false;
Console.WriteLine("South? Y/N");
south = Console.ReadLine().ToLower() == "y" ? true : false;
Console.WriteLine("West? Y/N");
west = Console.ReadLine().ToLower() == "y" ? true : false;

Console.WriteLine("Give a bearing (a number) for the direction in which you are going.");

var output = "";
output += north ? "    N\n    |\n" : "";
output += west ? "W---" : "    ";
output += "|";
output += east ? "---E" : "";
output += south ? "\n    |\n    S" : "";

Console.WriteLine($"From here you can go:\n{output}\n");

var bearing = Normalize(int.Parse(Console.ReadLine()));

var direction = bearing switch
{
    > 315 or <= 45 => "north",
    > 45 and <= 135 => "east",
    > 135 and <= 225 => "south",
    > 225 and <= 315 => "west",
};

if (!north && direction == "north")
{
    Console.WriteLine("You can't go north");
    Environment.Exit(0);
} else if (!east && direction == "east") 
{
    Console.WriteLine("You can't go east");
    Environment.Exit(0);
} else if (!south && direction == "south")
{
    Console.WriteLine("You can't go south");
    Environment.Exit(0);
} else if (!west && direction == "west")
{
    Console.WriteLine("You can't go west");
    Environment.Exit(0);
}

Console.WriteLine($"You are going {direction}");

int Normalize(int num)
{
    while (num > 360)
        num -= 360;
    while (num < 0)
        num += 360;
    return num;
}