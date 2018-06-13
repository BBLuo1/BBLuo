<%@ Page Language="VB" AutoEventWireup="false" CodeFile="chat_register.aspx.vb" Inherits="Chatroom_chat_register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Button.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        *<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
        <br />
        <br />
        密码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        *<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        <br />
        <br />
        确认密码：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        *<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请再次输入密码" ControlToValidate="TextBox3" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="两次密码输入不匹配" ControlToCompare="TextBox2" ControlToValidate="TextBox3"></asp:CompareValidator>
        <br />
        <br />
        性别：<asp:RadioButton ID="RadioButton1" runat="server" />男
        <asp:RadioButton ID="RadioButton2" runat="server" />女
        <br />
        <br />
        出生年月：<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        年<asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        月<asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
        日<br />
        <br />
        <asp:Button ID="login" runat="server" Text="注册" class="button button-primary button-rounded  button-small" />
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </form>
</body>
</html>
