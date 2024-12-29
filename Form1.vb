Public Class Form1
    Private t As Timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Text = "TimeIs-WinForms"

        t = New Timer()
    End Sub

End Class
