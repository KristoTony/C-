using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Game
/// </summary>
public class Game
{
    private Player player1;
    private Player player2;

	
    public Game(string player1Name,string player2Name)
	{
        player1 = new Player () { Name = player1Name };
        player2 = new Player () { Name = player2Name };
        
	}

    public string Play()
    {
        Deck deck = new Deck ();
        string result="<h3>Dealing cards...</h3>";
         result += deck.Deal (player1, player2);
         result += "<h3/>Begin battle...</h3>";
        int round=0;

        while(player1.Cards.Count != 0 && player2.Cards.Count != 0)
        {
            Battle battle = new Battle ();
            result+=battle.PerformBattle (player1, player2);

            round++;
            if(round > 20)
                break;
            
        }
        result += determineWinner ();
        return result;
    }

    

    private string determineWinner()
    {
        string result = "";
        if(player1.Cards.Count > player2.Cards.Count)
            result += "<br/>Player 1 wins";
        else 
            result += "<br/>Player 2 wins";

        result += "<br/>Player 1:" + player1.Cards.Count + "<br/>Player 2:" + player2.Cards.Count;

        return result;
    }

}