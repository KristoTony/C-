using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

public class Game
{
    private Player player1;
    private Player player2;

    private Random Rand;
    public Game(string player1Name,string player2Name)
    {
        player1 = new Player ();
        player1.Name = player1Name;
        player2 = new Player ();
        player2.Name = player2Name;

        Rand = new Random ();
    }

    public string Play()
    {
        while(player1.Score < 300 && player2.Score < 300)
        {
            playRound (player1);
            playRound (player2);
        }
        return displayResults ();
    }

    private string displayResults()
    {
        string result = string.Format ("{0}:{1}<br/>{2}:{3}<br/>", player1.Name, player1.Score, player2.Name, player2.Score);
        return result += "<br/>Winner:" + (player1.Score > player2.Score ? player1.Name : player2.Name);
    }

    private void playRound(Player player)
    {
        for(int i = 0; i < 3; i++)
        {
            Dart dart = new Dart (Rand);
            dart.Throw ();
            Score.ScoreDart (player, dart);
        }
    }
}