<%@ Page Language="VB" AutoEventWireup="false" CodeFile="chat.aspx.vb" Inherits="chatroom_chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>chatroom</title>
    <link href="../Style.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
</head>
<body> 
    <form id="form1" runat="server">
    <div id="chat">
        <div id="chattitle">聊天室</div>
        <div id="chatshow">
            <iframe src="chatshow.aspx" name="show" width="100%" height="560px" border="none"></iframe>
            <br />
            <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="清除聊天记录" />
        </div>
        <div id="chatuser">
            <div class ="online">用户名：
                 <asp:Label ID="lbluser" runat="server" ></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btnloginout" class="btn btn-success" runat="server" Text="注销" />
             </div>        
            <iframe src="chatuser.aspx" name="user" width="100%" height="560px" border="none" ></iframe>
        </div>
        <div id="chatsend">
            <iframe src="chatsend.aspx" name="send" width="100%" height="200px" border="none"></iframe>
        </div>
    </div>
        </form> 
</body>
</html>
