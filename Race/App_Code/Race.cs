using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for Race
/// </summary>
public class Race
{
    Player player1 = new Player ("rocky");
    Player player2 = new Player ("creed");
    Course course = new Course ();
    public StringBuilder sb=new StringBuilder();

	public string start()
    {
        sb.Append ("Course length:");
        sb.Append (course.length);
        while(player1.position < course.length && player2.position < course.length)
        {
            course.CheckPosition (player1);
            course.CheckPosition (player2);
            player1.position++;
            sb.Append ("<br/>position of ");
            sb.Append (player1.name);
            sb.Append (" is ");
            sb.Append (player1.position);
            sb.Append (" and time ");
            sb.Append (player1.time);
            player2.position++;
            sb.Append ("<br/>position of ");
            sb.Append (player2.name);
            sb.Append (" is ");
            sb.Append (player2.position);
            sb.Append (" and time ");
            sb.Append (player2.time);
        }
        CheckResult ();
        return sb.ToString (); ;
    }

    public void CheckResult()
    {
        if(player1.time < player2.time)
        {
            sb.Append ("<br/>Winner is:");
            sb.Append (player1.name);
        }
        else if(player2.time < player1.time)
        {
            sb.Append ("<br/>Winner is:");
            sb.Append (player2.name);
        }
        else
            sb.Append ("<br/>Draw");
    }

}