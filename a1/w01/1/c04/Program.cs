Console.WriteLine("What is your age?");
var age1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("What is the age of the student next to you?");
var age2 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine(age1 < age2 
    ? "You are younger" 
    : age1 > age2 
        ? "You are older" 
        : "Your ages are equal"
);