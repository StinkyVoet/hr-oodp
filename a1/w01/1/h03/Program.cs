const double discount = 0.1;
const double price = 55;
const double discountPrice = price - price * discount;

var message = $"The discount price is {discountPrice}";
Console.WriteLine(message);