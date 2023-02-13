var correct = false;
for (var i = 3; i > 0; i--)
{
    Console.WriteLine($"Enter your PIN\n{i} attempts left");
    var pin = Console.ReadLine();
    if (pin == "1234")
    {
        correct = true;
    }
}


Console.WriteLine(correct ? "Correct!" : "Your pass is confiscated.");
