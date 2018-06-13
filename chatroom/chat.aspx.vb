Imports System
Partial Class chatroom_chat
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("user") = "" Then
            Response.Redirect("login.aspx")
        End If
        lbluser.Text = ""
        lbluser.Text = Session("user") & "<img src='../images/" & Session("img") & "'/>"
    End Sub
    Protected Sub btnloginout_Click(sender As Object, e As EventArgs) Handles btnloginout.Click
        Dim saystr As String
        saystr = Now.ToLongTimeString & "  【" & Session("user") & "】离开了聊天室！" & "<br>"
        saystr = "<div class='marquee'>" & "<font color='red'>" & saystr & "</font>" & "</div>"
        Application.Lock()
        Application("show") &= saystr
        Application("user_online") = CInt(Application("user_online")) - 1
        Dim username(), img() As String
        ReDim username(10), img(10)
        username = Application("user_name")
        img = Application("user_img")
        Dim n = Application("user_online")
        Dim j As Integer
        For i = 0 To Application("user_online")
            If username(i) = Session("user") Then
                j = i
            End If
        Next
        For i = j To n
            username(i) = username(i + 1)
            img(i) = img(i + 1)
        Next
        Application.UnLock()
        Response.Redirect("login.aspx")
    End Sub

End Class
