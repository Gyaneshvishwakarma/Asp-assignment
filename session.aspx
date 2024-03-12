<%@ Page Language="C#" AutoEventWireup="true" CodeFile="session.aspx.cs" Inherits="session" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Your User Name"></asp:Label>
        <asp:TextBox ID="txtun" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="log" />
    </div>
    </form>
</body>
</html>
