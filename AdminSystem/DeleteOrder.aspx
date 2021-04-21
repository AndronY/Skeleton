<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrder.aspx.cs" Inherits="DeleteOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="544px">Are you sure you want to delete this record?</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" Text="Yes" />
            <asp:Button ID="Button2" runat="server" Text="No" />
        </div>
    </form>
</body>
</html>
