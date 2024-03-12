<%@ Page Language="C#" AutoEventWireup="true" CodeFile="matchvalue.aspx.cs" Inherits="matchvalue" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Value Matching Form</h1>
            <asp:TextBox ID="txtBox1" runat="server" placeholder="Enter text"></asp:TextBox>
            <asp:TextBox ID="txtBox2" runat="server" placeholder="Enter text"></asp:TextBox>
            <asp:Button ID="btnMatch" runat="server" Text="Match Values" OnClick="btnMatch_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
