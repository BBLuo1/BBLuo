Imports System.String
Partial Class chatroom_chatshow
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Application.Lock()
        'If (Application("show").ToString().Length > 100000000) Then '如果发言总长度超过10000个字符，则截断为10000
        'Dim show1 As String = StrReverse(Application("show"))
        ' show1 = show1.ToString.Substring(1, 100000000)
        '  Application("show") = StrReverse(show1)
        '  Application.UnLock()
        '  Label1.Text = ""
        '  End If
        Label1.Text = Application("show")
        Response.AddHeader("refresh", "5")
    End Sub

    
End Class
