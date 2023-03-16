Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Private Sub clear()
        lbResult.Text = ""
        txtValue.Text = ""
        rbtnMeters.Checked = True
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Const convertValue As Decimal = 0.0254D
        Dim input As Decimal
        Dim output As Decimal
        If IsNumeric(txtValue.Text) Then
            input = Convert.ToDecimal(txtValue.Text)
            If input >= 0 Then
                If rbtnMeters.Checked Then
                    output = input * convertValue
                    output = Math.Round(output, 3, MidpointRounding.AwayFromZero)
                    lbResult.Text = txtValue.Text + " inches is " + output.ToString() + " meters"
                ElseIf rbtnInches.Checked Then
                    output = input / convertValue
                    output = Math.Round(output, 3, MidpointRounding.AwayFromZero)
                    lbResult.Text = txtValue.Text + " meters is " + output.ToString() + " inches"
                End If
            Else
                MsgBox("Value Is Negative", 0)
            End If
        Else
            MsgBox("Enter A Numeric Value", 0)
        End If

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
