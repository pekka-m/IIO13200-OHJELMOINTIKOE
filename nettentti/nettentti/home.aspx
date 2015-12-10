<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="nettentti.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>ASDFASDFASFASFASFSF</h1>
    </div>
        
<asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
    runat="server" AutoGenerateColumns="false" AllowPaging="true">
    <Columns>
        <asp:BoundField DataField="koodaaja" HeaderText="koodaaja" ItemStyle-Width="80" />
        <asp:BoundField DataField="date" HeaderText="date" ItemStyle-Width="150" />
        <asp:BoundField DataField="koodaus-h" HeaderText="koodaus-h" ItemStyle-Width="150" />
        <asp:BoundField DataField="koodaus-m" HeaderText="koodaus-m" ItemStyle-Width="150" />
    </Columns>
</asp:GridView>

    </form>
</body>
</html>
