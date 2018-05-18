<%@ Page Language="VB" AutoEventWireup="false" CodeFile="下拉日期.aspx.vb" Inherits="下拉日期" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style ="margin :auto ;width:50%">
    <div class ="title2">下拉日期</div> 
        <div class ="body">
        请选择年月日<br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        年<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList>
        月<asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
        日<br />
        <asp:Button ID="Button1" runat="server" Text="确定" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="今天" />
    
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button3" runat="server" Text="代码" />
            <br />
    </div>
    </div>
        <p>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
