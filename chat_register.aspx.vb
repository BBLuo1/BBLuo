Imports System.Data.OleDb
Partial Class Chatroom_chat_register
    Inherits System.Web.UI.Page

    Protected Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If IsValid Then
            Dim myconn As New OleDbConnection()
            Dim mystr As String = ConfigurationManager.ConnectionStrings("myconnstring").ToString
            myconn.ConnectionString = mystr
            myconn.Open()
            Dim mycmd As New OleDbCommand("INSERT INTO [User]([PassWord],[UserName]) VALUES(@password,@name)", myconn)

            mycmd.Parameters.Add("@password", OleDbType.VarChar).Value = TextBox2.Text
            mycmd.Parameters.Add("@name", OleDbType.VarChar).Value = TextBox1.Text
            If mycmd.ExecuteNonQuery() = 1 Then
                Response.Write("<script>alert('注册成功');</script>")
            End If
            myconn.Close()
        End If
    End Sub
End Class
