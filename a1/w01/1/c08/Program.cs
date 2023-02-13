var x = 0;
var y = 0;

Console.WriteLine("What direction would you like to go?\nUp\nDown\nRight\nLeft");
var direction = Console.ReadLine() ?? "";

switch (direction.ToLower())
{
    case "up":
        y++;
        break;
    case "down":
        y--;
        break;
    case "right":
        x++;
        break;
    case "left":
        x--;
        break;
    default:
        Console.WriteLine("Invalid direction");
        break;
}

Console.WriteLine($"Current position\nX:{x}, Y:{y}");
