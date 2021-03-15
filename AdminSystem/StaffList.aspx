<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 21px; top: 20px; position: absolute; height: 331px; width: 265px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 18px; top: 384px; position: absolute; height: 36px; width: 75px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 97px; top: 384px; position: absolute; height: 36px; width: 71px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 442px; position: absolute"></asp:Label>
    </form>
</body>
</html>
