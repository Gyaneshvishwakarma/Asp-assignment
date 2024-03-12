<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="chkPhp" runat="server" Text="PHP" AutoPostBack="true" OnCheckedChanged="CheckBox_CheckedChanged" />
            <asp:CheckBox ID="chkJava" runat="server"  Text="Java" OnCheckedChanged="CheckBox_CheckedChanged" />
            <asp:CheckBox ID="chkCSharp" runat="server" Text="C#" AutoPostBack="true" OnCheckedChanged="CheckBox_CheckedChanged" />

            <br /><br />
             
            <asp:ListBox ID="lstTechnologies" runat="server" SelectionMode="Multiple"></asp:ListBox>
        </div>
    </form>
</body>
</html>
