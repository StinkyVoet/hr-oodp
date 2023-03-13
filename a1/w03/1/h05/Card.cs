public class Card
{
    public readonly string Suit, Rank;

    public Card(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public string GetName() => Suit == "Joker" ? $"{Rank} {Suit}" : $"{Rank} of {Suit}";
}