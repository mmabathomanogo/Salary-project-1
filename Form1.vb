
Option Explicit On
Option Strict On




Public Class Form1

    Private Const NormalHours As Double = 40

    Private Function CalcOvertimeHours(ByVal Hours As Double) As Double

        'Declare Variables

        Dim Overtime As Double

        'Process 

        If Hours > NormalHours Then

            Overtime = Hours - NormalHours

        Else

            Overtime = 0

        End If

        Return Overtime


    End Function


    Private Function CalcPay(ByVal Hours As Double, ByVal OverTimeHours As Double, ByVal Rate As Decimal) As Decimal

        'Declare Variables

        Dim Pay As Decimal

        'Process 

        If Hours <= NormalHours Then

            Pay = CDec(Hours * Rate)

        Else

            Pay = CDec((NormalHours * Rate) + (OverTimeHours * Rate * 2))


        End If

        Return Pay

    End Function
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declare Variables

        Dim Surname As String
        Dim Hours As Double
        Dim OverTimeHours As Double
        Dim Rate As Decimal
        Dim Pay As Decimal

        'Get and Convert INPUT 

        Surname = txtSurname.Text
        Hours = CDbl(txtHoursWorked.Text)
        Rate = CDec(txtRate.Text)

        'Calculate The Overtime Hours (Fuction Call)

        OverTimeHours = CalcOvertimeHours(Hours)

        'Calculate The Pay (Function Call)

        Pay = CalcPay(Hours, OverTimeHours, Rate)

        'Display Output

        lstOutput.Items.Clear() 'Clear any previous content

        lstOutput.Items.Add("********Employee*********")
        lstOutput.Items.Add("Surname :" & Surname)
        lstOutput.Items.Add("Overtime Hours :" & OverTimeHours.ToString("N1"))
        lstOutput.Items.Add("Pay :" & Pay.ToString("C2"))
        lstOutput.Items.Add("*************************")



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear Variables

        txtHoursWorked.Clear()
        txtRate.Clear()
        txtSurname.Clear()
        lstOutput.Items.Clear()

        txtSurname.Focus()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Close Program 

        Me.Close()


    End Sub
End Class
