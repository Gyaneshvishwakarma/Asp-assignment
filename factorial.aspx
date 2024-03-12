<%@ Page Language="C#" AutoEventWireup="true" CodeFile="factorial.aspx.cs" Inherits="factorial" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1>Factorial Calculator</h1>
            <label for="txtNumber">Enter a Number:</label>
            <asp:TextBox ID="txtNumber" runat="server" /><br />
            
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="Calculate_Click" /><br />
            
            <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
