<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Travel._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="From:"></asp:Label><br />
    
    </div>
    <br />
    <asp:RadioButton ID="RadioButton1" runat="server" Text="Chicago" 
        GroupName="A" /><br />
    <asp:RadioButton ID="RadioButton2" runat="server" Text="New York" 
        GroupName="A" /><br />
    <asp:RadioButton ID="RadioButton3" runat="server" Text="London" GroupName="A" /><br />
    <br />

    <asp:Label ID="Label2" runat="server" Text="To"></asp:Label><br /><br />
    <asp:RadioButton ID="RadioButton4" runat="server" Text="Chicago" 
        GroupName="B" /><br />
    <asp:RadioButton ID="RadioButton5" runat="server" Text="New York" 
        GroupName="B" /><br />
    <asp:RadioButton ID="RadioButton6" runat="server" Text="London" GroupName="B" /><br />
    <br />

    <asp:Button ID="Button1" runat="server" Text="OK" onclick="Button1_Click" /><br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
    </form>
    
</body>
</html>
