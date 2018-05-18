Partial Class lx4_1
    Inherits System.Web.UI.Page
    Public Function randomkey() As String
        Dim a, i, j As Integer
        Dim m As Integer
        Randomize()
        a = Int(2 * Rnd() + 4)
        For i = 1 To a
            Select Case Int(3 * Rnd() + 1)
                Case 1                '0~9之间的数字 ASCII 范围为：48~57  
                    m = Int(10 * Rnd() + 48)
                Case 2                'a~z之间的字符 ASCII 范围为：97~122  
                    m = Int(26 * Rnd() + 97)
                Case 3                'A~Z之间的字符 ASCII 范围为：65~90  
                    m = Int(26 * Rnd() + 65)
            End Select
            randomkey = randomkey & Chr(m)
        Next
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Label1.Text = randomkey()
        End If
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Label2.Text = ""
        If (Convert.ToString(Textbox1.Text) <> "WEB" Or Convert.ToString(Textbox2.Text) <> "2016" Or Convert.ToString(Textbox3.Text) <> Convert.ToString(Label1.Text)) Then
            If Convert.ToString(Textbox1.Text) <> "WEB" Then
                Label2.Text = "用户名错误" & "<br>"
                Textbox1.Focus()
            End If
            If Convert.ToString(Textbox2.Text) <> "2016" Then
                Label2.Text &= "密码错误" & "<br>"
                Textbox2.Focus()
            End If
            If Convert.ToString(Textbox3.Text) <> Convert.ToString(Label1.Text) Then
                If Textbox3.Text = "" Then
                    Label2.Text &= "请输入验证码"
                    Textbox3.Focus()
                Else
                    Label2.Text &= "验证码错误"
                    Textbox3.Focus()
                End If
            End If
            Else
                Label2.Text = "欢迎您，登陆成功！"
            End If
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs)
        Label1.Text = randomkey()
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
       Label3.Text="<xmp>"
	 Dim str As String = "lx4-1.aspx.vb"
        Dim sr As New IO.StreamReader(MapPath(str))
        Do Until sr.EndOfStream = True
            Label3.Text &= sr.ReadLine & VbCrLf
        Loop
    End Sub
End Class


