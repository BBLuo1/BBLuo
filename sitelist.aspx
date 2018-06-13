<%@ Page Language="VB" AutoEventWireup="false" CodeFile="sitelist.aspx.vb" Inherits="sitelist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>实验列表</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div id="left">                                                                                                                                                                                                 
             <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" Target="main" ImageSet="WindowsHelp">
                 <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
                 <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="1px" />
                 <ParentNodeStyle Font-Bold="False" />
                 <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" HorizontalPadding="0px" VerticalPadding="0px" />
             </asp:TreeView>                                                                                                                                       
             <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
             </div>                       
             <div id="right">
                <iframe  name ="main" width="100%"  height="100%"  margin="auto "></iframe>
            </div>
    </div>
    </form>
</body>
</html>
