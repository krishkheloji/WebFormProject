﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendingMail.aspx.cs" Inherits="JunBatchWebFormProject.SendingMail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            To
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Subject<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Body<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Attachment
            <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SEND" />
        </div>
    </form>
</body>
</html>
