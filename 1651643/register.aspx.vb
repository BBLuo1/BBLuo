
Partial Class login
    Inherits System.Web.UI.Page
    Dim l As New lbb
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filepath, lastname As String
        Dim image() As String = {"jpg", "png", "gif", "bmp", "tif"}
        Dim bool As Boolean = False
        Try
            Label2.Text = ""
            If FileUpload1.HasFile Then
                lastname = l.lastname(FileUpload1.FileName)
                For Each ch In image
                    If lastname = ch Then
                        bool = True
                    End If
                Next
                If bool = True Then
                    filepath = "~/images/" & FileUpload1.FileName
                    FileUpload1.SaveAs(MapPath(filepath))
                    Image1.ImageUrl = filepath
                    Label2.Text = FileUpload1.FileName & " 上传成功"
                Else
                    Label2.Text = "上传文件为." & lastname & " 请上传图片文件"
                End If
            Else
                Label2.Text = "请点击浏览选择文件"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Label4.Text = l.randomkey()
        End If
    End Sub

    Protected Sub Button3_Click1(sender As Object, e As EventArgs) Handles Button3.Click
        Label4.Text = l.randomkey()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sex, hobby, speciality As String
            Dim it As ListItem
            sex = ""
            If RadioButton1.Checked = True Then
                sex = RadioButton1.Text
            End If
            If RadioButton2.Checked = True Then
                sex &= " " & RadioButton2.Text
            End If
            hobby = ""
            If CheckBox1.Checked = True Then
                hobby = CheckBox1.Text
            End If
            If CheckBox2.Checked = True Then
                hobby &= " " & CheckBox1.Text
            End If
            If CheckBox3.Checked = True Then
                hobby &= " " & CheckBox1.Text
            End If
            If CheckBox4.Checked = True Then
                hobby &= " " & CheckBox1.Text
            End If
            If CheckBox5.Checked = True Then
                hobby &= " " & CheckBox1.Text
            End If
            If CheckBox6.Checked = True Then
                hobby &= " " & CheckBox1.Text
            End If
            speciality = ""
            For Each it In CheckBoxList1.Items
                If it.Selected = True Then
                    speciality = speciality & it.Text & " "
                End If
            Next
            Dim bool As Boolean = False
            If Convert.ToString(Textbox1.Text) = Convert.ToString(Label4.Text) Then
                bool = True
            End If
            Label1.Text = ""
            If (Textuser.Text = "" Or Textpassword.Text = "" Or bool = False) Then
                If Textuser.Text = "" Then
                    Label1.Text &= "请输入用户名" & "<br>"
                    Textuser.Focus()
                End If
                If Textpassword.Text = "" Then
                    Label1.Text &= "请输入密码" & "<br>"
                    Textpassword.Focus()
                End If
                If Convert.ToString(bool = False) Then
                    If Textbox1.Text = "" Then
                        Label1.Text &= "请输入验证码"
                        Textbox1.Focus()
                    Else
                        Label1.Text &= "验证码错误"
                        Textbox1.Focus()
                    End If
                End If
            Else
                Label1.Text = "注册成功!"
                Label1.Text = "用户名：" & Textuser.Text & "<br>" & "性别：" & sex & "<br>" & "邮箱："
                Label1.Text &= Textemail.Text & "<br>" & "学校：" & DropDownList1.SelectedItem.Text & "<br>" & "专业：" & DropDownList2.SelectedItem.Text
                Label1.Text &= "<br>" & "爱好：" & hobby & "<br>" & "特长：" & speciality
            End If
        Catch
            Label1.Text = "未知错误，请重试！"
        End Try
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str As String = "register.aspx"
        Dim File As String = MapPath(str)
        Label5.Text = l.readfile(File)
        Dim str1 As String = "register.aspx.vb"
        Dim File1 As String = MapPath(str1)
        Label5.Text &= l.readfile(File1)
    End Sub
End Class
