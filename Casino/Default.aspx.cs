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
        if(!IsPostBack)
        {
            
                double money = new double ();
                money = 100.00;
                ViewState.Add ("money", money);
                Label1.Text = ViewState["money"].ToString ();
                Image1.ImageUrl = "~/Images/" + GetImage () + ".png";//Gets the random image
                Image2.ImageUrl = "~/Images/" + GetImage () + ".png";
                Image3.ImageUrl = "~/Images/" + GetImage () + ".png";
            
        }
    }


    Random rand = new Random (); 
    private string GetImage()
    {
        string[] images = new string[] { "Strawberry", "Bar", "Lemon", "Bell", "Clover", "Cherry", "Diamond", "Orange", "Seven", "HorseShoe", "Plum", "Watermelon" };
        return images[rand.Next (11)];
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        Image1.ImageUrl = "~/Images/" + GetImage () + ".png";
        Image2.ImageUrl = "~/Images/" + GetImage () + ".png";
        Image3.ImageUrl = "~/Images/" + GetImage () + ".png";
        string[] reel = new string[] { Image1.ImageUrl, Image2.ImageUrl, Image3.ImageUrl };
        int money = int.Parse(ViewState["money"].ToString());
        if(money > 0) Evaluvate (reel);//Calculation
        else
        {
            Label1.Text = "you lost refresh the app";
        }
        
     
    }

    private void Evaluvate(string[] reel)
    {
        int multiplier;
        if(isBar (reel)) multiplier = 0;//checks for bar
        else if(isJackpot (reel)) multiplier = 100;//checks for Jackpot
        else if(isCherry (reel,out multiplier)) multiplier=multiplier/1; //checks for cherry
        Change (multiplier);//updating the values
    }

    private bool isBar(String[] reel)
    {
        if(reel[0] == "~/Images/Bar.png" || reel[1] == "~/Images/Bar.png" || reel[2] == "~/Images/Bar.png")
            return true;
        else
            return false;
    }

    private bool isJackpot(String[] reel)
    {
        if(reel[0] == "~/Images/Seven.png" && reel[1] == "~/Images/Seven.png" && reel[2] == "~/Images/Seven.png")
            return true;
        else
            return false;
    }

    private bool isCherry(string[] reel,out int multiplier)
    {
        int count = 0;
        for(int i = 0; i < 3; i++)
        {
            if(reel[i] == "~/Images/Cherry.png")
                count++;
        }
        multiplier = determine (count);//determines the number of cherries
        if(multiplier == 0)
            return false;
        else return true;
    }

    private int determine(int count)
    {
        if(count == 1) return 2;
        else if(count == 2) return 3;
        else if(count == 3) return 4;
        else
            return 0;

    }

    private void Change(int mult)
    {
        int bet = int.Parse (TextBox1.Text);
        int money = int.Parse (Label1.Text);
        money -= bet;
        ViewState["money"] = money;
        bet=bet*mult;
        Result (bet, money);//updates the UI
    }

    private void Result(int a, int b)
    {
        int money = b + a;
        ViewState["money"] = money;
        Label2.Text = string.Format ("You won:{0:C}", a);
        if(money > 0) Label1.Text = ViewState["money"].ToString ();
        else Label1.Text = "You loose";
    }

}