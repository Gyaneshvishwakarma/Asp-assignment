<%@ Page Language="C#" AutoEventWireup="true" CodeFile="simpleInterest.aspx.cs" Inherits="simpleInterest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
            <h1>Simple Interest Calculator</h1>
            <label>Principal Amount:</label>
            <asp:TextBox ID="txtPrincipal" runat="server" /><br />
            
            <label>Rate of Interest (%):</label>
            <asp:TextBox ID="txtRate" runat="server" /><br />
            
            <label>Time (in years):</label>
            <asp:TextBox ID="txtTime" runat="server" /><br />
            
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="Calculate_Click" /><br />
            
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
