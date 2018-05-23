Imports System.String
Partial Class chatroom_login
    Inherits System.Web.UI.Page
    Dim l As New lbb
    Dim bluser(,) As String = {{"a", "1111"}, {"b", "2222"}, {"c", "3333"}, {"你是一座小城", "123"}, {"lide", "920"}}
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
            Dim i As Integer
            For i = 0 To 2
                If Compare(txtuser.Text, bluser(i, 0), False) = 0 And Compare(txtpassword.Text, bluser(i, 1), False) = 0 And bool = True Then
                    Session("user") = bluser(i, 0)
                    Application("user_online") = CInt(Application("user_online")) + 1 '在线人数加1 
                    Dim sayStr As String
                    sayStr = Now.ToLongTimeString & "  欢迎【" & Session("user") & "】来到聊天室!"   '来访者昵称 
                    sayStr = "<div class='marquee'>" & "<font color='blue'>" & sayStr & "</font>" & "</div> " & "<br>"                        '蓝色显示
                    '下面几句将来访信息保存到Application中
                    Application.Lock()                                              '先锁定
                    Application("user_name") &= Session("user") & "."                           '返回在线用户名
                    Application("show") &= sayStr                                            '返回聊天信息
                    Application.UnLock()                                          '解除锁定
                    Response.Redirect("chat.aspx")
                Else
                    lblwarn.Text = "用户名或密码错！"
                End If
            Next
            If bool = False Then
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
        Response.Redirect("register.aspx")
    End Sub
End Class

