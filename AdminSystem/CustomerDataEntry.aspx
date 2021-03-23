<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="97px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 14px" Text="Find" />
        <p>
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="97px"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblAddress" runat="server" Text="Address" width="97px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address" width="97px"></asp:Label>
            <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateRegistered" runat="server" Text="Date Registered"></asp:Label>
            <asp:TextBox ID="txtDateRegistered" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkAbove18" runat="server" Text="Above18" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 7px" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            <asp:Button ID="btnCustomerList" runat="server" OnClick="btnCustomerList_Click" Text="View Customers" />
        </p>
    </form>
</body>
</html>
