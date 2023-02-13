Console.WriteLine("What is the amount to pay?");
var toPay = int.Parse(Console.ReadLine());

var paid = 0;
while (toPay > 0)
{
    Console.WriteLine($"{toPay} left to pay");
    Console.WriteLine("Pay how much?\n1: 5\n2: 10\n3: 20\n4: 50");
    var input = Console.ReadLine() switch
    {
        "1" => 5,
        "2" => 10,
        "3" => 20,
        "4" => 50,
        _ => 0,
    };
    toPay -= input;
    paid += input;
    if (toPay < 0)
    {
        Console.WriteLine($"You paid {toPay*-1} too much. Give a tip? y/n");
        var tip = "";
        while (tip is not "y" and not "n")
        {
            tip = Console.ReadLine().ToLower();
        }
        if (tip == "n")
        {
            paid += toPay;
        }
    }
}

Console.WriteLine($"You have paid {paid}");