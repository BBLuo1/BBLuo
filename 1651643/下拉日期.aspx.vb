
Partial Class 下拉日期
    Inherits System.Web.UI.Page
    Dim y, m, d As Integer
    Dim l As New lbb
    Public Sub year()
        Dim i%
        For i = 1900 To 2500
            DropDownList1.Items.Add(i)
        Next
    End Sub
    Public Sub day()
        Dim i%
        Select Case (DropDownList2.Text)
            Case 1, 3, 5, 7, 8, 10, 12
                For i = 1 To 31
                    DropDownList3.Items.Add(i)
                Next
            Case 4, 6, 9, 11
                For i = 1 To 30
                    DropDownList3.Items.Add(i)
                Next
            Case 2
                If (DropDownList1.SelectedItem.Text Mod 4 = 0 And DropDownList1.SelectedItem.Text Mod 100 <> 0) Or (DropDownList1.SelectedItem.Text Mod 400 = 0) Then
                    For i = 1 To 29
                        DropDownList3.Items.Add(i)
                    Next
                Else
                    For i = 1 To 28
                        DropDownList3.Items.Add(i)
                    Next
                End If
        End Select
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        year()
        DropDownList3.Items.Clear()
        day()
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ""
        Label1.Text = "您选择的日期是：" & DropDownList1.SelectedItem.Text & "年" & DropDownList2.SelectedItem.Text & "月" & DropDownList3.SelectedItem.Text & "日"
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = ""
        Label1.Text = "您选择的日期是：" & Today.Year & "年" & Today.Month & "月" & Today.Day & "日"
        DropDownList1.SelectedItem.Text = Today.Year
        DropDownList2.SelectedItem.Text = Today.Month
        DropDownList3.SelectedItem.Text = Today.Day
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filename As String = "下拉日期.aspx"
        Dim filepath As String = MapPath(filename)
        Label2.Text = l.readfile(filepath)
        Dim filename1 As String = "下拉日期.aspx.vb"
        Dim filepath1 As String = MapPath(filename1)
        Label2.Text &= l.readfile(filepath1)
    End Sub
End Class
