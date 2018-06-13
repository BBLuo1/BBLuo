Imports System
Partial Class chatroom_cahtuser
    Inherits System.Web.UI.Page
    Dim l As New lbb
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblonline.Text = ""
        lblonline.Text = "(" & Application("user_online") & "人)"
        Label1.Text = ""
        Dim n As Integer = Application("user_online") - 1
        Dim username() As String = Application("user_name")
        Dim img() As String = Application("user_img")
        For i = 0 To n
            Label1.Text &= "<div class='onlinename-content'>" & "<img src='../images/" & img(i) & "'/>" & username(i) & "</div>" & "<br>"
        Next
        Response.AddHeader("refresh", "5")
    End Sub
End Class
