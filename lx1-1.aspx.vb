
Partial Class lx1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "<a href='" & TextBox1.Text & "'>" & TextBox1.Text & "</a>"
    End Sub
End Class
