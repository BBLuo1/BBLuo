
Partial Class lx4_2
    Inherits System.Web.UI.Page
    Dim l As New lbb
    Dim s() As String = {"while", "if", "for", "break", "switch", "if-else", "do-while", "while"}  
    Public Function link(ByVal s() As String) As String
        Dim ch As String
        For Each ch In s
            Label1.Text &= " " & ch
        Next
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
        link(s)
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = ""
        l.ssort(s)
        Dim ch As String
        For Each ch In s
            Label2.Text &= " " & ch
        Next
    End Sub
End Class
