Imports System.String
Imports System.Data.OleDb

Partial Class chatroom_login
    Inherits System.Web.UI.Page
    Dim l As New lbb
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            lblyzm.Text = l.randomkey()
        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblyzm.Text = l.randomkey()
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            lblwarn.Text = ""
            Dim bool As Boolean = False
            If Convert.ToString(txtyzm.Text) = Convert.ToString(lblyzm.Text) Then
                bool = True
            End If
            '从数据库中查找用户存到数组中
            Dim mycon As New OleDbConnection()
            Dim str As String = ConfigurationManager.ConnectionStrings("myconnstring").ToString()
            mycon.ConnectionString = str
            mycon.Open()
            Dim mycmd As New OleDbCommand("SELECT [names],[passwords],[images] from [user]", mycon)
            Dim myreader As OleDbDataReader = mycmd.ExecuteReader()
            Dim users(,), image() As String
            ReDim users(10, 10)
            ReDim image(10)
            Dim i As Integer = 0
            While myreader.Read()
                users(i, 0) = myreader("names").ToString
                users(i, 1) = myreader("passwords").ToString
                image(i) = myreader("images").ToString
                If image(i) = "" Then
                    image(i) = "cat.jpg"
                End If
                i += 1
            End While
            Dim int As Integer
            myreader.Close()
            '验证是否存在
            Dim num As Integer
            For num = 0 To i
                If users(num, 0) = txtuser.Text.ToString Then
                    If users(num, 1) = txtpassword.Text.ToString Then
                        int = 1
                        Exit For
                    Else
                        int = 0
                    End If
                Else
                    int = -1
                End If
            Next
            If int = 1 And bool = True Then
                Session("user") = users(num, 0)
                Session("img") = image(num)
                Dim sayStr As String
                sayStr = Now.ToLongTimeString & "  欢迎【" & Session("user") & "】来到聊天室!"   '来访者昵称 
                sayStr = "<div class='marquee'>" & "<font color='blue'>" & sayStr & "</font>" & "</div> " & "<br>"                        '蓝色显示
                '下面几句将来访信息保存到Application中
                Application.Lock()                                              '先锁定
                If Application("user_name") Is Nothing Then          '返回在线用户名
                    Dim username(100), img(100) As String
                    username(0) = users(num, 0)
                    img(0) = image(num)
                    Application.Add("user_name", username)
                    Application.Add("user_img", img)
                    Application("user_online") = 1
                Else
                    Application("user_name")(Application("user_online")) = users(num, 0)
                    Application("user_img")(Application("user_online")) = image(num)
                    Application("user_online") = CInt(Application("user_online")) + 1   '在线人数加1 
                End If
                Application("show") &= sayStr                                            '返回聊天信息
                Application.UnLock()                                          '解除锁定
                Response.Redirect("chat.aspx")
            ElseIf int = -1 Then
                lblwarn.Text = "用户名不存在！"
            ElseIf int = 0 Then
                lblwarn.Text = "密码错误！"
            ElseIf bool = False Then
                If txtyzm.Text = "" Then
                    lblwarn.Text = "请输入验证码"
                Else
                    lblwarn.Text = "验证码错误！"
                End If
                txtyzm.Focus()
            End If
        Catch
            lblwarn.Text = "未知错误！"
        End Try
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Response.Redirect("../register.aspx")
    End Sub
End Class

