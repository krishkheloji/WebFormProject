<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="JunBatchWebFormProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server" style="width:30%;border:5px solid blue;padding:20px">
        ID<asp:TextBox ID="TextBox1" class="form-control" runat="server" placeholder="Enter ID"></asp:TextBox>
        <br />
        
        Name<asp:TextBox ID="TextBox2" class="form-control" runat="server" placeholder="Enter Name"></asp:TextBox>
        <br />
       
        Salary
        <asp:TextBox ID="TextBox3" class="form-control" runat="server" placeholder="Enter Salary"></asp:TextBox>
        <br />
       
        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Submit" OnClick="Button1_Click" />
        
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        
        <p>
            &nbsp;</p>
        <p>
            1st No
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            2nd No<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            Choice
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        
    </form>
</body>
</html>
