var num1 = int.Parse(Console.ReadLine());
var num2 = int.Parse(Console.ReadLine());

for (var i = num1; i <= num2; i++)
{
    var output = "";
    if (i % 3 == 0)
        output += "Fizz";
    if (i % 5 == 0)
        output += "Buzz";
    if (output != "")
        Console.WriteLine(output);
    else
        Console.WriteLine(i);
}