﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for Battle
/// </summary>
public class Battle
{
    private List<Card> bounty;
    private StringBuilder sb;

	public Battle()
	{
        bounty = new List<Card> ();
        sb = new StringBuilder ();
	}

    private Card getCard(Player player)
    {
        Card card = player.Cards.ElementAt (0);
        player.Cards.Remove (card);
        bounty.Add (card);
        return card;
    }

    private void performEvaluvation(Player player1, Player player2, Card card1, Card card2)
    {
        displayBattleCards (card1, card2);
        if(card1.CardValue () == card2.CardValue ())
            war (player1, player2);
        if(card1.CardValue () > card2.CardValue ())
            awardWinner (player1);
        else
            awardWinner (player2);
    }
    
    public string PerformBattle(Player player1,Player player2)
    {
        Card player1Card = getCard (player1);
        Card player2Card = getCard (player2);
        performEvaluvation (player1, player2, player1Card, player2Card);
        return sb.ToString ();
    }

    private void war(Player player1,Player player2)
    {
        sb.Append ("<br/>************WAR*********<br/>");
        getCard (player1);
        Card warCard1 = getCard (player1);
        getCard (player1);

        getCard (player2);
        Card warCard2 = getCard (player2);
        getCard (player2);

        performEvaluvation (player1, player2, warCard1, warCard2);

    }

    private void displayBattleCards(Card card1,Card card2)
    {
        sb.Append ("<br/>Battle Cards: ");
        sb.Append (card1.Kind);
        sb.Append (" of ");
        sb.Append (card1.Suit);
        sb.Append (" versus ");
        sb.Append (card2.Kind);
        sb.Append (" of ");
        sb.Append (card2.Suit);
    }

    private void displayBountyCards()
    {
        sb.Append ("<br/> Bounty...");
        foreach(var card in bounty)
        {
            sb.Append ("<br/> &nbsp;&nbsp;&nbsp;");
            sb.Append (card.Kind);
            sb.Append ("of");
            sb.Append (card.Suit);
        }
    }

    private void awardWinner(Player player)
    {
        if(bounty.Count == 0) return;
        displayBountyCards ();
        player.Cards.AddRange (bounty);
        bounty.Clear ();

        sb.Append ("<br/><strong>");
        sb.Append (player.Name);
        sb.Append ("wins!</strong><br/>");

    }


}