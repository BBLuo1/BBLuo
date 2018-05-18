
Partial Class lx3_1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i%, j%
        Label1.Text = "<table  border='2px'>"
        For i = 1 To 9
            Label1.Text &= "<tr>"
            For j = 1 To i
                Label1.Text &= "<td>" & i & "x" & j & "=" & i * j & "" & "</td>"
            Next
            Label1.Text &= "</tr>"
        Next
        Label1.Text &= "</table>"

    End Sub
End Class
