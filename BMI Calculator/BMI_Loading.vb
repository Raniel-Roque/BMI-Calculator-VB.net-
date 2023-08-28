Public Class BMI_Loading
    ' Programmer: Raniel Christian Roque
    ' Date Start-End: Aug 26 2023 - Aug 28 2023
    ' BSIT 2A

    Private Sub BMI_Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadTimer_Tick(sender As Object, e As EventArgs) Handles LoadTimer.Tick
        ' Fake Loading Screen
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 5
        ElseIf ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Dispose()
            Enter.Visible = True
        End If
    End Sub

    Dim BMI_Main_Form As BMI_Main
    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Enter.Click
        ' Goes to main menu of BMI Calculator
        If BMI_Main_Form Is Nothing Then
            BMI_Main_Form = New BMI_Main
        End If
        BMI_Main_Form.Show()
        Me.Close()
    End Sub
End Class
