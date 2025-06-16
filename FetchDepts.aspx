<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FetchDepts.aspx.cs" Inherits="JunBatchWebFormProject.FetchDepts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Depts
            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
