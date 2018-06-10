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
        performchanged ();
    }

    private void performchanged()
    {
        if(!ValuesExist ()) return;
        int volume = 0;
        if(!tryGetVolume (out volume)) return;

        double multiplier = getmultiplier ();
        double cost = volume * multiplier;
        Label1.Text = string.Format ("Your parcel will Cost:{0:C} to ship.", cost);
    }

    private double getmultiplier()
    {
        if(RadioButton1.Checked) return 0.15;
        else if(RadioButton2.Checked) return 0.25;
        else if(RadioButton3.Checked) return 0.45;
        else return 0;
             
    }

    private bool ValuesExist()
    {
        if(!RadioButton1.Checked && !RadioButton2.Checked && !RadioButton3.Checked)
            return false;
        if(TextBox1.Text.Trim ().Length == 0 || TextBox2.Text.Trim ().Length == 0)
            return false;

        return true;
    }

    private bool tryGetVolume(out int volume)
    {
        volume = 0;
        int width = 0;
        int hieght = 0;
        int length = 0;
        if(!int.TryParse(TextBox1.Text.Trim(),out width)) return false;
        if(!int.TryParse(TextBox2.Text.Trim(),out length)) return false;
        if(!int.TryParse(TextBox3.Text.Trim(),out hieght)) return false;
        volume = width * hieght * length;

        return true;
    }


}