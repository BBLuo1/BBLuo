Imports Microsoft.VisualBasic
Imports System
Public Class lbb
    Public Function sresort(ByVal str() As String)
        Dim i, j, len As Integer
        Dim t As String
        len = str.Length
        For i = 0 To len - 1
            For j = 0 To len - 2 - i
                If String.Compare(str(j), str(j + 1)) = -1 Then
                    t = str(j)
                    str(j) = str(j + 1)
                    str(j + 1) = t
                End If
            Next
        Next
        Return str
    End Function
    Public Function nresort(ByVal a() As Integer)
        Dim i, j, len, t As Integer
        len = a.Length
        For i = 0 To len - 1
            For j = 0 To len - 2 - i
                If a(j) < a(j + 1) Then
                    t = a(j)
                    a(j) = a(j + 1)
                    a(j + 1) = t
                End If
            Next
        Next
        Return a
    End Function
    Public Function ssort(ByVal str() As String)
        Dim i, j, len As Integer
        Dim t As String
        len = str.Length
        For i = 0 To len - 1
            For j = 0 To len - 2 - i
                If String.Compare(str(j), str(j + 1)) = 1 Then
                    t = str(j)
                    str(j) = str(j + 1)
                    str(j + 1) = t
                End If
            Next
        Next
        Return str
    End Function
    Public Function nsort(ByVal a() As Integer)
        Dim i, j, len, t As Integer
        len = a.Length
        For i = 0 To len - 1
            For j = 0 To len - 2 - i
                If a(j) > a(j + 1) Then
                    t = a(j)
                    a(j) = a(j + 1)
                    a(j + 1) = t
                End If
            Next
        Next
        Return a
    End Function
    Public Function average(ByVal s() As String) As Integer
        Dim n, t As Integer
        n = 0
        Dim aver, sum As Double
        sum = 0
        For Each t In s
            sum = sum + t
            n = n + 1
        Next
        aver = sum / n
        Return aver
    End Function
    Public Function randomkey() As String
        Dim a, i, j As Integer
        Dim m As Integer
        Randomize()
        For i = 0 To 3
            Select Case Int(3 * Rnd() + 1)
                Case 1                '0~9之间的数字 ASCII 范围为：48~57  
                    m = Int(10 * Rnd() + 48)
                Case 2                'a~z之间的字符 ASCII 范围为：97~122  
                    m = Int(26 * Rnd() + 97)
                Case 3                'A~Z之间的字符 ASCII 范围为：65~90  
                    m = Int(26 * Rnd() + 65)
            End Select
            randomkey = randomkey & Chr(m)
        Next
    End Function
    Public Function lastname(ByVal s As String)
        Dim n As Integer = 0
        Dim t(10), ch As String
        t = Split(s, ".")
        For Each ch In t
            n += 1
        Next
        Return t(n - 1)
    End Function

    Public Function readfile(ByVal str As String)
        Dim file As String
        Dim sr As New IO.StreamReader(str)
        Do Until sr.EndOfStream = True
            file &= sr.ReadLine & vbCrLf
        Loop
        Return "<xmp>" & file & "</xmp>"
    End Function
End Class
