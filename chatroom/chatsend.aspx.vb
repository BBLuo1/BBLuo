
Partial Class chatroom_chatsend
    Inherits System.Web.UI.Page


    Protected Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        Dim say As String
        If txtsend.Text <> "" Then
            say = "<div class='word-name'>" & Now.ToLongTimeString & "  【" & Session("user") & "】说:" & "</div> "
            say = say & "<br>" & "<div class='word'>" & Server.HtmlEncode(txtsend.Text) & "</div>"
            say = "<div class='word-content'>" & say & "</div>" & "<br>"
        End If
        Application.Lock()
        Application("show") &= say & "<br>" & "<br>" & "<br>"
        Application.UnLock()
        txtsend.Text = ""
    End Sub
End Class
