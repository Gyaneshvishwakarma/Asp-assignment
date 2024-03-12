<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calculator.aspx.cs" Inherits="calculator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Calculator"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Enter The 1st Value"></asp:Label>
        <asp:TextBox ID="val1" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Enter the 2nd value"></asp:Label>
        <asp:TextBox ID="val2" runat="server"></asp:TextBox>
        <asp:Label ID="res" runat="server" Text="Result"></asp:Label>

        <asp:Button ID="btnadd" runat="server" Text="+" OnClick="addition"/>
        <asp:Button ID="btnmin" runat="server" Text="-" OnClick="min" />
        <asp:Button ID="btndivision" runat="server" Text="/"  OnClick="div"/>
        <asp:Button ID="btnmul" runat="server" Text="*" OnClick="mul" />
    </div>
    </form>
</body>
</html>
