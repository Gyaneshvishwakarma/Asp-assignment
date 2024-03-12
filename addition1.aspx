<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addition1.aspx.cs" Inherits="addition1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lvl1" runat="server" Text="Enter the 1st Value : "></asp:Label>
    <asp:TextBox ID ="val1" runat="server"></asp:TextBox> <br />
    <asp:Label ID="Lvl2" runat="server" Text="Enter the 2nd Value : "></asp:Label>
    <asp:TextBox ID ="val2" runat="server"></asp:TextBox><br />
    <asp:Button ID="btn" runat="server" Text="Result" OnClick="add" />
    <asp:Label ID="result" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
<asp:menu runat="server">

    </asp:menu>
