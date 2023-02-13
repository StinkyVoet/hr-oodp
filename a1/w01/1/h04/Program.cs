var points = 0;
Console.WriteLine("Answer the following MCQs:");

Console.WriteLine("Which of the following is NOT a valid type in C#?\nA: bool\nB: int\nC: var\nD: string");
if (Console.ReadLine().ToLower() == "c")
{
    points++;
}

Console.WriteLine("What happens if you execute the following line C#?\nint x = 1.23;\nA: x will be 1.23\nB: x will be 1\nC: x will be 1.0\nD: you will get a compiler error");
if (Console.ReadLine().ToLower() == "d")
{
    points++;
}

Console.WriteLine("Consider the following line:\ndouble d = 1.23;\nWhat are TWO ways to convert variable d to an int?\nA: int i = (int)d;\nB: int i = int(d)\nC: int i = 0 + d\nD: int i = Convert.ToInt32(d)");
Console.WriteLine("Your first answer:");
var correct = 0;
var answer1 = Console.ReadLine().ToLower();
if (answer1 is "d" or "a")
{
    correct++;
}
Console.WriteLine("Your first answer:");
var answer2 = Console.ReadLine().ToLower();
if ((answer2 is "d" or "a") && answer2 != answer1)
{
    correct++;
}

if (correct == 2)
{
    points++;
}

Console.WriteLine($"Your score: {points} out of 3." + (points == 3 ? " Well done!" : null));