<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FeedBack Form</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>
        <asp:Image ID="Image1" runat="server" Height="116px" 
            ImageUrl="~/Images/happy.png" Width="72px" />
        Papa Bob's Pizza and Software</h1>
        <br />


    </div>
    <asp:RadioButton ID="RadioButton1" runat="server" 
        Text="SonBobSize(10&quot;)-10$" GroupName="A"  /><br />
    <asp:RadioButton ID="RadioButton2" runat="server"  
        Text="MamaBobSize(13&quot;)-13$" GroupName="A" /><br />
    <asp:RadioButton ID="RadioButton3" runat="server" 
        Text="PapaBobSize(16&quot;)-16$" GroupName="A" /><br />
        <br />
        <br />

    <asp:RadioButton ID="RadioButton4" runat="server" Text="Thin Crust" 
        GroupName="B" /><br />

    <asp:RadioButton ID="RadioButton5" runat="server" Text="Deep Dish-2$" 
        GroupName="B"  /><br />
    <br />

    <asp:CheckBox ID="CheckBox1" runat="server" Text="Peperoni-1.5$"  /><br />
    <asp:CheckBox ID="CheckBox2" runat="server" Text="Onion-0.75$"  /><br />
    <asp:CheckBox ID="CheckBox3" runat="server" Text="Green Pepper-0.5$"  /><br />
    <asp:CheckBox ID="CheckBox4" runat="server" Text="Red Pepper-0.75$"  /><br />
    <asp:CheckBox ID="CheckBox5" runat="server" Text="Anchovies-2$"  /><br />
    <h1>Papa Bob's <span style="color:Red">Special Deal</span></h1>
    <br />
    <p>Save 2$ when you add Pepperoni,Green Pepper and Anchovies OR Pepperoni,Red Peppers and Onions</p><br />
    <asp:Button ID="Button1" runat="server" Text="Purchase" 
        onclick="Button1_Click" /><br />
    </br>
    <asp:Label ID="Label1" runat="server" Text="Total:0.0$"></asp:Label><br />
    <br />
    <p>Sorry at this time you can only order one pizza online and pick-up only...we need a better website!</p>


    </form>
</body>
</html>
