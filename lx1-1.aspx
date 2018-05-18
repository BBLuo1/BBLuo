<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx1-1.aspx.vb" Inherits="lx1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        My first ASP.NET网页</div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="click" style="height: 27px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p> 
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
