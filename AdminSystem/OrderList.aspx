<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
    <p>
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 7px; top: 1px; position:absolute; Height: 175px; Width: 269px"></asp:ListBox>
            </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
        <p>
            
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="btnEdit" runat="server"  OnClick="BtnEdit_Click" Text="Edit"/>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete"  />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            
            <asp:Label ID="Label1" runat="server" Text="Enter a Shipping Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        </p>
        <p>
            
            <asp:Button ID="btnApply" runat="server"  OnClick="BtnApply_Click" Text="Apply" />
&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="BtnClear_Click"  Text="Clear" />
        </p>
        <p>
            
            &nbsp;</p>
        <p>
            
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <div>
            <br />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
      
    </form>
</body>
</html>
