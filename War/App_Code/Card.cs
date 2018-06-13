using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Card
/// </summary>
public class Card
{
    public string Suit { get; set; }
    public string Kind { get; set; }

    public int CardValue()
    {
        int value = 0;
        switch(this.Kind)
        {
            case "Jack":
                value = 11;
                break;
            case "Queen":
                value = 12;
                break;
            case "King":
                value = 13;
                break;
            case "Ace":
                value = 14;
                break;
            default:
                int.TryParse (this.Kind, out value);
                break;
        }
        return value;
    }
}