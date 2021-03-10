<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductID" runat="server" Text="Product ID"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Label ID="lblProductDescription" runat="server" Text="Product Description" width="68px"></asp:Label>
        <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStockQuantity" runat="server" Text="Quantity" width="68px"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDateListed" runat="server" Text="Date Listed" width="68px"></asp:Label>
        <asp:TextBox ID="txtDateListed" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="68px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkInStock" runat="server" Text="In Stock" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
