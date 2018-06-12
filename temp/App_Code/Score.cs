using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;


/// <summary>
/// Summary description for Score
/// </summary>
public class Score
{

    public static void ScoreDart(Player player,Dart dart)
    {
        int score = 0;
        if(dart.IsTriple) score = dart.score * 3;
        else if(dart.IsDouble) score = dart.score * 2;
        else score = dart.score;

        if(dart.IsTriple && dart.score == 0) score = 50;
        else if(dart.score == 0) score = 25;

        player.Score += score;
    }

}