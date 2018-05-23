<%@ Page Language="VB" AutoEventWireup="false" CodeFile="login.aspx.vb" Inherits="chatroom_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Style.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="title2">登陆</div> 
    <div class ="body ">
        用户名：<asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="用户名不能为空" ControlToValidate="txtuser"></asp:RequiredFieldValidator>
        <br />
        密 码： 
        <asp:TextBox ID="txtpassword" runat="server" TextMode ="Password" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="密码不能为空" ControlToValidate="txtpassword"></asp:RequiredFieldValidator>
        <br />

    验证码：<asp:TextBox ID="txtyzm" runat="server"></asp:TextBox>
                    <asp:Label ID="lblyzm" runat="server"></asp:Label>
                    <asp:Button ID="Button3" runat="server" class="btn btn-default" Text="看不清，换一张" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="必须输入验证码" ControlToValidate="txtyzm"></asp:RequiredFieldValidator>
                        <br />
                    <asp:Button ID="Button4" runat="server" Text="登陆" class="btn btn-success"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" Text="注册" class="btn btn-success"/>
                    <br />
                    <asp:Label ID="lblwarn" runat="server" ></asp:Label>
    </div>
    </form>
</body>
</html>
