Public Class Form1
    Private t As Timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Text = "TimeIs-WinForms"

        t = New Timer()
        AddHandler t.Tick, AddressOf Timer_Tick
        t.Interval = 1000
        t.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        LabelTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
End Class
