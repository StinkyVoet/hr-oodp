var balance = double.Parse(Console.ReadLine() ?? "");
var interest = int.Parse(Console.ReadLine() ?? "");
// var interestPercentage = (double)interest / 100;
var years = int.Parse(Console.ReadLine() ?? "");
double taxes = 0;

for (var i = 0; i < years; i++)
{
    NextYear(balance);
}

Console.WriteLine($"Balance after {years} years: {(int)balance}\nAmount of taxes paid: {(int)taxes}");

void NextYear(double oldBalance)
{
    double newTaxes = 0;
    var newBalance = oldBalance + oldBalance * interest / 100;

    switch (oldBalance)
    {
        case <= 50_000:
            break;
        case > 50_000 and <= 100_000:
            newTaxes = (newBalance - 50_000) * 0.015;
            newBalance -= newTaxes;
            break;
        case > 100_000:
            newTaxes = (newBalance - 100_000) * 0.03 + 50_000 * 0.015;
            newBalance -= newTaxes;
            break;
    }

    balance = newBalance;
    taxes += newTaxes;
}