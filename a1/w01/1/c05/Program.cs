Console.WriteLine("What is the temperature of the water? (Celsius)");
var temp = double.Parse(Console.ReadLine() ?? "");
var state = temp <= 0 ? "solid" : temp >= 100 ? "gas" : "liquid";

Console.WriteLine($"At {temp} degrees Celsius, the water will be {state}");