Imports System
Partial Class chatroom_cahtuser
    Inherits System.Web.UI.Page
    Dim l As New lbb
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblonline.Text = ""
        lblonline.Text = "(" & Application("user_online") & "人)"
        Label1.Text = ""
        Dim username() As String
        ReDim username(10)
        username = Split(Application("user_name"), ".")
        l.ssort(username)
        For Each name In username
            If name <> "" Then
                Label1.Text &= name & "<br>"
            End If
        Next
    End Sub
End Class
