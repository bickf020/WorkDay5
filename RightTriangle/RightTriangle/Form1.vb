Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim X As Double = CDbl(txtSideOne.Text)
        Dim Y As Double = CDbl(txtSideTwo.Text)

        Dim z As Double = Hypotenuse(X, Y)

        txtHyp.Text = CStr(z)

    End Sub

    Function Hypotenuse(ByVal A As Double, ByVal B As Double) As Double

        Dim c As Double

        c = Math.Sqrt(A ^ 2 + B ^ 2)

        Return c

    End Function


End Class
