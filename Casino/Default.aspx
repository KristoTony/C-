<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Width="139px" />
        <asp:Image ID="Image2" runat="server" Width="139px" />
        <asp:Image ID="Image3" runat="server" Width="139px" />
        <br />
        <br />
        Your Bet:<asp:TextBox ID="TextBox1" runat="server" Width="168px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Pull The Lever" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Result"></asp:Label>
        <br />
        <br />
        Player&#39;s Money:<asp:Label ID="Label1" runat="server" Text="Money"></asp:Label>
        <br />
        <br />
        <ul style=" margin-top: 0px; margin-bottom: 10px; line-height: inherit; font-weight: 400; color: rgb(51, 51, 51); font-family: &quot;Roboto Slab&quot;, serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
            <li style=" font-size: 1.07em; line-height: 2; font-weight: 400;">
                2x Bet for 1 Cherry</li>
            <li style=" font-size: 1.07em; line-height: 2; font-weight: 400;">
                3x Bet for 2 Cherries</li>
            <li style=" font-size: 1.07em; line-height: 2; font-weight: 400;">
                4x Bet for 3 Cherries</li>
            <li style=" font-size: 1.07em; line-height: 2; font-weight: 400;">
                100x Bet for three 7&#39;s</li>
        </ul>
    
    </div>
    </form>
    <p>
        HOWEVER</p>
    <p>
        If There&#39;s even one BAR you win nothing.</p>
</body>
</html>
