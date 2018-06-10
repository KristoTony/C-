<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Postal Calculator</h1>
    <p>Width:<asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
    </p>
    <p>Height:<asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" 
            ></asp:TextBox>
    </p>
    <p>Length:<asp:TextBox ID="TextBox3" runat="server" AutoPostBack="True"></asp:TextBox>
    </p>
    <p>
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="A" 
             Text="Ground" AutoPostBack="True" />
    </p>
    <p>
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="A" 
            Text="Air" AutoPostBack="True" />
    </p>
    <p>
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="A" 
             Text="Next Day" AutoPostBack="True" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Result"></asp:Label>
    </p>
    </form>
</body>
</html>
