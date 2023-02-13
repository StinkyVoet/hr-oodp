var color1 = "";
var num1 = 0;

while (color1 != "red" && color1 != "blue" && color1 != "green" && color1 != "yellow") {
    Console.WriteLine("Pick a color (red/blue/green/yellow):");
    color1 = Console.ReadLine().ToLower();
}

while (num1 is < 1 or > 8) {
    Console.WriteLine("Pick a number (1-8):");
    num1 = int.Parse(Console.ReadLine());
}

var fortuneNumber = (color1.Length + num1) % 4 + 1;