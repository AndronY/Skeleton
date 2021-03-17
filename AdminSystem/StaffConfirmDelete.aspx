<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 106px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Are you sure you want to delete this staff record?</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 29px; top: 156px; position: absolute; height: 36px; width: 73px" Text="Yes" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 115px; top: 156px; position: absolute; height: 36px; width: 73px" Text="No" />
        </p>
    </form>
</body>
</html>
