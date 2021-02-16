<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" height="27px" Text="Staff ID" width="97px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="margin-bottom: 1px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 295px; top: 42px; position: absolute; height: 35px; width: 84px;" Text="Find" />
        <p>
            <asp:Label ID="lblName" runat="server" height="27px" Text="Name" width="97px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblStartDate" runat="server" height="27px" Text="Start Date" Width ="97px"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblJobRole" runat="server" height="27px" Text="Job role" width="97px"></asp:Label>
            <asp:TextBox ID="txtJobRole" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" height="27px" Text="Email" width="97px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkStaffExists" runat="server" Text="Exists" />
        <p>

            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOkay" runat="server" OnClick="btnOkay_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>

