<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
	This is the order entry page
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtOrderID" runat="server" Height="16px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
            <br />
            <br />
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;
            <asp:CheckBox ID="chkOrderShipped" runat="server" Text="Order Shipped" />
            <br />
            <br />
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtShippingAddress" runat="server" Width="382px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtOrderStatus" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            &nbsp;<br />
            <asp:Button ID="btnOk" runat="server" OnClick="BtnOK_Click" Text="Ok" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
