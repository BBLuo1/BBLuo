Imports System.Data.OleDb
Partial Class login
    Inherits System.Web.UI.Page
    Dim l As New lbb


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
                sex = RadioButton2.Text
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
            Dim schoolname, majorname As String
            If DropDownList1.SelectedItem.Text = "请选择学校" Then
                schoolname = ""
            Else
                schoolname = DropDownList1.SelectedItem.Text
            End If
            If DropDownList2.SelectedItem.Text = "请选择专业" Then
                majorname = ""
            Else
                majorname = DropDownList2.SelectedItem.Text
            End If
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
                '上传头像
                Dim filepaths, lastnames As String
                Dim photo() As String = {"jpg", "png", "gif", "bmp", "tif"}
                Dim booll As Boolean = False
                Label2.Text = ""
                If FileUpload1.HasFile Then
                    lastnames = l.lastname(FileUpload1.FileName)
                    For Each ch In photo
                        If lastnames = ch Then
                            booll = True
                        End If
                    Next
                    If booll = True Then
                        filepaths = "~/images/" & FileUpload1.FileName
                        FileUpload1.SaveAs(MapPath(filepaths))
                        Image1.ImageUrl = filepaths
                        Label2.Text = FileUpload1.FileName & " 上传成功"

                    Else
                        Label2.Text = "上传文件为." & lastnames & " 请上传图片文件"
                    End If
                Else
                    Label2.Text = "请点击浏览选择文件"
                End If
                '显示注册信息
                Label1.Text = "用户名：" & Textuser.Text & "<br>" & "性别：" & sex & "<br>" & "邮箱："
                Label1.Text &= Textemail.Text & "<br>" & "学校：" & schoolname & "<br>" & "专业：" & majorname
                Label1.Text &= "<br>" & "爱好：" & hobby & "<br>" & "特长：" & speciality
                '将注册信息加入数据库
                Dim mystr As String
                Dim mycon As New OleDbConnection()
                mystr = ConfigurationManager.ConnectionStrings("myconnstring").ToString()
                mycon.ConnectionString = mystr
                mycon.Open()
                Dim mycmd As New OleDbCommand("INSERT INTO [user]([names],[passwords],[sex],[email],[school],[major],[images]) VALUES (@names,@passwords,@sex,@email,@school,@major,@image)", mycon)
                mycmd.Parameters.Add("@names", OleDbType.VarChar).Value = Textuser.Text
                mycmd.Parameters.Add("@passwords", OleDbType.VarChar).Value = Textpassword.Text
                mycmd.Parameters.Add("@sex", OleDbType.VarChar).Value = sex
                mycmd.Parameters.Add("@email", OleDbType.VarChar).Value = Textemail.Text
                mycmd.Parameters.Add("@school", OleDbType.VarChar).Value = schoolname
                mycmd.Parameters.Add("@major", OleDbType.VarChar).Value = majorname
                mycmd.Parameters.Add("@image", OleDbType.Char).Value = FileUpload1.FileName
                If mycmd.ExecuteNonQuery() = 1 Then
                    Response.Write("<script>alert('注册成功')</script>")
                    Response.AddHeader("REFTESH", "0")
                Else
                    Response.Write("注册失败！")

                End If
                mycon.Close()

            End If
        Catch
            Label1.Text = "未知错误，请重试！"
        End Try
        Label4.Text = l.randomkey()
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str As String = "register.aspx"
        Dim File As String = MapPath(str)
        Label5.Text = l.readfile(File)
        Dim str1 As String = "register.aspx.vb"
        Dim File1 As String = MapPath(str1)
        Label5.Text &= l.readfile(File1)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.AddHeader("refresh", "0")
    End Sub
End Class
