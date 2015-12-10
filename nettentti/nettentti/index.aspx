<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="nettentti.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>PuoliPilkunViilaajat</h1>
        <img src="logo.jpg" alt="logo" />
        <br />
        <asp:TextBox ID="TextBox_username" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox_password" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button_login" runat="server" OnClick="Button_login_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label_result" runat="server"></asp:Label>       
    </div>
    </form>
</body>
</html>
