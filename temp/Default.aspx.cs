using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Game game = new Game ("player 1", "player 2");
        string result = game.Play ();
        Result.Text = result;
    }
}