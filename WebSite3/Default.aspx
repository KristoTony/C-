<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <h1>Asset Performance Tracker</h1><br />
        Asset Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Elections Rigged:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Acts Of Subterfuge Performed:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Result "></asp:Label>
       <br />

    
    </div>
    </form>
</body>
</html>
