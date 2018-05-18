<%@ Page Language="VB" AutoEventWireup="false" CodeFile="lx4-1.aspx.vb" Inherits="lx4_1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>       
        用户登陆<br />
        用户名：<asp:TextBox ID="Textbox1" runat="server"></asp:TextBox>
        <br />
        密 码： 
        <asp:TextBox ID="Textbox2" runat="server" type="password"></asp:TextBox>
        <br />
        验证码&nbsp;<asp:TextBox ID="Textbox3" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server"></asp:Label> 
        <asp:Button ID="Button2" runat="server" Text="看不清，换一张" OnClick="Button2_Click" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确定" />      
        <br />        
        <asp:Label ID="Label2" runat="server" ></asp:Label>       
        <br />
        <asp:Button ID="Button3" runat="server" Text="代码" />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
