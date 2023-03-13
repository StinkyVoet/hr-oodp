public class Deck
{
    public readonly List<Card> Cards;
    public readonly bool AreJokersIncluded;

    private static readonly Random Rng = new Random();  

    public Deck(bool areJokersIncluded)
    {
        AreJokersIncluded = areJokersIncluded;
        Cards = new List<Card>();

        var suits = new List<string> { "Diamonds", "Clubs", "Hearts", "Spades" };
        foreach (var suit in suits)
        {
            for (var i = 1; i < 14; i++)
            {
                var name = i switch
                {
                    1 => "Ace",
                    11 => "Jack",
                    12 => "Queen",
                    13 => "King",
                    _ => null
                };
                
                Cards.Add(new Card(suit, name ?? i.ToString()));
            }
        }

        if (AreJokersIncluded)
        {
            Cards.AddRange(new []
            {
                new Card("Joker", "Red"), 
                new Card("Joker", "Black"),
            });
        }
    }

    public void Shuffle()
    {
        var n = Cards.Count;
        while (n > 1) {
            n--;
            var k = Rng.Next(n + 1);
            (Cards[k], Cards[n]) = (Cards[n], Cards[k]);
        }
    }

    public Card? Draw()
    {
        if (Cards.Count == 0) return null;
        
        var card = Cards.Last();
        Cards.RemoveAt(Cards.Count - 1);
        return card;
    }
}