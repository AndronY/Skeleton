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
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 18px; top: 384px; position: absolute; height: 36px; width: 75px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 97px; top: 384px; position: absolute; height: 36px; width: 75px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 548px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server"  style="z-index: 1; left: 173px; top: 438px; position: absolute; width: 237px;"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 174px; top: 384px; position: absolute; height: 36px; width: 75px" Text="Delete" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblEnterName" runat="server" style="z-index: 1; left: 22px; top: 438px; position: absolute; height: 34px; width: 160px; margin-bottom: 2px" Text="Enter a name"></asp:Label>
        </p>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 20px; top: 29px; position: absolute; height: 331px; width: 265px"></asp:ListBox>
        <p>
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 239px; top: 482px; position: absolute; height: 38px; width: 80px;" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 335px; top: 482px; position: absolute; height: 38px; width: 80px;" Text="Clear" OnClick="btnClear_Click" />
        </p>
    </form>
</body>
</html>
