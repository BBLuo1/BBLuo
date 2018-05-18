Partial Class lx3_2
    Inherits System.Web.UI.Page
    Dim l As New lbb
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str() As String
        str = Split(TextBox1.Text, " ")
        Dim ch As String
        Label1.Text = ""
        For Each ch In str
            Label1.Text &= ch & " "
        Next
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str(), t As String
        str = Split(TextBox1.Text, " ")
        Dim a(), len As Integer, i As Integer = 0
        len = str.Length
        ReDim a(len)
        For Each t In str
            a(i) = Convert.ToInt16(t)
            i += 1
        Next
        l.nresort(a)
        Label1.Text = ""
        Dim ch As Integer
        Label1.Text = "降序排列："
        For Each ch In a
            Label1.Text &= ch & " "
        Next
        Label1.Text = Label1.Text & "<br>" & "平均数：" & l.average(str)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str(), t As String
        str = Split(TextBox1.Text, " ")
        Dim a(), len As Integer, i As Integer = 0
        len = str.Length
        ReDim a(len)
        For Each t In str
            a(i) = Convert.ToInt16(t)
            i += 1
        Next
        l.nsort(a)
        Label1.Text = ""
        Dim ch As Integer
        Label1.Text = "升序排列："
        For Each ch In a
            Label1.Text &= ch & " "
        Next
        Label1.Text = Label1.Text & "<br>" & "平均数：" & l.average(str)
    End Sub
End Class
