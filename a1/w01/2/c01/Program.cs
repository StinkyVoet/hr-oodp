var money = 4;

while (money > 0)
{
    Console.WriteLine($"Money left: {money}\nLook around (1) or go in a ride (2)?");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("Yay!");
            break;
        case 2:
            money--;
            Console.WriteLine("Wheee!");
            break;
        default:
            continue;
    }
}

Console.WriteLine("Time to go home");