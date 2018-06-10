using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Travel
{
    public partial class _default : System.Web.UI.Page
    {

        double[,] priceGrid = new double[3, 3];
        protected void Page_Load(object sender, EventArgs e)
        {
            
            priceGrid[0, 1] = 350.00;
            priceGrid[0, 2] = 750.00;
            priceGrid[1, 0] = 400.00;
            priceGrid[1, 2] = 700.00;
            priceGrid[2, 0] = 800.00;
            priceGrid[2, 1] = 805.00;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int from, to;
            if(RadioButton1.Checked) from=0;
            else if (RadioButton2.Checked) from=1;
            else   from=2;
            
            if(RadioButton4.Checked) to=0;
            else if(RadioButton5.Checked) to=1;
            else to=2;

            Label3.Text=string.Format("The price is:{0}",priceGrid[from,to]);
        }
    }
}