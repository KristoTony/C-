using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Course
/// </summary>
public class Course
{
    public Obstacle obstacle { get; set; }
    public int length { get; set; }
    Random rand { get; set; }

	public Course()
	{
        obstacle = new Obstacle ();
        rand=new Random();
        length=rand.Next(50);
	}

    public void CheckPosition(Player player)
    {
        if(obstacle.CheckObstacle (player))
            player.time += 2;
        else
            player.time++;
    }

   
}