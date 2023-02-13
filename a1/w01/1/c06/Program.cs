Console.WriteLine("Give some text");
var text = Console.ReadLine() ?? "";

Console.WriteLine("What do you want to do with this text?");
Console.WriteLine("U: make all uppercase");
Console.WriteLine("L: make all lowercase");
Console.WriteLine("Any other key: do not change");
var choice = Console.ReadLine();

var newText = choice switch
{
    "U" => text.ToUpper(),
    "L" => text.ToLower(),
    _ => text
};

Console.WriteLine(newText);