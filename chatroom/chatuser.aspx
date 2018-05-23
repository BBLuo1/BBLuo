<%@ Page Language="VB" AutoEventWireup="false" CodeFile="chatuser.aspx.vb" Inherits="chatroom_cahtuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="refresh" content="1"/>
    <title></title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">  
        <div>           
            <div class ="online" >当前在线：<asp:Label ID="lblonline" runat="server" ></asp:Label></div><br />
            <div class ="onlinename"><asp:Label ID="Label1" runat="server" ></asp:Label></div>
        </div> 
    </form>
</body>
</html>
