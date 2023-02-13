Console.WriteLine("You have one chance to guess this six-letter word:\nLe..th");
const string word = "Length";
var guess = Console.ReadLine()?? "";

if (guess == word)
{
    Console.WriteLine("Correct!");
} else if (guess == word.ToLower())
{
    Console.WriteLine("Kind of correct; the case was just wrong");
} else if (guess.Length != word.Length)
{
    Console.WriteLine("Incorrect! That is not even a six-letter word!");
}
else
{
    Console.WriteLine("Incorrect!");
}