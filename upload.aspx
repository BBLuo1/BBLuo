<%@ Page Language="VB" AutoEventWireup="false" CodeFile="upload.aspx.vb" Inherits="upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<link href="css/bootstrap.css" rel="stylesheet" />
<link href="Style.css" rel="stylesheet" />
<body>
    <form id="form1" runat="server">
    <div>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <div class="title2">第一步：输入个人信息</div> 
                    <div class ="body ">
                    学号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="必须输入7位学号" ControlToValidate="TextBox1" ValidationExpression="[0-9]{7}"></asp:RegularExpressionValidator>
                    <br />
                    姓名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="必须输入名字" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                    <br />
                    专业：<asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>请选择专业</asp:ListItem>
                        <asp:ListItem>材料科学与专业</asp:ListItem>
                        <asp:ListItem>汽车</asp:ListItem>
                        <asp:ListItem>艺术与传媒</asp:ListItem>
                        <asp:ListItem>经济管理</asp:ListItem>
                        <asp:ListItem>电子信息与工程</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    验证码：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                    <asp:Button ID="Button3" runat="server" class="btn btn-default" Text="看不起，换一张" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="必须输入验证码" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                        <br />
                    <asp:Button ID="Button4" runat="server" Text="登陆" class="btn btn-success"/>
                    <br />
                    <asp:Label ID="Label3" runat="server" ></asp:Label>
                    <br />
                    <asp:Button ID="Button5" runat="server" class="btn btn-default" Text="下一步" CommandName ="Next View" />
                        <asp:Button ID="Button6" runat="server" class="btn btn-default" Text="代码" />
                        <br />
                    </div>
                </asp:View> 
                
                <asp:View ID="View2" runat="server" ViewStateMode="Enabled">
                    <div class ="title2">第二步：选择上传web试验<br />                     
                     </div>
                 <div class="body">
                    <table class="table table-hover"> 
                       <tr><td>文件名规定：学号-实验编号（例：1001234-1.rar)</td> </tr>
                       <tr class="danger">
                        <td>
                            <input id="Radio1" type="radio" />实验1 ASP.NEeT网站的建立与管理和网页的基本操作</td>
                       </tr>
                       <tr >
                        <td><input id="Radio2" type="radio" />实验2 HTML网页的编写与调试 </td>
                       </tr>
                       <tr class="danger">
                        <td><input id="Radio3" type="radio" />实验3 ASP.NET程序设计基础</td>
                       </tr>
                       <tr >
                        <td><input id="Radio4" type="radio" />实验4 WEB服务器基本控件的设计和使用 </td>
                       </tr>
                       <tr class="danger">
                        <td><input id="Radio5" type="radio" />实验5 内部对象的设计和使用</td>
                       </tr>
                        <tr >
                        <td><input id="Radio6" type="radio" />实验6 主题、母版页和站点导航 </td>
                       </tr>
                        <tr class="danger">
                        <td><input id="Radio7" type="radio" />实验7 ASP.NET存取数据库的基本操作</td>
                       </tr>
                        <tr >
                        <td><input id="Radio8" type="radio" />实验8 WEB应用系统课程设计 </td>
                       </tr>
                        <tr >
                        <td>
                            <asp:FileUpload ID="FileUpload2" runat="server" />                         
                            <br />
                            *文件最大为5M
                        </td>
                       </tr>
                     </table>
                     <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="上传提交" />
                     <br />
                     <asp:Label ID="Label1" runat="server"></asp:Label>
                     <br />
                     <asp:Button ID="Button2" runat="server"  class="btn btn-default" Text="上一步"  CommandName ="Prev View"/>
                    </div>                 
                </asp:View>
            </asp:MultiView>
    </div>
        <p>
                        <asp:Label ID="Label5" runat="server"></asp:Label>
                    </p>
    </form>
</body>
</html>
