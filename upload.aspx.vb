
Partial Class upload
    Inherits System.Web.UI.Page
    Dim l As New lbb

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filepath, lastname As String
        Dim ya() As String = {"rar", "zip"}
        Try
            Label1.Text = ""
            If FileUpload2.HasFile Then
                lastname = l.lastname(FileUpload2.FileName)
                Dim bool As Boolean = False
                For Each ch In ya
                    If lastname = ch Then
                        bool = True
                    End If
                Next
                If bool = True Then
                    filepath = "~/shiyan/" & FileUpload2.FileName
                    FileUpload2.SaveAs(MapPath(filepath))
                    Label1.Text = "上传成功！"
                Else
                    Label1.Text = "请上传rar、zip文件"
                End If
                If FileUpload2.PostedFile.ContentLength >= 5 * 1024 * 1024 Then
                    Label1.Text = "文件过大，请重新上传"
                End If
            End If
        Catch
            Label1.Text = "未知错误"
        End Try
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Label4.Text = l.randomkey()
            MultiView1.ActiveViewIndex = 0
        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label4.Text = l.randomkey()
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Label3.Text = ""
            Dim bool As Boolean = False
            If Convert.ToString(TextBox3.Text) = Convert.ToString(Label4.Text) Then
                bool = True
            End If
            If TextBox1.Text = "" Or TextBox2.Text = "" Or bool = False Then
                Label3.Text = "请先登陆"
                TextBox1.Focus()
                If bool = False Then
                    If TextBox3.Text = "" Then
                        Label3.Text = "请输入验证码"

                    Else
                        Label3.Text = "验证码错误！"
                    End If
                    TextBox3.Focus()
                End If
            Else
                Label3.Text = "登陆成功！<br>您的信息是：<br>" & "学号：" & TextBox1.Text & "<br>" & "姓名：" & TextBox2.Text & "<br>" & "专业：" & DropDownList1.SelectedItem.Text
            End If
        Catch
            Label3.Text = "未知错误！"
        End Try
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label3.Text = ""
        Dim bool As Boolean = False
        If Convert.ToString(TextBox3.Text) = Convert.ToString(Label4.Text) Then
            bool = True
        End If
        If TextBox1.Text = "" Or TextBox2.Text = "" Or bool = False Then
            Label3.Text = "请先登陆"
        Else
            MultiView1.ActiveViewIndex = 1
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MultiView1.ActiveViewIndex = 0
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim str As String = "upload.aspx"
        Dim File As String = MapPath(str)
        Label5.Text = l.readfile(File)
        Dim str1 As String = "upload.aspx.vb"
        Dim File1 As String = MapPath(str1)
        Label5.Text &= l.readfile(File1)
    End Sub
End Class
