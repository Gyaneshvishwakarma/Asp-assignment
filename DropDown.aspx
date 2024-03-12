<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDown.aspx.cs" Inherits="DropDown" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlItems" runat="server"></asp:DropDownList>
            <br /><br />
            <asp:TextBox ID="txtNewItem" runat="server" placeholder="Enter item" />
            <asp:Button ID="btnAddFirst" runat="server" Text="Add at First" OnClick="btnAddFirst_Click" />
            <asp:Button ID="btnAddLast" runat="server" Text="Add at Last" OnClick="btnAddLast_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete Selected" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>
