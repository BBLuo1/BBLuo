<%@ Page Language="VB" AutoEventWireup="false" CodeFile="register.aspx.vb" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 292px;
        }
    </style>
    <link href="Style.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style ="margin :auto ;width:80%">
    <div class ="title2" style ="width :100%">  用户注册</div>
        <div class="body" style="float :left ;width :60%">
        <table >
        <tr>
            <td>用户名</td>
            <td>
                <asp:TextBox ID="Textuser" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入用户名" ControlToValidate="Textuser" ></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>密码</td>
            <td>
                <asp:TextBox ID="Textpassword" runat="server" TextMode="password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码" ControlToValidate="Textpassword"></asp:RequiredFieldValidator>
             </td>
        </tr>
        <tr>
            <td>确认密码</td>
            <td>
                <asp:TextBox ID="Textpassword1" runat="server" Type="password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="两次密码不一样" ControlToCompare="Textpassword" ControlToValidate="Textpassword1"></asp:CompareValidator>
             </td>
        </tr>
       
        <tr>
            <td>性别</td>
            <td class="auto-style1" >                
                &nbsp;<asp:RadioButton ID="RadioButton1" runat="server" text="男" GroupName ="xb"/>
                &nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" text="女" GroupName ="xb"/>               
            </td>         
        </tr> 
        <tr>
            <td>邮箱</td>
            <td>
                <asp:TextBox ID="Textemail" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="邮箱地址有误" ControlToValidate="Textemail" ValidationExpression="^\w+([-+.]\w+)@\w+([-.]\w+).\w+([-.]\w+)*$ ">
                </asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>学校</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>请选择学校</asp:ListItem>
                    <asp:ListItem>同济大学</asp:ListItem>
                    <asp:ListItem>复旦大学</asp:ListItem>
                    <asp:ListItem>上海交通大学</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>专业</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>请选择专业</asp:ListItem>
                    <asp:ListItem>材料科学与工程</asp:ListItem>
                    <asp:ListItem>汽车</asp:ListItem>
                    <asp:ListItem>计算机</asp:ListItem>
                    <asp:ListItem>电子信息工程</asp:ListItem>
                    <asp:ListItem>机械与能源</asp:ListItem>
                    <asp:ListItem>经济管理</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>爱好</td>
            <td>
                 <asp:CheckBox ID="CheckBox1" runat="server"  Text ="打球"/> &nbsp;
                <asp:CheckBox ID="CheckBox2" runat="server" text="跑步"/> &nbsp;
                <asp:CheckBox ID="CheckBox3" runat="server" Text ="阅读"/>&nbsp;
                <asp:CheckBox ID="CheckBox4" runat="server" Text ="上网"/>&nbsp;
                <asp:CheckBox ID="CheckBox5" runat="server" Text ="下棋"/> &nbsp;
                <asp:CheckBox ID="CheckBox6" runat="server" Text ="骑行"/>
            </td>
        </tr>
        <tr>
            <td>特长</td>
            <td>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    <asp:ListItem>绘画</asp:ListItem>
                    <asp:ListItem>唱歌</asp:ListItem>
                    <asp:ListItem>舞蹈</asp:ListItem>
                    <asp:ListItem>书法</asp:ListItem>
                    <asp:ListItem>玩游戏</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        
    </table>
            
            <br />
             验证码&nbsp;<asp:TextBox ID="Textbox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server"></asp:Label> 
            <asp:Button ID="Button3" runat="server"  class="btn btn-default" Text="看不清，换一张" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入验证码" ControlToValidate="Textbox1" SetFocusOnError="True"></asp:RequiredFieldValidator>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" class="btn btn-default" Text="提交" /> 
            <asp:Button ID="Button2" runat="server"  class="btn btn-default" Text="重置" />
        <br />
        <asp:Label ID="Label1" runat="server" ></asp:Label>
            <br />
            
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button4" runat="server"  class="btn btn-default" Text="代码" />
        <br />
        <asp:Label ID="Label5" runat="server" ></asp:Label>
    </div>
    <div class="userimg" >
        上传头像<br>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:Image ID="Image1"   runat="server" width="70px" Height ="100px"/>
            <br />
        </div> 
    </div>
    </form>
</body>
</html>
