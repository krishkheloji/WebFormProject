<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterDb.aspx.cs" Inherits="JunBatchWebFormProject.RegisterDb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Email<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Password<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Up" />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" EnableTheming="True" NavigateUrl="~/LoginDB.aspx">Go for Login</asp:HyperLink>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
