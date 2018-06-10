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
            string[] assets = new string[0];
            int[] elections = new int[0];
            int[] acts = new int[0];

            ViewState.Add ("assets", assets);
            ViewState.Add ("elections", elections);
            ViewState.Add ("acts", acts);
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] asset = (string[])ViewState ["assets"];
        int[] election = (int[])ViewState["elections"];
        int[] act = (int[])ViewState["acts"];
        int length = asset.Length + 1;
        Array.Resize (ref asset, length);
        Array.Resize (ref election, length);
        Array.Resize (ref act, length);
        int item = asset.GetUpperBound(0);
        asset[item] = TextBox1.Text;
        election[item] = int.Parse (TextBox2.Text);
        act[item] = int.Parse (TextBox3.Text);
        ViewState["assets"]=asset;
        ViewState["elections"]=election;
        ViewState["acts"]=act;
        Label1.Text = string.Format ("Total Elections Rigged:{0}<br/>Average Acts Of Subterfuge per Asset:{1:N2}<br/>Last Asset Added:{2}<br/>", election.Sum (), act.Average (), asset[item]);



    }

}