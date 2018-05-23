<%@ Page Language="VB" AutoEventWireup="false" CodeFile="chatsend.aspx.vb" Inherits="chatroom_chatsend" %>

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
    <div>
    
        <asp:TextBox ID="txtsend" runat="server" style="Height:150px;Width:40%" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="btnsend" class="btn btn-success" runat="server" Text="发送" />
    </div>
    </form>
</body>
</html>
