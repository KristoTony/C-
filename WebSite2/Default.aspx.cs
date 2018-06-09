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
        double total;

        if(RadioButton1.Checked)
            total = 10.0;
        else if(RadioButton2.Checked)
            total = 13.0;
        else
            total = 16.0;

        if(RadioButton5.Checked)
            total += 2.0;

        total = (CheckBox1.Checked) ? total + 1.5 : total;
        total = (CheckBox2.Checked) ? total + .75 : total;
        total = (CheckBox3.Checked) ? total + .5 : total;
        total = (CheckBox4.Checked) ? total + .75 : total;

        if(CheckBox5.Checked) total += 2.0;

        if((CheckBox1.Checked
            && CheckBox3.Checked
            && CheckBox5.Checked)
            || (CheckBox1.Checked
            && CheckBox2.Checked
            && CheckBox4.Checked))
        {
            total -= 2.0;
        }

        Label1.Text = "$" + total.ToString ();
    }
}