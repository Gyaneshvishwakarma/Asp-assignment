<%@ Page Language="C#" AutoEventWireup="true" CodeFile="primenumber.aspx.cs" Inherits="primenumber" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h1>Prime Number Checker</h1>
            <label for="txtNumber">Enter a Number:</label>
            <asp:TextBox ID="txtNumber" runat="server" /><br />
            
            <asp:Button ID="btnCheckPrime" runat="server" Text="Check Prime" OnClick="CheckPrime_Click" /><br />
            
            <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
