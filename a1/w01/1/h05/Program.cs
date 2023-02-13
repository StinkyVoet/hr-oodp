Console.WriteLine("What is the month? 1-12");
var month = int.Parse(Console.ReadLine());

Console.WriteLine("What is the day? 1-31");
var day = int.Parse(Console.ReadLine());

var date = new DateTime(DateTime.Now.Year, month: month, day: day);
var season = "";
if(date >= new DateTime(DateTime.Now.Year, month: 3, day: 21) && date < new DateTime(DateTime.Now.Year, month:6, day: 21))
{
    season = "Spring";
} else if (date >= new DateTime(DateTime.Now.Year, month: 6, day: 21) && date < new DateTime(DateTime.Now.Year, month:9, day: 21))
{
    season = "Summer";
} else if (date >= new DateTime(DateTime.Now.Year, month: 9, day: 21) && date < new DateTime(DateTime.Now.Year, month: 12, day: 21))
{
    season = "Autumn";
} else if (date >= new DateTime(DateTime.Now.Year, month: 12, day: 21) || date < new DateTime(DateTime.Now.Year, month: 3, day: 21))
{
    season = "Winter";
}

Console.WriteLine($"On {day}-{month} it is {season}");