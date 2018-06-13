using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for Deck
/// </summary>
public class Deck
{
    private List<Card> deck;
    private Random random;
    private StringBuilder sb;

	public Deck()
	{
        random = new Random ();
        deck = new List<Card> ();
        sb = new StringBuilder ();
        string[] suits = new string[] { "Clubs", "Spades", "Diamonds", "Hearts" };
        string[] kinds = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        foreach(var suit in suits)
        {
            foreach(var kind in kinds)
            {
                deck.Add (new Card { Suit = suit, Kind = kind });

            }
        }
	}

    public string Deal(Player player1,Player player2)
    {
        while(deck.Count > 0)
        {
            dealCard (player1);
            dealCard (player2);
        }

        return sb.ToString ();
    }

    private void dealCard(Player player)
    {
        Card card = deck.ElementAt (random.Next (deck.Count));
        player.Cards.Add (card);
        deck.Remove (card);

        sb.Append ("<br/>");
        sb.Append (player.Name);
        sb.Append ("is dealt the");
        sb.Append (card.Kind);
        sb.Append ("of");
        sb.Append (card.Suit);

    }
}