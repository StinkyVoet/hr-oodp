Console.WriteLine("How many seconds?");
var seconds = int.Parse(Console.ReadLine() ?? "");
var time = TimeSpan.FromSeconds(seconds);
Console.WriteLine("Hours: {0}\nMinutes: {1}\nSeconds left: {2}", time.Hours, time.Minutes, time.Seconds);