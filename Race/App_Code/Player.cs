using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

/// <summary>
/// Summary description for Player
/// </summary>
public class Player
{
    public string name { get; set; }
    public int position{get;set;}
    public int time { get; set; }


	public Player(string player)
	{
        name = player;
        position = 0;
        time = 0;
	}


}