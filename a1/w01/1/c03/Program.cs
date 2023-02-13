Console.WriteLine("What is the temperature in Celsius?");
var celcius = double.Parse(Console.ReadLine() ?? "");
var fahrenheit = celcius * 1.8 + 32;

Console.WriteLine($"{celcius} C = {fahrenheit} F");
Console.WriteLine($"Rounded down that is {Math.Floor(fahrenheit)} F");