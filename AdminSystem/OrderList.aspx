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
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 7px; top: 1px; position:absolute; Height: 291px; Width: 265px"></asp:ListBox>
            </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
        <p>
            
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnAdd" runat="server" Text="Add" />
&nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
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
