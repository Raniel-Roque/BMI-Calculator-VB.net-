﻿Public Class BMI_Main
    ' Programmer: Raniel Christian Roque
    ' Date Start-End: Aug 26 2023 - Aug 28 2023
    ' BSIT 2A
    Private Sub BMI_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sets the dropdown values
        HeightConvert.SelectedItem = "cm"
        WeightConvert.SelectedItem = "kg"
        TextBox1.Focus()
    End Sub

    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles Compute.Click
        Dim HeightText As String = HeightBox.Text
        Dim WeightText As String = WeightBox.Text
        Dim HeightDouble, WeightDouble As Double

        ' Checks If textboxes are empty and informs user if so
        If (HeightTxT.Text.Equals("Enter Height") AndAlso WeightTxT.Text.Equals("Enter Weight")) Or (String.IsNullOrEmpty(HeightText) AndAlso String.IsNullOrEmpty(WeightText)) Then
            HeightTxT.ForeColor = Color.Red
            WeightTxT.ForeColor = Color.Red
            BMICatBox.Clear()
            BMIBox.Clear()
            MessageBox.Show("Error: Please fill in both height and weight.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf HeightTxT.Text.Equals("Enter Height") Or String.IsNullOrEmpty(HeightText) Then
            WeightTxT.ForeColor = Color.Black
            HeightTxT.ForeColor = Color.Red
            BMICatBox.Clear()
            BMIBox.Clear()
            MessageBox.Show("Error: Please fill in height.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf WeightTxT.Text.Equals("Enter Weight") Or String.IsNullOrEmpty(WeightText) Then
            HeightTxT.ForeColor = Color.Black
            WeightTxT.ForeColor = Color.Red
            BMICatBox.Clear()
            BMIBox.Clear()
            MessageBox.Show("Error: Please fill in weight.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Checks If inputs are correct or incorrect and informs user if so
        Try
            If Not Double.TryParse(HeightText, HeightDouble) And Not Double.TryParse(WeightText, WeightDouble) Then
                HeightTxT.ForeColor = Color.Red
                WeightTxT.ForeColor = Color.Red
                BMICatBox.Clear()
                BMIBox.Clear()
                MessageBox.Show("Error: Invalid height and weight inputs.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            ElseIf Not Double.TryParse(HeightText, HeightDouble) Then
                WeightTxT.ForeColor = Color.Black
                HeightTxT.ForeColor = Color.Red
                BMICatBox.Clear()
                BMIBox.Clear()
                MessageBox.Show("Error: Invalid height input.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            ElseIf Not Double.TryParse(WeightText, WeightDouble) Then
                HeightTxT.ForeColor = Color.Black
                WeightTxT.ForeColor = Color.Red
                BMICatBox.Clear()
                BMIBox.Clear()
                MessageBox.Show("Error: Invalid weight input.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Defaults the color of labels to black
        HeightTxT.ForeColor = Color.Black
        WeightTxT.ForeColor = Color.Black

        ' String to Double
        HeightDouble = Double.Parse(HeightText)
        WeightDouble = Double.Parse(WeightText)

        ' Avoids the NaN Output
        If HeightDouble = 0 AndAlso WeightDouble = 0 Then
            BMIBox.Text = (0.0).ToString("F1")
            BMICatBox.Text = "Very Severely Underweight"
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure the given information is correct?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Return
        End If

        ' BMI Process
        If HeightConvert.SelectedItem.ToString = "cm" Then
            ' Metric System Formula
            ' Converts cm to m by dividing 100
            If WeightConvert.SelectedItem.ToString = "kg" Then
                ' Handle cm and kg
                BMIBox.Text = ((WeightDouble) / ((HeightDouble / 100) ^ 2)).ToString("F1")
            ElseIf WeightConvert.SelectedItem.ToString = "lbs" Then
                ' Handle cm and lb
                ' Converts lbs to kg by dividing 2.205
                BMIBox.Text = ((WeightDouble / 2.205) / ((HeightDouble / 100) ^ 2)).ToString("F1")
            End If

        ElseIf HeightConvert.SelectedItem.ToString = "in" Then
            ' Imperial System Formula
            If WeightConvert.SelectedItem.ToString = "kg" Then
                ' Handle in and kg
                ' Converts kg to lbs by multiplying 2.205
                BMIBox.Text = ((703 * (WeightDouble * 2.205)) / ((HeightDouble) ^ 2)).ToString("F1")
            ElseIf WeightConvert.SelectedItem.ToString = "lbs" Then
                ' Handle in and lb
                BMIBox.Text = ((703 * WeightDouble) / (HeightDouble ^ 2)).ToString("F1")
            End If

        ElseIf HeightConvert.SelectedItem.ToString = "m" Then
            ' Metric System Formula
            If WeightConvert.SelectedItem.ToString = "kg" Then
                ' Handle m and kg
                BMIBox.Text = (WeightDouble / (HeightDouble ^ 2)).ToString("F1")
            ElseIf WeightConvert.SelectedItem.ToString = "lbs" Then
                ' Handle m and lb
                ' Converts lbs to kg by dividing 2.205
                BMIBox.Text = ((WeightDouble / 2.205) / (HeightDouble ^ 2)).ToString("F1")
            End If
        End If

        'BMI CATEGORY
        If Double.Parse(BMIBox.Text) < 15 Then
            BMICatBox.Text = "Very Severely Underweight"
        ElseIf Double.Parse(BMIBox.Text) >= 15 AndAlso Double.Parse(BMIBox.Text) <= 16 Then
            BMICatBox.Text = "Severely Underweight"
        ElseIf Double.Parse(BMIBox.Text) >= 16.1 AndAlso Double.Parse(BMIBox.Text) <= 18.5 Then
            BMICatBox.Text = "Underweight"
        ElseIf Double.Parse(BMIBox.Text) >= 18.6 AndAlso Double.Parse(BMIBox.Text) <= 25 Then
            BMICatBox.Text = "Normal (Healthy Weight)"
        ElseIf Double.Parse(BMIBox.Text) >= 25.1 AndAlso Double.Parse(BMIBox.Text) <= 30 Then
            BMICatBox.Text = "Overweight"
        ElseIf Double.Parse(BMIBox.Text) >= 30.1 AndAlso Double.Parse(BMIBox.Text) <= 35 Then
            BMICatBox.Text = "Moderately Obese"
        ElseIf Double.Parse(BMIBox.Text) >= 35.1 AndAlso Double.Parse(BMIBox.Text) <= 40 Then
            BMICatBox.Text = "Severely Obese"
        ElseIf Double.Parse(BMIBox.Text) > 40 Then
            BMICatBox.Text = "Very Severely Obese"
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ' Clears
        Dim result As DialogResult = MessageBox.Show("Clear Data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.No Then
            Return
        End If

        HeightBox.Text = "Enter Height"
        HeightBox.ForeColor = Color.Gray
        WeightBox.Text = "Enter Weight"
        WeightBox.ForeColor = Color.Gray
        BMIBox.Clear()
        BMICatBox.Clear()
    End Sub

    Private Sub Exp_Col_Click(sender As Object, e As EventArgs) Handles Exp_Col.Click
        ' Expands and Collapse for table
        If Me.Height = 348 Then
            Exp_Col.Text = "Collapse"
            Me.Top = 60
            Me.Height = 601
            TableLayoutPanel1.Visible = True
        ElseIf Me.Height = 601 Then
            Exp_Col.Text = "BMI Table (Expand)"
            TableLayoutPanel1.Visible = False
            Me.Top = 180
            Me.Height = 348
        End If
    End Sub

    Private Sub HeightBox_KeyDown(sender As Object, e As KeyEventArgs) Handles HeightBox.KeyDown
        ' Once enter is pressed in the Height textbox, cursor/next input goes to weight
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            WeightBox.Focus()
        End If
    End Sub

    Private Sub WeightBox_KeyDown(sender As Object, e As KeyEventArgs) Handles WeightBox.KeyDown
        ' Same concept as Height but it executes the compute function
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ActiveControl = Nothing
            Compute.PerformClick()
        End If
    End Sub
    Dim BMI_Load_form As BMI_Loading
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back to main menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If BMI_Load_form Is Nothing Then
                BMI_Load_form = New BMI_Loading
            End If
            BMI_Load_form.Show()
            Me.Close()
        End If
    End Sub

    Private Sub HeightBox_GotFocus(sender As Object, e As EventArgs) Handles HeightBox.GotFocus
        If HeightBox.Text.Equals("Enter Height") Then
            HeightBox.Text = ""
            HeightBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub HeightBox_LostFocus(sender As Object, e As EventArgs) Handles HeightBox.LostFocus
        If HeightBox.Text.Equals("") Then
            HeightBox.Text = "Enter Height"
            HeightBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub WeightBox_GotFocus(sender As Object, e As EventArgs) Handles WeightBox.GotFocus
        If WeightBox.Text.Equals("Enter Weight") Then
            WeightBox.Text = ""
            WeightBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub WeightBox_LostFocus(sender As Object, e As EventArgs) Handles WeightBox.LostFocus
        If WeightBox.Text.Equals("") Then
            WeightBox.Text = "Enter Weight"
            WeightBox.ForeColor = Color.Gray
        End If
    End Sub
End Class