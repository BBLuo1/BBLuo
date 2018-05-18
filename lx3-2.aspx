<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx3-2.aspx.vb" Inherits="lx3_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> 
        输入数据<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="原始数据" />
        <asp:Button ID="Button2" runat="server" Text="降序排列" />
        <asp:Button ID="Button3" runat="server" Text="升序排列" />   
    </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
