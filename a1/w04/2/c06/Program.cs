class Program
{
    public static void Main()
    {
        Deck deck = new(true);
        deck.Shuffle();
        foreach (var card in deck.Cards)
        {
            Console.WriteLine(card.GetName());
        }

        // Console.WriteLine(new Card("Spades", "Ace").GetName());
    }
}