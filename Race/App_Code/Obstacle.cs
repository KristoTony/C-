using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Obstacle
/// </summary>
public class Obstacle
{
    Random rand { get; set; }
    public  int position { get; set; }

	public Obstacle()
	{
        rand = new Random ();      
	}

    public bool CheckObstacle(Player player)
    {
        position = rand.Next (0, 100);
        if(position > 50)
        {
            return true;
        }
        else
            return false;
    }
}